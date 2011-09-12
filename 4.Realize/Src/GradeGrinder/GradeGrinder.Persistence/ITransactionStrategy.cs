namespace GradeGrinder.Persistence
{
    public interface ITransactionStrategy
    {
        void Begin();
        void Commit();
        void Rollback();
    }
}
