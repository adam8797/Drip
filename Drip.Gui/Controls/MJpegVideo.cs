using Ozeki.Media;

namespace Drip.Gui.Controls
{
    public class MJPEGVideo : VideoViewerWF
    {
        private DrawingImageProvider _bitmapSourceProvider;
        private MediaConnector _connector;
        private MJPEGConnection _mjpegConnection;

        public MJPEGVideo()
        {
            _bitmapSourceProvider = new DrawingImageProvider();
            _connector = new MediaConnector();
            _mjpegConnection = new MJPEGConnection();
            SetImageProvider(_bitmapSourceProvider);
        }

        private string _url;
        public string MJPEGUrl
        {
            get { return _url; }
            set
            {
                if (_url != value)
                {
                    _url = value;
                    Rebind();
                }
            }
        }

        private void Rebind()
        {
            _mjpegConnection.Disconnect();
            _mjpegConnection.Connect(_url);
            _connector.Connect(_mjpegConnection.VideoChannel, _bitmapSourceProvider);
            Start();
        }
    }
}
