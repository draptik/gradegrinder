using System.IO;
using GradeGrinder.Common;
using GradeGrinder.Service.Constants;
using log4net;

namespace GradeGrinder.Service
{
    public class FileService
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(FileService));

        //public FileInfo GetDefaultDataFile(string dataLocation)
        //{
        //    if (dataLocation.IsNullOrEmpty()) {
        //        Log.Error("app.config is missing '" + ApplicationKeyNames.DataStorageLocationDefault + "' key!");
        //        return null;
        //    }


        //    //FileInfo result = new FileInfo();

        //    //return result;
        //}
    }
}
