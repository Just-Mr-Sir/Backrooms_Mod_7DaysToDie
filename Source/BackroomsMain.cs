using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackroomsGenV1_1NET4_5
{
    public class BackroomsMain : IModApi
    {
        public void InitMod(Mod _modInstance)
        {
            IConsoleCommand commandGenBR = new ConsoleCmdGenBR();
            IConsoleCommand commandDeleteRegions = new ConsoleCmdDeleteRegions();
            IConsoleCommand commandNoClipBR = new ConsoleCmdNoclipBR();
            SortedList<string, IConsoleCommand> sl = new SortedList<string, IConsoleCommand>
            {
                { "GenerateBackrooms", commandGenBR },
                { "Delete Regions", commandDeleteRegions },
                { "Noclip BR", commandNoClipBR }
            };

            SdtdConsole.Instance.RegisterCommand(sl, "ConsoleCmdGenBR", commandGenBR);
            SdtdConsole.Instance.RegisterCommand(sl, "ConsoleCmdDeleteRegions", commandDeleteRegions);
            SdtdConsole.Instance.RegisterCommand(sl, "ConsoleCmdNoclipBR", commandNoClipBR);

            MapGen.UpdateWeightedList();
        }
    }
}
