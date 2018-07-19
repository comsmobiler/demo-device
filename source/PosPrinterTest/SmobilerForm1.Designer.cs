using Smobiler.Core;

namespace PosPrinterTest
{
    partial class SmobilerForm1 : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm Designer generated code "

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
            this.btnPrinter = new Smobiler.Core.Controls.Button();
            this.btnOnedimensionalcode = new Smobiler.Core.Controls.Button();
            this.bbtnTwodimensionalcode = new Smobiler.Core.Controls.Button();
            this.btnopenblackmark = new Smobiler.Core.Controls.Button();
            this.btncloseblackmark = new Smobiler.Core.Controls.Button();
            this.btnSamplelabel = new Smobiler.Core.Controls.Button();
            this.btnSteptoblackmark = new Smobiler.Core.Controls.Button();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.posPrinter1 = new Smobiler.Device.PosPrinter();
            this.posPrinter2 = new Smobiler.Device.PosPrinter();
            this.posPrinter3 = new Smobiler.Device.PosPrinter();
            this.posPrinter4 = new Smobiler.Device.PosPrinter();
            // 
            // btnPrinter
            // 
            this.btnPrinter.Location = new System.Drawing.Point(21, 61);
            this.btnPrinter.Name = "btnPrinter";
            this.btnPrinter.Size = new System.Drawing.Size(100, 30);
            this.btnPrinter.Text = "打印";
            this.btnPrinter.Press += new System.EventHandler(this.btnPrinter_Press);
            // 
            // btnOnedimensionalcode
            // 
            this.btnOnedimensionalcode.Location = new System.Drawing.Point(21, 129);
            this.btnOnedimensionalcode.Name = "btnOnedimensionalcode";
            this.btnOnedimensionalcode.Size = new System.Drawing.Size(100, 30);
            this.btnOnedimensionalcode.Text = "一维码";
            this.btnOnedimensionalcode.Press += new System.EventHandler(this.btnOnedimensionalcode_Press);
            // 
            // bbtnTwodimensionalcode
            // 
            this.bbtnTwodimensionalcode.Location = new System.Drawing.Point(21, 195);
            this.bbtnTwodimensionalcode.Name = "bbtnTwodimensionalcode";
            this.bbtnTwodimensionalcode.Size = new System.Drawing.Size(100, 30);
            this.bbtnTwodimensionalcode.Text = "二维码";
            this.bbtnTwodimensionalcode.Press += new System.EventHandler(this.bbtnTwodimensionalcode_Press);
            // 
            // btnopenblackmark
            // 
            this.btnopenblackmark.Location = new System.Drawing.Point(21, 253);
            this.btnopenblackmark.Name = "btnopenblackmark";
            this.btnopenblackmark.Size = new System.Drawing.Size(100, 30);
            this.btnopenblackmark.Text = "开启黑标检测";
            this.btnopenblackmark.Press += new System.EventHandler(this.btnopenblackmark_Press);
            // 
            // btncloseblackmark
            // 
            this.btncloseblackmark.Location = new System.Drawing.Point(21, 306);
            this.btncloseblackmark.Name = "btncloseblackmark";
            this.btncloseblackmark.Size = new System.Drawing.Size(100, 30);
            this.btncloseblackmark.Text = "关闭黑标检测";
            this.btncloseblackmark.Press += new System.EventHandler(this.btncloseblackmark_Press);
            // 
            // btnSamplelabel
            // 
            this.btnSamplelabel.Location = new System.Drawing.Point(21, 356);
            this.btnSamplelabel.Name = "btnSamplelabel";
            this.btnSamplelabel.Size = new System.Drawing.Size(100, 30);
            this.btnSamplelabel.Text = "样例标签";
            this.btnSamplelabel.Press += new System.EventHandler(this.btnSamplelabel_Press);
            // 
            // btnSteptoblackmark
            // 
            this.btnSteptoblackmark.Location = new System.Drawing.Point(166, 253);
            this.btnSteptoblackmark.Name = "btnSteptoblackmark";
            this.btnSteptoblackmark.Size = new System.Drawing.Size(100, 30);
            this.btnSteptoblackmark.Text = "走纸到黑标";
            this.btnSteptoblackmark.Press += new System.EventHandler(this.btnSteptoblackmark_Press);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 190);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 35);
            // 
            // posPrinter1
            // 
            this.posPrinter1.Name = "posPrinter1";
            // 
            // posPrinter2
            // 
            this.posPrinter2.Name = "posPrinter2";
            // 
            // posPrinter3
            // 
            this.posPrinter3.Name = "posPrinter3";
            // 
            // posPrinter4
            // 
            this.posPrinter4.Name = "posPrinter4";
            // 
            // SmobilerForm1
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.posPrinter1,
            this.posPrinter2,
            this.posPrinter3,
            this.posPrinter4});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnPrinter,
            this.btnOnedimensionalcode,
            this.bbtnTwodimensionalcode,
            this.btnopenblackmark,
            this.btncloseblackmark,
            this.btnSamplelabel,
            this.btnSteptoblackmark,
            this.textBox1});
            this.Name = "SmobilerForm1";

        }
        #endregion

        private Smobiler.Core.Controls.Button btnPrinter;
        private Smobiler.Core.Controls.Button btnOnedimensionalcode;
        private Smobiler.Core.Controls.Button bbtnTwodimensionalcode;
        private Smobiler.Core.Controls.Button btnopenblackmark;
        private Smobiler.Core.Controls.Button btncloseblackmark;
        private Smobiler.Core.Controls.Button btnSamplelabel;
        private Smobiler.Core.Controls.Button btnSteptoblackmark;
        private Smobiler.Core.Controls.TextBox textBox1;
        private Smobiler.Device.PosPrinter posPrinter1;
        private Smobiler.Device.PosPrinter posPrinter2;
        private Smobiler.Device.PosPrinter posPrinter3;
        private Smobiler.Device.PosPrinter posPrinter4;
    }
}