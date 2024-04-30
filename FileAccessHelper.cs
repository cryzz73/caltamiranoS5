using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caltamiranoS5
{
    internal class FileAccessHelper
    {
        public static string GetLocalFilePath(String filename)
        {
            //permisos de entrada y salida BDD 
            return System.IO.Path.Combine(FileSystem.AppDataDirectory, filename);
        }
    }
}
