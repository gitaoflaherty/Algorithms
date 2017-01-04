using System;
using System.Collections.Generic;
using System.IO;
using Utility;

namespace UnionFind
{
    public class ConnectedComponentCollection
    {
        const string EXCEPTION_PREFIX = "ConnectedComponentCollection: ";
        IList<ConnectedComponent> mList;

        public ConnectedComponentCollection()
        {
            mList = new List<ConnectedComponent>();
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filepath"></param>
        /// <exception cref="ArgumentException">Thown if specified file is not found.</exception>
        /// <exception cref="InvalidDataException">Thrown if file format is incorrect.</exception>
        public void ReadFile(string filepath)
        {
            // Find file
            string foundFilepath;
            if(!FileHelper.FindFile(filepath, out foundFilepath))
            {
                throw new ArgumentException( EXCEPTION_PREFIX + "Invalid {filepath}." );
            }

            // Open file

            

            char[] DELIMITER = { ',' };

            IEnumerable<string> lines = File.ReadLines(foundFilepath);
            int lineNumber = 0;
            foreach (var line in lines)
            {
                lineNumber++;
                string[] tokens = line.Split(DELIMITER);
                int fieldCount = tokens.Length;

                // Ignore empty lines
                if (fieldCount <= 0)
                {
                    continue;
                }

                // Invalid data length
                const int MAX_COUNT = 2;
                if (fieldCount > MAX_COUNT)
                {
                    throw new InvalidDataException(EXCEPTION_PREFIX + "{filepath} contains invalid data. The maximum number of values allowed is {MAX_COUNT}, line {lineNumber} has {fieldCount} values. ");
                }

                
                foreach (var item in tokens)
                {
                    int value;
                    if ( !int.TryParse( item, out value ))
                    {
                        // 
                    }
                }
            }



            // Parse
            // .. Ignore comment
            // .. Validate data: one or two values

            // Close file

        }
    }
}
