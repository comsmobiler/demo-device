using Smobiler.Core;

namespace H947BarcodeTest
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
            this.barcode1 = new Smobiler.Device.R100Scanner();
            this.btnScan = new Smobiler.Core.Controls.Button();
            this.btnScanInstantly = new Smobiler.Core.Controls.Button();
            this.btnStopScan = new Smobiler.Core.Controls.Button();
            this.btnEnableTrigger = new Smobiler.Core.Controls.Button();
            this.btnDisableTrigger = new Smobiler.Core.Controls.Button();
            this.labData = new Smobiler.Core.Controls.Label();
            this.btnBindKeyDown = new Smobiler.Core.Controls.Button();
            this.btnUnbindKeyDown = new Smobiler.Core.Controls.Button();
            // 
            // barcode1
            // 
            this.barcode1.Name = "barcode1";
            this.barcode1.DataCaptured += new Smobiler.Device.R100BarcodeScanEventHandler(this.barcode1_DataCaptured);
            this.barcode1.OnNotify += new Smobiler.Device.R100BarcodeOnNotifyEventHandler(this.barcode1_OnNotify);
            this.barcode1.KeyDown += new Smobiler.Device.R100ButtonEventHandler(this.barcode1_KeyDown);
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(86, 57);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(100, 30);
            this.btnScan.Text = "É¨Ãè";
            this.btnScan.Press += new System.EventHandler(this.btnScan_Press);
            // 
            // btnScanInstantly
            // 
            this.btnScanInstantly.Location = new System.Drawing.Point(86, 100);
            this.btnScanInstantly.Name = "btnScanInstantly";
            this.btnScanInstantly.Size = new System.Drawing.Size(100, 30);
            this.btnScanInstantly.Text = "³ÖÐøÉ¨Ãè";
            this.btnScanInstantly.Press += new System.EventHandler(this.btnScanInstantly_Press);
            // 
            // btnStopScan
            // 
            this.btnStopScan.Location = new System.Drawing.Point(86, 142);
            this.btnStopScan.Name = "btnStopScan";
            this.btnStopScan.Size = new System.Drawing.Size(100, 30);
            this.btnStopScan.Text = "Í£Ö¹É¨Ãè";
            this.btnStopScan.Press += new System.EventHandler(this.btnStopScan_Press);
            // 
            // btnEnableTrigger
            // 
            this.btnEnableTrigger.Location = new System.Drawing.Point(86, 186);
            this.btnEnableTrigger.Name = "btnEnableTrigger";
            this.btnEnableTrigger.Size = new System.Drawing.Size(100, 30);
            this.btnEnableTrigger.Text = "×¢²á¼üÅÌ";
            this.btnEnableTrigger.Press += new System.EventHandler(this.btnEnableTrigger_Press);
            // 
            // btnDisableTrigger
            // 
            this.btnDisableTrigger.Location = new System.Drawing.Point(86, 229);
            this.btnDisableTrigger.Name = "btnDisableTrigger";
            this.btnDisableTrigger.Size = new System.Drawing.Size(100, 30);
            this.btnDisableTrigger.Text = "²»×¢²á¼üÅÌ";
            this.btnDisableTrigger.Press += new System.EventHandler(this.btnDisableTrigger_Press);
            // 
            // labData
            // 
            this.labData.Location = new System.Drawing.Point(6, 362);
            this.labData.Name = "labData";
            this.labData.Size = new System.Drawing.Size(300, 35);
            // 
            // btnBindKeyDown
            // 
            this.btnBindKeyDown.Location = new System.Drawing.Point(86, 278);
            this.btnBindKeyDown.Name = "btnBindKeyDown";
            this.btnBindKeyDown.Size = new System.Drawing.Size(100, 30);
            this.btnBindKeyDown.Text = "É¨Ãè¼ü×Ô¶¨Òå";
            this.btnBindKeyDown.Press += new System.EventHandler(this.btnBindKeyDown_Press);
            // 
            // btnUnbindKeyDown
            // 
            this.btnUnbindKeyDown.Location = new System.Drawing.Point(86, 321);
            this.btnUnbindKeyDown.Name = "btnUnbindKeyDown";
            this.btnUnbindKeyDown.Size = new System.Drawing.Size(100, 30);
            this.btnUnbindKeyDown.Text = "É¨Ãè¼ü²»×Ô¶¨Òå";
            this.btnUnbindKeyDown.Press += new System.EventHandler(this.btnUnbindKeyDown_Press);
            // 
            // SmobilerForm1
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.barcode1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnScan,
            this.btnScanInstantly,
            this.btnStopScan,
            this.btnEnableTrigger,
            this.btnDisableTrigger,
            this.labData,
            this.btnBindKeyDown,
            this.btnUnbindKeyDown});
            this.Name = "SmobilerForm1";

        }
        #endregion

        private Smobiler.Core.Controls.Button btnScan;
        private Smobiler.Device.R100Scanner barcode1;
        private Smobiler.Core.Controls.Button btnScanInstantly;
        private Smobiler.Core.Controls.Button btnStopScan;
        private Smobiler.Core.Controls.Button btnEnableTrigger;
        private Smobiler.Core.Controls.Button btnDisableTrigger;
        private Smobiler.Core.Controls.Label labData;
        private Smobiler.Core.Controls.Button btnBindKeyDown;
        private Smobiler.Core.Controls.Button btnUnbindKeyDown;
    }
}