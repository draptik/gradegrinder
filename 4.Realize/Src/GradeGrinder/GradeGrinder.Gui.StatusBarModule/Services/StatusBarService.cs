using GradeGrinder.Gui.Interfaces.Services;
using System;

namespace GradeGrinder.Gui.StatusBarModule.Services
{
    public class StatusBarService : IStatusBarService
    {
        private string _currentStatusText;

        #region Implementation of IStatusBarService

        public string CurrentStatusText { get { return _currentStatusText; } }

        public void ShowStatusText(string statusText)
        {
            _currentStatusText = statusText;
            
            var statusTextChanged = StatusTextChanged;
            if (statusTextChanged != null) {
                statusTextChanged(this, new EventArgs());
            }
        }

        public void ClearStatusText()
        {
            ShowStatusText(String.Empty);
        }

        public event EventHandler<EventArgs> StatusTextChanged;

        #endregion
    }
}
