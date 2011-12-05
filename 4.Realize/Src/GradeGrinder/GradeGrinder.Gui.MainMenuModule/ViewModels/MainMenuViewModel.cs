using System;
using System.Windows;
using System.Windows.Input;
using GradeGrinder.Gui.Interfaces.Services;
using GradeGrinder.Gui.Interfaces.ViewModels;
using GradeGrinder.Infrastructure.Constants;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.ServiceLocation;

namespace GradeGrinder.Gui.MainMenuModule.ViewModels
{
    public class MainMenuViewModel : IMainMenuViewModel
    {
        #region fields

        private readonly DelegateCommand _exitCommand;

        private readonly DelegateCommand _newStudentCommand;
        //private readonly DelegateCommand _browseStudentsCommand;

        //private readonly DelegateCommand _editTitleCommand;

        #endregion


        #region constructors

        public MainMenuViewModel()
        {
            _exitCommand = new DelegateCommand(ExitApplication);

            //_newStudentCommand = new DelegateCommand(NewStudent);
            //_browseStudentsCommand = new DelegateCommand(BrowseStudents);

            //_editTitleCommand = new DelegateCommand(EditTitle);
        }

        #endregion

        #region properties

        public ICommand ExitCommand { get { return _exitCommand; } }
        public ICommand NewStudentCommand { get { return _newStudentCommand; } }
        //public ICommand BrowseStudentsCommand { get { return _browseStudentsCommand; } }
        //public ICommand EditTitleCommand { get { return _editTitleCommand; } }

        #endregion

        #region private members

        private static void ExitApplication()
        {
            Application.Current.Shutdown();
        }

        //private void NewStudent()
        //{
        //    ServiceLocator.Current.GetInstance<INavigationService>()
        //        .Navigate(ViewNames.EditStudentView, String.Concat(ViewNames.EditStudentView, "NEW"), RegionNames.DocumentRegion, true, "NEW");
        //}

        //private void BrowseStudents()
        //{
        //    ServiceLocator.Current.GetInstance<IRegionManager>()
        //        .RequestNavigate(RegionNames.DocumentRegion, new Uri(ViewNames.BrowseStudentsView, UriKind.Relative));
        //}

        //private void EditTitle()
        //{
        //    ServiceLocator.Current.GetInstance<IRegionManager>()
        //        .RequestNavigate(RegionNames.DocumentRegion, new Uri(ViewNames.EditTitleView, UriKind.Relative));
        //}

        #endregion

    }
}
