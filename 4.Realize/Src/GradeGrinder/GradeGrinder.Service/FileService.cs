using System;
using System.IO;
using log4net;
using GradeGrinder.Common;

namespace GradeGrinder.Service
{
    public class FileService
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(FileService));
        
        public FileInfo DefaultDataFile { get; private set; }

        public FileService()
        {
        }
        
        public FileInfo GetDefaultDataFileByName(string filename)
        {
            if (filename.IsNullOrEmpty()) {
                throw new ArgumentNullException();
            }

            DefaultDataFile = new FileInfo(filename);
            if (!DefaultDataFile.Exists) {
                throw new FileNotFoundException("File '" + filename + "' not found!");
            }

            return DefaultDataFile;
        }
    }
}
