using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.FFMPEG;
using AForge.Video;
using System.Diagnostics;


namespace JetScreenRecorder
{
    public partial class Form1 : Form
    {
        private bool _isRecording;
        private List<string> _screenNames;
        //private Rectangle _screenSize;
        private UInt32 _frameCount;
        private VideoFileWriter _writer;
        private int _width;
        private int _height;
        private ScreenCaptureStream _streamVideo;
        private Stopwatch _stopWatch;
        private Rectangle _screenArea;
        

        public Form1()
        {
            InitializeComponent();

            this._isRecording = false;
            //this._screenSize = Screen.PrimaryScreen.Bounds;
            this._frameCount = 0;
            this._width = SystemInformation.VirtualScreen.Width;
            this._height = SystemInformation.VirtualScreen.Height;
            this._stopWatch = new Stopwatch();
            this._screenArea = Rectangle.Empty;

            this.bt_Save.Enabled = false;
            this._writer = new VideoFileWriter();

            _screenNames = new List<string>();
            _screenNames.Add( @"Select ALL" );
            foreach ( var screen in Screen.AllScreens )
            {
                _screenNames.Add(screen.DeviceName);
            }
            this.cb_screenSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cb_screenSelector.DataSource = _screenNames;

            // Codec ComboBox
            this.cb_VideoCodec.DataSource = Enum.GetValues( typeof( VideoCodec ) );
            this.cb_VideoCodec.DropDownStyle = ComboBoxStyle.DropDownList;

            // BitRate 2000kbit/s 2000000 1000000
            this.cb_BitRate.DataSource = Enum.GetValues( typeof( BitRate ) );
            this.cb_BitRate.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cb_BitRate.SelectedIndex = 3;
            panel1.Visible = false;
        }

        private void bt_start_Click( object sender, EventArgs e )
        {
            try
            {
                if ( this.tb_SaveFolder.Text.Length < 1 )
                {
                    FolderBrowserDialog fbd = new FolderBrowserDialog();
                    if ( fbd.ShowDialog() == DialogResult.OK )
                    {
                        this.StartRec( fbd.SelectedPath );
                    }
                }
                else
                {
                    this.StartRec( this.tb_SaveFolder.Text );
                }
                if (tb_SaveFolder.Text.Length == 0)
                {
                    panel1.Visible = false;
                }
            }
            catch ( Exception exc )
            {
                MessageBox.Show( exc.Message );
            }
        }

        private void StartRec( string path )
        {
            if ( _isRecording == false )
            {
                panel1.Visible = true;
                this.SetScreenArea();

                this.SetVisible( true );

                this._frameCount = 0;

                this.tb_SaveFolder.Text = path;
                string fullName = string.Format( @"{0}\{1}_{2}.avi", path, Environment.UserName.ToUpper(), DateTime.Now.ToString( "d_MMM_yyyy_HH_mm_ssff" ) );

                // Save File option
                _writer.Open(
                    fullName,
                    this._width,
                    this._height,
                    ( int ) nud_FPS.Value,
                    ( VideoCodec ) cb_VideoCodec.SelectedValue,
                    ( int ) ( BitRate ) this.cb_BitRate.SelectedValue );

                // Start main work
                this.StartRecord();
            }
        }

        private void SetScreenArea()
        {
            // get entire desktop area size
            string screenName = this.cb_screenSelector.SelectedValue.ToString();
            if ( string.Compare( screenName, @"Select ALL", StringComparison.OrdinalIgnoreCase) == 0 )
            {
                foreach ( Screen screen in Screen.AllScreens )
                {
                    this._screenArea = Rectangle.Union( _screenArea, screen.Bounds );
                }
            }
            else
            {
                this._screenArea = Screen.AllScreens.First( scr => scr.DeviceName.Equals( screenName ) ).Bounds;
                this._width = this._screenArea.Width;
                this._height = this._screenArea.Height;
            }
        }

        private void StartRecord() //Object stateInfo
        {
            // create screen capture video source
            this._streamVideo = new ScreenCaptureStream( this._screenArea );

            // set NewFrame event handler
            this._streamVideo.NewFrame += new NewFrameEventHandler( this.video_NewFrame );

            // start the video source
            this._streamVideo.Start();

            // _stopWatch
            this._stopWatch.Start();
        }

        private void video_NewFrame( object sender, NewFrameEventArgs eventArgs )
        {
            if ( this._isRecording )
            {
                this._frameCount++;
                this._writer.WriteVideoFrame( eventArgs.Frame );

                this.lb_1.Invoke( new Action( () =>
                {
                    lb_1.Text = string.Format( @"Frames: {0}", _frameCount );
                } ) );

                this.lb_stopWatch.Invoke( new Action( () =>
                {
                    this.lb_stopWatch.Text = _stopWatch.Elapsed.ToString();
                } ) );
            }
            else
            {
                _stopWatch.Reset();
                Thread.Sleep( 500 );
                _streamVideo.SignalToStop();
                Thread.Sleep( 500 );
                _writer.Close();
            }
        }

        private void bt_Save_Click( object sender, EventArgs e )
        {
            panel1.Visible = false;
            this.SetVisible( false );
            MessageBox.Show( @"File saved!" );
        }

        private void SetVisible( bool visible )
        {
            this.bt_start.Enabled = !visible;
            this.bt_Save.Enabled = visible;
            this._isRecording = visible;
        }

        private void Form1_FormClosing( object sender, FormClosingEventArgs e )
        {
            this._isRecording = false;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Opacity = 0;      //first the opacity is 0

            timer1.Interval = 10;  //we'll increase the opacity every 10ms
            timer1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            timer1.Start();
        }
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                timer1.Stop();   //this stops the timer if the form is completely displayed
                panel2.Visible = false;
            }
            else
                Opacity += 0.01;
        }

    }

    public enum BitRate
    {
        _50kbit = 5000,
        _100kbit = 10000,
        _500kbit = 50000,
        _1000kbit = 1000000,
        _2000kbit = 2000000,
        _3000kbit = 3000000
    }
}
