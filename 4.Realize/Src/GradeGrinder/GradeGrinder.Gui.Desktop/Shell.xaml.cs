using System;
using System.Configuration;
using System.IO;
using System.Windows;
using GradeGrinder.Infrastructure.Constants;
using GradeGrinder.Service;
using log4net;

namespace GradeGrinder.Gui.Desktop
{
    /// <summary>
    /// Interaction logic for Shell.xaml
    /// </summary>
    public partial class Shell : Window
    {
        #region Private Fields

        private static readonly ILog Log = LogManager.GetLogger(typeof(Shell));

        #endregion


        public Shell()
        {
            log4net.Config.XmlConfigurator.Configure();
            Log.Info("STARTED LOGGING...............");

            var fileService = new FileService();

            FileInfo defaultDataFile = null;
            try {
                defaultDataFile = fileService.GetDefaultDataFileByName(ConfigurationManager.AppSettings[ApplicationKeyNames.DataStorageLocationDefault]);
            }
            catch (ArgumentNullException ex) {
                Log.Error("Default file is empty!", ex);
            }
            catch (FileNotFoundException ex) {
                Log.Error("Default file not found!", ex);
            }
            catch (Exception ex) {
                Log.Error("Error while getting default file!", ex);
            }

            if (defaultDataFile != null) {
                InitializeComponent();    
            }
        }
    }
}
