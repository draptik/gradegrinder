using log4net;

namespace GradeGrinder.Domain
{
    public class Student : Auto.Student
    {
        #region Private Fields

        private static readonly ILog Log = LogManager.GetLogger(typeof(Student));

        #endregion
        
        #region Ctor
        
        /// <summary>
        /// Default Ctor for NHibernate
        /// </summary>
        public Student() { }

        #endregion
    }
}
