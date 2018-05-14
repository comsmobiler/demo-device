using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using Smobiler.Device;

namespace H947BarcodeTest
{
    partial class SmobilerForm1 : Smobiler.Core.Controls.MobileForm
    {
        private void btnScan_Press(object sender, EventArgs e)
        {
            this.r100Scanner1.BarcodeIsMulti(false);
            this.r100Scanner1.BarcodeScan();
        }

        private void btnScanInstantly_Press(object sender, EventArgs e)
        {
            this.r100Scanner1.BarcodeIsMulti(true);
            this.r100Scanner1.BarcodeScan();
        }

        private void btnStopScan_Press(object sender, EventArgs e)
        {
            this.r100Scanner1.BarcodeScanStop();
        }

        private void btnEnableTrigger_Press(object sender, EventArgs e)
        {
            this.r100Scanner1.EnableTrigger();
        }

        private void btnDisableTrigger_Press(object sender, EventArgs e)
        {
            this.r100Scanner1.DisableTrigger();
        }

        private void btnBindKeyDown_Press(object sender, EventArgs e)
        {
            r100Scanner1.BindKeyDown();
        }

        private void btnUnbindKeyDown_Press(object sender, EventArgs e)
        {
            r100Scanner1.UnbindKeyDown();
        }

        private void r100Scanner1_DataCaptured(object sender, R100BarcodeScanEventArgs e)
        {
            this.labData.Text = e.Data;
        }

        private void r100Scanner1_KeyDown(object sender, R100ButtonEventArgs e)
        {
            if (e.KeyCode == R100Keys.F1)
                Toast("1");
            if (e.KeyCode == R100Keys.F2)
                Toast("2");
            if (e.KeyCode == R100Keys.F3)
                Toast("3");
            if (e.KeyCode == R100Keys.F4)
                Toast("4");
            if (e.KeyCode == R100Keys.F5_SCAN)
                Toast("5");
            if (e.KeyCode == R100Keys.LeftTrigger)
                Toast("6");
            if (e.KeyCode == R100Keys.RightTrigger)
                Toast("7");
        }

        private void r100Scanner1_OnNotify(object sender, ComponentResultArgs e)
        {
            if (e.isError == true)
            {
                MessageBox.Show(e.error);
            }
        }
    }
}