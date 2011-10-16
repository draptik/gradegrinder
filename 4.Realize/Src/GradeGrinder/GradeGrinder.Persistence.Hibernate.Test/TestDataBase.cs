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
            _container = ContainerProvider.Container;
        }

        #endregion


        #region TESTS

        [Test]
        public void TestCreateAndSaveAStudent()
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
