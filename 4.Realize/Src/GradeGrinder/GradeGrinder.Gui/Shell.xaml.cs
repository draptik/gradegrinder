using System.Windows;
using log4net;

namespace GradeGrinder.Gui
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

            InitializeComponent();

        }
    }
}
