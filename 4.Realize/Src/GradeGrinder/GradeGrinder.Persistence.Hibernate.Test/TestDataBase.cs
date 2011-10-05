using System;
using Castle.Windsor;
using GradeGrinder.IoC.Windsor;
using GradeGrinder.Persistence.Dao;
using NUnit.Framework;
using GradeGrinder.Domain;

namespace GradeGrinder.Persistence.Hibernate.Test
{
    [TestFixture]
    public class TestDataBase
    {
        #region Fields and Properties

        //private ITransactionStrategy _transaction;
        //private AbstractDaoFactory _daoFactory;

        private IWindsorContainer _container;

        #endregion

        #region Test Setup/Teardown

        [TestFixtureSetUp]
        public void FixtureSetUp()
        {
        }

        [SetUp]
        public void SetUp()
        {
            //_transaction = new DefaultTransactionStrategy();
            //_daoFactory = new HibernateDaoFactory();

            _container = ContainerProvider.Container;
        }

        #endregion


        #region TESTS

        [Test, Ignore]
        public void CreateDatabase_Orig()
        {
            try {
                //_transaction.Begin();

                //_daoFactory.GetStudentDao().Save(new Student { FirstName = "Max", LastName = "Mustermann" });

                //_transaction.Commit();
            }
            catch (Exception ex) {
                //_transaction.Rollback();
            }
        }

        [Test]
        public void TestFoo()
        {
            Student student = CreateNewStudent();
            Guid studentId;
            IEditStudentModel model = _container.GetService<IEditStudentModel>();
            model.SaveStudent(student);
            studentId = student.Id;
            model.SaveAll();
            student = null;

            student = model.GetStudent(studentId);
            student.LastName = "FooBar";
            model.CancelAll();
            student = null;
        }

        #endregion

        #region Helper

        private static Student CreateNewStudent()
        {
            return new Student {FirstName = "Jon", LastName = "Doe"};
        }

        #endregion
    }
}
