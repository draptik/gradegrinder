using GradeGrinder.Persistence.Dao;
using GradeGrinder.Persistence.Hibernate.Dao;

namespace GradeGrinder.Persistence.Hibernate
{
    public class HibernateDaoFactory : AbstractDaoFactory
    {
        #region Overrides of AbstractDaoFactory

        public override IStudentDao GetStudentDao()
        {
            return new StudentDao();
        }

        #endregion
    }
}
