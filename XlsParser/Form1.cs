using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqToExcel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace XlsParser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //quick program to parse some excel data to pdf

        private void parse_xls_btn_Click(object sender, EventArgs e)
        {
            this.openFileDialogXls.FileName = "*.xls";
            if (this.openFileDialogXls.ShowDialog() == DialogResult.OK)
            {
                var excel = new ExcelQueryFactory(openFileDialogXls.FileName);
                var people = from c in excel.Worksheet("k")
                             //where c["Person"] == "Anders Krog"
                             select c;


                //create PDF
                Document doc = new Document(iTextSharp.text.PageSize.A4, 58, 58, 108, 10);

                var output = new FileStream("brevhoved pdf.pdf", FileMode.Create);
                var writer = PdfWriter.GetInstance(doc, output);

                doc.Open();

                int page_counter = 0;

                foreach (var row in people)
                {
                    if (row["Person"] != "" && row["Postnr og By"] != "" && row["Adresse"] != "")
                    {
                        if (page_counter > 0)
                        {
                            doc.NewPage();
                        }
                        string name = row["Person"];
                        string city = row["Postnr og By"];
                        string address = row["Adresse"];

                        doc.Add(new Phrase(name));
                        doc.Add(new Phrase(Environment.NewLine));
                        doc.Add(new Phrase(address));
                        doc.Add(new Phrase(Environment.NewLine));
                        doc.Add(new Phrase(city));

                        page_counter++;


                    }
                }
                doc.Close();
                System.Diagnostics.Process.Start("brevhoved pdf.pdf");
                Application.Exit();
            }
        }
    }
}
