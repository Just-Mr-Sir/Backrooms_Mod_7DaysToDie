using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using UnityEngine;

namespace BackroomsGenV1_1NET4_5
{
    internal class ConsoleCmdDeleteRegions : ConsoleCmdAbstract
    {
        public override bool IsExecuteOnClient => true;
        public override bool AllowedInMainMenu => true;

        public ConsoleCmdDeleteRegions() : base()
        {
        }

        public override string[] GetCommands()
        {
            //command names in this package
            string[] commands = {
            "deleteRegions"
        };

            return commands;
        }

        public override string GetDescription()
        {
            return "Deletes all the region files for a specific game";
        }

        public override string GetHelp()
        {
            return "Make sure to use valid commands and arguments: deleteRegions [GenWorldName] [GameName]\nMake sure you are not currently playing in a World";
        }

        public override void Execute(List<string> _params, CommandSenderInfo _senderInfo)
        {
            string genWorldName = "";
            //break up worldSeedName parameter to include spaces based on placement of capital letters
            bool isFirst = true;
            foreach (char c in _params[0])
            {
                if (char.IsUpper(c) && !isFirst)
                {
                    genWorldName += " ";
                }

                genWorldName += c;
                isFirst = false;
            }

            SaveDataManagedPath sdmp = new SaveDataManagedPath("Saves\\" + genWorldName + "\\" + _params[1] + "\\Region");
            if(!SaveDataManager_Placeholder.Instance.ManagedDirectoryExists(sdmp))
            {
                GetHelp();

                return;
            }

            var regionFiles = System.IO.Directory.EnumerateFiles(sdmp.GetOriginalPath());

            foreach (var rf in regionFiles)
            {
                System.IO.File.Delete(rf);
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
