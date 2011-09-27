using System.Windows.Controls;
using GradeGrinder.Gui.Interfaces.ViewModels;
using GradeGrinder.Gui.Interfaces.Views;
using Microsoft.Practices.ServiceLocation;

namespace GradeGrinder.Gui.MainMenuModule.Views
{
    /// <summary>
    /// Interaction logic for MainMenuView.xaml
    /// </summary>
    partial class MainMenuView : UserControl, IMainMenuView
    {
        public MainMenuView()
        {
            InitializeComponent();

            DataContext = ServiceLocator.Current.GetInstance<IMainMenuViewModel>();
        }
    }
}
