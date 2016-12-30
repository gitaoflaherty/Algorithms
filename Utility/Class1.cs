using System;
using System.IO;

namespace Utility
{
    /// <summary>
    /// File
    /// 
    /// Directory
    ///     CreateDirectory(path)
    ///     Exists     
    ///     GetCurrentDirectory()
    ///     GetDirectories(path)
    /// 
    /// Environment
    ///     CurrentDirectory = myDirectory
    /// 
    /// </summary>
    public static class FileHelper
    {
        /// <summary>
        /// Does the specified file exist?
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool Exists( string path )
        {
            bool exists = File.Exists(path);
            // If not in specified directory, try parent directory
            if ( !exists )
            {
                // Does the directory exist?
                //Directory.Exists();

                //Environment.CurrentDirectory = 

            }
            return exists;         
        }

        public static bool Open( string path )
        {
            return false;
        }
    }
}
