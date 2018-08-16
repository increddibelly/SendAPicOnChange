using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Domain;
using Renci.SshNet;

namespace Presenter
{
    public class ScpUploader : IPresenter<Bitmap>
    {
        private readonly Configuration _config;

        public ScpUploader(Configuration config)
        {
            _config = config;
        }

        public void Present(Bitmap source)
        {
            var connectionConfig = new ConnectionInfo(
                _config.SCPHostName,
                _config.SCPPort,
                _config.SCPUser,
                new PasswordAuthenticationMethod(_config.SCPUser, _config.SCPPass));

            try
            {
                using (var bitmap = new MemoryStream(new byte[_config.SCPBuffersize]))
                using (var uploader = new ScpClient(connectionConfig))
                {
                    source.Save(bitmap, ImageFormat.Png);

                    uploader.Connect();

                    if (!uploader.IsConnected)
                        throw new IOException($"Could not connect to {_config.SCPHostName}:{_config.SCPPort}/{_config.SCPDestinationPath}");

                    uploader.BufferSize = _config.SCPBuffersize;
                    uploader.OperationTimeout = _config.SCPTimeout;

                    //uploader.Uploading += UploaderOnUploading;
                    //uploader.ErrorOccurred += UploaderOnErrorOccurred;

                    uploader.Upload(bitmap, _config.SCPDestinationPath);
                }
            }
            catch (Exception ex)
            {
                //UploaderOnErrorOccurred(this, new ExceptionEventArgs(ex));
            }
        }
    }
}
