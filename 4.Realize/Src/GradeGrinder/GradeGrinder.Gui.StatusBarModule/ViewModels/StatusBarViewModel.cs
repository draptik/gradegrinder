using GradeGrinder.Gui.Interfaces.ViewModels;
using Microsoft.Practices.Prism.ViewModel;

namespace GradeGrinder.Gui.StatusBarModule.ViewModels
{
    /// <summary>
    /// Derive from NotificationObject!
    /// </summary>
    public class StatusBarViewModel : NotificationObject, IStatusBarViewModel
    {
        #region StatusText
        
        private string _statusText;

        public string StatusText
        {
            get { return _statusText; }
            set
            {
                if (_statusText != value) {
                    _statusText = value;
                    RaisePropertyChanged(() => StatusText);
                }
            }
        } 

        #endregion
    }
}
