using GradeGrinder.Domain;
using GradeGrinder.Persistence.Dao;
using log4net;

namespace GradeGrinder.Persistence.Hibernate.Dao
{
    public class StudentDao : AbstractHibernateDao<Student, long?>, IStudentDao
    {
        #region Private Fields

        private static readonly ILog Log = LogManager.GetLogger(typeof(Student));

        #endregion

    }
}
