using System;

namespace GradeGrinder.Gui.Interfaces.Services
{
    public interface IStatusBarService
    {
        string CurrentStatusText { get; }
        void ShowStatusText(string statusText);
        void ClearStatusText();
        event EventHandler<EventArgs> StatusTextChanged;
    }
}
