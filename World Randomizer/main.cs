using System;
using System.Collections.Generic;
using Terraria;
using TShockAPI;
using TerrariaApi.Server;
using System.Reflection;

namespace Randomizer
{
    [ApiVersion(1, 16)]
    public class WorldRandomizer : TerrariaPlugin
    {
        List<int> walls = new List<int>();
        List<int> tiles = new List<int>();
        Random rnd = new Random();
        public override Version Version
        {
            get { return Assembly.GetExecutingAssembly().GetName().Version; }
        }
        public override string Author
        {
            get { return "Ancientgods"; }
        }
        public override string Name
        {
            get { return "World Randomizer"; }
        }

        public override string Description
        {
            get { return "Makes your world looks awesome"; }
        }

        public override void Initialize()
        {
            var Hook = ServerApi.Hooks;
            Hook.GameInitialize.Register(this, (args) => { OnInitialize(); });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                var Hook = ServerApi.Hooks;
                Hook.GameInitialize.Deregister(this, (args) => { OnInitialize(); });
            }
            base.Dispose(disposing);
        }

        public WorldRandomizer(Main game)
            : base(game)
        {
            Order = 1;
        }

        public void OnInitialize()
        {
            Commands.ChatCommands.Add(new Command("tshock.world.randomize", randomizeworld, "randomizeworld", "rw"));
        }

        private void randomizeworld(CommandArgs args)
        {
            RandomizeWallsAndTiles();
            foreach (Tile t in Main.tile)
            {
                if (t != null)
                {
                    switch ((int)t.type)
                    {
                        case 0:
                            t.type = (byte)tiles[0];
                            break;
                        case 1:
                            t.type = (byte)tiles[1];
                            break;
                        case 2:
                            t.type = (byte)tiles[2];
                            break;
                        case 6:
                            t.type = (byte)tiles[3];
                            break;
                        case 7:
                            t.type = (byte)tiles[4];
                            break;
                        case 8:
                            t.type = (byte)tiles[5];
                            break;
                        case 9:
                            t.type = (byte)tiles[6];
                            break;
                        case 22:
                            t.type = (byte)tiles[7];
                            break;
                        case 23:
                            t.type = (byte)tiles[8];
                            break;
                        case 25:
                            t.type = (byte)tiles[9];
                            break;
                        case 30:
                            t.type = (byte)tiles[10];
                            break;
                        case 37:
                            t.type = (byte)tiles[11];
                            break;
                        case 38:
                            t.type = (byte)tiles[12];
                            break;
                        case 39:
                            t.type = (byte)tiles[13];
                            break;
                        case 40:
                            t.type = (byte)tiles[14];
                            break;
                        case 41:
                            t.type = (byte)tiles[15];
                            break;
                        case 43:
                            t.type = (byte)tiles[16];
                            break;
                        case 44:
                            t.type = (byte)tiles[17];
                            break;
                        case 45:
                            t.type = (byte)tiles[18];
                            break;
                        case 46:
                            t.type = (byte)tiles[19];
                            break;
                        case 47:
                            t.type = (byte)tiles[20];
                            break;
                        case 54:
                            t.type = (byte)tiles[21];
                            break;
                        case 56:
                            t.type = (byte)tiles[22];
                            break;
                        case 57:
                            t.type = (byte)tiles[23];
                            break;
                        case 58:
                            t.type = (byte)tiles[24];
                            break;
                        case 59:
                            t.type = (byte)tiles[25];
                            break;
                        case 60:
                            t.type = (byte)tiles[26];
                            break;
                        case 63:
                            t.type = (byte)tiles[27];
                            break;
                        case 64:
                            t.type = (byte)tiles[28];
                            break;
                        case 65:
                            t.type = (byte)tiles[29];
                            break;
                        case 66:
                            t.type = (byte)tiles[30];
                            break;
                        case 67:
                            t.type = (byte)tiles[31];
                            break;
                        case 68:
                            t.type = (byte)tiles[32];
                            break;
                        case 70:
                            t.type = (byte)tiles[33];
                            break;
                        case 75:
                            t.type = (byte)tiles[34];
                            break;
                        case 76:
                            t.type = (byte)tiles[35];
                            break;
                        case 107:
                            t.type = (byte)tiles[36];
                            break;
                        case 108:
                            t.type = (byte)tiles[37];
                            break;
                        case 109:
                            t.type = (byte)tiles[38];
                            break;
                        case 111:
                            t.type = (byte)tiles[39];
                            break;
                        case 117:
                            t.type = (byte)tiles[40];
                            break;
                        case 118:
                            t.type = (byte)tiles[41];
                            break;
                        case 119:
                            t.type = (byte)tiles[42];
                            break;
                        case 120:
                            t.type = (byte)tiles[43];
                            break;
                        case 121:
                            t.type = (byte)tiles[44];
                            break;
                        case 122:
                            t.type = (byte)tiles[45];
                            break;
                        case 130:
                            t.type = (byte)tiles[46];
                            break;
                        case 140:
                            t.type = (byte)tiles[47];
                            break;
                        case 145:
                            t.type = (byte)tiles[48];
                            break;
                        case 146:
                            t.type = (byte)tiles[49];
                            break;
                        case 147:
                            t.type = (byte)tiles[50];
                            break;
                        case 148:
                            t.type = (byte)tiles[51];
                            break;
                        case 150:
                            t.type = (byte)tiles[52];
                            break;
                        case 151:
                            t.type = (byte)tiles[53];
                            break;
                        case 152:
                            t.type = (byte)tiles[54];
                            break;
                        case 153:
                            t.type = (byte)tiles[55];
                            break;
                        case 154:
                            t.type = (byte)tiles[56];
                            break;
                        case 155:
                            t.type = (byte)tiles[57];
                            break;
                        case 156:
                            t.type = (byte)tiles[58];
                            break;
                        case 157:
                            t.type = (byte)tiles[59];
                            break;
                        case 158:
                            t.type = (byte)tiles[60];
                            break;
                        case 159:
                            t.type = (byte)tiles[61];
                            break;
                        case 161:
                            t.type = (byte)tiles[62];
                            break;
                        case 166:
                            t.type = (byte)tiles[63];
                            break;
                        case 167:
                            t.type = (byte)tiles[64];
                            break;
                        case 168:
                            t.type = (byte)tiles[65];
                            break;
                        case 169:
                            t.type = (byte)tiles[66];
                            break;
                        case 175:
                            t.type = (byte)tiles[67];
                            break;
                        case 176:
                            t.type = (byte)tiles[68];
                            break;
                        case 177:
                            t.type = (byte)tiles[69];
                            break;
                        case 188:
                            t.type = (byte)tiles[70];
                            break;
                        case 189:
                            t.type = (byte)tiles[71];
                            break;
                        case 190:
                            t.type = (byte)tiles[72];
                            break;
                        case 191:
                            t.type = (byte)tiles[73];
                            break;
                        case 193:
                            t.type = (byte)tiles[74];
                            break;
                        case 194:
                            t.type = (byte)tiles[75];
                            break;
                        case 195:
                            t.type = (byte)tiles[76];
                            break;
                        case 196:
                            t.type = (byte)tiles[77];
                            break;
                        case 197:
                            t.type = (byte)tiles[78];
                            break;
                        case 198:
                            t.type = (byte)tiles[79];
                            break;
                        case 199:
                            t.type = (byte)tiles[80];
                            break;
                        case 200:
                            t.type = (byte)tiles[81];
                            break;
                        case 202:
                            t.type = (byte)tiles[82];
                            break;
                        case 203:
                            t.type = (byte)tiles[83];
                            break;
                        case 204:
                            t.type = (byte)tiles[84];
                            break;
                        case 206:
                            t.type = (byte)tiles[85];
                            break;
                        case 208:
                            t.type = (byte)tiles[86];
                            break;
                        case 211:
                            t.type = (byte)tiles[87];
                            break;
                        case 221:
                            t.type = (byte)tiles[88];
                            break;
                        case 222:
                            t.type = (byte)tiles[89];
                            break;
                        case 223:
                            t.type = (byte)tiles[90];
                            break;
                        case 225:
                            t.type = (byte)tiles[91];
                            break;
                        case 226:
                            t.type = (byte)tiles[92];
                            break;
                        case 229:
                            t.type = (byte)tiles[93];
                            break;
                        case 230:
                            t.type = (byte)tiles[94];
                            break;
                        case 248:
                            t.type = (byte)tiles[95];
                            break;
                        case 249:
                            t.type = (byte)tiles[96];
                            break;
                        case 250:
                            t.type = (byte)tiles[97];
                            break;
                        case 251:
                            t.type = (byte)tiles[98];
                            break;
                        case 252:
                            t.type = (byte)tiles[99];
                            break;
                        case 253:
                            t.type = (byte)tiles[100];
                            break;
                    }
                    switch ((int)t.wall)
                    {
                        case 1:
                            t.wall = (byte)walls[0];
                            break;
                        case 2:
                            t.wall = (byte)walls[1];
                            break;
                        case 3:
                            t.wall = (byte)walls[2];
                            break;
                        case 4:
                            t.wall = (byte)walls[3];
                            break;
                        case 5:
                            t.wall = (byte)walls[4];
                            break;
                        case 6:
                            t.wall = (byte)walls[5];
                            break;
                        case 7:
                            t.wall = (byte)walls[6];
                            break;
                        case 8:
                            t.wall = (byte)walls[7];
                            break;
                        case 9:
                            t.wall = (byte)walls[8];
                            break;
                        case 10:
                            t.wall = (byte)walls[9];
                            break;
                        case 11:
                            t.wall = (byte)walls[10];
                            break;
                        case 12:
                            t.wall = (byte)walls[11];
                            break;
                        case 13:
                            t.wall = (byte)walls[12];
                            break;
                        case 14:
                            t.wall = (byte)walls[13];
                            break;
                        case 15:
                            t.wall = (byte)walls[14];
                            break;
                        case 16:
                            t.wall = (byte)walls[15];
                            break;
                        case 17:
                            t.wall = (byte)walls[16];
                            break;
                        case 18:
                            t.wall = (byte)walls[17];
                            break;
                        case 19:
                            t.wall = (byte)walls[18];
                            break;
                        case 20:
                            t.wall = (byte)walls[19];
                            break;
                        case 21:
                            t.wall = (byte)walls[20];
                            break;
                        case 22:
                            t.wall = (byte)walls[21];
                            break;
                        case 23:
                            t.wall = (byte)walls[22];
                            break;
                        case 24:
                            t.wall = (byte)walls[23];
                            break;
                        case 25:
                            t.wall = (byte)walls[24];
                            break;
                        case 26:
                            t.wall = (byte)walls[25];
                            break;
                        case 27:
                            t.wall = (byte)walls[26];
                            break;
                        case 28:
                            t.wall = (byte)walls[27];
                            break;
                        case 29:
                            t.wall = (byte)walls[28];
                            break;
                        case 30:
                            t.wall = (byte)walls[29];
                            break;
                        case 31:
                            t.wall = (byte)walls[30];
                            break;
                        case 32:
                            t.wall = (byte)walls[31];
                            break;
                        case 33:
                            t.wall = (byte)walls[32];
                            break;
                        case 34:
                            t.wall = (byte)walls[33];
                            break;
                        case 35:
                            t.wall = (byte)walls[34];
                            break;
                        case 36:
                            t.wall = (byte)walls[35];
                            break;
                        case 37:
                            t.wall = (byte)walls[36];
                            break;
                        case 38:
                            t.wall = (byte)walls[37];
                            break;
                        case 39:
                            t.wall = (byte)walls[38];
                            break;
                        case 40:
                            t.wall = (byte)walls[39];
                            break;
                        case 41:
                            t.wall = (byte)walls[40];
                            break;
                        case 42:
                            t.wall = (byte)walls[41];
                            break;
                        case 43:
                            t.wall = (byte)walls[42];
                            break;
                        case 45:
                            t.wall = (byte)walls[43];
                            break;
                        case 46:
                            t.wall = (byte)walls[44];
                            break;
                        case 47:
                            t.wall = (byte)walls[45];
                            break;
                        case 48:
                            t.wall = (byte)walls[46];
                            break;
                        case 49:
                            t.wall = (byte)walls[47];
                            break;
                        case 50:
                            t.wall = (byte)walls[48];
                            break;
                        case 51:
                            t.wall = (byte)walls[49];
                            break;
                        case 52:
                            t.wall = (byte)walls[50];
                            break;
                        case 53:
                            t.wall = (byte)walls[51];
                            break;
                        case 54:
                            t.wall = (byte)walls[52];
                            break;
                        case 55:
                            t.wall = (byte)walls[53];
                            break;
                        case 56:
                            t.wall = (byte)walls[54];
                            break;
                        case 57:
                            t.wall = (byte)walls[55];
                            break;
                        case 58:
                            t.wall = (byte)walls[56];
                            break;
                        case 59:
                            t.wall = (byte)walls[57];
                            break;
                        case 60:
                            t.wall = (byte)walls[58];
                            break;
                        case 61:
                            t.wall = (byte)walls[59];
                            break;
                        case 62:
                            t.wall = (byte)walls[60];
                            break;
                        case 63:
                            t.wall = (byte)walls[61];
                            break;
                        case 64:
                            t.wall = (byte)walls[62];
                            break;
                        case 65:
                            t.wall = (byte)walls[63];
                            break;
                        case 66:
                            t.wall = (byte)walls[64];
                            break;
                        case 67:
                            t.wall = (byte)walls[65];
                            break;
                        case 68:
                            t.wall = (byte)walls[66];
                            break;
                        case 69:
                            t.wall = (byte)walls[67];
                            break;
                        case 70:
                            t.wall = (byte)walls[68];
                            break;
                        case 71:
                            t.wall = (byte)walls[69];
                            break;
                        case 72:
                            t.wall = (byte)walls[70];
                            break;
                        case 73:
                            t.wall = (byte)walls[71];
                            break;
                        case 74:
                            t.wall = (byte)walls[72];
                            break;
                        case 75:
                            t.wall = (byte)walls[73];
                            break;
                        case 76:
                            t.wall = (byte)walls[74];
                            break;
                        case 77:
                            t.wall = (byte)walls[75];
                            break;
                        case 78:
                            t.wall = (byte)walls[76];
                            break;
                        case 79:
                            t.wall = (byte)walls[77];
                            break;
                        case 80:
                            t.wall = (byte)walls[78];
                            break;
                        case 81:
                            t.wall = (byte)walls[79];
                            break;
                        case 82:
                            t.wall = (byte)walls[80];
                            break;
                        case 83:
                            t.wall = (byte)walls[81];
                            break;
                        case 84:
                            t.wall = (byte)walls[82];
                            break;
                        case 85:
                            t.wall = (byte)walls[83];
                            break;
                        case 86:
                            t.wall = (byte)walls[84];
                            break;
                        case 87:
                            t.wall = (byte)walls[85];
                            break;
                        case 88:
                            t.wall = (byte)walls[86];
                            break;
                        case 89:
                            t.wall = (byte)walls[87];
                            break;
                        case 90:
                            t.wall = (byte)walls[88];
                            break;
                        case 91:
                            t.wall = (byte)walls[89];
                            break;
                        case 92:
                            t.wall = (byte)walls[90];
                            break;
                        case 93:
                            t.wall = (byte)walls[91];
                            break;
                        case 94:
                            t.wall = (byte)walls[92];
                            break;
                        case 95:
                            t.wall = (byte)walls[93];
                            break;
                        case 96:
                            t.wall = (byte)walls[94];
                            break;
                        case 97:
                            t.wall = (byte)walls[95];
                            break;
                        case 98:
                            t.wall = (byte)walls[96];
                            break;
                        case 99:
                            t.wall = (byte)walls[97];
                            break;
                        case 100:
                            t.wall = (byte)walls[98];
                            break;
                        case 101:
                            t.wall = (byte)walls[99];
                            break;
                        case 102:
                            t.wall = (byte)walls[100];
                            break;
                        case 103:
                            t.wall = (byte)walls[101];
                            break;
                        case 104:
                            t.wall = (byte)walls[102];
                            break;
                        case 105:
                            t.wall = (byte)walls[103];
                            break;
                        case 106:
                            t.wall = (byte)walls[104];
                            break;
                        case 107:
                            t.wall = (byte)walls[105];
                            break;
                        case 108:
                            t.wall = (byte)walls[106];
                            break;
                        case 109:
                            t.wall = (byte)walls[107];
                            break;
                        case 110:
                            t.wall = (byte)walls[108];
                            break;
                        case 111:
                            t.wall = (byte)walls[109];
                            break;
                        case 112:
                            t.wall = (byte)walls[110];
                            break;
                        case 113:
                            t.wall = (byte)walls[111];
                            break;
                        case 114:
                            t.wall = (byte)walls[112];
                            break;
                    }
                }
            }
            informplayers();
            TSPlayer.All.SendInfoMessage("The world has been randomized!");
        }

        #region Randomize Tiles & Walls
        void RandomizeWallsAndTiles()
        {
            List<int> ts = new List<int> { 0, 1, 2, 6, 7, 8, 9, 22, 23, 25, 30, 37, 38, 39, 40, 41, 43, 44, 45, 46, 47, 54, 56, 57, 58, 59, 60, 63, 64, 65, 66, 67, 68, 70, 75, 76, 107, 108, 109, 111, 117, 118, 119, 120, 121, 122, 130, 140, 145, 146, 147, 148, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 161, 166, 167, 168, 169, 175, 176, 177, 188, 189, 190, 191, 193, 194, 195, 196, 197, 198, 199, 200, 202, 203, 204, 206, 208, 211, 221, 222, 223, 225, 226, 229, 230, 248, 249, 250, 251, 252, 253 };
            List<int> ws = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114 };
            walls.Clear();
            tiles.Clear();
            while (ts.Count > 0)
            {
                int rt = ts[rnd.Next(0, ts.Count)];
                tiles.Add(rt); ts.Remove(rt);
            }
            while (ws.Count > 0)
            {
                int rw = ws[rnd.Next(0, ws.Count)];
                walls.Add(rw); ws.Remove(rw);
            }
        }

        void informplayers(bool hard = false)
        {
            foreach (TSPlayer person in TShock.Players)
            {
                if ((person != null) && (person.Active))
                {
                    for (int i = 0; i < 255; i++)
                    {
                        for (int j = 0; j < Main.maxSectionsX; j++)
                        {
                            for (int k = 0; k < Main.maxSectionsY; k++)
                            {
                                Netplay.serverSock[i].tileSection[j, k] = false;
                            }
                        }
                    }
                }
            }
        }
    }
    #endregion Randomize Tiles & Walls
}