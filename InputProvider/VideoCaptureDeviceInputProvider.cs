using System;
using System.Drawing;
using System.Threading.Tasks;
using AForge.Video;
using AForge.Video.DirectShow;
using Domain;

namespace InputProvider
{
    public class VideoCaptureDeviceInputProvider : IInputProvider<Bitmap>
    {
        private VideoCaptureDevice _device;
        private Bitmap _last;
        private readonly object bitmapIO = new object();

        public void Initialize()
        {
            var videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count <= 0)
            {
                throw new NotSupportedException("No video devices available");
            }

            _device = new VideoCaptureDevice(videoDevices[0].MonikerString);
            _device.ProvideSnapshots = true;

            _device.NewFrame += NewFrame;
            _device.SnapshotFrame += NewFrame;

            _device.Start();
        }

        public void Stop()
        {
            _device.SignalToStop();
        }

        private void NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            lock (bitmapIO)
            {
                _last?.Dispose();
                _last = new Bitmap(eventArgs.Frame);
            }
        }

        public async Task<Bitmap> Get()
        {
            Bitmap result;
            lock(bitmapIO)
            {
                result = _last == null 
                    ? null 
                    : new Bitmap(_last);
            }
            result?.Save(@"C:\Repositories\last.bmp");
            return result;
        }
    }
}
