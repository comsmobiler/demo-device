using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using Smobiler.Device;

namespace R2000Test
{
    partial class SmobilerForm1 : Smobiler.Core.Controls.MobileForm
    {
        private void btnBarcodescan_Press(object sender, EventArgs e)
        {
            r2000Scanner1.BarcodeScan();
        }

        private void btnBarcodescanstop_Press(object sender, EventArgs e)
        {
            r2000Scanner1.BarcodeScanStop();
        }
        private bool mbMulti = false;
        private void btnBarcodeIsMulti_Press(object sender, EventArgs e)
        {
            mbMulti = !mbMulti;
            r2000Scanner1.BarcodeIsMulti(mbMulti);
        }

        private void btnRFIDscan_Press(object sender, EventArgs e)
        {
            r2000Scanner1.RFIDScan();
        }

        private void btnRFIDscanstop_Press(object sender, EventArgs e)
        {
            r2000Scanner1.RFIDScanStop();
        }
        private bool mrMulti = false;
        private void btnRFIDIsMulti_Press(object sender, EventArgs e)
        {
            mrMulti = !mrMulti;
            r2000Scanner1.RFIDIsMulti(mrMulti);
        }

        private void btnEnableTrigger_Press(object sender, EventArgs e)
        {
            r2000Scanner1.EnableTrigger();
        }

        private void btnDisableTrigger_Press(object sender, EventArgs e)
        {
            r2000Scanner1.DisableTrigger();
        }

        private void r2000Scanner1_BarcodeDataCaptured(object sender, Smobiler.Device.R2000BarcodeScanEventArgs e)
        {
            this.label1.Text = e.Data;
        }

        private void r2000Scanner1_FFIDDataCaptured(object sender, Smobiler.Device.R2000RFIDScanEventArgs e)
        {
            this.label1.Text = e.Epc;
            this.label2.Text = e.Rssi;
        }

        private void r2000Scanner1_OnNotify(object sender, ComponentResultArgs e)
        {
            if (e.isError == true)
            {
                MessageBox.Show(e.error);
            }
        }

        private void btnsetRfidPower_Press(object sender, EventArgs e)
        {
            try
            {
                
                    r2000Scanner1.SetRFIDPower(int.Parse(textBox1.Text), int.Parse(textBox1.Text));
            }
            catch
            {
                Toast("设置正确的功率（5-30）");
            }
        }

        private void btngetRfidPower_Press(object sender, EventArgs e)
        {
            //r2000Scanner1.getRfidPower((obj, args) => { Toast(args.ReadPower.ToString()); });
            r2000Scanner1.GetRFIDPower(r2000Scanner1_GetRFIDPower);
        }

        private void r2000Scanner1_GetRFIDPower(object sender, Smobiler.Device.R2000GetRFIDPowerEventArgs e)
        {
            MessageBox.Show(e.ReadPower + "  " + e.WritePower);
        }

        private void btnBindKeyDown_Press(object sender, EventArgs e)
        {
            r2000Scanner1.BindKeyDown();
        }

        private void btnUnBindKeyDown_Press(object sender, EventArgs e)
        {
            r2000Scanner1.UnbindKeyDown();
        }

        private void r2000Scanner1_KeyDown(object sender, R2000ButtonEventArgs e)
        {
            if (e.KeyCode == R2000Keys.F1)
                Toast("1");
            if (e.KeyCode == R2000Keys.F2)
                Toast("2");
            if (e.KeyCode == R2000Keys.LeftTrigger)
                Toast("3");
            if (e.KeyCode == R2000Keys.RightTrigger)
                Toast("4");
        }
    }
}