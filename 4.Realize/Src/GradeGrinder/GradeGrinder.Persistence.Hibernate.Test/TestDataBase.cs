using System;
using NUnit.Framework;
using GradeGrinder.Domain;

namespace GradeGrinder.Persistence.Hibernate.Test
{
    [TestFixture]
    public class TestDataBase
    {
        #region Fields and Properties

        private ITransactionStrategy _transaction;
        private AbstractDaoFactory _daoFactory;

        #endregion

        #region Test Setup/Teardown

        [TestFixtureSetUp]
        public void FixtureSetUp()
        {
        }

        [SetUp]
        public void SetUp()
        {
            _transaction = new DefaultTransactionStrategy();
            _daoFactory = new HibernateDaoFactory();
        }

        #endregion


        #region TESTS

        [Test]
        public void CreateDatabase()
        {
            try {
                _transaction.Begin();

                _daoFactory.GetStudentDao().Save(new Student { FirstName = "Max", LastName = "Mustermann" });

                _transaction.Commit();
            }
            catch (Exception ex) {
                _transaction.Rollback();
            }
        }

        #endregion
    }
}
