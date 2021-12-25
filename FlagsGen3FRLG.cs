﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PKHeX.Core;

namespace MissingEventFlagsCheckerPlugin
{
    static class FlagsGen3FRLG
    {
        static List<string> s_missingEventFlagsList = new List<string>(4096);

        static bool[] s_eventFlags;

        static void CheckFlag(int flagIdx, string aFlagDetail)
        {
            if (!s_eventFlags[flagIdx])
            {
                s_missingEventFlagsList.Add(aFlagDetail);
            }
        }

        public static void ExportFlags(SaveFile savFile)
        {
            s_eventFlags = savFile.GetEventFlags();
            s_missingEventFlagsList.Clear();

            CheckFlags();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s_missingEventFlagsList.Count; ++i)
            {
                sb.AppendFormat("{0}\n", s_missingEventFlagsList[i]);
            }

            System.IO.File.WriteAllText(string.Format("missing_events_{0}.txt", savFile.Version), sb.ToString());
        }

        static void CheckFlags()
        {
            // Hidden Items
            CheckFlag(0x3E8, "FLAG_HIDDEN_ITEM_VIRIDIAN_FOREST_POTION");
            CheckFlag(0x3E9, "FLAG_HIDDEN_ITEM_VIRIDIAN_FOREST_ANTIDOTE");
            CheckFlag(0x3EA, "FLAG_HIDDEN_ITEM_MT_MOON_B2F_MOON_STONE");
            CheckFlag(0x3EB, "FLAG_HIDDEN_ITEM_MT_MOON_B2F_ETHER");
            CheckFlag(0x3EC, "FLAG_HIDDEN_ITEM_ROUTE25_ELIXIR");
            CheckFlag(0x3ED, "FLAG_HIDDEN_ITEM_ROUTE25_ETHER");
            CheckFlag(0x3EE, "FLAG_HIDDEN_ITEM_ROUTE9_ETHER");
            CheckFlag(0x3EF, "FLAG_HIDDEN_ITEM_UNUSED_0x07");
            CheckFlag(0x3F0, "FLAG_HIDDEN_ITEM_SSANNE_B1F_CORRIDOR_HYPER_POTION");
            CheckFlag(0x3F1, "FLAG_HIDDEN_ITEM_ROUTE10_SUPER_POTION");
            CheckFlag(0x3F2, "FLAG_HIDDEN_ITEM_ROUTE10_MAX_ETHER");
            CheckFlag(0x3F3, "FLAG_HIDDEN_ITEM_ROCKET_HIDEOUT_B1F_PP_UP");
            CheckFlag(0x3F4, "FLAG_HIDDEN_ITEM_ROCKET_HIDEOUT_B3F_NUGGET");
            CheckFlag(0x3F5, "FLAG_HIDDEN_ITEM_ROCKET_HIDEOUT_B4F_NEST_BALL");
            CheckFlag(0x3F6, "FLAG_HIDDEN_ITEM_POKEMON_TOWER_5F_BIG_MUSHROOM");
            CheckFlag(0x3F7, "FLAG_HIDDEN_ITEM_ROUTE13_PP_UP");
            CheckFlag(0x3F8, "FLAG_HIDDEN_ITEM_UNUSED_0x10");
            CheckFlag(0x3F9, "FLAG_HIDDEN_ITEM_ROUTE17_RARE_CANDY");
            CheckFlag(0x3FA, "FLAG_HIDDEN_ITEM_ROUTE17_FULL_RESTORE");
            CheckFlag(0x3FB, "FLAG_HIDDEN_ITEM_ROUTE17_PP_UP");
            CheckFlag(0x3FC, "FLAG_HIDDEN_ITEM_ROUTE17_MAX_REVIVE");
            CheckFlag(0x3FD, "FLAG_HIDDEN_ITEM_ROUTE17_MAX_ELIXIR");
            CheckFlag(0x3FE, "FLAG_HIDDEN_ITEM_SAFARI_ZONE_CENTER_LEAF_STONE");
            CheckFlag(0x3FF, "FLAG_HIDDEN_ITEM_SAFARI_ZONE_WEST_REVIVE");
            CheckFlag(0x400, "FLAG_HIDDEN_ITEM_SILPH_CO_5F_ELIXIR");
            CheckFlag(0x401, "FLAG_HIDDEN_ITEM_SILPH_CO_9F_MAX_POTION");
            CheckFlag(0x402, "FLAG_HIDDEN_ITEM_SAFFRON_CITY_COPYCATS_HOUSE_2F_NUGGET");
            CheckFlag(0x403, "FLAG_HIDDEN_ITEM_POWER_PLANT_MAX_ELIXIR");
            CheckFlag(0x404, "FLAG_HIDDEN_ITEM_POWER_PLANT_THUNDER_STONE");
            CheckFlag(0x405, "FLAG_HIDDEN_ITEM_SEAFOAM_ISLANDS_B3F_NUGGET");
            CheckFlag(0x406, "FLAG_HIDDEN_ITEM_SEAFOAM_ISLANDS_B4F_WATER_STONE");
            CheckFlag(0x407, "FLAG_HIDDEN_ITEM_POKEMON_MANSION_1F_MOON_STONE");
            CheckFlag(0x408, "FLAG_HIDDEN_ITEM_POKEMON_MANSION_3F_RARE_CANDY");
            CheckFlag(0x409, "FLAG_HIDDEN_ITEM_POKEMON_MANSION_B1F_ELIXIR");
            CheckFlag(0x40A, "FLAG_HIDDEN_ITEM_ROUTE23_FULL_RESTORE");
            CheckFlag(0x40B, "FLAG_HIDDEN_ITEM_ROUTE23_ULTRA_BALL");
            CheckFlag(0x40C, "FLAG_HIDDEN_ITEM_ROUTE23_MAX_ETHER");
            CheckFlag(0x40D, "FLAG_HIDDEN_ITEM_VICTORY_ROAD_1F_ULTRA_BALL");
            CheckFlag(0x40E, "FLAG_HIDDEN_ITEM_VICTORY_ROAD_1F_FULL_RESTORE");
            CheckFlag(0x40F, "FLAG_HIDDEN_ITEM_CERULEAN_CAVE_1F_ULTRA_BALL");
            CheckFlag(0x410, "FLAG_HIDDEN_ITEM_UNUSED_0x28");
            CheckFlag(0x411, "FLAG_HIDDEN_ITEM_ROUTE11_ESCAPE_ROPE");
            CheckFlag(0x412, "FLAG_HIDDEN_ITEM_ROUTE12_HYPER_POTION");
            CheckFlag(0x413, "FLAG_HIDDEN_ITEM_UNUSED_0x2B");
            CheckFlag(0x414, "FLAG_HIDDEN_ITEM_UNUSED_0x2C");
            CheckFlag(0x415, "FLAG_HIDDEN_ITEM_UNUSED_0x2D");
            CheckFlag(0x416, "FLAG_HIDDEN_ITEM_UNUSED_0x2E");
            CheckFlag(0x417, "FLAG_HIDDEN_ITEM_CELADON_CITY_PP_UP");
            CheckFlag(0x418, "FLAG_HIDDEN_ITEM_VERMILION_CITY_MAX_ETHER");
            CheckFlag(0x419, "FLAG_HIDDEN_ITEM_CERULEAN_CITY_RARE_CANDY");
            CheckFlag(0x41A, "FLAG_HIDDEN_ITEM_ROUTE4_GREAT_BALL");
            CheckFlag(0x41B, "FLAG_HIDDEN_ITEM_CELADON_CITY_GAME_CORNER_COINS");
            CheckFlag(0x41C, "FLAG_HIDDEN_ITEM_CELADON_CITY_GAME_CORNER_COINS_2");
            CheckFlag(0x41D, "FLAG_HIDDEN_ITEM_CELADON_CITY_GAME_CORNER_COINS_3");
            CheckFlag(0x41E, "FLAG_HIDDEN_ITEM_CELADON_CITY_GAME_CORNER_COINS_4");
            CheckFlag(0x41F, "FLAG_HIDDEN_ITEM_CELADON_CITY_GAME_CORNER_COINS_5");
            CheckFlag(0x420, "FLAG_HIDDEN_ITEM_CELADON_CITY_GAME_CORNER_COINS_6");
            CheckFlag(0x421, "FLAG_HIDDEN_ITEM_CELADON_CITY_GAME_CORNER_COINS_7");
            CheckFlag(0x422, "FLAG_HIDDEN_ITEM_CELADON_CITY_GAME_CORNER_COINS_8");
            CheckFlag(0x423, "FLAG_HIDDEN_ITEM_CELADON_CITY_GAME_CORNER_COINS_9");
            CheckFlag(0x424, "FLAG_HIDDEN_ITEM_CELADON_CITY_GAME_CORNER_COINS_10");
            CheckFlag(0x425, "FLAG_HIDDEN_ITEM_CELADON_CITY_GAME_CORNER_COINS_11");
            CheckFlag(0x426, "FLAG_HIDDEN_ITEM_CELADON_CITY_GAME_CORNER_COINS_12");
            CheckFlag(0x427, "FLAG_HIDDEN_ITEM_SEVEN_ISLAND_SEVAULT_CANYON_CHERI_BERRY");
            CheckFlag(0x428, "FLAG_HIDDEN_ITEM_SEVEN_ISLAND_TANOBY_RUINS_HEART_SCALE_4");
            CheckFlag(0x429, "FLAG_HIDDEN_ITEM_SEVEN_ISLAND_TANOBY_RUINS_HEART_SCALE");
            CheckFlag(0x42A, "FLAG_HIDDEN_ITEM_SEVEN_ISLAND_TANOBY_RUINS_HEART_SCALE_2");
            CheckFlag(0x42B, "FLAG_HIDDEN_ITEM_SEVEN_ISLAND_TANOBY_RUINS_HEART_SCALE_3");
            CheckFlag(0x42C, "FLAG_HIDDEN_ITEM_FIVE_ISLAND_ROCKET_WAREHOUSE_NEST_BALL");
            CheckFlag(0x42D, "FLAG_HIDDEN_ITEM_FIVE_ISLAND_ROCKET_WAREHOUSE_NET_BALL");
            CheckFlag(0x42E, "FLAG_HIDDEN_ITEM_UNDERGROUND_PATH_NORTH_SOUTH_TUNNEL_POTION");
            CheckFlag(0x42F, "FLAG_HIDDEN_ITEM_UNDERGROUND_PATH_NORTH_SOUTH_TUNNEL_ANTIDOTE");
            CheckFlag(0x430, "FLAG_HIDDEN_ITEM_UNDERGROUND_PATH_NORTH_SOUTH_TUNNEL_PARALYZE_HEAL");
            CheckFlag(0x431, "FLAG_HIDDEN_ITEM_UNDERGROUND_PATH_NORTH_SOUTH_TUNNEL_AWAKENING");
            CheckFlag(0x432, "FLAG_HIDDEN_ITEM_UNDERGROUND_PATH_NORTH_SOUTH_TUNNEL_BURN_HEAL");
            CheckFlag(0x433, "FLAG_HIDDEN_ITEM_UNDERGROUND_PATH_NORTH_SOUTH_TUNNEL_ICE_HEAL");
            CheckFlag(0x434, "FLAG_HIDDEN_ITEM_UNDERGROUND_PATH_NORTH_SOUTH_TUNNEL_ETHER");
            CheckFlag(0x435, "FLAG_HIDDEN_ITEM_UNDERGROUND_PATH_EAST_WEST_TUNNEL_POTION");
            CheckFlag(0x436, "FLAG_HIDDEN_ITEM_UNDERGROUND_PATH_EAST_WEST_TUNNEL_ANTIDOTE");
            CheckFlag(0x437, "FLAG_HIDDEN_ITEM_UNDERGROUND_PATH_EAST_WEST_TUNNEL_PARALYZE_HEAL");
            CheckFlag(0x438, "FLAG_HIDDEN_ITEM_UNDERGROUND_PATH_EAST_WEST_TUNNEL_AWAKENING");
            CheckFlag(0x439, "FLAG_HIDDEN_ITEM_UNDERGROUND_PATH_EAST_WEST_TUNNEL_BURN_HEAL");
            CheckFlag(0x43A, "FLAG_HIDDEN_ITEM_UNDERGROUND_PATH_EAST_WEST_TUNNEL_ICE_HEAL");
            CheckFlag(0x43B, "FLAG_HIDDEN_ITEM_UNDERGROUND_PATH_EAST_WEST_TUNNEL_ETHER");
            CheckFlag(0x43C, "FLAG_HIDDEN_ITEM_MT_MOON_B1F_TINY_MUSHROOM");
            CheckFlag(0x43D, "FLAG_HIDDEN_ITEM_MT_MOON_B1F_TINY_MUSHROOM_2");
            CheckFlag(0x43E, "FLAG_HIDDEN_ITEM_MT_MOON_B1F_TINY_MUSHROOM_3");
            CheckFlag(0x43F, "FLAG_HIDDEN_ITEM_MT_MOON_B1F_BIG_MUSHROOM");
            CheckFlag(0x440, "FLAG_HIDDEN_ITEM_MT_MOON_B1F_BIG_MUSHROOM_2");
            CheckFlag(0x441, "FLAG_HIDDEN_ITEM_MT_MOON_B1F_BIG_MUSHROOM_3");
            CheckFlag(0x442, "FLAG_HIDDEN_ITEM_THREE_ISLAND_BERRY_FOREST_RAZZ_BERRY");
            CheckFlag(0x443, "FLAG_HIDDEN_ITEM_THREE_ISLAND_BERRY_FOREST_BLUK_BERRY");
            CheckFlag(0x444, "FLAG_HIDDEN_ITEM_THREE_ISLAND_BERRY_FOREST_NANAB_BERRY");
            CheckFlag(0x445, "FLAG_HIDDEN_ITEM_THREE_ISLAND_BERRY_FOREST_WEPEAR_BERRY");
            CheckFlag(0x446, "FLAG_HIDDEN_ITEM_THREE_ISLAND_BERRY_FOREST_ORAN_BERRY");
            CheckFlag(0x447, "FLAG_HIDDEN_ITEM_THREE_ISLAND_BERRY_FOREST_CHERI_BERRY");
            CheckFlag(0x448, "FLAG_HIDDEN_ITEM_THREE_ISLAND_BERRY_FOREST_CHESTO_BERRY");
            CheckFlag(0x449, "FLAG_HIDDEN_ITEM_THREE_ISLAND_BERRY_FOREST_PECHA_BERRY");
            CheckFlag(0x44A, "FLAG_HIDDEN_ITEM_THREE_ISLAND_BERRY_FOREST_RAWST_BERRY");
            CheckFlag(0x44B, "FLAG_HIDDEN_ITEM_THREE_ISLAND_BERRY_FOREST_ASPEAR_BERRY");
            CheckFlag(0x44C, "FLAG_HIDDEN_ITEM_THREE_ISLAND_BERRY_FOREST_PERSIM_BERRY");
            CheckFlag(0x44D, "FLAG_HIDDEN_ITEM_THREE_ISLAND_BERRY_FOREST_PINAP_BERRY");
            CheckFlag(0x44E, "FLAG_HIDDEN_ITEM_THREE_ISLAND_BERRY_FOREST_LUM_BERRY");
            CheckFlag(0x44F, "FLAG_HIDDEN_ITEM_ONE_ISLAND_TREASURE_BEACH_STARDUST");
            CheckFlag(0x450, "FLAG_HIDDEN_ITEM_ONE_ISLAND_TREASURE_BEACH_STARDUST_2");
            CheckFlag(0x451, "FLAG_HIDDEN_ITEM_ONE_ISLAND_TREASURE_BEACH_PEARL");
            CheckFlag(0x452, "FLAG_HIDDEN_ITEM_ONE_ISLAND_TREASURE_BEACH_PEARL_2");
            CheckFlag(0x453, "FLAG_HIDDEN_ITEM_ONE_ISLAND_TREASURE_BEACH_ULTRA_BALL");
            CheckFlag(0x454, "FLAG_HIDDEN_ITEM_ONE_ISLAND_TREASURE_BEACH_ULTRA_BALL_2");
            CheckFlag(0x455, "FLAG_HIDDEN_ITEM_ONE_ISLAND_TREASURE_BEACH_STAR_PIECE");
            CheckFlag(0x456, "FLAG_HIDDEN_ITEM_ONE_ISLAND_TREASURE_BEACH_BIG_PEARL");
            CheckFlag(0x457, "FLAG_HIDDEN_ITEM_TWO_ISLAND_CAPE_BRINK_RARE_CANDY");
            CheckFlag(0x458, "FLAG_HIDDEN_ITEM_PEWTER_CITY_POKE_BALL");
            CheckFlag(0x459, "FLAG_HIDDEN_ITEM_ROUTE3_ORAN_BERRY");
            CheckFlag(0x45A, "FLAG_HIDDEN_ITEM_ROUTE4_PERSIM_BERRY");
            CheckFlag(0x45B, "FLAG_HIDDEN_ITEM_ROUTE24_PECHA_BERRY");
            CheckFlag(0x45C, "FLAG_HIDDEN_ITEM_ROUTE25_ORAN_BERRY");
            CheckFlag(0x45D, "FLAG_HIDDEN_ITEM_ROUTE25_BLUK_BERRY");
            CheckFlag(0x45E, "FLAG_HIDDEN_ITEM_ROUTE6_SITRUS_BERRY");
            CheckFlag(0x45F, "FLAG_HIDDEN_ITEM_ROUTE6_RARE_CANDY");
            CheckFlag(0x460, "FLAG_HIDDEN_ITEM_SSANNE_KITCHEN_PECHA_BERRY");
            CheckFlag(0x461, "FLAG_HIDDEN_ITEM_SSANNE_KITCHEN_CHERI_BERRY");
            CheckFlag(0x462, "FLAG_HIDDEN_ITEM_SSANNE_KITCHEN_CHESTO_BERRY");
            CheckFlag(0x463, "FLAG_HIDDEN_ITEM_ROUTE9_RARE_CANDY");
            CheckFlag(0x464, "FLAG_HIDDEN_ITEM_UNUSED_0x7C");
            CheckFlag(0x465, "FLAG_HIDDEN_ITEM_ROUTE10_PERSIM_BERRY");
            CheckFlag(0x466, "FLAG_HIDDEN_ITEM_ROUTE10_CHERI_BERRY");
            CheckFlag(0x467, "FLAG_HIDDEN_ITEM_ROUTE8_RAWST_BERRY");
            CheckFlag(0x468, "FLAG_HIDDEN_ITEM_ROUTE8_LUM_BERRY");
            CheckFlag(0x469, "FLAG_HIDDEN_ITEM_ROUTE8_LEPPA_BERRY");
            CheckFlag(0x46A, "FLAG_HIDDEN_ITEM_ROUTE12_RARE_CANDY");
            CheckFlag(0x46B, "FLAG_HIDDEN_ITEM_ROUTE12_LEFTOVERS");
            CheckFlag(0x46C, "FLAG_HIDDEN_ITEM_ROUTE16_LEFTOVERS");
            CheckFlag(0x46D, "FLAG_HIDDEN_ITEM_FUCHSIA_CITY_MAX_REVIVE");
            CheckFlag(0x46E, "FLAG_HIDDEN_ITEM_ROCKET_HIDEOUT_B4F_NET_BALL");
            CheckFlag(0x46F, "FLAG_HIDDEN_ITEM_SILPH_CO_2F_ULTRA_BALL");
            CheckFlag(0x470, "FLAG_HIDDEN_ITEM_SILPH_CO_3F_PROTEIN");
            CheckFlag(0x471, "FLAG_HIDDEN_ITEM_SILPH_CO_4F_IRON");
            CheckFlag(0x472, "FLAG_HIDDEN_ITEM_SILPH_CO_5F_PP_UP");
            CheckFlag(0x473, "FLAG_HIDDEN_ITEM_SILPH_CO_6F_CARBOS");
            CheckFlag(0x474, "FLAG_HIDDEN_ITEM_SILPH_CO_7F_ZINC");
            CheckFlag(0x475, "FLAG_HIDDEN_ITEM_SILPH_CO_8F_NUGGET");
            CheckFlag(0x476, "FLAG_HIDDEN_ITEM_SILPH_CO_9F_CALCIUM");
            CheckFlag(0x477, "FLAG_HIDDEN_ITEM_SILPH_CO_10F_HP_UP");
            CheckFlag(0x478, "FLAG_HIDDEN_ITEM_SILPH_CO_11F_REVIVE");
            CheckFlag(0x479, "FLAG_HIDDEN_ITEM_ROUTE23_LUM_BERRY");
            CheckFlag(0x47A, "FLAG_HIDDEN_ITEM_ROUTE23_SITRUS_BERRY");
            CheckFlag(0x47B, "FLAG_HIDDEN_ITEM_ROUTE23_ASPEAR_BERRY");
            CheckFlag(0x47C, "FLAG_HIDDEN_ITEM_ROUTE23_LEPPA_BERRY");
            CheckFlag(0x47D, "FLAG_HIDDEN_ITEM_ROUTE14_ZINC");
            CheckFlag(0x47E, "FLAG_HIDDEN_ITEM_ROUTE9_CHESTO_BERRY");
            CheckFlag(0x47F, "FLAG_HIDDEN_ITEM_ROUTE10_NANAB_BERRY");
            CheckFlag(0x480, "FLAG_HIDDEN_ITEM_ROUTE7_WEPEAR_BERRY");
            CheckFlag(0x481, "FLAG_HIDDEN_ITEM_ROUTE20_STARDUST");
            CheckFlag(0x482, "FLAG_HIDDEN_ITEM_ROUTE21_NORTH_PEARL");
            CheckFlag(0x483, "FLAG_HIDDEN_ITEM_ROUTE23_MAX_ELIXIR");
            CheckFlag(0x484, "FLAG_HIDDEN_ITEM_ROUTE4_RAZZ_BERRY");
            CheckFlag(0x485, "FLAG_HIDDEN_ITEM_ROUTE14_PINAP_BERRY");
            CheckFlag(0x486, "FLAG_HIDDEN_ITEM_MT_EMBER_EXTERIOR_FIRE_STONE");
            CheckFlag(0x487, "FLAG_HIDDEN_ITEM_POKEMON_TOWER_7F_SOOTHE_BELL");
            CheckFlag(0x488, "FLAG_HIDDEN_ITEM_NAVEL_ROCK_SUMMIT_SACRED_ASH");
            CheckFlag(0x489, "FLAG_HIDDEN_ITEM_TWO_ISLAND_CAPE_BRINK_PP_MAX");
            CheckFlag(0x48A, "FLAG_HIDDEN_ITEM_MT_EMBER_EXTERIOR_ULTRA_BALL");
            CheckFlag(0x48B, "FLAG_HIDDEN_ITEM_THREE_ISLAND_DUNSPARCE_TUNNEL_NUGGET");
            CheckFlag(0x48C, "FLAG_HIDDEN_ITEM_THREE_ISLAND_PP_UP");
            CheckFlag(0x48D, "FLAG_HIDDEN_ITEM_THREE_ISLAND_BOND_BRIDGE_MAX_REPEL");
            CheckFlag(0x48E, "FLAG_HIDDEN_ITEM_THREE_ISLAND_BOND_BRIDGE_PEARL");
            CheckFlag(0x48F, "FLAG_HIDDEN_ITEM_THREE_ISLAND_BOND_BRIDGE_STARDUST");
            CheckFlag(0x490, "FLAG_HIDDEN_ITEM_FOUR_ISLAND_PEARL");
            CheckFlag(0x491, "FLAG_HIDDEN_ITEM_FOUR_ISLAND_ULTRA_BALL");
            CheckFlag(0x492, "FLAG_HIDDEN_ITEM_FIVE_ISLAND_MEMORIAL_PILLAR_BIG_PEARL");
            CheckFlag(0x493, "FLAG_HIDDEN_ITEM_FIVE_ISLAND_MEMORIAL_PILLAR_RAZZ_BERRY");
            CheckFlag(0x494, "FLAG_HIDDEN_ITEM_FIVE_ISLAND_MEMORIAL_PILLAR_SITRUS_BERRY");
            CheckFlag(0x495, "FLAG_HIDDEN_ITEM_FIVE_ISLAND_MEMORIAL_PILLAR_BLUK_BERRY");
            CheckFlag(0x496, "FLAG_HIDDEN_ITEM_FIVE_ISLAND_RESORT_GORGEOUS_NEST_BALL");
            CheckFlag(0x497, "FLAG_HIDDEN_ITEM_FIVE_ISLAND_RESORT_GORGEOUS_STARDUST");
            CheckFlag(0x498, "FLAG_HIDDEN_ITEM_FIVE_ISLAND_RESORT_GORGEOUS_STAR_PIECE");
            CheckFlag(0x499, "FLAG_HIDDEN_ITEM_FIVE_ISLAND_RESORT_GORGEOUS_STARDUST_2");
            CheckFlag(0x49A, "FLAG_HIDDEN_ITEM_SIX_ISLAND_OUTCAST_ISLAND_STAR_PIECE");
            CheckFlag(0x49B, "FLAG_HIDDEN_ITEM_SIX_ISLAND_OUTCAST_ISLAND_NET_BALL");
            CheckFlag(0x49C, "FLAG_HIDDEN_ITEM_SIX_ISLAND_GREEN_PATH_ULTRA_BALL");
            CheckFlag(0x49D, "FLAG_HIDDEN_ITEM_SIX_ISLAND_WATER_PATH_ASPEAR_BERRY");
            CheckFlag(0x49E, "FLAG_HIDDEN_ITEM_SIX_ISLAND_WATER_PATH_ORAN_BERRY");
            CheckFlag(0x49F, "FLAG_HIDDEN_ITEM_SIX_ISLAND_WATER_PATH_PINAP_BERRY");
            CheckFlag(0x4A0, "FLAG_HIDDEN_ITEM_SIX_ISLAND_LEPPA_BERRY");
            CheckFlag(0x4A1, "FLAG_HIDDEN_ITEM_SEVEN_ISLAND_TRAINER_TOWER_BIG_PEARL");
            CheckFlag(0x4A2, "FLAG_HIDDEN_ITEM_SEVEN_ISLAND_TRAINER_TOWER_PEARL");
            CheckFlag(0x4A3, "FLAG_HIDDEN_ITEM_SEVEN_ISLAND_TRAINER_TOWER_NANAB_BERRY");
            CheckFlag(0x4A4, "FLAG_HIDDEN_ITEM_SEVEN_ISLAND_SEVAULT_CANYON_ENTRANCE_RAWST_BERRY");
            CheckFlag(0x4A5, "FLAG_HIDDEN_ITEM_VIRIDIAN_CITY_GYM_MACHO_BRACE");
            CheckFlag(0x4A6, "FLAG_HIDDEN_ITEM_SSANNE_EXTERIOR_LAVA_COOKIE");

            // Normal items
            CheckFlag(0x154, "FLAG_ITEM_ROUTE2_ETHER");
            CheckFlag(0x155, "FLAG_ITEM_ROUTE2_PARALYZE_HEAL");
            CheckFlag(0x156, "FLAG_ITEM_VIRIDIAN_FOREST_POKE_BALL");
            CheckFlag(0x157, "FLAG_ITEM_VIRIDIAN_FOREST_ANTIDOTE");
            CheckFlag(0x158, "FLAG_ITEM_VIRIDIAN_FOREST_POTION");
            CheckFlag(0x159, "FLAG_ITEM_MT_MOON_1F_PARALYZE_HEAL");
            CheckFlag(0x15A, "FLAG_ITEM_MT_MOON_1F_TM09");
            CheckFlag(0x15B, "FLAG_ITEM_MT_MOON_1F_POTION");
            CheckFlag(0x15C, "FLAG_ITEM_MT_MOON_1F_RARE_CANDY");
            CheckFlag(0x15D, "FLAG_ITEM_MT_MOON_1F_ESCAPE_ROPE");
            CheckFlag(0x15E, "FLAG_ITEM_MT_MOON_1F_MOON_STONE");
            CheckFlag(0x15F, "FLAG_ITEM_MT_MOON_B2F_STAR_PIECE");
            CheckFlag(0x160, "FLAG_ITEM_MT_MOON_B2F_TM46");
            CheckFlag(0x161, "FLAG_ITEM_ROUTE4_TM05");
            CheckFlag(0x162, "FLAG_ITEM_ROUTE24_TM45");
            CheckFlag(0x163, "FLAG_ITEM_ROUTE25_TM43");
            CheckFlag(0x164, "FLAG_ITEM_SSANNE_1F_ROOM2_TM31");
            CheckFlag(0x165, "FLAG_ITEM_SSANNE_2F_ROOM2_STARDUST");
            CheckFlag(0x166, "FLAG_ITEM_SSANNE_2F_ROOM4_X_ATTACK");
            CheckFlag(0x167, "FLAG_ITEM_SSANNE_B1F_ROOM2_TM44");
            CheckFlag(0x168, "FLAG_ITEM_SSANNE_B1F_ROOM3_ETHER");
            CheckFlag(0x169, "FLAG_ITEM_SSANNE_B1F_ROOM5_SUPER_POTION");
            CheckFlag(0x16A, "FLAG_ITEM_SSANNE_KITCHEN_GREAT_BALL");
            CheckFlag(0x16B, "FLAG_ITEM_ROUTE9_TM40");
            CheckFlag(0x16C, "FLAG_ITEM_ROCKET_HIDEOUT_B1F_ESCAPE_ROPE");
            CheckFlag(0x16D, "FLAG_ITEM_ROCKET_HIDEOUT_B1F_HYPER_POTION");
            CheckFlag(0x16E, "FLAG_ITEM_ROCKET_HIDEOUT_B2F_X_SPEED");
            CheckFlag(0x16F, "FLAG_ITEM_ROCKET_HIDEOUT_B2F_MOON_STONE");
            CheckFlag(0x170, "FLAG_ITEM_ROCKET_HIDEOUT_B2F_TM12");
            CheckFlag(0x171, "FLAG_ITEM_ROCKET_HIDEOUT_B2F_SUPER_POTION");
            CheckFlag(0x172, "FLAG_ITEM_ROCKET_HIDEOUT_B3F_RARE_CANDY");
            CheckFlag(0x173, "FLAG_ITEM_ROCKET_HIDEOUT_B3F_TM21");
            CheckFlag(0x174, "FLAG_ITEM_ROCKET_HIDEOUT_B4F_TM49");
            CheckFlag(0x175, "FLAG_ITEM_ROCKET_HIDEOUT_B4F_MAX_ETHER");
            CheckFlag(0x176, "FLAG_ITEM_ROCKET_HIDEOUT_B4F_CALCIUM");
            CheckFlag(0x177, "FLAG_ITEM_POKEMON_TOWER_3F_ESCAPE_ROPE");
            CheckFlag(0x178, "FLAG_ITEM_POKEMON_TOWER_4F_ELIXIR");
            CheckFlag(0x179, "FLAG_ITEM_POKEMON_TOWER_4F_AWAKENING");
            CheckFlag(0x17A, "FLAG_ITEM_POKEMON_TOWER_4F_GREAT_BALL");
            CheckFlag(0x17B, "FLAG_ITEM_POKEMON_TOWER_5F_NUGGET");
            CheckFlag(0x17C, "FLAG_ITEM_POKEMON_TOWER_6F_RARE_CANDY");
            CheckFlag(0x17D, "FLAG_ITEM_POKEMON_TOWER_6F_X_ACCURACY");
            CheckFlag(0x17E, "FLAG_ITEM_ROUTE12_TM48");
            CheckFlag(0x17F, "FLAG_ITEM_ROUTE12_IRON");
            CheckFlag(0x180, "FLAG_ITEM_ROUTE15_TM18");
            CheckFlag(0x181, "FLAG_ITEM_SAFARI_ZONE_CENTER_NUGGET");
            CheckFlag(0x182, "FLAG_ITEM_SAFARI_ZONE_EAST_MAX_POTION");
            CheckFlag(0x183, "FLAG_ITEM_SAFARI_ZONE_EAST_FULL_RESTORE");
            CheckFlag(0x184, "FLAG_ITEM_SAFARI_ZONE_EAST_TM11");
            CheckFlag(0x185, "FLAG_ITEM_SAFARI_ZONE_EAST_LEAF_STONE");
            CheckFlag(0x186, "FLAG_ITEM_SAFARI_ZONE_NORTH_PROTEIN");
            CheckFlag(0x187, "FLAG_ITEM_SAFARI_ZONE_NORTH_TM47");
            CheckFlag(0x188, "FLAG_ITEM_SAFARI_ZONE_WEST_TM32");
            CheckFlag(0x189, "FLAG_ITEM_SAFARI_ZONE_WEST_GOLD_TEETH");
            CheckFlag(0x18A, "FLAG_ITEM_SAFARI_ZONE_WEST_MAX_POTION");
            CheckFlag(0x18B, "FLAG_ITEM_SAFARI_ZONE_WEST_MAX_REVIVE");
            CheckFlag(0x18C, "FLAG_ITEM_SILPH_CO_3F_HYPER_POTION");
            CheckFlag(0x18D, "FLAG_ITEM_SILPH_CO_4F_MAX_REVIVE");
            CheckFlag(0x18E, "FLAG_ITEM_SILPH_CO_4F_ESCAPE_ROPE");
            CheckFlag(0x18F, "FLAG_ITEM_SILPH_CO_4F_FULL_HEAL");
            CheckFlag(0x190, "FLAG_ITEM_SILPH_CO_5F_PROTEIN");
            CheckFlag(0x191, "FLAG_ITEM_SILPH_CO_5F_TM01");
            CheckFlag(0x192, "FLAG_ITEM_SILPH_CO_5F_CARD_KEY");
            CheckFlag(0x193, "FLAG_ITEM_SILPH_CO_6F_HP_UP");
            CheckFlag(0x194, "FLAG_ITEM_SILPH_CO_6F_X_SPECIAL");
            CheckFlag(0x195, "FLAG_ITEM_SILPH_CO_7F_CALCIUM");
            CheckFlag(0x196, "FLAG_ITEM_SILPH_CO_7F_TM08");
            CheckFlag(0x197, "FLAG_ITEM_SILPH_CO_10F_CARBOS");
            CheckFlag(0x198, "FLAG_ITEM_SILPH_CO_10F_ULTRA_BALL");
            CheckFlag(0x199, "FLAG_ITEM_SILPH_CO_10F_RARE_CANDY");
            CheckFlag(0x19A, "FLAG_ITEM_POWER_PLANT_MAX_POTION");
            CheckFlag(0x19B, "FLAG_ITEM_POWER_PLANT_TM17");
            CheckFlag(0x19C, "FLAG_ITEM_POWER_PLANT_TM25");
            CheckFlag(0x19D, "FLAG_ITEM_POWER_PLANT_THUNDER_STONE");
            CheckFlag(0x19E, "FLAG_ITEM_POWER_PLANT_ELIXIR");
            CheckFlag(0x19F, "FLAG_ITEM_POKEMON_MANSION_1F_CARBOS");
            CheckFlag(0x1A0, "FLAG_ITEM_POKEMON_MANSION_1F_ESCAPE_ROPE");
            CheckFlag(0x1A1, "FLAG_ITEM_POKEMON_MANSION_2F_CALCIUM");
            CheckFlag(0x1A2, "FLAG_ITEM_POKEMON_MANSION_3F_MAX_POTION");
            CheckFlag(0x1A3, "FLAG_ITEM_POKEMON_MANSION_3F_IRON");
            CheckFlag(0x1A4, "FLAG_ITEM_POKEMON_MANSION_B1F_TM14");
            CheckFlag(0x1A5, "FLAG_ITEM_POKEMON_MANSION_B1F_FULL_RESTORE");
            CheckFlag(0x1A6, "FLAG_0x1A6");
            CheckFlag(0x1A7, "FLAG_ITEM_POKEMON_MANSION_B1F_TM22");
            CheckFlag(0x1A8, "FLAG_ITEM_POKEMON_MANSION_B1F_SECRET_KEY");
            CheckFlag(0x1A9, "FLAG_ITEM_VICTORY_ROAD_1F_RARE_CANDY");
            CheckFlag(0x1AA, "FLAG_ITEM_VICTORY_ROAD_1F_TM02");
            CheckFlag(0x1AB, "FLAG_ITEM_VICTORY_ROAD_2F_GUARD_SPEC");
            CheckFlag(0x1AC, "FLAG_ITEM_VICTORY_ROAD_2F_TM07");
            CheckFlag(0x1AD, "FLAG_ITEM_VICTORY_ROAD_2F_FULL_HEAL");
            CheckFlag(0x1AE, "FLAG_ITEM_VICTORY_ROAD_2F_TM37");
            CheckFlag(0x1AF, "FLAG_ITEM_VICTORY_ROAD_3F_MAX_REVIVE");
            CheckFlag(0x1B0, "FLAG_ITEM_VICTORY_ROAD_3F_TM50");
            CheckFlag(0x1B1, "FLAG_ITEM_CERULEAN_CAVE_1F_MAX_ELIXIR");
            CheckFlag(0x1B2, "FLAG_ITEM_CERULEAN_CAVE_1F_NUGGET");
            CheckFlag(0x1B3, "FLAG_ITEM_CERULEAN_CAVE_1F_FULL_RESTORE");
            CheckFlag(0x1B4, "FLAG_ITEM_CERULEAN_CAVE_2F_FULL_RESTORE");
            CheckFlag(0x1B5, "FLAG_ITEM_CERULEAN_CAVE_2F_PP_UP");
            CheckFlag(0x1B6, "FLAG_ITEM_CERULEAN_CAVE_2F_ULTRA_BALL");
            CheckFlag(0x1B7, "FLAG_ITEM_CERULEAN_CAVE_B1F_MAX_REVIVE");
            CheckFlag(0x1B8, "FLAG_ITEM_CERULEAN_CAVE_B1F_ULTRA_BALL");
            CheckFlag(0x1B9, "FLAG_ITEM_FUCHSIA_CITY_WARDENS_HOUSE_RARE_CANDY");
            CheckFlag(0x1BA, "FLAG_ITEM_TWO_ISLAND_REVIVE");
            CheckFlag(0x1BB, "FLAG_ITEM_THREE_ISLAND_ZINC");
            CheckFlag(0x1BC, "FLAG_0x1BC");
            CheckFlag(0x1BD, "FLAG_0x1BD");
            CheckFlag(0x1BE, "FLAG_ITEM_VIRIDIAN_FOREST_POTION_2");
            CheckFlag(0x1BF, "FLAG_ITEM_MT_MOON_B2F_REVIVE");
            CheckFlag(0x1C0, "FLAG_ITEM_MT_MOON_B2F_ANTIDOTE");
            CheckFlag(0x1C1, "FLAG_ITEM_ROUTE11_X_DEFEND");
            CheckFlag(0x1C2, "FLAG_ITEM_ROUTE9_BURN_HEAL");
            CheckFlag(0x1C3, "FLAG_ITEM_ROCK_TUNNEL_1F_REPEL");
            CheckFlag(0x1C4, "FLAG_ITEM_ROCK_TUNNEL_1F_PEARL");
            CheckFlag(0x1C5, "FLAG_ITEM_ROCK_TUNNEL_1F_ESCAPE_ROPE");
            CheckFlag(0x1C6, "FLAG_ITEM_ROCK_TUNNEL_B1F_REVIVE");
            CheckFlag(0x1C7, "FLAG_ITEM_ROCK_TUNNEL_B1F_MAX_ETHER");
            CheckFlag(0x1C8, "FLAG_ITEM_SILPH_CO_8F_IRON");
            CheckFlag(0x1C9, "FLAG_ITEM_SILPH_CO_11F_ZINC");
            CheckFlag(0x1CA, "FLAG_ITEM_POKEMON_MANSION_1F_PROTEIN");
            CheckFlag(0x1CB, "FLAG_ITEM_POKEMON_MANSION_2F_ZINC");
            CheckFlag(0x1CC, "FLAG_ITEM_POKEMON_MANSION_2F_HP_UP");
            CheckFlag(0x1CD, "FLAG_ITEM_VIRIDIAN_CITY_POTION");
            CheckFlag(0x1CE, "FLAG_ITEM_ROUTE11_GREAT_BALL");
            CheckFlag(0x1CF, "FLAG_ITEM_ROUTE11_AWAKENING");
            CheckFlag(0x1D0, "FLAG_ITEM_POKEMON_TOWER_5F_CLEANSE_TAG");
            CheckFlag(0x1D1, "FLAG_ITEM_CELADON_CITY_ETHER");
            CheckFlag(0x1D2, "FLAG_ITEM_ROCKET_HIDEOUT_B3F_BLACK_GLASSES");
            CheckFlag(0x1D3, "FLAG_ITEM_SAFARI_ZONE_NORTH_QUICK_CLAW");
            CheckFlag(0x1D4, "FLAG_ITEM_SEAFOAM_ISLANDS_1F_ICE_HEAL");
            CheckFlag(0x1D5, "FLAG_ITEM_SEAFOAM_ISLANDS_B1F_WATER_STONE");
            CheckFlag(0x1D6, "FLAG_ITEM_SEAFOAM_ISLANDS_B1F_REVIVE");
            CheckFlag(0x1D7, "FLAG_ITEM_SEAFOAM_ISLANDS_B2F_BIG_PEARL");
            CheckFlag(0x1D8, "FLAG_ITEM_SEAFOAM_ISLANDS_B4F_ULTRA_BALL");
            CheckFlag(0x1D9, "FLAG_ITEM_FOUR_ISLAND_STAR_PIECE");
            CheckFlag(0x1DA, "FLAG_ITEM_FOUR_ISLAND_STARDUST");
            CheckFlag(0x1DB, "FLAG_ITEM_ONE_ISLAND_KINDLE_ROAD_ETHER");
            CheckFlag(0x1DC, "FLAG_ITEM_ONE_ISLAND_KINDLE_ROAD_MAX_REPEL");
            CheckFlag(0x1DD, "FLAG_ITEM_ONE_ISLAND_KINDLE_ROAD_CARBOS");
            CheckFlag(0x1DE, "FLAG_ITEM_FIVE_ISLAND_MEADOW_MAX_POTION");
            CheckFlag(0x1DF, "FLAG_ITEM_FIVE_ISLAND_MEADOW_PP_UP");
            CheckFlag(0x1E0, "FLAG_ITEM_FIVE_ISLAND_MEMORIAL_PILLAR_METAL_COAT");
            CheckFlag(0x1E1, "FLAG_ITEM_SIX_ISLAND_OUTCAST_ISLAND_PP_UP");
            CheckFlag(0x1E2, "FLAG_ITEM_SIX_ISLAND_WATER_PATH_ELIXIR");
            CheckFlag(0x1E3, "FLAG_ITEM_SIX_ISLAND_WATER_PATH_DRAGON_SCALE");
            CheckFlag(0x1E4, "FLAG_ITEM_SIX_ISLAND_RUIN_VALLEY_FULL_RESTORE");
            CheckFlag(0x1E5, "FLAG_ITEM_SIX_ISLAND_RUIN_VALLEY_HP_UP");
            CheckFlag(0x1E6, "FLAG_ITEM_SIX_ISLAND_RUIN_VALLEY_SUN_STONE");
            CheckFlag(0x1E7, "FLAG_ITEM_SEVEN_ISLAND_SEVAULT_CANYON_KINGS_ROCK");
            CheckFlag(0x1E8, "FLAG_ITEM_SEVEN_ISLAND_SEVAULT_CANYON_MAX_ELIXIR");
            CheckFlag(0x1E9, "FLAG_ITEM_SEVEN_ISLAND_SEVAULT_CANYON_NUGGET");
            CheckFlag(0x1EA, "FLAG_ITEM_THREE_ISLAND_BERRY_FOREST_MAX_ETHER");
            CheckFlag(0x1EB, "FLAG_ITEM_THREE_ISLAND_BERRY_FOREST_FULL_HEAL");
            CheckFlag(0x1EC, "FLAG_ITEM_THREE_ISLAND_BERRY_FOREST_MAX_ELIXIR");
            CheckFlag(0x1ED, "FLAG_ITEM_MT_EMBER_EXTERIOR_ULTRA_BALL");
            CheckFlag(0x1EE, "FLAG_ITEM_MT_EMBER_EXTERIOR_FIRE_STONE");
            CheckFlag(0x1EF, "FLAG_ITEM_MT_EMBER_EXTERIOR_DIRE_HIT");
            CheckFlag(0x1F0, "FLAG_ITEM_FOUR_ISLAND_ICEFALL_CAVE_1F_ULTRA_BALL");
            CheckFlag(0x1F1, "FLAG_ITEM_FOUR_ISLAND_ICEFALL_CAVE_1F_HM07");
            CheckFlag(0x1F2, "FLAG_ITEM_FOUR_ISLAND_ICEFALL_CAVE_B1F_FULL_RESTORE");
            CheckFlag(0x1F3, "FLAG_ITEM_FOUR_ISLAND_ICEFALL_CAVE_B1F_NEVER_MELT_ICE");
            CheckFlag(0x1F4, "FLAG_ITEM_FIVE_ISLAND_ROCKET_WAREHOUSE_BIG_PEARL");
            CheckFlag(0x1F5, "FLAG_ITEM_FIVE_ISLAND_ROCKET_WAREHOUSE_TM36");
            CheckFlag(0x1F6, "FLAG_ITEM_FIVE_ISLAND_ROCKET_WAREHOUSE_PEARL");
            CheckFlag(0x1F7, "FLAG_ITEM_FIVE_ISLAND_ROCKET_WAREHOUSE_UP_GRADE");
            CheckFlag(0x1F8, "FLAG_ITEM_FIVE_ISLAND_LOST_CAVE_ROOM10_SILK_SCARF");
            CheckFlag(0x1F9, "FLAG_ITEM_FIVE_ISLAND_LOST_CAVE_ROOM11_LAX_INCENSE");
            CheckFlag(0x1FA, "FLAG_ITEM_FIVE_ISLAND_LOST_CAVE_ROOM12_SEA_INCENSE");
            CheckFlag(0x1FB, "FLAG_ITEM_FIVE_ISLAND_LOST_CAVE_ROOM13_MAX_REVIVE");
            CheckFlag(0x1FC, "FLAG_ITEM_FIVE_ISLAND_LOST_CAVE_ROOM14_RARE_CANDY");
            CheckFlag(0x1FD, "FLAG_ITEM_SEVEN_ISLAND_SEVAULT_CANYON_HOUSE_LUCKY_PUNCH");
            CheckFlag(0x1FE, "FLAG_ITEM_SILPH_CO_4F_TM41");
        }

    }

}
