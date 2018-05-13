using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Using necesarios para este proyecto
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System.IO;
using System.Drawing.Imaging;


namespace GenerarQR
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void GenerarCodigoQR()
        {
            string texto = this.tb_texto.Text.Trim();
            //si el text box no tiene valores nulos ni esta limpio
            if (!string.IsNullOrEmpty(texto))
            {
                QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
                QrCode qrCode = new QrCode();
                try
                {
                    //tratamos de convertir el texto en codigo qr
                    qrEncoder.TryEncode(texto, out qrCode);
                    GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.FloralWhite);
                    MemoryStream ms = new MemoryStream();
                    renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
                    var imagen_temporal = new Bitmap(ms);
                    var imagen = new Bitmap(imagen_temporal, new Size(new Point(200, 200)));
                    pn_generador.BackgroundImage = imagen_temporal;
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                GC.Collect();
            }
            else
            {
                MessageBox.Show("Escribe algo flojo :v", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_texto.Focus();
            }
        }

        private void btn_generar_qr_Click(object sender, EventArgs e)
        {
            //llamamos al metodo encargado de generar el codigo QR
            GenerarCodigoQR();
        }
    }
}
