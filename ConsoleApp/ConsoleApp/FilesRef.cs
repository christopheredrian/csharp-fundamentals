using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp
{
    class FilesRef
    {
        public static void Run()
        {
            // File (static) and FileInfo (instance)
            
            //var path = @"D:\temp\myfile.jpeg";

            //File.Copy(@"C:\temp\myfile.txt", @"D:\temp\myfile.txt", true);
            
            //if (File.Exists(path))
            //{
            //    File.Delete(path);
            //}

            //var content = File.ReadAllText(path);

            //var fileInfo = new FileInfo(path);
            //fileInfo.CopyTo(path);
            
            //if (fileInfo.Exists)
            //{
            //    fileInfo.Delete();
            //}

            //var fileStream = fileInfo.OpenRead();


            // Directory and DirectoryInfo
            var directory = @"D:\Projects";

            //Directory.CreateDirectory(directory);
            //var files = Directory.GetFiles(directory, "*.js", SearchOption.AllDirectories);
            //Console.WriteLine(files);
            //foreach (var file in files)
            //{
            //    Console.WriteLine(file);
            //}

            //var directories = Directory.GetDirectories(directory, "*.*", SearchOption.TopDirectoryOnly);
            //foreach (var dir in directories)
            //{
            //    Console.WriteLine(dir);
            //}

            //if (Directory.Exists(directory))
            //{
            //    Console.WriteLine("It exists");
            //}

            var di = new DirectoryInfo(directory);
            var directories = di.GetDirectories("*", SearchOption.TopDirectoryOnly);

            foreach (var dir in directories)
            {
                Console.WriteLine(dir.FullName) ;
            }

            // Path 
            var path = @"D:\Projects\electron-quick-start\package.json";

            var ext = Path.GetExtension(path);
            var fileName = Path.GetFileName(path);
            var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(path);
            var directoryName = Path.GetDirectoryName(path);

            Console.WriteLine(ext);
            Console.WriteLine(fileName);
            Console.WriteLine(fileNameWithoutExtension);
            Console.WriteLine(directoryName);
        }
    }
}
