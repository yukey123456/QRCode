using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetQRCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnSaveBmp.Enabled = false;
        }

        private void btnLayMa_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
            QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(txtID.Text, QRCodeGenerator.ECCLevel.Q);
            ////QRCodeGenerator.ECCLevel.Q là mức chịu lỗi 25%; .L là 7%; .M là 15% và .H là trên 25%
            QRCode qRCode = new QRCode(qRCodeData);
            Image qRCodeImage = qRCode.GetGraphic(20, Color.Black, Color.White, true);
            pbQr.Image = qRCodeImage;
            btnSaveBmp.Enabled = true;

            //Anh nhan dep trai sieu cap vo dich
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSaveBmp_Click(object sender, EventArgs e)
        {
            pbQr.Image.Save(@"C:\Users\Windows 10\Desktop\QRCODE.Bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            MessageBox.Show("QRCODE has been saved !");
        }
    }
}
