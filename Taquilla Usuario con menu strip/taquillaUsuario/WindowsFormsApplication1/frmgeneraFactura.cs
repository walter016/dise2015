using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class frmgeneraFactura : Form
    {
        public frmgeneraFactura()
        {
            InitializeComponent();
        }

        private void frmgeneraFactura_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void pdf_factura()
        {
            // Creamos el documento con el tamaño de página tradicional
            Document doc = new Document(PageSize.LETTER);
            // Indicamos donde vamos a guardar el documento




            PdfWriter writer = PdfWriter.GetInstance(doc,
                                        new FileStream(@"E:\" + txtnombreFactura.Text + ".pdf", FileMode.Create));

            // Le colocamos el título y el autor
            doc.AddTitle("Facturas Cinema World");
            doc.AddCreator("Cinema World");

            // Abrimos el archivo
            doc.Open();

            // Creamos el tipo de Font que vamos utilizar
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            //Imagen
            iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(@"E:\Logo\logo2.jpg");

            jpg.Alignment = iTextSharp.text.Image.TOP_BORDER;

            //imagen
            // Escribimos el encabezamiento en el documento
            doc.Add(jpg);

            doc.Add(new Paragraph("FACTURA"));
            doc.Add(Chunk.NEWLINE);

            // Creamos una tabla que contendrá el nombre, apellido y país
            // de nuestros visitante.
            PdfPTable tblFactura = new PdfPTable(3);
            tblFactura.WidthPercentage = 100;

            // Configuramos el título de las columnas de la tabla
            PdfPCell clNombre = new PdfPCell(new Phrase("Nombre", _standardFont));
            clNombre.BorderWidth = 0;
            clNombre.BorderWidthBottom = 0.75f;

            PdfPCell clNit = new PdfPCell(new Phrase("nit", _standardFont));
            clNit.BorderWidth = 0;
            clNit.BorderWidthBottom = 0.75f;

            PdfPCell clTarjeta = new PdfPCell(new Phrase("No. Tarjeta", _standardFont));
            clTarjeta.BorderWidth = 0;
            clTarjeta.BorderWidthBottom = 0.75f;

            PdfPCell clPelicula = new PdfPCell(new Phrase("Pelicula", _standardFont));
            clPelicula.BorderWidth = 0;
            clPelicula.BorderWidthBottom = 0.75f;

            PdfPCell clSala = new PdfPCell(new Phrase("Sala", _standardFont));
            clSala.BorderWidth = 0;
            clSala.BorderWidthBottom = 0.75f;

            PdfPCell clAsiento = new PdfPCell(new Phrase("Asiento", _standardFont));
            clAsiento.BorderWidth = 0;
            clAsiento.BorderWidthBottom = 0.75f;

            PdfPCell cltotal = new PdfPCell(new Phrase("Total Factura", _standardFont));
            cltotal.BorderWidth = 0;
            cltotal.BorderWidthBottom = 0.75f;
 
            
            // Añadimos las celdas a la tabla
            tblFactura.AddCell(clNombre);
            tblFactura.AddCell(clNit);
            tblFactura.AddCell(clTarjeta);
            tblFactura.AddCell(clPelicula);
            tblFactura.AddCell(clSala);
            tblFactura.AddCell(clAsiento);
            tblFactura.AddCell(cltotal);

            // Llenamos la tabla con información
            clNombre = new PdfPCell(new Phrase(txtnombreFactura.Text, _standardFont));
            clNombre.BorderWidth = 0;

            clNit = new PdfPCell(new Phrase(txtfacturaNit.Text, _standardFont));
            clNit.BorderWidth = 0;

            clTarjeta = new PdfPCell(new Phrase(txtfacturaTarjeta.Text, _standardFont));
            clTarjeta.BorderWidth = 0;

            
            clPelicula  = new PdfPCell(new Phrase(txtfacturaPelicula .Text, _standardFont));
            clPelicula.BorderWidth = 0;

            clSala = new PdfPCell(new Phrase(txtfacturaSala.Text, _standardFont));
            clSala.BorderWidth = 0;

            clAsiento = new PdfPCell(new Phrase(txtfacturaAsientos.Text, _standardFont));
            clAsiento.BorderWidth = 0;

            
            cltotal  = new PdfPCell(new Phrase(txtfacturaTotal.Text, _standardFont));
            cltotal.BorderWidth = 0;



            // Añadimos las celdas a la tabla
            tblFactura.AddCell(clNombre);
            tblFactura.AddCell(clNit);
            tblFactura.AddCell(clTarjeta);
            tblFactura.AddCell(clPelicula);
            tblFactura.AddCell(clSala);
            tblFactura.AddCell(clAsiento);
            tblFactura.AddCell(cltotal);
            // Finalmente, añadimos la tabla al documento PDF y cerramos el documento
            doc.Add(tblFactura);

            doc.Close();
            writer.Close();

        }

                private void btnfacturaPagado_Click(object sender, EventArgs e)
        {
                     /*Configuración del Mensaje
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(txtfrom.Text);

            mail.To.Add(txtfrom.Text);
            mail.Subject = "Envio de factura";
            mail.Body = "Adjuntamos la copia de su factura";

            mail.IsBodyHtml = false;
            mail.Priority = MailPriority.High;
            
            
                
        SmtpClient SmtpServer = new SmtpClient("smtp.live.com");
                
              
            //mail.Attachments.Add(new Attachment(@"C:\Documentos\carta.docx"));

            //Configuracion del SMTP
        SmtpServer.Host = "smtp.live.com";   
        SmtpServer.Port = 25; 
        SmtpServer.Credentials = new System.Net.NetworkCredential("ultra143@hotmail.com", "password");
            SmtpServer.EnableSsl = true;

            try
            {
                SmtpServer.Send(mail);
                MessageBox.Show("Correo Enviado");
            }

            catch
            {

                MessageBox.Show("No se pudo enviar el correo");

            }
            mail.Dispose();   
        }


    */
            pdf_factura();
           
        }






        }
    }

