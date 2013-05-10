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
                            lines.Add(curParsedLine);
                            curParsedLine = string.Empty;
                        }
                    }
                }
            }
        }
    }
}
