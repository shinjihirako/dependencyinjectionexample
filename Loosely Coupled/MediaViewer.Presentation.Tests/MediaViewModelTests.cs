using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace MediaViewer.Presentation.Tests
{
    [TestClass]
    public class MediaViewModelTests
    {
        [TestMethod]
        public void Media_OnRefreshMedia_HasData()
        {
            //arrange
            var reader = new DummyReader();
            var viewModel = new MediaViewModel(reader);

            //act
            viewModel.RefreshMedia();

            //assert
            Assert.IsNotNull(viewModel.Media);
            Assert.AreEqual(2, viewModel.Media.Count());
        }

        [TestMethod]
        public void Media_OnClearMedia_IsEmpty()
        {
            //arrange 
            var reader = new DummyReader();
            var viewModel = new MediaViewModel(reader);
            viewModel.RefreshMedia();
            Assert.AreNotEqual(0, viewModel.Media.Count(), "invalid range");

            //act 
            viewModel.ClearMedia();

            //assert 
            Assert.AreEqual(0, viewModel.Media.Count());
        }
    }
}
