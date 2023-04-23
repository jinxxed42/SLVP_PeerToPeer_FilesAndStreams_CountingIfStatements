using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace SLVP_PeerToPeer_FilesAndStreams_CountingIfStatements
{
    public partial class IfLineFinderForm : Form
    {
        private List<IfLine> _ifLines = new List<IfLine>();

        private int _count;

        private bool _saveToFileErrorShown = false;

        private Action<IfLine> _ifLineFound;

        public IfLineFinderForm()
        {
            InitializeComponent();
            _ifLineFound = AddIfLine;
        }

        // Handles clicks on the Check button.
        private void BtnFile_Click(object sender, EventArgs e)
        {
            _ifLines.Clear();
            _count = 0;
            _saveToFileErrorShown = false;
            LblCountText.Text = _count.ToString();
            string file = TbFile.Text;
            if (File.Exists(file))
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    string loadedString = sr.ReadToEnd();
                    IfLineFinder.FindIfLine(loadedString, _ifLineFound);
                }

            }
            else
            {
                MessageBox.Show("The file wasn't found. Make sure to enter the correct path.");
            }
        }

        // Adds found IfLines to the DataGridView and updates the count.
        public void AddIfLine(IfLine ifLine)
        {
            _ifLines.Add(ifLine);
            _count++;
            LblCountText.Text = _count.ToString();
            DgvUpdate();
        }

        // Allows for saving the results to a specified file if enabled.
        public void AddIfLineToFile(IfLine ifLine)
        {
            string file = TbSaveFile.Text;
            try
            {
                if (!File.Exists(file))
                {
                    File.Create(file).Close();
                }
                using (FileStream fs = new FileStream(file, FileMode.Append, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(ifLine.LineNumber + " - " + ifLine.LineText);
                    }
                }
            }
            catch (Exception ex)
            {
                if (!_saveToFileErrorShown)
                {
                    MessageBox.Show($"Error saving to file!\n\n{ex.Message}\n\nPlease make sure you have permission to save in the specified location.");
                    _saveToFileErrorShown = true;
                }
            }

        }

        // Outputs results to debug window if enabled.
        public void AddIfLineToDebug(IfLine ifLine)
        {
            System.Diagnostics.Debug.WriteLine(ifLine.LineNumber + " - " + ifLine.LineText);
        }


        // Updating the DataGridView.
        public void DgvUpdate()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = _ifLines;
            Dgv.DataSource = bs;
            Dgv.Columns[0].HeaderText = "Line #";
            Dgv.Columns[1].HeaderText = "Text";
            Dgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        // Add the AddIfLineToDebug method to the delegate if the box is checked. Or remove it unchecked.
        private void ChbDebug_CheckedChanged(object sender, EventArgs e)
        {
            if (ChbDebug.Checked)
            {
                _ifLineFound += AddIfLineToDebug;
            }
            else
            {
#pragma warning disable 8601
                _ifLineFound -= AddIfLineToDebug; // The event would always be added here. But even if it wasn't added it
#pragma warning restore 8601                      // would not cause an exception so warning disabled.
            }
        }

        // Add the AddIfLineToFile method to the delegate if the box is checked. Or remove it unchecked.
        private void ChbSaveFile_CheckedChanged(object sender, EventArgs e)
        {
            if (ChbSaveFile.Checked)
            {
                _ifLineFound += AddIfLineToFile;
            }
            else
            {
#pragma warning disable 8601
                _ifLineFound -= AddIfLineToFile; // The event would always be added here. But even if it wasn't added it
#pragma warning restore 8601                     // would not cause an exception so warning disabled.
            }
        }
    }
}