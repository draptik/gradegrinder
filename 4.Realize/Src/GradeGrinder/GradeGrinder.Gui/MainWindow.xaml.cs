using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using log4net;

namespace GradeGrinder.Gui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Private Fields

        private static readonly ILog Log = LogManager.GetLogger(typeof(MainWindow));

        #endregion


        public MainWindow()
        {
            log4net.Config.XmlConfigurator.Configure();

            InitializeComponent();
            Log.Info("STARTED LOGGING...............");
        }
    }
}
