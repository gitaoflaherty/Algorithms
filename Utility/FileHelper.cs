using System;
using System.Collections.Generic;
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
        public static bool FindFile( string path, out string foundPath )
        {
            foundPath = string.Empty;
            bool exists = File.Exists(path);
            if ( exists )
            {
                foundPath = Path.GetFullPath(path);
            }
            else             
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
