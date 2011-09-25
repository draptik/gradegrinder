using System.Windows.Controls;
using GradeGrinder.Interfaces.ViewModels;
using GradeGrinder.Interfaces.Views;
using Microsoft.Practices.ServiceLocation;

namespace GradeGrinder.MainMenuModule.Views
{
    /// <summary>
    /// Interaction logic for MainMenuView.xaml
    /// </summary>
    public partial class MainMenuView : UserControl, IMainMenuView
    {
        public MainMenuView()
        {
            InitializeComponent();

            DataContext = ServiceLocator.Current.GetInstance<IMainMenuViewModel>();
        }
    }
}
