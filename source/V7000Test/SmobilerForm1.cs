using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using Smobiler.Device;

namespace V7000ScanTest
{
    partial class SmobilerForm1 : Smobiler.Core.Controls.MobileForm
    {
        private void SmobilerForm_Load(object sender, EventArgs e)
        {
            label2.Text = v7000Scan1.Encoding.ToString();
            label3.Text = v7000Scan1.IsContinue.ToString();
            label4.Text = v7000Scan1.IsVoice.ToString();
            label5.Text = v7000Scan1.IsVibator.ToString();
        }


        private void btnencoding_Press(object sender, EventArgs e)
        {
            if (v7000Scan1.Encoding == V7000Encoding.GBK)
                v7000Scan1.Encoding = V7000Encoding.UTF8;
            else
                v7000Scan1.Encoding = V7000Encoding.GBK;
            label2.Text = v7000Scan1.Encoding.ToString();
        }

        private void btnisContinue_Press(object sender, EventArgs e)
        {
            v7000Scan1.IsContinue = !v7000Scan1.IsContinue;
            label3.Text = v7000Scan1.IsContinue.ToString();
        }

        private void btnisVoice_Press(object sender, EventArgs e)
        {
            v7000Scan1.IsVoice = !v7000Scan1.IsVoice;
            label4.Text = v7000Scan1.IsVoice.ToString();
        }

        private void btnisVibator_Press(object sender, EventArgs e)
        {
            v7000Scan1.IsVibator = !v7000Scan1.IsVibator;
            label5.Text = v7000Scan1.IsVibator.ToString();
        }

        private void btnregisterKeyDown_Press(object sender, EventArgs e)
        {
            v7000Scan1.EnableTrigger();
        }

        private void btnunRegisterKeyDown_Press(object sender, EventArgs e)
        {
            v7000Scan1.DisableTrigger();
        }

        private void v7000Scan1_DataCaptured(object sender, V7000ScanEventArgs e)
        {
            label6.Text = e.Data;
        }

        private void v7000Scan1_OnNotify(object sender, ComponentResultArgs e)
        {
            if (e.isError == true)
            {
                MessageBox.Show(e.error);
            }
        }

        private void btnScan_Press(object sender, EventArgs e)
        {
            v7000Scan1.Scan();
        }
    }
}