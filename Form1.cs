using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System.Globalization;
using static System.Windows.Forms.DataFormats;

namespace CSVConverter
{
    [Serializable]
    public class BankData
    {
        [Name("Date (MM/DD/YYYY)")]
        public required string Date { get; set; }

        [Name("Payer/Payee Name")]
        public required string Name { get; set; }
        [Name("Transaction Id")]
        public required string TransID { get; set; }
        [Name("Transaction Type")]
        public required string TransType { get; set; }
        [Name("Amount")]
        public required string Amount { get; set; }
        [Name("Memo")]
        public required string Memo { get; set; }
        [Name("NS Internal Customer Id")]
        public required string NS_CID { get; set; }
        [Name("NS Customer Name")]
        public required string NS_Name { get; set; }
        [Name("Invoice Number(s)")]
        public required string Invoice_Number { get; set; }
    }

    public class BankDataMap : ClassMap<BankData>
    {
        public BankDataMap()
        {
            Map(m => m.Date).Name("Value Date");
            //Map(m => m.Name).Name("Payer/Payee Name");
            //Map(m => m.TransID).Name("Transaction Id");
            Map(m => m.TransType).Name("Amount Indicator");
            Map(m => m.Amount).Name("Amount");
            Map(m => m.Memo).Name("Transaction Description");
            //Map(m => m.Invoice_Number).Name("Invoice Number(s)");
        }
    }

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var file_location = File_Label.Text;

            using (var reader = new StreamReader(file_location))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<BankDataMap>();
                var records = csv.GetRecords<BankData>().ToList();

                // Update the Date field to the formatted version
                foreach (var record in records)
                {
                    record.Date = DateTime.ParseExact(record.Date, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy");
                    record.TransType = record.TransType == "CR" ? "Credit" : (record.TransType == "DR" ?"Debit" : "Other");
                    record.Amount = record.TransType == "Credit" ? record.Amount : "-" + record.Amount;
                }

                var file_directory = Path.GetDirectoryName(file_location);
                var file_name = Path.GetFileNameWithoutExtension(file_location);
                var new_file_location = Path.Combine(file_directory, file_name + "_Netsuite.csv");

                using (var writer = new StreamWriter(new_file_location))
                using (var csvw = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvw.WriteRecords(records);
                    Output_Label.Text = "File written at: " + new_file_location;
                }
            }
        }

        private void File_Label_Click(object sender, EventArgs e)
        {
            Browse_Files(sender, e);
        }

        private void File_Select_Click(object sender, EventArgs e)
        {
            Browse_Files(sender, e);
        }

        private void Browse_Files(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                openFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                //    //Read the contents of the file into a stream
                //    var fileStream = openFileDialog.OpenFile();

                //    using (StreamReader reader = new StreamReader(fileStream))
                //    {
                //        fileContent = reader.ReadToEnd();
                //    }
                }
            }
            Set_Label_Text(filePath);
            //MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Set_Label_Text(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                 File_Label.Text = text;
            }
        }
    }
}
