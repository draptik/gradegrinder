using Microsoft.Practices.Prism.Commands;

namespace GradeGrinder.Infrastructure.GlobalCommands
{
    public static class GlobalCommands
    {
        private static readonly CompositeCommand _closeCommand = new CompositeCommand(true);
        private static readonly CompositeCommand _closeAllCommand = new CompositeCommand(false);

        public static CompositeCommand CloseCommand
        {
            get { return _closeCommand; }
        }

        public static CompositeCommand CloseAllCommand
        {
            get { return _closeAllCommand; }
        }
    }
}
