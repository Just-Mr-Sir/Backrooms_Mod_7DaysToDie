using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace BackroomsGenV1_1NET4_5
{
    internal class ConsoleCmdNoclipBR: ConsoleCmdAbstract
    {
        public ConsoleCmdNoclipBR() : base()
        {
        }

        public override string[] GetCommands()
        {
            //command names in this package
            string[] commands = {
            "noclipBR"
        };

            return commands;
        }

        public override string GetDescription()
        {
            return "Deletes all the region files for a specific game";
        }

        public override string GetHelp()
        {
            return "Make sure to use valid commands and arguments: noclipIntoBR";
        }

        public override void Execute(List<string> _params, CommandSenderInfo _senderInfo)
        {
            EntityPlayerLocal epl = GameManager.Instance.myEntityPlayerLocal;
            Vector3 pos = epl.GetPosition();

            if (pos.y <= 13)
                SdtdConsole.Instance.executeCommand("teleport " + Math.Round(pos.x) + " " + Math.Round(pos.z), _senderInfo);
            else
            {
                Vector3i testPos = new Vector3i(pos.x, AllRoomData.BASE_OFFSET_Y + 1, pos.z);
                int breakCounter = 2000;
                while(!GameManager.Instance.World.IsEmptyPosition(testPos) && breakCounter > 0)
                {
                    testPos.x += 1;
                    testPos.z += 1;
                    breakCounter--;
                }

                SdtdConsole.Instance.executeCommand("teleport " + testPos.x + " " + testPos.y + " " + testPos.z, _senderInfo);
            }
        }

        public override string[] getCommands()
        {
            throw new NotImplementedException();
        }

        public override string getDescription()
        {
            throw new NotImplementedException();
        }
    }
}
