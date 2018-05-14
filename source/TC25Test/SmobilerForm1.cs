using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using Smobiler.Device;

namespace TC25Test
{
    partial class SmobilerForm1 : Smobiler.Core.Controls.MobileForm
    {
        int i = 0;
        private void btnsetTriggerType_Press(object sender, EventArgs e)
        {
            if (i == 0)
            { this.barcode1.SetTriggerType(Smobiler.Device.TriggerType.Software);btnsetTriggerType.Text = "设置扫描方式 1"; i++; }
            else
            { this.barcode1.SetTriggerType(Smobiler.Device .TriggerType.Hardware); btnsetTriggerType.Text = "设置扫描方式 0"; i = 0; }
        }

        private void btnscan_Press(object sender, EventArgs e)
        {
            this.barcode1.Scan();
        }


        private void btnstop_Press(object sender, EventArgs e)
        {
            this.barcode1.ScanStop();
        }

        private void btnstatus_Press(object sender, EventArgs e)
        {
            this.barcode1.Status();
        }

        private void barcode1_OnNotify(object sender, Smobiler.Core.Controls.ComponentResultArgs e)
        {
            if (e.isError == true)
            {
                MessageBox.Show(e.error);
            }
        }

        private void barcode1_DataCaptured(object sender, TC25BarcodeScanEventArgs e)
        {
            this.label1.Text = e.Data;
        }

        private void barcode1_OnStatus(object sender, TC25BarcodeStatusEventArgs e)
        {
            this.label2.Text = e.Status;
        }
    }
}