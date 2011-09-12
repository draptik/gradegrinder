namespace GradeGrinder.Persistence
{
    public abstract class AbstractDaoFactory
    {
        public abstract IStudentDao GetStudentDao();
    }
}
