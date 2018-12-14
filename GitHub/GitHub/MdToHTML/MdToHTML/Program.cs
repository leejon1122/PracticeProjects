using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MdToHTML
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            //string path = @"C:\Program Files\";

//            Console.WriteLine("Geef locatie map op");
//            string path = Console.ReadLine();

//            if (System.IO.Directory.Exists(path))
//            {
//                Console.WriteLine("bestaat");
//            }
//            else
//            {
//                Console.WriteLine("bestaat niet");
//            }
//            Console.ReadLine();
//        }
//    }
//}


{
    class CopyDir
    {
        public static void Copy(string sourceDirectory, string targetDirectory)
        {
            DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);
            DirectoryInfo diTarget = new DirectoryInfo(targetDirectory);

            CopyAll(diSource, diTarget);
        }

        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            foreach (FileInfo fi in source.GetFiles())
            {
                Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
            }

            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }

            public void Main(string[] args)
            {
            DirectoryCopy(".", @".\temp", true);

        }
            }

    public static void Copy(string sourceFileName, string destFileName);
}
}

