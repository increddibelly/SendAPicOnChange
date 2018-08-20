using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Domain;

namespace SendAPicOnChange
{
    public partial class MainWindow : Form
    {
        public const string TagForBitmapPictureBox = nameof(PictureBox1);
        public const string TagForTimestamp = nameof(lbTimestamp);

        private readonly Configuration _config;
        private readonly ICollection<IPresenter<Bitmap>> _bitmapPresenters;
        private readonly IProcessor<Bitmap> _bitmapProcessor;
        private readonly IInputProvider<Bitmap> _inputProvider;
        private readonly IChangeDetector<Bitmap> _changeDetector;

        public MainWindow(
            IEnumerable<IControlContentProvider> controlContentProviders,
            IEnumerable<IPresenter<Bitmap>> presenters, 
            IProcessor<Bitmap> bitmapProcessor, 
            Configuration config, 
            IInputProvider<Bitmap> inputProvider, 
            IChangeDetector<Bitmap> changeDetector)
        {
            _bitmapProcessor = bitmapProcessor;
            _config = config;
            _inputProvider = inputProvider;
            _changeDetector = changeDetector;
            _bitmapPresenters = presenters.ToArray();
            
            InitializeComponent();

            trackAccuracy.Value = _config.MaxGlitches;
            trackTolerance.Value = _config.Tolerance;

            foreach (var ccp in controlContentProviders)
            {
                var control = this.Controls.Find(ccp.Tag, true).SingleOrDefault();
                ccp.Control = control;
            }

            btStart_Click(this, null);
            CheckForChange_Tick(this, null);
        }

        private void trackTolerance_ValueChanged(object sender, EventArgs e)
        {
            tbTolerance.Text = trackTolerance.Value.ToString();
            _changeDetector.Tolerance = trackTolerance.Value;
        }

        private void trackAccuracy_ValueChanged(object sender, EventArgs e)
        {
            tbAccuracy.Text = trackAccuracy.Value.ToString();
            _changeDetector.Accuracy = trackAccuracy.Value;
        }

        private async void CheckForChange_Tick(object sender, EventArgs e)
        {
            var newFrame = await _bitmapProcessor.CheckInput();
            if (newFrame != null)
            {
                foreach (var presenter in _bitmapPresenters)
                {
                    try
                    {
                        presenter.Present(newFrame);
                    }
                    catch (Exception ex)
                    {
                        var test = ex.Message;
                    }
                }
            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            _inputProvider.Initialize();

            CheckForChange.Interval = _config.CheckInterval;
            CheckForChange.Enabled = true;
            CheckForChange.Start();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            _inputProvider.Stop();

            CheckForChange.Stop();
            CheckForChange.Enabled = false;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            btStop_Click(this, e);
        }
    }
}
