using System;

namespace MediaViewer.DataAccess.CSV.Tests
{
    public static class TestData
    {
        public static string GoodRecords = 
            "1,Tenet, https://media.newsmonkey.be/20200828122539/tenet1-1024x640.jpg,null,2020/09/03,8" + Environment.NewLine +
            "2,Back to the Future,https://media.s-bol.com/3BDBL1XPXz9/550x778.jpg,null,1985/07/03,8,";

        public static string GoodandBadRecords = 
            "1,Tenet, https://media.newsmonkey.be/20200828122539/tenet1-1024x640.jpg,null,2020/09/03,8" + Environment.NewLine +
            "Invalid data" + Environment.NewLine +
            "2,Back to the Future,https://media.s-bol.com/3BDBL1XPXz9/550x778.jpg,null,1985/07/03,8," + Environment.NewLine +
            "Invalid data" + Environment.NewLine;

        public static string BadRecords = 
            "Invalid data" + Environment.NewLine +         
            "Invalid data" + Environment.NewLine;
    }
}
