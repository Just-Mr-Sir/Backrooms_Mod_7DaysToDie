using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static BackroomsGenV1_1NET4_5.MapGen;
using static vp_Weapon;

namespace BackroomsGenV1_1NET4_5
{   class MapGen
    {

        //data regarding to instances of placed rooms (prefabs)
        public class PInstance
        {
            public RoomData RoomData;
            public Vector3i Position;
            public int Rotation;

			public PInstance()
            {
				//RoomData = null;
				Position = Vector3i.zero;
				Rotation = 0;
            }

            public PInstance(RoomData rd, Vector3i pos, int rot)
            {
                RoomData = rd;
                Position = pos;
                Rotation = rot;
            }

			public Vector3i[] GetSpawnPoints()
            {
				List<Vector3i> sp = new List<Vector3i>(RoomData.SpawnPoints);
				float angle = Rotation * 90; //get degrees from int rot
				angle = Mathf.Round(angle / 90) * 90; //round to nearest 90
				angle = angle * (Mathf.PI) / 180; //convert to radians

                for (int i = 0; i < sp.Count; i++)
                {
                    Vector3i temp = sp[i];
					sp[i] = new Vector3i((int)Math.Round(temp.x * Mathf.Cos(angle) - temp.z * Mathf.Sin(angle)), 0,
                                            (int)Math.Round(temp.x * Mathf.Sin(angle) + temp.z * Mathf.Cos(angle)));

                    if (sp[i].x % 7 != 0 || sp[i].z % 7 != 0)
                        SdtdConsole.Instance.Output("Rounding error! " + sp[i]);
                }

				return sp.ToArray();
            }
        }

        //stores filenames of prefabs in weighted fashion
        private static WeightedList<RoomData> weightedList;

        public static void UpdateWeightedList()
        {
            weightedList = new WeightedList<RoomData>();

            for (int i = 0; i < AllRoomData.s_AllRoomData.Length; i++)
            {
                weightedList.AddItem(AllRoomData.s_AllRoomData[i], AllRoomData.s_AllRoomData[i].Weight, AllRoomData.s_AllRoomData[i].OverrideWeights);
            }
        }

        //generating the backrooms via the breadth depth method
        //returns an array of PInstanceData
        public static PInstance[] BreathDepthGen(int maxSize)
        {
			int maxHalfSize = maxSize / 2;

			//queue of unused doors
			List<PInstance> PInstances = new List<PInstance>();
			Queue<(Vector3i, string)> openSet = new Queue<(Vector3i, string)>();
			Queue<Vector3i> openSetDirs = new Queue<Vector3i>(); //the direction from the openSet Vector3 to the target (already closed)
			//List<Vector3i> closedSet = new List<Vector3i>();
			Dictionary<int, Vector3i> closedSet = new Dictionary<int, Vector3i>(); //key is a Hash

            //start with specific lore-accurate large room
            RoomData startEntrance = AllRoomData.FindRoomByName("br_startEntranceP1");
            if (startEntrance.RoomName == "br_startEntranceP1")
            {
                PInstance pid = new PInstance(startEntrance, Vector3i.zero, 0);
                closedSet.Add(pid.Position.GetHashCode(), pid.Position);

                //attempt to add large room (should work for small 7x7 room as well)
                //shouldn't ever use the curTuple or curDir in this case
                AttemptAddRoom(pid, (Vector3i.zero, "br_startEntranceP1"), Vector3i.zero, PInstances, openSet, openSetDirs, closedSet);
            }

            RoomData cacheEndcap = AllRoomData.FindRoomByName("br_endcap_7x6x7");

            //while doorways priority queue is not empty
            int breakCounter = (int)Mathf.Pow(2*(maxHalfSize / 7), 2);
			while (openSet.Count() > 0 && breakCounter >= 0)
			{
				breakCounter--;

                //dequeue
                (Vector3i, string) curTuple = openSet.Dequeue();
				Vector3i curDir = openSetDirs.Dequeue();

				//spawn random room
				RoomData ogRoom = default;

				bool foundEndcap = false;
				if (curTuple.Item1.x >= maxHalfSize || curTuple.Item1.x <= -maxHalfSize ||
                    curTuple.Item1.z >= maxHalfSize || curTuple.Item1.z <= -maxHalfSize)
				{
                    ogRoom = cacheEndcap;
                }
				if(!foundEndcap)
					ogRoom = weightedList.GetRandItem(curTuple.Item2);

				//calculate angle for new room
				float angle = (float)Math.Atan2(curDir.z, curDir.x) + (Mathf.PI/2); //CHANGED FROM ...-(Mathf.PI / 2)
                int rot = Mathf.RoundToInt(angle * 180f / (Mathf.PI) / 90f);
				if (rot < 0)
					rot += 4;

				rot = (rot + 2) % 4; //correction for something? It just works

                PInstance pi = new PInstance(ogRoom, curTuple.Item1, rot);

                AttemptAddRoom(pi, curTuple, curDir, PInstances, openSet, openSetDirs, closedSet);
            }

			return PInstances.ToArray();
        }

        private static void AttemptAddRoom(PInstance pi, (Vector3i, string) curTuple, Vector3i curDir, List<PInstance> pInstances,
                                            Queue<(Vector3i, string)> openSet, Queue<Vector3i> openSetDirs, Dictionary<int, Vector3i> closedSet)
        {
            if (pi.RoomData is RoomDataLarge && ((RoomDataLarge)pi.RoomData).IsHead)
            {
                string[] parts = ((RoomDataLarge)pi.RoomData).Parts;
                Vector3i[] partsDis = ((RoomDataLarge)pi.RoomData).PartsDisplacement;

                //rotate displacements
                Vector3i[] newPartsDis = new Vector3i[partsDis.Length];
                float angle = pi.Rotation * 90; //get degrees from int rot
                angle = Mathf.Round(angle / 90) * 90; //round to nearest 90
                angle = angle * (Mathf.PI) / 180; //convert to radians
                for (int i = 0; i < newPartsDis.Length; i++)
                {
                    newPartsDis[i] = new Vector3i((int)Math.Round(partsDis[i].x * Mathf.Cos(angle) - partsDis[i].z * Mathf.Sin(angle)), 0,
                                                (int)Math.Round(partsDis[i].x * Mathf.Sin(angle) + partsDis[i].z * Mathf.Cos(angle)));

                    if (newPartsDis[i].x % 7 != 0 || newPartsDis[i].z % 7 != 0)
                        SdtdConsole.Instance.Output("Rounding error! " + newPartsDis[i]);
                }

                //check if positions are valid first (not taken) to place big room
                for (int i = 0; i < newPartsDis.Length; i++)
                {
                    Vector3i checkPos = pi.Position + newPartsDis[i];

                    if (closedSet.ContainsKey(checkPos.GetHashCode())) //placement of large room is invalid
                    { 
                        //re-add the original position to openset (like nothing happened...)
                        openSet.Enqueue((pi.Position, curTuple.Item2));
                        openSetDirs.Enqueue(curDir);

                        return;
                    }
                }

                //generate big room parts and reserve space
                for (int i = 0; i < parts.Length; i++)
                {
                    RoomData rd = AllRoomData.FindRoomByName(parts[i]);

                    PInstance lppi = new PInstance(rd, pi.Position + newPartsDis[i], pi.Rotation);
                    pInstances.Add(lppi);

                    closedSet.Add((lppi.Position).GetHashCode(), lppi.Position); //add this large room part to closed set

                    HandleSpawnPoints(lppi, openSet, openSetDirs, closedSet); //handle spawnpoints for this large room part

                    lppi.Position.y = rd.OffsetY;
                }
            }

            pInstances.Add(pi);

            //handle spawnpoints for this room instance
            HandleSpawnPoints(pi, openSet, openSetDirs, closedSet);

            pi.Position.y = pi.RoomData.OffsetY;
        }

		private static void HandleSpawnPoints(PInstance pi, Queue<(Vector3i, string)> openSet, Queue<Vector3i> openSetDirs, Dictionary<int, Vector3i> closedSet)
		{
            //add new points to openSet
            Vector3i[] sp = pi.GetSpawnPoints();
            for (int i = 0; i < sp.Length; i++)
            {
                Vector3i testSP = sp[i] + pi.Position; //get spawnpoint in world position instead of relative to the room instance
                                                       //check if in closed set
                if (closedSet.ContainsKey(testSP.GetHashCode()))
                    continue;

                openSet.Enqueue((testSP, pi.RoomData.RoomName));
                openSetDirs.Enqueue(pi.Position - testSP); //direction doorway is opening towards
                                                           //add spawn point to closed set
                closedSet.Add(testSP.GetHashCode(), testSP);
            }
        }
    }
}
