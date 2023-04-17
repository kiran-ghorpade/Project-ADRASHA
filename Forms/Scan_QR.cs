using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;

namespace ADRASHA_Main.Forms
{
    public partial class Scan_QR : Form
    {
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        int member_id = 0;


        public Scan_QR()
        {
            InitializeComponent();
        }

        private void Scan_QR_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                comboBox1.Items.Add(Device.Name);
            }

            comboBox1.SelectedIndex = 0;
            //FinalFrame = new VideoCaptureDevice();


            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();

            timer1.Enabled = true;
            timer1.Start();

        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader Reader = new BarcodeReader();
                Result result = Reader.Decode((Bitmap)pictureBox1.Image);
                try
                {
                    if (result == null) { return; }
                    string decoded = result.ToString().Trim();
                    if (decoded != "")
                    {
                        timer1.Stop();
                        member_id = Convert.ToInt32(decoded);
                        search(member_id);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("QR Code Invalid.");
                    timer1.Stop();
                    timer1.Start();
                }
            }
        }

        public void search(int member_id)
        {
            if (FinalFrame.IsRunning == true)
            {
                exitcamera();
            }
            this.Dispose();
            Health_Profile profile = new Health_Profile(Convert.ToInt32(member_id));
            MyFunctions.LoadChildForm(profile, MDI.childformpanel);
        }

        private void Scan_QR_FormClosing(object sender, FormClosingEventArgs e)
        {
            exitcamera();
            Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice();

            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();

            timer1.Enabled = true;
            timer1.Start();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void exitcamera()
        {
            if (FinalFrame != null && FinalFrame.IsRunning)
            {
                timer1.Stop();
                FinalFrame.NewFrame -= new NewFrameEventHandler(FinalFrame_NewFrame);
                FinalFrame.SignalToStop();
                FinalFrame.Stop();
                FinalFrame.WaitForStop();
                FinalFrame.WaitForStop();
                CaptureDevice = null;
                FinalFrame = null;
            }
        }
    }
}
