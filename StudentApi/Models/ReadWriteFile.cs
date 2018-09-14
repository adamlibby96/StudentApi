using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using StudentApi.Models;

namespace ReadWriteFile
{
    public class FileManager
    {
        public List<string> file;

        public FileManager(string path)
        {
            StreamReader reader = new StreamReader(path);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                file.Add(line);
            }
        }
        
    }
}
