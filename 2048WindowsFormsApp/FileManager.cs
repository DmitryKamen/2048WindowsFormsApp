using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _2048WindowsFormsApp
{
    public class FileManager
    {
        public readonly string _filename;

        public FileManager(string filename)
        {
            _filename = filename;

        }

        public static void Append(string _filename,string value)
        {
            var writer = new StreamWriter(_filename, true);
            writer.WriteLine(value);
            writer.Close();

        }

        public static void Replace(string _filename, string value)
        {
            var writer = new StreamWriter(_filename, false);
            writer.WriteLine(value);
            writer.Close();

        }

        public static string Get(string _filename)
        {
            var reader = new StreamReader(_filename);
            var fileData = reader.ReadToEnd();
            reader.Close();
            return fileData;
        }

        public static bool Exist(string filename)
        {
            return File.Exists(filename);
        }

        internal void Clear()
        {
            File.WriteAllText(_filename, string.Empty);
        }  
    }
}


