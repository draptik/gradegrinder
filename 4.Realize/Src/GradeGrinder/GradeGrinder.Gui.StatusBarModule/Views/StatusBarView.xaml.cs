using GradeGrinder.Gui.Interfaces.ViewModels;
using GradeGrinder.Gui.Interfaces.Views;
using Microsoft.Practices.ServiceLocation;

namespace GradeGrinder.Gui.StatusBarModule.Views
{
    /// <summary>
    /// Interaction logic for StatusBarView.xaml
    /// </summary>
    public partial class StatusBarView : IStatusBarView
    {
        public StatusBarView()
        {
            InitializeComponent();

            DataContext = ServiceLocator.Current.GetInstance<IStatusBarViewModel>();
        }
    }
}
