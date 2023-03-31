using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;


namespace winformQRFW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Bitmap GenerateQRCode(string text)
        {
            var writer = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new ZXing.Common.EncodingOptions
                {
                    Height = pictureBox1.Height,
                    Width = pictureBox1.Width
                }
            };
            var barcodeBitmap = writer.Write(text);
            return barcodeBitmap;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var text = txtTextToEncode.Text;
            var barcodeBitmap = GenerateQRCode(text);
            pictureBox1.Image = barcodeBitmap;
        }

    }
}
