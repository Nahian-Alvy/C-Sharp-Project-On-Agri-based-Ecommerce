using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Project2
{
    public partial class Card : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        public Card()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void datainsert()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into Revenue (Amount) values (@Amount)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Amount", textBox1.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                

                
                
                
                    if (MessageBox.Show("Payment Successful Do you want to download Receipt?", "Payement", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        printpdf();
                        datainsert();

                        MessageBox.Show("Receipt Downloaded Successfully");
                    }


                
               
            }
            else
            {
                MessageBox.Show("Please Enter Information", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void printpdf()
        {
            try
            {
                // Step 1: Retrieve data from the database (replace with your data retrieval code)
                SqlConnection con = new SqlConnection(cs);
                string query = "select * from Cart";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);

                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                string outputPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PaymentSlip2.pdf");
                var random = new Random();
                int s = random.Next();
                // Step 2: Create a new PDF document
                Document document = new Document();
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream("E:\\4V\\Last\\Last\\Payslip\\Payslip2.pdf", FileMode.Create));
                document.Open();
                iTextSharp.text.Font p1 = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 13, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.RED);
                iTextSharp.text.Font p2 = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 20, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.RED);
                iTextSharp.text.Font p3 = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 20, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.GREEN);
                Paragraph paragraph0 = new Paragraph("Agri For All", p3);
                paragraph0.Alignment = Element.ALIGN_CENTER;
                document.Add(paragraph0);
                Paragraph paragraph = new Paragraph("Invoice ID: " + s, p1);
                paragraph.Alignment = Element.ALIGN_LEFT;
                document.Add(paragraph);

                // Step 3: Add data from DataTable to the PDF
                PdfPTable pdfTable = new PdfPTable(dataTable.Columns.Count);
                foreach (DataColumn column in dataTable.Columns)
                {
                    pdfTable.AddCell(column.ColumnName);
                }
                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (object item in row.ItemArray)
                    {
                        pdfTable.AddCell(item.ToString());
                    }
                }
                pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
                document.Add(pdfTable);
                Paragraph paragraph2 = new Paragraph("Total Paid :" + textBox3.Text, p2);
                paragraph2.Alignment = Element.ALIGN_CENTER;
                document.Add(paragraph2);
                Paragraph paragraph3 = new Paragraph("******Paid by Card******", p2);
                paragraph3.Alignment = Element.ALIGN_CENTER;
                document.Add(paragraph3);

                document.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Card_Load(object sender, EventArgs e)
        {

        }
    }
}
