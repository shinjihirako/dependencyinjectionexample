using MediaViewer.CSV;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Linq;

namespace MediaViewer.DataAccess.CSV.Tests
{
    [TestClass]
    public class CSVReaderTests
    {
        [TestMethod]
        public void GetMedia_WithOnlyGoodRecords_ReturnsAllRecords()
        {
            var reader = new CSVReader();
            reader.FileLoader = new DummyFileLoader("Good");

            var result = reader.GetMedia();

            Assert.AreEqual(2, result.Count());
        }

        [TestMethod]
        public void GetMedia_WithSomeGoodRecords_ReturnsGoodRecords()
        {
            var reader = new CSVReader();
            reader.FileLoader = new DummyFileLoader("Mixed");

            var result = reader.GetMedia();

            Assert.AreEqual(2, result.Count());
        }

        [TestMethod]
        public void GetMedia_WithOnlyBadRecords_ReturnsEmptyList()
        {
            var reader = new CSVReader();
            reader.FileLoader = new DummyFileLoader("Bad");

            var result = reader.GetMedia();

            Assert.AreEqual(0, result.Count());
        }

        [TestMethod]
        public void GetMedia_WithEmptyFile_ReturnsEmptyList()
        {
            var reader = new CSVReader();
            reader.FileLoader = new DummyFileLoader("Empty");

            var result = reader.GetMedia();

            Assert.AreEqual(0, result.Count());
        }


        [TestMethod]
        public void GetMedia_WithNoFile_ThrowsFileNotFoundException()
        {
            var reader = new CSVReader();

            Assert.ThrowsException<FileNotFoundException>(
                () => reader.GetMedia());
        }
    }
}
