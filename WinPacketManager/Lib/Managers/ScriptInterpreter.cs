using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPacketManager.Lib.Managers
{
    public class ScriptInterpreter
    {
        List<Command> cmdList;
        List<Command> currentCommands;
        List<string> lines;
        const char lineSeperator = ';';

        public void LoadFile(string path)
        {
            if (lines != null)
                lines.Clear();
            lines = new List<string>();
            path = Path.GetFullPath(path);
            StreamReader sr = File.OpenText(path);
            string curParsedLine = string.Empty;
            string line = string.Empty;
            while ((line = sr.ReadLine()) != null)
            {
                if (!line.Contains(lineSeperator))
                    curParsedLine += line;
                else
                {
                    string[] splitArr = line.Split(lineSeperator);
                    for (int i = 0; i < splitArr.Length; i++)
                    {
                        if (i >= splitArr.Length - 1)
                            curParsedLine += splitArr[i];
                        else
                        {
                            curParsedLine += splitArr[i];
                            ParseAndAddCommand(curParsedLine);
                            curParsedLine = string.Empty;
                        }
                    }
                }
            }
                
        }

        public void ParseAndAddCommand(string line)
        {
            if (currentCommands == null)
                currentCommands = new List<Command>();
            foreach (Command cmd in cmdList)
                if (line.StartsWith(cmd.CommandString))
                    currentCommands.Add(cmd);
        }

        public void RunCurrentScript()
        {
            foreach (Command cmd in currentCommands)
                cmd.Run(cmd.Arguments);
        }
    }
}
