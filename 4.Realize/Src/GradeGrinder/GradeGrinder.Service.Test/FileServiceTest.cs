using System;
using System.IO;
using NUnit.Framework;

namespace GradeGrinder.Service.Test
{
    [TestFixture]
    public class FileServiceTest
    {
        #region Fields and Properties

        private FileService _fileService;

        // We are currently in: 4.Realize\Src\GradeGrinder\GradeGrinder.Service.Test\bin\Debug
        private const string ValidFileName = @"..\..\..\..\..\..\5.Test\db.test.sqlite3\GradeGrinderTestDb.sqlite3";

        #endregion

        #region Test Setup/Teardown

        [TestFixtureSetUp]
        public void FixtureSetUp()
        {
        }

        [SetUp]
        public void SetUp()
        {
            _fileService = new FileService();
        }

        #endregion

        #region TESTS

        [Test]
        public void GetDefaultDataFileTest_FillNameIsNull_ShouldThrowArgumentNullException()
        {
            string invalidFileName = null;
            Assert.Throws<ArgumentNullException>(() => _fileService.GetDefaultDataFileByName(invalidFileName));
        }
        
        [Test]
        public void GetDefaultDataFileTest_FillNameIsEmpty_ShouldThrowArgumentNullException()
        {
            string invalidFileName = string.Empty;
            Assert.Throws<ArgumentNullException>(() => _fileService.GetDefaultDataFileByName(invalidFileName));
        }

        [Test]
        public void GetDefaultDataFileTest_FillNotValid_ShouldThrowFileNotFoundException()
        {
            const string invalidFileName = "invalid.sqlite3";
            Assert.Throws<FileNotFoundException>(() => _fileService.GetDefaultDataFileByName(invalidFileName));
        }

        [Test]
        public void GetDefaultDataFileTest_FillValid_ShouldNotThrow()
        {
            Assert.DoesNotThrow(() => _fileService.GetDefaultDataFileByName(ValidFileName));
        }

        [Test]
        public void GetDefaultDataFileTest_FillValid_ShouldReturnValidFileInfo()
        {
            FileInfo fileInfo = _fileService.GetDefaultDataFileByName(ValidFileName);
            Assert.IsNotNull(fileInfo);
        }


        #endregion

    }
}
