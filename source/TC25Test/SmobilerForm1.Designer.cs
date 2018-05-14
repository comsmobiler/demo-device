using Smobiler.Core;
using Smobiler.Device;

namespace TC25Test
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
            this.barcode1 = new Smobiler.Device.TC25Scanner();
            this.btnsetTriggerType = new Smobiler.Core.Controls.Button();
            this.btnscan = new Smobiler.Core.Controls.Button();
            this.btnstop = new Smobiler.Core.Controls.Button();
            this.btnstatus = new Smobiler.Core.Controls.Button();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            // 
            // barcode1
            // 
            this.barcode1.Name = "barcode1";
            this.barcode1.DataCaptured += new Smobiler.Device.TC25BarcodeScanEventHandler(this.barcode1_DataCaptured);
            this.barcode1.OnNotify += new Smobiler.Device.TC25BarcodeOnNotifyEventHandler(this.barcode1_OnNotify);
            this.barcode1.OnStatus += new Smobiler.Device.TC25BarcodeStatusEventHandler(this.barcode1_OnStatus);
            // 
            // btnsetTriggerType
            // 
            this.btnsetTriggerType.Location = new System.Drawing.Point(80, 97);
            this.btnsetTriggerType.Name = "btnsetTriggerType";
            this.btnsetTriggerType.Size = new System.Drawing.Size(130, 37);
            this.btnsetTriggerType.Text = "设置扫描方式 0";
            this.btnsetTriggerType.Press += new System.EventHandler(this.btnsetTriggerType_Press);
            // 
            // btnscan
            // 
            this.btnscan.Location = new System.Drawing.Point(80, 147);
            this.btnscan.Name = "btnscan";
            this.btnscan.Size = new System.Drawing.Size(130, 33);
            this.btnscan.Text = "开启扫描";
            this.btnscan.Press += new System.EventHandler(this.btnscan_Press);
            // 
            // btnstop
            // 
            this.btnstop.Location = new System.Drawing.Point(80, 204);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(130, 32);
            this.btnstop.Text = "关闭扫描";
            this.btnstop.Press += new System.EventHandler(this.btnstop_Press);
            // 
            // btnstatus
            // 
            this.btnstatus.Location = new System.Drawing.Point(80, 252);
            this.btnstatus.Name = "btnstatus";
            this.btnstatus.Size = new System.Drawing.Size(130, 30);
            this.btnstatus.Text = "获取当前扫描设备状态";
            this.btnstatus.Press += new System.EventHandler(this.btnstatus_Press);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 51);
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(45, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 71);
            this.label2.Text = "label2";
            // 
            // SmobilerForm1
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.barcode1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnsetTriggerType,
            this.btnscan,
            this.btnstop,
            this.btnstatus,
            this.label1,
            this.label2});
            this.Name = "SmobilerForm1";

        }
        #endregion

        private Smobiler.Device.TC25Scanner barcode1;
        private Smobiler.Core.Controls.Button btnsetTriggerType;
        private Smobiler.Core.Controls.Button btnscan;
        private Smobiler.Core.Controls.Button btnstop;
        private Smobiler.Core.Controls.Button btnstatus;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
    }
}