using MediaViewer.CSV;

namespace MediaViewer.DataAccess.CSV.Tests
{
    class DummyFileLoader : ICSVFileLoader
    {
        private string _dataType;
        public DummyFileLoader(string dataType)
        {
            _dataType = dataType;
        }
        public string LoadFile()
        {
            switch (_dataType)
            {
                case "Good": return TestData.GoodRecords;
                case "Mixed": return TestData.GoodandBadRecords;
                case "Bad": return TestData.BadRecords;
                case "Empty": return string.Empty;
                default: return TestData.GoodRecords;
            }
        }
    }
}
