using Smobiler.Core;

namespace V7000ScanTest
{
    partial class SmobilerForm1 : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm Designer generated code "

        public SmobilerForm1()
            : base()
        {
            //This call is required by the SmobilerForm Designer.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm Designer
        //It can be modified using the SmobilerForm Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.btnScan = new Smobiler.Core.Controls.Button();
            this.btnencoding = new Smobiler.Core.Controls.Button();
            this.btnisContinue = new Smobiler.Core.Controls.Button();
            this.btnisVoice = new Smobiler.Core.Controls.Button();
            this.btnisVibator = new Smobiler.Core.Controls.Button();
            this.btnregisterKeyDown = new Smobiler.Core.Controls.Button();
            this.btnunRegisterKeyDown = new Smobiler.Core.Controls.Button();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.v7000Scan1 = new Smobiler.Device.V7000Scanner();
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(0, 55);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(300, 64);
            this.btnScan.Text = "…®√Ë";
            this.btnScan.Press += new System.EventHandler(this.btnScan_Press);
            // 
            // btnencoding
            // 
            this.btnencoding.Location = new System.Drawing.Point(0, 119);
            this.btnencoding.Name = "btnencoding";
            this.btnencoding.Size = new System.Drawing.Size(100, 30);
            this.btnencoding.Text = "encoding";
            this.btnencoding.Press += new System.EventHandler(this.btnencoding_Press);
            // 
            // btnisContinue
            // 
            this.btnisContinue.Location = new System.Drawing.Point(0, 149);
            this.btnisContinue.Name = "btnisContinue";
            this.btnisContinue.Size = new System.Drawing.Size(100, 30);
            this.btnisContinue.Text = "isContinue";
            this.btnisContinue.Press += new System.EventHandler(this.btnisContinue_Press);
            // 
            // btnisVoice
            // 
            this.btnisVoice.Location = new System.Drawing.Point(0, 179);
            this.btnisVoice.Name = "btnisVoice";
            this.btnisVoice.Size = new System.Drawing.Size(100, 30);
            this.btnisVoice.Text = "isVoice";
            this.btnisVoice.Press += new System.EventHandler(this.btnisVoice_Press);
            // 
            // btnisVibator
            // 
            this.btnisVibator.Location = new System.Drawing.Point(0, 209);
            this.btnisVibator.Name = "btnisVibator";
            this.btnisVibator.Size = new System.Drawing.Size(100, 30);
            this.btnisVibator.Text = "isVibator";
            this.btnisVibator.Press += new System.EventHandler(this.btnisVibator_Press);
            // 
            // btnregisterKeyDown
            // 
            this.btnregisterKeyDown.Location = new System.Drawing.Point(0, 239);
            this.btnregisterKeyDown.Name = "btnregisterKeyDown";
            this.btnregisterKeyDown.Size = new System.Drawing.Size(300, 61);
            this.btnregisterKeyDown.Text = "ø™∆Ù…®√Ëº¸…®√Ë";
            this.btnregisterKeyDown.Press += new System.EventHandler(this.btnregisterKeyDown_Press);
            // 
            // btnunRegisterKeyDown
            // 
            this.btnunRegisterKeyDown.Location = new System.Drawing.Point(0, 300);
            this.btnunRegisterKeyDown.Name = "btnunRegisterKeyDown";
            this.btnunRegisterKeyDown.Size = new System.Drawing.Size(300, 63);
            this.btnunRegisterKeyDown.Text = "πÿ±’…®√Ëº¸…®√Ë";
            this.btnunRegisterKeyDown.Press += new System.EventHandler(this.btnunRegisterKeyDown_Press);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(100, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 30);
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(100, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 30);
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(100, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 30);
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(100, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 30);
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 55);
            // 
            // v7000Scan1
            // 
            this.v7000Scan1.Encoding = Smobiler.Device.V7000Encoding.GBK;
            this.v7000Scan1.Name = "v7000Scan1";
            this.v7000Scan1.DataCaptured += new Smobiler.Device.V7000ScanEventHandler(this.v7000Scan1_DataCaptured);
            this.v7000Scan1.OnNotify += new Smobiler.Device.V7000OnNotifyEventHandler(this.v7000Scan1_OnNotify);
            // 
            // SmobilerForm1
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.v7000Scan1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnScan,
            this.btnencoding,
            this.btnisContinue,
            this.btnisVoice,
            this.btnisVibator,
            this.btnregisterKeyDown,
            this.btnunRegisterKeyDown,
            this.label2,
            this.label3,
            this.label4,
            this.label5,
            this.label6});
            this.Load += new System.EventHandler(this.SmobilerForm_Load);
            this.Name = "SmobilerForm1";

        }
        #endregion
        private Smobiler.Core.Controls.Button btnScan;
        private Smobiler.Core.Controls.Button btnencoding;
        private Smobiler.Core.Controls.Button btnisContinue;
        private Smobiler.Core.Controls.Button btnisVoice;
        private Smobiler.Core.Controls.Button btnisVibator;
        private Smobiler.Core.Controls.Button btnregisterKeyDown;
        private Smobiler.Core.Controls.Button btnunRegisterKeyDown;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.Label label6;
        private Smobiler.Device.V7000Scanner v7000Scan1;
    }
}