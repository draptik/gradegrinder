using GradeGrinder.Domain;

namespace GradeGrinder.Persistence.Hibernate
{
    public class StudentDao : AbstractHibernateDao<Student, long?>, IStudentDao
    {
    }
}
