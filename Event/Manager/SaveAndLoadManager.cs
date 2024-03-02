using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    internal class SaveAndLoadManager
    {
        public static void SaveTextToFile(string path, string fileName, string data)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);

            }

            path = path+"\\"+fileName;

            Console.WriteLine(path);


            try
            {
                File.WriteAllText(path, data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static string LoadFileToText(string path, string fileName)
        {
            string data = null;

            path = path +"\\"+ fileName;

            if (!IfExistFileInPath(path))
            {
                Console.WriteLine("LoadFileToText Failed !File.Exists(path)");

                return null;
            }
            try
            {
                data = File.ReadAllText(path);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return data;
        }
        public static string LoadFileToText(string path)
        {
            string data = null;

            if (!IfExistFileInPath(path))
            {
                Console.WriteLine("LoadFileToText Failed !File.Exists(path)");

                return null;
            }
            try
            {
                data = File.ReadAllText(path);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return data;
        }
        public static bool IfExistFileInPath(string path, string fileName) 
        {
            path = path + "\\" + fileName;
            return IfExistFileInPath(path);
        }
        public static bool IfExistFileInPath(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("LoadFileToText Failed !File.Exists(path)");

                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool IfExistFolderInPath(string path)
        {
            if (!Directory.Exists(path))
            {
                Console.WriteLine("LoadFileToText Failed !File.Exists(path)");

                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
