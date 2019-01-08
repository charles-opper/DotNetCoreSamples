using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Samples.Files
{
    public class TextFileBasics
    {
        public void WriteToTextFile(string location, string value)
        {
            using (var writer = new StreamWriter(location))
            {
                writer.WriteLine(value);
            }
        }

        public string ReadAllLinesFromTextFile(string location)
        {
            using (var reader = new StreamReader(location))
            {
                return reader.ReadToEnd();
            }
        }

        public void WriteLinesToFile(string location, string[] lines)
        {
            using (var writer = new StreamWriter(location))
            {
                foreach(var line in lines)
                {
                    writer.WriteLine(line);
                }
            }
        }
    }
}
