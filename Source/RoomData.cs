using System.Collections.Generic;

namespace BackroomsGenV1_1NET4_5
{
    //data regarding unplaced rooms
    internal class RoomData
    {
        public string RoomName { get { return roomName; } }
        public float Weight { get { return weight; } }
        public int SizeX { get { return sizeX; } }
        public int OffsetY { get { return offsetY; } }
        public int SizeZ { get { return sizeZ; } }
        public Vector3i[] SpawnPoints { get { return spawnPoints; } }
        public Dictionary<string, float> OverrideWeights { get { return new Dictionary<string, float>(overrideWeights); } }

        private string roomName;
        private float weight;
        private int sizeX;
        private int offsetY; //offsetY from zero where positive is up
        private int sizeZ;
        private Vector3i[] spawnPoints;
        private Dictionary<string, float> overrideWeights;


        public RoomData(string f, float w, Dictionary<string, float> ow, int sx, int offsetY, int sz, Vector3i[] sp)
        {
            roomName = f;
            weight = w;
            overrideWeights = ow;
            sizeX = sx;
            this.offsetY = offsetY;
            sizeZ = sz;
            spawnPoints = sp;
        }

        public void SetWeight(float w)
        {
            weight = w;
        }
    }
}
