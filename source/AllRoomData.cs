using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackroomsGenV1_1NET4_5
{
    class AllRoomData
    {
        //all rooms used by backrooms generator
        public static RoomData[] s_AllRoomData =
        {
			//base rooms
			new RoomData("br_hallway_7x6x7", 8, new Dictionary<string, float>(), 7, 7, new Vector3i[] {  new Vector3i(0, 0, 7), new Vector3i(0, 0, -7 ) }),
            new RoomData("br_corner_7x6x7", 8, new Dictionary<string, float>(), 7, 7, new Vector3i[] {  new Vector3i(0, 0, 7), new Vector3i(-7, 0, 0 ) }),
            new RoomData("br_threeway_7x6x7", 9, new Dictionary<string, float>(), 7, 7, new Vector3i[] { new Vector3i(0, 0, 7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0 ) }),
            new RoomData("br_fourway_7x6x7", 10, new Dictionary<string, float>(), 7, 7, new Vector3i[] { new Vector3i(0, 0, -7), new Vector3i(0, 0, 7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0 ) }),
            new RoomData("br_endcap_7x6x7", 7, new Dictionary<string, float>(), 7, 7, new Vector3i[] { new Vector3i(0, 0, 7) }),

            new RoomData("br_doorToThreeway", 6, new Dictionary<string, float>() { { "br_doorwayToHallway", 0 }, { "br_endcapExitReal", 0 }, { "br_dinerLargeP2", 0 } },
                            7, 7, new Vector3i[] { new Vector3i(0, 0, 7), new Vector3i(0, 0, -7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0) }),
            new RoomData("br_doorwayToHallway", 4, new Dictionary<string, float>() { { "br_doorToThreeway", 0 }, { "br_endcapExitReal", 0 }, { "br_dinerLargeP2", 0 }}, 
                            7, 7, new Vector3i[] { new Vector3i(0, 0, 7), new Vector3i(0, 0, -7) }),

			//small base rooms
			new RoomData("br_hallwaySmall_7x6x7", 8, new Dictionary<string, float>(), 7, 7, new Vector3i[] {  new Vector3i(0, 0, 7), new Vector3i(0, 0, -7 ) }),
            new RoomData("br_cornerSmall_7x6x7", 8, new Dictionary<string, float>(), 7, 7, new Vector3i[] {  new Vector3i(0, 0, 7), new Vector3i(-7, 0, 0 ) }),
            new RoomData("br_threewaySmall_7x6x7", 9, new Dictionary<string, float>(), 7, 7, new Vector3i[] { new Vector3i(0, 0, 7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0 ) }),
            new RoomData("br_fourwaySmall_7x6x7", 10, new Dictionary<string, float>(), 7, 7, new Vector3i[] { new Vector3i(0, 0, -7), new Vector3i(0, 0, 7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0 ) }),
            new RoomData("br_endcapSmall_7x6x7", 7, new Dictionary<string, float>(), 7, 7, new Vector3i[] { new Vector3i(0, 0, 7) }),

			//empty rooms
			new RoomData("br_pillarCenter_7x6x7", 5, new Dictionary<string, float>(), 7, 7, new Vector3i[] { new Vector3i(0, 0, -7), new Vector3i(0, 0, 7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0 ) }),
            new RoomData("br_pillarOffset", 5, new Dictionary<string, float>(), 7, 7, new Vector3i[] { new Vector3i(0, 0, 7), new Vector3i(0, 0, -7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0) }),
            new RoomData("br_pillarThick", 5, new Dictionary<string, float>(), 7, 7, new Vector3i[] { new Vector3i(0, 0, 7), new Vector3i(0, 0, -7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0) }),
            new RoomData("br_pillarThickOffset", 3, new Dictionary<string, float>(), 7, 7, new Vector3i[] { new Vector3i(0, 0, 7), new Vector3i(0, 0, -7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0) }),
            new RoomData("br_pillarsNine", 3, new Dictionary<string, float>() { { "br_pillarsNine", 8 } }, 7, 7, new Vector3i[] { new Vector3i(0, 0, 7), new Vector3i(0, 0, -7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0) }),

            new RoomData("br_empty_7x6x7", 10, new Dictionary<string, float>(), 7, 7, new Vector3i[] { new Vector3i(0, 0, -7), new Vector3i(0, 0, 7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0 ) }),
            new RoomData("br_emptyOneWall_7x6x7", 9, new Dictionary<string, float>(), 7, 7, new Vector3i[] { new Vector3i(0, 0, 7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0 ) }),
            new RoomData("br_emptyTwoWalls_7x6x7", 8, new Dictionary<string, float>(), 7, 7, new Vector3i[] {  new Vector3i(0, 0, 7), new Vector3i(-7, 0, 0 ) }),

            new RoomData("br_wallCenter", 4, new Dictionary<string, float>(), 7, 7, new Vector3i[] { new Vector3i(0, 0, 7), new Vector3i(0, 0, -7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0) }),

			//trap rooms
			new RoomData("br_fakeWalls1_7x6x7", 5, new Dictionary<string, float>(), 7, 7, new Vector3i[] { new Vector3i(0, 0, 7) }),
            new RoomData("br_hallwaydrop_7x8x7", 5, new Dictionary<string, float>(), 7, 7, new Vector3i[] {  new Vector3i(0, 0, 7), new Vector3i(0, 0, -7 ) }),

			//unique loot rooms
			new RoomData("br_lootRoom1_7x6x7", 1, new Dictionary<string, float>(), 7, 7, new Vector3i[] { new Vector3i(0, 0, -7), new Vector3i(0, 0, 7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0 ) }),
            new RoomData("br_foodStore_7x6x7", 1, new Dictionary<string, float>(), 7, 7, new Vector3i[] { new Vector3i(0, 0, 7) }),
            //new RoomData("br_bathroomM_7x6x7", 1, new Dictionary<string, float>(), 7, 7, new Vector3i[] { new Vector3i(0, 0, 7) }),
            //new RoomData("br_bathroomF_7x6x7", 1, new Dictionary<string, float>(), 7, 7, new Vector3i[] { new Vector3i(0, 0, 7) }),
            new RoomData("br_militaryCheckpoint_7x6x7", 1, new Dictionary<string, float>(), 7, 7, new Vector3i[] { new Vector3i(0, 0, 7), new Vector3i(0, 0, -7) }),
            new RoomData("br_smilingCampers", 1, new Dictionary<string, float>(), 7, 7, new Vector3i[] { new Vector3i(0, 0, 7) }),

			//easter egg rooms
			new RoomData("br_reachEG_7x6x7", 0.1f, new Dictionary<string, float>(), 7, 7, new Vector3i[] { new Vector3i(0, 0, 7)}),

			//other rooms
			new RoomData("br_carCrash1_7x6x7", 1, new Dictionary<string, float>(), 7, 7, new Vector3i[] { new Vector3i(0, 0, 7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0 ) }),
            new RoomData("br_threewayWatercooler_7x6x7", 2, new Dictionary<string, float>(), 7, 7, new Vector3i[] { new Vector3i(0, 0, 7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0 ) }),
            new RoomData("br_tallCrawl_7x6x7", 1, new Dictionary<string, float>(), 7, 7, new Vector3i[] {  new Vector3i(0, 0, 7), new Vector3i(0, 0, -7 ) }),
            new RoomData("br_endcapExitFake", 1, new Dictionary<string, float>(), 7, 7, new Vector3i[] { new Vector3i(0, 0, 7)}),
            new RoomData("br_endcapExitReal", 1, new Dictionary<string, float>(), 7, 7, new Vector3i[] { new Vector3i(0, 0, 7), new Vector3i(0, 0, -7) }),
            //new RoomData("br_lp_portalClimb", 0.1f, new Dictionary<string, float>(), 7, 7, new Vector3i[] { new Vector3i(0, 0, -7), new Vector3i(0, 0, 7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0 ) }),

			//large rooms
			new RoomDataLarge("br_dinerLargeP1", 1, new Dictionary<string, float>(), 7, 7, new Vector3i[] { new Vector3i(0, 0, 7) },
                                true, new string[] { "br_dinerLargeP2", "br_dinerLargeP3", "br_dinerLargeP4"},
                                      new Vector3i[] {new Vector3i(7, 0, 0), new Vector3i(7, 0, -7), new Vector3i(0, 0, -7)}),
            new RoomDataLarge("br_dinerLargeP2", 0, new Dictionary<string, float>() { }, 7, 7, new Vector3i[] { new Vector3i(7, 0, 0) },
                                false, null, null),
            new RoomDataLarge("br_dinerLargeP3", 0, new Dictionary<string, float>() { }, 7, 7, new Vector3i[] {  },
                                false, null, null),
            new RoomDataLarge("br_dinerLargeP4", 0, new Dictionary<string, float>() { }, 7, 7, new Vector3i[] {  },
                                false, null, null),

            new RoomDataLarge("br_startEntranceP1", 0, new Dictionary<string, float>(), 7, 7, new Vector3i[] { },
                    true, new string[] { "br_startEntranceP2", "br_startEntranceP3", "br_startEntranceP4", "br_startEntranceP5", "br_startEntranceP6", "br_startEntranceP7", "br_startEntranceP8", "br_startEntranceP9"},
                          new Vector3i[] {new Vector3i(-7, 0, 0), new Vector3i(-14, 0, 0), new Vector3i(-14, 0, -7), new Vector3i(-7, 0, -7), new Vector3i(0, 0, -7), new Vector3i(0, 0, -14), new Vector3i(-7, 0, -14), new Vector3i(-14, 0, -14)}),
            new RoomDataLarge("br_startEntranceP2", 0, new Dictionary<string, float>() { }, 7, 7, new Vector3i[] {  },
                    false, null, null),
            new RoomDataLarge("br_startEntranceP3", 0, new Dictionary<string, float>() { }, 7, 7, new Vector3i[] { new Vector3i(0, 0, 7) },
                    false, null, null),
            new RoomDataLarge("br_startEntranceP4", 0, new Dictionary<string, float>() { }, 7, 7, new Vector3i[] { new Vector3i(-7, 0, 0) },
                    false, null, null),
            new RoomDataLarge("br_startEntranceP5", 0, new Dictionary<string, float>() { }, 7, 7, new Vector3i[] {  },
                    false, null, null),
            new RoomDataLarge("br_startEntranceP6", 0, new Dictionary<string, float>() { }, 7, 7, new Vector3i[] {  },
                    false, null, null),
            new RoomDataLarge("br_startEntranceP7", 0, new Dictionary<string, float>() { }, 7, 7, new Vector3i[] { new Vector3i(0, 0, -7), new Vector3i(7, 0, 0) },
                    false, null, null),
            new RoomDataLarge("br_startEntranceP8", 0, new Dictionary<string, float>() { }, 7, 7, new Vector3i[] { new Vector3i(0, 0, -7) },
                    false, null, null),
            new RoomDataLarge("br_startEntranceP9", 0, new Dictionary<string, float>() { }, 7, 7, new Vector3i[] {  },
                    false, null, null),

            new RoomDataLarge("br_couchPillarLargeP1", 1, new Dictionary<string, float>(), 7, 7, new Vector3i[] { new Vector3i(0, 0, 7) },
                                true, new string[] { "br_couchPillarLargeP2", "br_couchPillarLargeP3", "br_couchPillarLargeP4"},
                                      new Vector3i[] {new Vector3i(7, 0, 0), new Vector3i(7, 0, -7), new Vector3i(0, 0, -7)}),
            new RoomDataLarge("br_couchPillarLargeP2", 0, new Dictionary<string, float>() { }, 7, 7, new Vector3i[] {  },
                                false, null, null),
            new RoomDataLarge("br_couchPillarLargeP3", 0, new Dictionary<string, float>() { }, 7, 7, new Vector3i[] { new Vector3i(7, 0, 0) },
                                false, null, null),
            new RoomDataLarge("br_couchPillarLargeP4", 0, new Dictionary<string, float>() { }, 7, 7, new Vector3i[] {  },
                                false, null, null),
        };

        public static RoomData FindRoomByName(string name)
        {
            for (int i = 0; i < s_AllRoomData.Length; i++)
            {
                if (s_AllRoomData[i].RoomName == name)
                    return s_AllRoomData[i];
            }

            return null;
        }
    }
}
