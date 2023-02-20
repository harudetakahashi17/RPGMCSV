using CsvHelper;
using RPGM_CSV_Converter.Models;
using System.Globalization;
using Newtonsoft.Json;
using System.Text;

namespace RPGM_CSV_Converter
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OpenFileCSV_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileCSV.ShowDialog();
            if(!string.IsNullOrEmpty(OpenFileCSV.FileName))
            {
                tbFileName.Text = OpenFileCSV.FileName;
            }
        }

        private void tbFileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OutputDir.ShowDialog();
            if (!string.IsNullOrEmpty(OutputDir.SelectedPath))
            {
                tbOutputDir.Text = OutputDir.SelectedPath;
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            var errMsg = string.Empty;
            List<string> TypeOptions = new List<string>() { "Armors", "Classes", "Enemies", "Items", "Skills", "Types", "Weapons" };

            #region Input Validation
            if (string.IsNullOrEmpty(tbFileName.Text))
            {
                errMsg += "Please select the CSV file.\n";
            }
            else
            {
                bool isCsvFile = CheckFileType(tbFileName.Text);
                if (!isCsvFile)
                {
                    errMsg += "Invalid filetype. Please select CSV file.\n";
                }
            }

            if (string.IsNullOrEmpty(cbType.Text))
            {
                errMsg += "Please select the output type.\n";
            }
            else
            {
                if(!TypeOptions.Contains(cbType.Text))
                {
                    errMsg += "Please select the output type.\n";
                }
            }

            if (string.IsNullOrEmpty(tbOutputDir.Text))
            {
                errMsg += "Please select the output directory.\n";
            }
            else
            {
                if(!Directory.Exists(tbOutputDir.Text))
                {
                    string message = "Do you want to create new directory?";
                    string title = "Alert!";
                    MessageBoxButtons confirmation = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, confirmation, MessageBoxIcon.Warning);
                    if(result == DialogResult.Yes)
                    {
                        try
                        {
                            Directory.CreateDirectory(tbOutputDir.Text);
                        }
                        catch(Exception ex)
                        {
                            errMsg += ex.Message;
                        }
                    }
                    else
                    {
                        errMsg += "Directory not found";
                    }
                }
            }
            #endregion

            if (string.IsNullOrEmpty(errMsg))
            {
                string warnText = "All files related with type option will be placed!\n";
                tbInformation.Text = warnText + "Processing...\n";
                try
                {
                    string outputFilename = cbType.Text + ".json";
                    if (cbType.Text.ToUpper() == "CLASSES")
                    {
                        using (var reader = new StreamReader(tbFileName.Text))
                        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                        {
                            var records = csv.GetRecords<ClassesDomain>().ToList();
                            if (records == null)
                            {
                                errMsg += "Unable to get data.\n";
                            }
                            else if (records.Count == 0)
                            {
                                errMsg += "Table is empty.\n";
                            }
                            else
                            {
                                int idx = 1;
                                List<object?> result = new List<object?>() { null };
                                foreach (var record in records)
                                {
                                    List<int> MHP = ClassParamGenerator(record.MinHP, record.MaxHP);
                                    List<int> MMP = ClassParamGenerator(record.MinMP, record.MaxMP);
                                    List<int> ATK = ClassParamGenerator(record.MinAtk, record.MaxAtk);
                                    List<int> DEF = ClassParamGenerator(record.MinDef, record.MaxDef);
                                    List<int> MATK = ClassParamGenerator(record.MinMAtk, record.MaxMAtk);
                                    List<int> MDEF = ClassParamGenerator(record.MinMDef, record.MaxMDef);
                                    List<int> AGI = ClassParamGenerator(record.MinAgi, record.MaxAgi);
                                    List<int> LUK = ClassParamGenerator(record.MinLuk, record.MaxLuk);

                                    object classObj = new
                                    {
                                        id = idx,
                                        expParams = new List<int>() { record.ExpBaseValue, record.ExpExtraValue, record.ExpAccel1, record.ExpAccel2 },
                                        traits = new List<object>(),
                                        learnings = new List<object>(),
                                        name = record.Name,
                                        note = record.Note,
                                        Params = new List<List<int>>() { MHP, MMP, ATK, DEF, MATK, MDEF, AGI, LUK }
                                    };
                                    result.Add(classObj);
                                }

                                var serializedResult = JsonConvert.SerializeObject(result);
                                serializedResult = serializedResult.Replace("\"Params\"", "\"params\"");

                                using (var fs = File.Create(Path.Combine(tbOutputDir.Text, outputFilename)))
                                {
                                    byte[] data = new UTF8Encoding(true).GetBytes(serializedResult);
                                    fs.Write(data, 0, data.Length);
                                }
                                tbInformation.ForeColor = Color.Green;
                                tbInformation.Text += "Processing Complete. Your file in " + Path.Combine(tbOutputDir.Text, outputFilename);
                            }
                        }
                    }
                    else if (cbType.Text.ToUpper() == "SKILLS")
                    {
                        using (var reader = new StreamReader(tbFileName.Text))
                        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                        {
                            var records = csv.GetRecords<SkillsDomain>().ToList();
                            if (records == null)
                            {
                                errMsg += "Unable to get data.\n";
                            }
                            else if (records.Count == 0)
                            {
                                errMsg += "Table is empty.\n";
                            }
                            else
                            {
                                int idx = 1;
                                List<object?> result = new List<object?>() { null };
                                foreach (var record in records)
                                {
                                    object classObj = new
                                    {
                                        id = idx,
                                        animationId = 0,
                                        damage = new
                                        {
                                            critical = false,
                                            elementId = 0,
                                            formula = "0",
                                            type = 0,
                                            variance = 0
                                        },
                                        description = record.Description,
                                        effect = new List<object>(),
                                        hitType = 0,
                                        iconIndex = 0,
                                        message1 = record.Message1,
                                        message2 = record.Message2,
                                        mpCost = record.MPCost,
                                        name = record.Name,
                                        note = record.Note,
                                        occasion = 0,
                                        repeats = record.Repeat,
                                        requiredWtypeId1 = 0,
                                        requiredWtypeId2 = 0,
                                        scope = 0,
                                        speed = record.Speed,
                                        stypeId = 1,
                                        successRate = record.SuccessRate,
                                        tpCost = record.TPCost,
                                        tpGain = record.TPGain,
                                        messageType = 1
                                    };
                                    result.Add(classObj);
                                }

                                var serializedResult = JsonConvert.SerializeObject(result);

                                using (var fs = File.Create(Path.Combine(tbOutputDir.Text, outputFilename)))
                                {
                                    byte[] data = new UTF8Encoding(true).GetBytes(serializedResult);
                                    fs.Write(data, 0, data.Length);
                                }
                                tbInformation.ForeColor = Color.Green;
                                tbInformation.Text += "Processing Complete. Your file in " + Path.Combine(tbOutputDir.Text, outputFilename);
                            }
                        }
                    }
                    else if (cbType.Text.ToUpper() == "ITEMS")
                    {
                        using (var reader = new StreamReader(tbFileName.Text))
                        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                        {
                            var records = csv.GetRecords<ItemsDomain>().ToList();
                            if (records == null)
                            {
                                errMsg += "Unable to get data.\n";
                            }
                            else if (records.Count == 0)
                            {
                                errMsg += "Table is empty.\n";
                            }
                            else
                            {
                                int idx = 1;
                                List<object?> result = new List<object?>() { null };
                                foreach (var record in records)
                                {
                                    object classObj = new
                                    {
                                        id = idx,
                                        animationId = 0,
                                        consumable = record.Consumable,
                                        damage = new
                                        {
                                            critical = false,
                                            elementId = 0,
                                            formula = "0",
                                            type = 0,
                                            variance = 0
                                        },
                                        description = record.Description,
                                        effect = new List<object>(),
                                        hitType = 0,
                                        iconIndex = 0,
                                        itypeId = record.ItemTypeId,
                                        name = record.Name,
                                        note = record.Note,
                                        occasion = 0,
                                        price = record.Price,
                                        repeats = record.Repeat,
                                        scope = 0,
                                        speed = record.Speed,
                                        successRate = record.SuccessRate,
                                        tpGain = record.TPGain,
                                    };
                                    result.Add(classObj);
                                }

                                var serializedResult = JsonConvert.SerializeObject(result);

                                using (var fs = File.Create(Path.Combine(tbOutputDir.Text, outputFilename)))
                                {
                                    byte[] data = new UTF8Encoding(true).GetBytes(serializedResult);
                                    fs.Write(data, 0, data.Length);
                                }
                                tbInformation.ForeColor = Color.Green;
                                tbInformation.Text += "Processing Complete. Your file in " + Path.Combine(tbOutputDir.Text, outputFilename);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    string logDir = tbOutputDir.Text + "\\errLogs\\";
                    string logName = DateTime.Now.ToString("yyyyMMddHHmmss") + " Error.log";
                    if (!Directory.Exists(logDir))
                    {
                        Directory.CreateDirectory(logDir);
                    }
                    string filepath = logDir + logName;
                    using (var lf = File.Create(filepath))
                    {
                        byte[] err = new UTF8Encoding(true).GetBytes("Type: " + ex.Message);
                        lf.Write(err, 0, err.Length);
                    }

                    tbInformation.ForeColor = Color.Red;
                    tbInformation.Text = "Unexpected error has been recorded to " + Path.Combine(logDir, logName) + "\n";
                }
            }
            else
            {
                tbInformation.Text = errMsg;
            }
        }

        #region Internal Method
        private bool CheckFileType(string filepath)
        {
            string ext = Path.GetExtension(filepath);
            if (ext == ".csv")
                return true;
            else
                return false;
        }
        private List<int> ClassParamGenerator(int minVal, int maxVal)
        {
            List<int> result = new List<int>();
            for(var i = 1; i < 100; i++)
            {
                double rate = 0;
                var formulaCalc = Convert.ToDecimal(minVal + Math.Floor((1-rate) * Math.Ceiling((maxVal-minVal) * (i-1)/98.0) + rate * Math.Ceiling((maxVal - minVal) * Math.Pow((i - 1) / 98.0, 2))));
                int res = Convert.ToInt32(formulaCalc);
                result.Add(res);
            }
            return result;
        }
        #endregion
    }
}