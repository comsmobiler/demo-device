using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using Smobiler.Device;

namespace R1000Test
{
    partial class SmobilerForm1 : Smobiler.Core.Controls.MobileForm
    {
        private void btnBarcodescan_Press(object sender, EventArgs e)
        {
            r1000Scanner1.BarcodeIsMulti(false);
            r1000Scanner1.BarcodeScan(10);
        }

        private void btnBarcodescanstop_Press(object sender, EventArgs e)
        {
            r1000Scanner1.BarcodeScanStop();
        }

        private void btnEnableTrigger_Press(object sender, EventArgs e)
        {
            r1000Scanner1.EnableTrigger();
        }

        private void btnDisableTrigger_Press(object sender, EventArgs e)
        {
            r1000Scanner1.DisableTrigger();
        }

        private void btnRFIDscan_Press(object sender, EventArgs e)
        {
            r1000Scanner1.RFIDScan();
        }

        private void btnRFIDscanstop_Press(object sender, EventArgs e)
        {
            r1000Scanner1.RFIDScanStop();
        }

        private void btnBarcodeTimerScan_Press(object sender, EventArgs e)
        {
            r1000Scanner1.BarcodeIsMulti(true);
            r1000Scanner1.BarcodeScan();
        }

        private void btnsetRfidPower_Press(object sender, EventArgs e)
        {
            r1000Scanner1.SetRFIDPower(int.Parse(textBox1.Text));
        }

        private void r1000Scanner1_BarcodeDataCaptured(object sender, Smobiler.Device.R1000BarcodeScanEventArgs e)
        {
            this.label1.Text = e.Data;
        }

        private void r1000Scanner1_OnNotify(object sender, ComponentResultArgs e)
        {
            if (e.isError == true)
            {
                MessageBox.Show(e.error);
            }
        }

        private void r1000Scanner1_RFIDDataCaptured(object sender, Smobiler.Device.R1000RFIDScanEventArgs e)
        {
            this.label1.Text = e.Epc;
            this.label2.Text = e.Rssi;
        }

        private void r1000Scanner1_KeyDown(object sender, Smobiler.Device.R1000ButtonEventArgs e)
        {
            if (e.KeyCode == R1000Keys.F1)
                Toast("1");
            if (e.KeyCode == R1000Keys.F2)
                Toast("2");
            if (e.KeyCode == R1000Keys.F3)
                Toast("3");
            if (e.KeyCode == R1000Keys.F4)
                Toast("4");
            if (e.KeyCode == R1000Keys.F5_SCAN)
                Toast("5");
            if (e.KeyCode == R1000Keys.LeftTrigger)
                Toast("6");
            if (e.KeyCode == R1000Keys.RightTrigger)
                Toast("7");
        }

        private void btnBindKeyDown_Press(object sender, EventArgs e)
        {
            r1000Scanner1.BindKeyDown();
        }

        private void btnUnbindKeyDown_Press(object sender, EventArgs e)
        {
            r1000Scanner1.UnbindKeyDown();
        }
    }
}