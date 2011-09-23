using GradeGrinder.Domain;
using GradeGrinder.Persistence.Dao;

namespace GradeGrinder.Persistence.Hibernate.Dao
{
    public class StudentDao : AbstractHibernateDao<Student, long?>, IStudentDao
    {
    }
}
