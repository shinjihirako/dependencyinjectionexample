using MediaViewer.Common;
using MediaViewer.Service;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MediaViewer.Presentation
{
    public class MediaViewModel : INotifyPropertyChanged
    {
        protected IMediaReader DataReader;

        private IEnumerable<Media> _media;

        public IEnumerable<Media> Media
        {
            get { return _media; }
            set { if (_media == value)
                    return;
                _media = value;
                RaisePropertyChanged();
            }
        }

        public MediaViewModel(IMediaReader dataReader)
        {
            DataReader = dataReader;
        }

        public void RefreshMedia()
        {
            Media = DataReader.GetMedia();
        }

        public void ClearMedia()
        {
            Media = new List<Media>();
        }

        public string DataReaderType
        {
            get { return DataReader.GetType().ToString(); }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
