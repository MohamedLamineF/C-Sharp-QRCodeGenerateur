using IronBarCode;
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

namespace QRCodeGenerateur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnGen.Enabled = false;
            pictureBox1.Image = QRCodeGenerateur.Properties.Resources.qrCode;
            barCodeImg.Image = QRCodeGenerateur.Properties.Resources.barCode;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            var MyData = QG.CreateQrCode(generatedText.Text, QRCoder.QRCodeGenerator.ECCLevel.H, true,true, QRCoder.QRCodeGenerator.EciMode.Utf8);
            var code = new QRCoder.QRCode(MyData);
            pictureBox1.Image = code.GetGraphic(50);

            var barCode = BarcodeWriter.CreateBarcode(generatedText.Text, BarcodeEncoding.Code128);
            barCodeImg.Image = barCode.Image;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void eccMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void generatedText_TextChanged(object sender, EventArgs e)
        {
            if(generatedText.Text.Length > 0)
            {
                btnGen.Enabled=true;
            }
            else
            {
                btnGen.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "JPG(*.JPG)|*.jpg";

            if (sf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(sf.FileName);
            }
        }

        private void saveBar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "JPG(*.JPG)|*.jpg";

            if (sf.ShowDialog() == DialogResult.OK)
            {
                barCodeImg.Image.Save(sf.FileName);
            }
        }
    }
}
