using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System.Xml;

namespace BackroomsGenV1_1NET4_5
{
    public class ConsoleCmdGenBR : ConsoleCmdAbstract
    {
        public override bool IsExecuteOnClient => true;
        public override bool AllowedInMainMenu => true;

        public ConsoleCmdGenBR() : base()
        {
        }

        public override string[] GetCommands()
        {
            //command names in this package
            string[] commands = {
            "genbackrooms"
        };

            return commands;
        }

        public override string GetDescription()
        {
            return "Generates the Backrooms";
        }

        public override string GetHelp()
        {
            return "Make sure to use valid commands and arguments: genbackrooms [GenWorldName] [MaxGenSize]\nMake sure you are not currently playing in a World";
        }

        public override void Execute(List<string> _params, CommandSenderInfo _senderInfo)
        {
            float startTime = Time.realtimeSinceStartup;

            //get help if number of parameters entered are insufficient or
            //the player is currently in a world
            if (_params.Count != 2 || GameManager.Instance.World != null)
            {
                SdtdConsole.Instance.Output(GetHelp());
                return;
            }

            string genWorldName = "";
            //break up worldSeedName parameter to include spaces based on placement of capital letters
            bool isFirst = true;
            foreach(char c in _params[0])
            {
                if (char.IsUpper(c) && !isFirst)
                {
                    genWorldName += " ";
                }

                genWorldName += c;
                isFirst = false;
            }

            //parse size param
            string sizeParam = _params[1].ToLower();
            int size;
            //input validation sizeText to int
            if (!int.TryParse(sizeParam, out size))
                SdtdConsole.Instance.Output("Error: could not parse " + sizeParam + "to int");

            SdtdConsole.Instance.Output("Time Prior to Map Generation: " + (Time.realtimeSinceStartup - startTime));

            MapGen.PInstance[] prefabs = MapGen.BreathDepthGen(size);

            SdtdConsole.Instance.Output("Generated backrooms data, rooms: " + prefabs.Length);

            string prefabsFilePath = "GeneratedWorlds\\" + genWorldName + "\\prefabs.xml";
            var sdmp = new SaveDataManagedPath(prefabsFilePath);

            SdtdConsole.Instance.Output("Time Prior to Loading XmlDocument: " + (Time.realtimeSinceStartup - startTime));

            //get xml document from stream
            XmlDocument prefabsDoc = new XmlDocument();
            prefabsDoc.Load(sdmp.GetOriginalPath());
            XmlNode root = prefabsDoc.DocumentElement;

            SdtdConsole.Instance.Output("Time Prior to Filtering out br_: " + (Time.realtimeSinceStartup - startTime));

            //remove all Backrooms rooms
            //this lends to a "regenerating" of the backrooms everytime the command is run targeting the same world
            XmlNodeList nodesToRemove = root.SelectNodes("//decoration[starts-with(@name, 'br_')]");
            foreach (XmlNode n in nodesToRemove)
            {
                root.RemoveChild(n);
            }

            SdtdConsole.Instance.Output("Prior to Adding br_: " + (Time.realtimeSinceStartup - startTime));

            //add new Backrooms rooms to xml file
            for (int i = 0; i < prefabs.Length; i++)
            {
                XmlElement newElem = prefabsDoc.CreateElement("decoration");

                newElem.SetAttribute("type", "model");
                newElem.SetAttribute("name", prefabs[i].RoomData.RoomName); //prefabs[i].Position.x + "," + prefabs[i].Position.y + "," + prefabs[i].Position.z
                newElem.SetAttribute("position", prefabs[i].Position.ToString());
                newElem.SetAttribute("rotation", prefabs[i].Rotation.ToString());
                newElem.SetAttribute("y_is_groundlevel", "true");

                root.AppendChild(newElem);
            }

            SdtdConsole.Instance.Output("Time Prior to Saving: " + (Time.realtimeSinceStartup - startTime));

            prefabsDoc.Save(sdmp.GetOriginalPath());
            //stream.Close();

            SdtdConsole.Instance.Output("Time at Finish: " + (Time.realtimeSinceStartup - startTime));
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