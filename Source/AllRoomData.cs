using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackroomsGenV1_1NET4_5
{
    class AllRoomData
    {
        public const int BASE_OFFSET_Y = 6;

        //all rooms used by backrooms generator
        public static RoomData[] s_AllRoomData =
        {
			//base rooms
			new RoomData("br_hallway_7x6x7", 8, new Dictionary<string, float>() { { "br_hallway_7x6x7", 18 }, { "br_corner_7x6x7", 18 }, { "br_threeway_7x6x7", 18 },
                            { "br_fourway_7x6x7", 18 }, { "br_endcap_7x6x7", 18 }}, 
                            7, BASE_OFFSET_Y, 7, new Vector3i[] {  new Vector3i(0, 0, 7), new Vector3i(0, 0, -7 ) }),
            new RoomData("br_corner_7x6x7", 8, new Dictionary<string, float>() { { "br_hallway_7x6x7", 18 }, { "br_corner_7x6x7", 18 }, { "br_threeway_7x6x7", 18 },
                            { "br_fourway_7x6x7", 18 }, { "br_endcap_7x6x7", 18 }}, 
                            7, BASE_OFFSET_Y,  7, new Vector3i[] {  new Vector3i(0, 0, 7), new Vector3i(-7, 0, 0 ) }),
            new RoomData("br_threeway_7x6x7", 9, new Dictionary<string, float>(){ { "br_hallway_7x6x7", 19 }, { "br_corner_7x6x7", 19 }, { "br_threeway_7x6x7", 19 },
                            { "br_fourway_7x6x7", 19 }, { "br_endcap_7x6x7", 19 }}, 
                            7, BASE_OFFSET_Y,  7, new Vector3i[] { new Vector3i(0, 0, 7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0 ) }),
            new RoomData("br_fourway_7x6x7", 10, new Dictionary<string, float>(){ { "br_hallway_7x6x7", 20 }, { "br_corner_7x6x7", 20 }, { "br_threeway_7x6x7", 20 },
                            { "br_fourway_7x6x7", 20 }, { "br_endcap_7x6x7", 20 }}, 
                            7, BASE_OFFSET_Y,  7, new Vector3i[] { new Vector3i(0, 0, -7), new Vector3i(0, 0, 7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0 ) }),
            new RoomData("br_endcap_7x6x7", 5, new Dictionary<string, float>(){ { "br_hallway_7x6x7", 15 }, { "br_corner_7x6x7", 15 }, { "br_threeway_7x6x7", 15 },
                            { "br_fourway_7x6x7", 15 }, { "br_endcap_7x6x7", 15 }}, 
                            7, BASE_OFFSET_Y,  7, new Vector3i[] { new Vector3i(0, 0, 7) }),

            new RoomData("br_doorToThreeway", 3, new Dictionary<string, float>() { { "br_doorwayToHallway", 0 }, { "br_endcapExitReal", 0 }, { "br_dinerLargeP2", 0 } },
                            7, BASE_OFFSET_Y,  7, new Vector3i[] { new Vector3i(0, 0, 7), new Vector3i(0, 0, -7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0) }),
            new RoomData("br_doorwayToHallway", 2, new Dictionary<string, float>() { { "br_doorToThreeway", 0 }, { "br_endcapExitReal", 0 }, { "br_dinerLargeP2", 0 }}, 
                            7, BASE_OFFSET_Y,  7, new Vector3i[] { new Vector3i(0, 0, 7), new Vector3i(0, 0, -7) }),

			//small base rooms
			new RoomData("br_hallwaySmall_7x6x7", 8, new Dictionary<string, float>() { { "br_hallwaySmall_7x6x7", 18 }, { "br_cornerSmall_7x6x7", 18 }, { "br_threewaySmall_7x6x7", 18 },
                            { "br_fourwaySmall_7x6x7", 18 }, { "br_endcapSmall_7x6x7", 18 }}, 
                            7, BASE_OFFSET_Y,  7, new Vector3i[] {  new Vector3i(0, 0, 7), new Vector3i(0, 0, -7 ) }),
            new RoomData("br_cornerSmall_7x6x7", 8, new Dictionary<string, float>(){ { "br_hallwaySmall_7x6x7", 18 }, { "br_cornerSmall_7x6x7", 18 }, { "br_threewaySmall_7x6x7", 18 },
                            { "br_fourwaySmall_7x6x7", 18 }, { "br_endcapSmall_7x6x7", 18 }}, 
                            7, BASE_OFFSET_Y,  7, new Vector3i[] {  new Vector3i(0, 0, 7), new Vector3i(-7, 0, 0 ) }),
            new RoomData("br_threewaySmall_7x6x7", 9, new Dictionary<string, float>() { { "br_hallwaySmall_7x6x7", 19 }, { "br_cornerSmall_7x6x7", 19 }, { "br_threewaySmall_7x6x7", 19 },
                            { "br_fourwaySmall_7x6x7", 19 }, { "br_endcapSmall_7x6x7", 19 }}, 
                            7, BASE_OFFSET_Y,  7, new Vector3i[] { new Vector3i(0, 0, 7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0 ) }),
            new RoomData("br_fourwaySmall_7x6x7", 10, new Dictionary<string, float>(){ { "br_hallwaySmall_7x6x7", 20 }, { "br_cornerSmall_7x6x7", 20 }, { "br_threewaySmall_7x6x7", 20 },
                            { "br_fourwaySmall_7x6x7", 20 }, { "br_endcapSmall_7x6x7", 20 }}, 
                            7, BASE_OFFSET_Y,  7, new Vector3i[] { new Vector3i(0, 0, -7), new Vector3i(0, 0, 7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0 ) }),
            new RoomData("br_endcapSmall_7x6x7", 5, new Dictionary<string, float>(){ { "br_hallwaySmall_7x6x7", 15 }, { "br_cornerSmall_7x6x7", 15 }, { "br_threewaySmall_7x6x7", 15 },
                            { "br_fourwaySmall_7x6x7", 15 }, { "br_endcapSmall_7x6x7", 15 }}, 
                            7, BASE_OFFSET_Y,  7, new Vector3i[] { new Vector3i(0, 0, 7) }),

			//empty rooms
			new RoomData("br_pillarCenter_7x6x7", 5, new Dictionary<string, float>(), 7, BASE_OFFSET_Y,  7, new Vector3i[] { new Vector3i(0, 0, -7), new Vector3i(0, 0, 7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0 ) }),
            new RoomData("br_pillarOffset", 5, new Dictionary<string, float>(), 7, BASE_OFFSET_Y,  7, new Vector3i[] { new Vector3i(0, 0, 7), new Vector3i(0, 0, -7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0) }),
            new RoomData("br_pillarThick", 5, new Dictionary<string, float>(), 7, BASE_OFFSET_Y,  7, new Vector3i[] { new Vector3i(0, 0, 7), new Vector3i(0, 0, -7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0) }),
            new RoomData("br_pillarThickOffset", 3, new Dictionary<string, float>(), 7, BASE_OFFSET_Y,  7, new Vector3i[] { new Vector3i(0, 0, 7), new Vector3i(0, 0, -7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0) }),
            new RoomData("br_pillarsNine", 3, new Dictionary<string, float>() { { "br_pillarsNine", 20 } }, 7, BASE_OFFSET_Y,  7, new Vector3i[] { new Vector3i(0, 0, 7), new Vector3i(0, 0, -7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0) }),

            new RoomData("br_empty_7x6x7", 10, new Dictionary<string, float>() { { "br_empty_7x6x7", 20 } }, 7, BASE_OFFSET_Y,  7, new Vector3i[] { new Vector3i(0, 0, -7), new Vector3i(0, 0, 7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0 ) }),
            new RoomData("br_emptyOneWall_7x6x7", 9, new Dictionary<string, float>(), 7, BASE_OFFSET_Y,  7, new Vector3i[] { new Vector3i(0, 0, 7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0 ) }),
            new RoomData("br_emptyTwoWalls_7x6x7", 8, new Dictionary<string, float>(), 7, BASE_OFFSET_Y,  7, new Vector3i[] {  new Vector3i(0, 0, 7), new Vector3i(-7, 0, 0 ) }),
            new RoomData("br_emptyOneWallArrowR", 1, new Dictionary<string, float>(), 7, BASE_OFFSET_Y,  7, new Vector3i[] { new Vector3i(0, 0, 7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0 ) }),
            new RoomData("br_emptyOneWallArrowL", 1, new Dictionary<string, float>(), 7, BASE_OFFSET_Y,  7, new Vector3i[] { new Vector3i(0, 0, 7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0 ) }),

            //new RoomData("br_emptyOneWallSlit", 1, new Dictionary<string, float>(), 7, BASE_OFFSET_Y,  7, new Vector3i[] { new Vector3i(0, 0, -7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0 ) }),

            new RoomData("br_wallCenter", 4, new Dictionary<string, float>(), 7, BASE_OFFSET_Y,  7, new Vector3i[] { new Vector3i(0, 0, 7), new Vector3i(0, 0, -7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0) }),

            //dark rooms (biome)
             new RoomData("br_fourwayDark", 0.5f, new Dictionary<string, float>(), 7, BASE_OFFSET_Y,  7, new Vector3i[] { new Vector3i(0, 0, -7), new Vector3i(0, 0, 7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0 ) }),
             new RoomData("br_emptyDark", 0, new Dictionary<string, float>() { { "br_fourwayDark", 1000 }, { "br_emptyDark", 1000 },  { "br_emptyOneWallDark", 1000 },
                            { "br_emptyTwoWallsDark", 1000 } }, 
                            7, BASE_OFFSET_Y,  7, new Vector3i[] { new Vector3i(0, 0, -7), new Vector3i(0, 0, 7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0 ) }),
             new RoomData("br_emptyOneWallDark", 0, new Dictionary<string, float>() { { "br_fourwayDark", 1000 }, { "br_emptyDark", 1000 },  { "br_emptyOneWallDark", 1000 },
                            { "br_emptyTwoWallsDark", 1000 } }, 
                            7, BASE_OFFSET_Y,  7, new Vector3i[] { new Vector3i(0, 0, 7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0 ) }),
             new RoomData("br_emptyTwoWallsDark", 0, new Dictionary<string, float>() { { "br_fourwayDark", 1000 }, { "br_emptyDark", 1000 },  { "br_emptyOneWallDark", 1000 },
                            { "br_emptyTwoWallsDark", 1000 } }, 
                            7, BASE_OFFSET_Y,  7, new Vector3i[] {  new Vector3i(0, 0, 7), new Vector3i(-7, 0, 0 ) }),
             new RoomData("br_smilingCampers", 0, new Dictionary<string, float>() { { "br_fourwayDark", 200 }, { "br_emptyDark", 200 },  { "br_emptyOneWallDark", 200 },
                            { "br_emptyTwoWallsDark", 200 } }, 7, BASE_OFFSET_Y,  7, new Vector3i[] { new Vector3i(0, 0, 7) }),

			//trap rooms
			new RoomData("br_fakeWalls1_7x6x7", 3, new Dictionary<string, float>(), 7, BASE_OFFSET_Y,  7, new Vector3i[] { new Vector3i(0, 0, 7) }),
            new RoomData("br_hallwaydrop_7x8x7", 3, new Dictionary<string, float>(), 7, BASE_OFFSET_Y,  7, new Vector3i[] {  new Vector3i(0, 0, 7), new Vector3i(0, 0, -7 ) }),

			//unique loot rooms
			new RoomData("br_lootRoom1_7x6x7", 1, new Dictionary<string, float>() { {"br_lootRoom1_7x6x7", 0 } }, 7, BASE_OFFSET_Y,  7, new Vector3i[] { new Vector3i(0, 0, -7), new Vector3i(0, 0, 7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0 ) }),
            new RoomData("br_foodStore_7x6x7", 1, new Dictionary<string, float>() { { "br_dinerLargeP2", 0 } }, 7, BASE_OFFSET_Y,  7, new Vector3i[] { new Vector3i(0, 0, 7) }),
            //new RoomData("br_bathroomM_7x6x7", 1, new Dictionary<string, float>(), 7, BASE_OFFSET_Y,  7, new Vector3i[] { new Vector3i(0, 0, 7) }),
            //new RoomData("br_bathroomF_7x6x7", 1, new Dictionary<string, float>(), 7, BASE_OFFSET_Y,  7, new Vector3i[] { new Vector3i(0, 0, 7) }),
            new RoomData("br_militaryCheckpoint_7x6x7", 1, new Dictionary<string, float>() { { "br_militaryCheckpoint_7x6x7", 0 } }, 7, BASE_OFFSET_Y,  7, new Vector3i[] { new Vector3i(0, 0, 7), new Vector3i(0, 0, -7) }),
            new RoomData("br_wallSlit", 1, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y,  7, new Vector3i[] { new Vector3i(0, 0, -7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0 ) }),
            new RoomData("br_survivorCamp1", 1, new Dictionary<string, float>(), 7, BASE_OFFSET_Y,  7, new Vector3i[] {  new Vector3i(0, 0, 7), new Vector3i(7, 0, 0 ) }),

			//easter egg rooms
			new RoomData("br_reachEG_7x6x7", 0.1f, new Dictionary<string, float>(), 7, BASE_OFFSET_Y,  7, new Vector3i[] { new Vector3i(0, 0, 7)}),

			//other rooms
			new RoomData("br_carCrash1_7x6x7", 1, new Dictionary<string, float>() { { "br_carCrash1_7x6x7", 0 } }, 7, BASE_OFFSET_Y,  7, new Vector3i[] { new Vector3i(0, 0, 7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0 ) }),
            new RoomData("br_threewayWatercooler_7x6x7", 2, new Dictionary<string, float>() { { "br_threewayWatercooler_7x6x7", 0 } }, 7, BASE_OFFSET_Y,  7, new Vector3i[] { new Vector3i(0, 0, 7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0 ) }),
            new RoomData("br_tallCrawl_7x6x7", 1, new Dictionary<string, float>(), 7, BASE_OFFSET_Y,  7, new Vector3i[] {  new Vector3i(0, 0, 7), new Vector3i(0, 0, -7 ) }),
            new RoomData("br_endcapExitFake", 1, new Dictionary<string, float>(), 7, BASE_OFFSET_Y,  7, new Vector3i[] { new Vector3i(0, 0, 7)}),
            new RoomData("br_endcapExitReal", 1, new Dictionary<string, float>(), 7, BASE_OFFSET_Y,  7, new Vector3i[] { new Vector3i(0, 0, 7), new Vector3i(0, 0, -7) }),
            new RoomData("br_holeToRoom", 1, new Dictionary<string, float>(), 7, BASE_OFFSET_Y,  7, new Vector3i[] { new Vector3i(0, 0, 7) }),
            new RoomData("br_holeToRoomDogs", 1, new Dictionary<string, float>(), 7, BASE_OFFSET_Y,  7, new Vector3i[] { new Vector3i(0, 0, 7) }),
            new RoomData("br_spikeTrapPit", 1, new Dictionary<string, float>(), 7, BASE_OFFSET_Y - 2,  7, new Vector3i[] { new Vector3i(0, 0, 7), new Vector3i(0, 0, -7 )  }),
            //new RoomData("br_lp_portalClimb", 0.1f, new Dictionary<string, float>(), 7, BASE_OFFSET_Y, 7, new Vector3i[] { new Vector3i(0, 0, -7), new Vector3i(0, 0, 7), new Vector3i(7, 0, 0), new Vector3i(-7, 0, 0 ) }),

			//large rooms
			new RoomDataLarge("br_dinerLargeP1", 1, new Dictionary<string, float>() { { "br_tallCrawl_7x6x7", 0 } }, 7, BASE_OFFSET_Y, 7, new Vector3i[] { new Vector3i(0, 0, 7) },
                                true, new string[] { "br_dinerLargeP2", "br_dinerLargeP3", "br_dinerLargeP4"},
                                      new Vector3i[] {new Vector3i(7, 0, 0), new Vector3i(7, 0, -7), new Vector3i(0, 0, -7)}),
            new RoomDataLarge("br_dinerLargeP2", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] { new Vector3i(7, 0, 0) },
                                false, null, null),
            new RoomDataLarge("br_dinerLargeP3", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] {  },
                                false, null, null),
            new RoomDataLarge("br_dinerLargeP4", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] {  },
                                false, null, null),

            new RoomDataLarge("br_startEntranceP1", 0, new Dictionary<string, float>(), 7, BASE_OFFSET_Y, 7, new Vector3i[] { },
                    true, new string[] { "br_startEntranceP2", "br_startEntranceP3", "br_startEntranceP4", "br_startEntranceP5", "br_startEntranceP6", "br_startEntranceP7", "br_startEntranceP8", "br_startEntranceP9"},
                          new Vector3i[] {new Vector3i(-7, 0, 0), new Vector3i(-14, 0, 0), new Vector3i(-14, 0, -7), new Vector3i(-7, 0, -7), new Vector3i(0, 0, -7), new Vector3i(0, 0, -14), new Vector3i(-7, 0, -14), new Vector3i(-14, 0, -14)}),
            new RoomDataLarge("br_startEntranceP2", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] {  },
                    false, null, null),
            new RoomDataLarge("br_startEntranceP3", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] { new Vector3i(0, 0, 7) },
                    false, null, null),
            new RoomDataLarge("br_startEntranceP4", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] { new Vector3i(-7, 0, 0) },
                    false, null, null),
            new RoomDataLarge("br_startEntranceP5", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] {  },
                    false, null, null),
            new RoomDataLarge("br_startEntranceP6", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] {  },
                    false, null, null),
            new RoomDataLarge("br_startEntranceP7", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] { new Vector3i(0, 0, -7), new Vector3i(7, 0, 0) },
                    false, null, null),
            new RoomDataLarge("br_startEntranceP8", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] { new Vector3i(0, 0, -7) },
                    false, null, null),
            new RoomDataLarge("br_startEntranceP9", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] {  },
                    false, null, null),

            new RoomDataLarge("br_couchPillarLargeP1", 1, new Dictionary<string, float>() { { "br_tallCrawl_7x6x7", 0 } }, 7, BASE_OFFSET_Y, 7, new Vector3i[] { new Vector3i(0, 0, 7) },
                                true, new string[] { "br_couchPillarLargeP2", "br_couchPillarLargeP3", "br_couchPillarLargeP4"},
                                      new Vector3i[] {new Vector3i(7, 0, 0), new Vector3i(7, 0, -7), new Vector3i(0, 0, -7)}),
            new RoomDataLarge("br_couchPillarLargeP2", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] {  },
                                false, null, null),
            new RoomDataLarge("br_couchPillarLargeP3", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] { new Vector3i(7, 0, 0) },
                                false, null, null),
            new RoomDataLarge("br_couchPillarLargeP4", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] {  },
                                false, null, null),

            new RoomDataLarge("br_body3WallHolesLargeP1", 1, new Dictionary<string, float>() { { "br_hallway_7x6x7", 18 }, { "br_tallCrawl_7x6x7", 0 } }, 7, BASE_OFFSET_Y, 7, new Vector3i[] { new Vector3i(0, 0, 7) },
                                true, new string[] { "br_body3WallHolesLargeP2", "br_body3WallHolesLargeP3", "br_body3WallHolesLargeP4"},
                                      new Vector3i[] {new Vector3i(0, 0, -7), new Vector3i(-7, 0, -7), new Vector3i(-7, 0, 0)}),
            new RoomDataLarge("br_body3WallHolesLargeP2", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] {  },
                                false, null, null),
            new RoomDataLarge("br_body3WallHolesLargeP3", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] { new Vector3i(-7, 0, 0) },
                                false, null, null),
            new RoomDataLarge("br_body3WallHolesLargeP4", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] {  },
                                false, null, null),

            new RoomDataLarge("br_ff2MonsterHouseP1", 1, new Dictionary<string, float>() { { "br_couchPillarLargeP3", 0 }, { "br_body3WallHolesLargeP3", 0 }, { "br_dinerLargeP2", 0 },
                                    { "br_oneWallSlitLargeP1", 0 }, { "br_tallCrawl_7x6x7", 0 }, { "br_hallwaySmall_7x6x7", 0 }, { "br_cornerSmall_7x6x7", 0 },
                                    { "br_threewaySmall_7x6x7", 0 }, { "br_fourwaySmall_7x6x7", 0 }}, 7, BASE_OFFSET_Y, 7, new Vector3i[] { new Vector3i(0, 0, 7) },
                                true, new string[] { "br_ff2MonsterHouseP2", "br_ff2MonsterHouseP3", "br_ff2MonsterHouseP4", "br_ff2MonsterHouseP5",
                                                        "br_ff2MonsterHouseP6", "br_ff2MonsterHouseP7", "br_ff2MonsterHouseP8"},
                                      new Vector3i[] {  new Vector3i(7, 0, 0), new Vector3i(7, 0, -7), new Vector3i(0, 0, -7), new Vector3i(-7, 0, -7),
                                                        new Vector3i(-14, 0, -7), new Vector3i(-14, 0, 0), new Vector3i(-7, 0, 0) }),
            new RoomDataLarge("br_ff2MonsterHouseP2", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y - 1, 7, new Vector3i[] {  },
                                false, null, null),
            new RoomDataLarge("br_ff2MonsterHouseP3", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y - 1, 7, new Vector3i[] {  },
                                false, null, null),
            new RoomDataLarge("br_ff2MonsterHouseP4", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] {  },
                                false, null, null),
            new RoomDataLarge("br_ff2MonsterHouseP5", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] {  },
                                false, null, null),
            new RoomDataLarge("br_ff2MonsterHouseP6", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] {  },
                                false, null, null),
            new RoomDataLarge("br_ff2MonsterHouseP7", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] {  },
                                false, null, null),
            new RoomDataLarge("br_ff2MonsterHouseP8", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] {  },
                                false, null, null),

            new RoomDataLarge("br_pillarRoom1LargeP1", 1, new Dictionary<string, float>() { { "br_couchPillarLargeP3", 0 }, { "br_body3WallHolesLargeP3", 0 }, { "br_dinerLargeP2", 0 },
                                    { "br_tallCrawl_7x6x7", 0 }, { "br_hallwaySmall_7x6x7", 0 }, { "br_cornerSmall_7x6x7", 0 },
                                    { "br_threewaySmall_7x6x7", 0 }, { "br_fourwaySmall_7x6x7", 0 }}, 7, BASE_OFFSET_Y, 7, new Vector3i[] { new Vector3i(0, 0, 7) },
                                true, new string[] { "br_pillarRoom1LargeP2", "br_pillarRoom1LargeP3", "br_pillarRoom1LargeP4", "br_pillarRoom1LargeP5",
                                                        "br_pillarRoom1LargeP6", "br_pillarRoom1LargeP7", "br_pillarRoom1LargeP8", "br_pillarRoom1LargeP9",
                                                        "br_pillarRoom1LargeP10", "br_pillarRoom1LargeP11", "br_pillarRoom1LargeP12"},
                                      new Vector3i[] {  new Vector3i(-7, 0, 0), new Vector3i(-14, 0, 0), new Vector3i(-14, 0, -7), new Vector3i(-7, 0, -7),
                                                        new Vector3i(0, 0, -7), new Vector3i(0, 0, -14), new Vector3i(-7, 0, -14), new Vector3i(-14, 0, -14),
                                                        new Vector3i(-14, 0, -21), new Vector3i(-7, 0, -21), new Vector3i(0, 0, -21)}),
            new RoomDataLarge("br_pillarRoom1LargeP2", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] {  },
                                false, null, null),
            new RoomDataLarge("br_pillarRoom1LargeP3", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] {  },
                                false, null, null),
            new RoomDataLarge("br_pillarRoom1LargeP4", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] {  },
                                false, null, null),
            new RoomDataLarge("br_pillarRoom1LargeP5", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] {  },
                                false, null, null),
            new RoomDataLarge("br_pillarRoom1LargeP6", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] {  },
                                false, null, null),
            new RoomDataLarge("br_pillarRoom1LargeP7", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] { new Vector3i(7, 0, 0) },
                                false, null, null),
            new RoomDataLarge("br_pillarRoom1LargeP8", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] {  },
                                false, null, null),
            new RoomDataLarge("br_pillarRoom1LargeP9", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] {  },
                                false, null, null),
            new RoomDataLarge("br_pillarRoom1LargeP10", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] {  },
                                false, null, null),
            new RoomDataLarge("br_pillarRoom1LargeP11", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] {  },
                                false, null, null),
            new RoomDataLarge("br_pillarRoom1LargeP12", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] { new Vector3i(0, 0, -7) },
                                false, null, null),

            new RoomDataLarge("br_ff3MonsterSpeakerP1", 1, new Dictionary<string, float>() { { "br_tallCrawl_7x6x7", 0 } }, 7, BASE_OFFSET_Y, 7, new Vector3i[] { new Vector3i(0, 0, 7) },
                                true, new string[] { "br_ff3MonsterSpeakerP2", "br_ff3MonsterSpeakerP3", "br_ff3MonsterSpeakerP4"},
                                      new Vector3i[] {new Vector3i(-7, 0, 0), new Vector3i(-7, 0, -7), new Vector3i(0, 0, -7)}),
            new RoomDataLarge("br_ff3MonsterSpeakerP2", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] {  },
                                false, null, null),
            new RoomDataLarge("br_ff3MonsterSpeakerP3", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] { new Vector3i(-7, 0, 0) },
                                false, null, null),
            new RoomDataLarge("br_ff3MonsterSpeakerP4", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] {  },
                                false, null, null),

            new RoomDataLarge("br_companyOutpost1P1", 1, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] { new Vector3i(0, 0, 7), new Vector3i(-7, 0, 0) },
                                true, new string[] { "br_companyOutpost1P2", "br_companyOutpost1P3", "br_companyOutpost1P4"},
                                      new Vector3i[] {new Vector3i(7, 0, 0), new Vector3i(7, 0, -7), new Vector3i(0, 0, -7)}),
            new RoomDataLarge("br_companyOutpost1P2", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] { new Vector3i(0, 0, 7), new Vector3i(7, 0, 0) },
                                false, null, null),
            new RoomDataLarge("br_companyOutpost1P3", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] { new Vector3i(0, 0, -7), new Vector3i(7, 0, 0) },
                                false, null, null),
            new RoomDataLarge("br_companyOutpost1P4", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y, 7, new Vector3i[] { new Vector3i(0, 0, -7), new Vector3i(-7, 0, 0) },
                                false, null, null),

            new RoomDataLarge("br_underUpDuctP1", 1, new Dictionary<string, float>(), 7, BASE_OFFSET_Y - 6, 7, new Vector3i[] { new Vector3i(0, 0, 7), new Vector3i(0, 0, -7) },
                                true, new string[] { "br_underUpDuctP2"},
                                      new Vector3i[] {new Vector3i(7, 0, 0) }),
            new RoomDataLarge("br_underUpDuctP2", 0, new Dictionary<string, float>() { }, 7, BASE_OFFSET_Y - 6, 7, new Vector3i[] { new Vector3i(0, 0, 7), new Vector3i(0, 0, -7) },
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
