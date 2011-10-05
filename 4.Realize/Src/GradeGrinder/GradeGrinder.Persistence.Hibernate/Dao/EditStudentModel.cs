using System;
using GradeGrinder.Domain;
using GradeGrinder.Persistence.Dao;
using uNhAddIns.Adapters;

namespace GradeGrinder.Persistence.Hibernate.Dao
{
    [PersistenceConversational(MethodsIncludeMode = MethodsIncludeMode.Implicit)]
    public class EditStudentModel : IEditStudentModel
    {
        private readonly IDao<Student> _studentDao;

        
        public EditStudentModel(IDao<Student> studentDao)
        {
            _studentDao = studentDao;
        }

        #region Implementation of IEditStudentModel

        public Student GetStudent(Guid studentId)
        {
            return _studentDao.Get(studentId);
        }

        public void SaveStudent(Student student)
        {
            _studentDao.Save(student);
        }

        [PersistenceConversation(ConversationEndMode = EndMode.End)]
        public void SaveAll()
        {
        }

        [PersistenceConversation(ConversationEndMode = EndMode.Abort)]
        public void CancelAll()
        {
        }

        #endregion
    }
}
