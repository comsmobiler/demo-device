using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using Smobiler.Device;

namespace PosPrinterTest
{
    partial class SmobilerForm1 : Smobiler.Core.Controls.MobileForm
    {
        public SmobilerForm1() : base()
        {
            InitializeComponent();
        }
        PosPrinterEntityCollection Commands1 = new PosPrinterEntityCollection();
        PosPrinterEntityCollection Commands2 = new PosPrinterEntityCollection();
        PosPrinterEntityCollection Commands3 = new PosPrinterEntityCollection();
        PosPrinterEntityCollection Commands4 = new PosPrinterEntityCollection();
        private void btnPrinter_Press(object sender, EventArgs e)
        {
            Commands1.Clear();
            Commands1.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.Initial));
            Commands1.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.Center));
            Commands1.Add(new PosPrinterContentEntity("这是我的店"));
            Commands1.Add(new PosPrinterContentEntity("Tel:0123 456 7890"));
            Commands1.Add(new PosPrinterContentEntity("Web: www.smobiler.com"));
            Commands1.Add(new PosPrinterContentEntity("sales@smobiler.com"));
            Commands1.Add(new PosPrinterContentEntity("Print No.:6361183623024359309"));
            Commands1.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.Left));
            Commands1.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.EnabledUnderline2));
            Commands1.Add(new PosPrinterContentEntity("_".PadRight(42, '_')));
            Commands1.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.DisabledUnderline));
            Commands1.Add(new PosPrinterContentEntity("Tea                                  T1   1.30"));
            Commands1.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.EnabledUnderline2));
            Commands1.Add(new PosPrinterContentEntity("______________________________________________"));
            Commands1.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.DisabledUnderline));
            Commands1.Add(new PosPrinterContentEntity("                                 Total:   1.30"));
            Commands1.Add(new PosPrinterContentEntity("                                              "));
            Commands1.Add(new PosPrinterContentEntity("                             Paid Card:   1.30"));
            Commands1.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.Center));
            Commands1.Add(new PosPrinterContentEntity("Thank You For Your Support!"));
            Commands1.Add(new PosPrinterContentEntity("                                              "));
            Commands1.Add(new PosPrinterContentEntity(System.Environment.NewLine));
            Commands1.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.Cut));

            posPrinter1.Print(Commands1, (obj, args) =>
            {
                if (args.isError == true)
                    this.Toast("Error: " + args.error);
                else
                    this.Toast("打印成功");
            }
            );
        }

        private void SmobilerForm1_Load(object sender, EventArgs e)
        {

            Commands3.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.Initial));
            Commands3.Add(new PosPrinterBarcodeEntity(PosBarcodeType.QRCODE, "1A115090109566C"));
            Commands3.Add(new PosPrinterContentEntity(System.Environment.NewLine));
            Commands3.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.Cut));
        }

        private void btnOnedimensionalcode_Press(object sender, EventArgs e)
        {

            Commands2.Clear();
            Commands2.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.Initial));
            Commands2.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.EnabledBarcode));
            Commands2.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.AbsoluteLocation));
            Commands2.Add(new PosPrinterBarcodeEntity(PosBarcodeType.CODE128Height, "62"));
            Commands2.Add(new PosPrinterBarcodeEntity(PosBarcodeType.CODE128, "6925303721367"));
            Commands2.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.DisabledBarcode));
            Commands2.Add(new PosPrinterContentEntity(System.Environment.NewLine));
            Commands2.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.Cut));

            posPrinter2.Print(Commands2, (obj, args) =>
            {
                if (args.isError == true)
                    this.Toast("Error: " + args.error);
                else
                    this.Toast("打印成功");
            }
          );
        }

        private void bbtnTwodimensionalcode_Press(object sender, EventArgs e)
        {

            posPrinter3.Print(Commands3, (obj, args) =>
            {
                if (args.isError == true)
                    this.Toast("Error: " + args.error);
                else
                    this.Toast("打印成功");
            }
          );
        }

        private void btncloseblackmark_Press(object sender, EventArgs e)
        {
            Commands1.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.Turnoffblackmark));
            Commands2.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.Turnoffblackmark));
            Commands3.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.Turnoffblackmark));
        }

        private void btnopenblackmark_Press(object sender, EventArgs e)
        {
            Commands1.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.Turnonblackmark));
            Commands2.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.Turnonblackmark));
            Commands3.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.Turnonblackmark));
        }

        private void btnSamplelabel_Press(object sender, EventArgs e)
        {
            Commands4.Clear();
            Commands4.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.Initial));
            Commands4.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.LeftMargin));
            Commands4.Add(new PosPrinterBarcodeEntity(PosBarcodeType.CODE128Height, "62"));
            Commands4.Add(new PosPrinterBarcodeEntity(PosBarcodeType.CODE128, "2102315687895200"));
            Commands4.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.LeftMargin0));
            Commands4.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.Left));
            Commands4.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.Size2));
            Commands4.Add(new PosPrinterContentEntity("标准快递" + System.Environment.NewLine));
            Commands4.Add(new PosPrinterContentEntity("2018-3-1 14：30：00" + System.Environment.NewLine));
            Commands4.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.Size1));
            Commands4.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.EnabledUnderline2));
            Commands4.Add(new PosPrinterContentEntity("___________________________________________" + System.Environment.NewLine));
            Commands4.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.DisabledUnderline));
            Commands4.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.Left));
            Commands4.Add(new PosPrinterContentEntity("寄件人：乐标                  邮编：201600" + System.Environment.NewLine));
            Commands4.Add(new PosPrinterContentEntity("地址：上海市松江区茸北路" + System.Environment.NewLine));
            Commands4.Add(new PosPrinterContentEntity("计费重量（KG）：1          保价金额：500元" + System.Environment.NewLine));
            Commands4.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.EnabledUnderline2));
            Commands4.Add(new PosPrinterContentEntity("___________________________________________" + System.Environment.NewLine));
            Commands4.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.DisabledUnderline));
            Commands4.Add(new PosPrinterContentEntity("收件人：李四通                邮编：910000" + System.Environment.NewLine));
            Commands4.Add(new PosPrinterContentEntity("收件人签名：     收件时间：  年  月  日  时" + System.Environment.NewLine));
            Commands4.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.EnabledUnderline2));
            Commands4.Add(new PosPrinterContentEntity("___________________________________________" + System.Environment.NewLine));
            Commands4.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.DisabledUnderline));
            Commands4.Add(new PosPrinterContentEntity("                                           " + System.Environment.NewLine));
            Commands4.Add(new PosPrinterContentEntity("订单ID:"));
            Commands4.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.LeftMargin));
            Commands4.Add(new PosPrinterBarcodeEntity(PosBarcodeType.CODE128Height, "40"));
            Commands4.Add(new PosPrinterBarcodeEntity(PosBarcodeType.CODE128, "911"));
            Commands4.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.LeftMargin0));

            Commands4.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.DisabledUnderline));
            Commands4.Add(new PosPrinterContentEntity("                                           " + System.Environment.NewLine));
            Commands4.Add(new PosPrinterBarcodeEntity(PosBarcodeType.CODE128Height, "120"));
            Commands4.Add(new PosPrinterBarcodeEntity(PosBarcodeType.CODE128, "2102315687895200"));
            Commands4.Add(new PosPrinterContentEntity(System.Environment.NewLine));
            Commands4.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.Cut));

            posPrinter4.Print(Commands4, (obj, args) =>
            {
                if (args.isError == true)
                    this.Toast("Error: " + args.error);
                else
                    this.Toast("打印成功");
            }
            );
        }


        private void btnSteptoblackmark_Press(object sender, EventArgs e)
        {
            PosPrinterEntityCollection Commands1 = new PosPrinterEntityCollection();
            Commands1.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.Initial));
            Commands1.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.Turnonblackmark));
            //Commands1.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.Center));
            //Commands1.Add(new PosPrinterBarcodeEntity(PosBarcodeType.QRCODE, "6925303721367"));
            //Commands1.Add(new PosPrinterContentEntity("产品名称：" + "aaaaaa" + System.Environment.NewLine));
            //Commands1.Add(new PosPrinterContentEntity("产品编码：" + "aaaaaa" + System.Environment.NewLine));
            // Commands1.Add(new PosPrinterContentEntity("规格：" + "aaaaaa" + System.Environment.NewLine));
            Commands1.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.Steptoblackmark));
            //Commands1.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.Turnoffblackmark));
            posPrinter1.Print(Commands1, (obj, args) =>
            {
                if (args.isError == true)
                    this.Toast("Error: " + args.error);
                else
                    this.Toast("打印成功");
            });
        }
    }
}