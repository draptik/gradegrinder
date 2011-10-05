using System;
using GradeGrinder.Domain;

namespace GradeGrinder.Persistence.Dao
{
    public interface IEditStudentModel
    {
        Student GetStudent(Guid studentId);
        void SaveStudent(Student student);
        void SaveAll();
        void CancelAll();
    }
}
