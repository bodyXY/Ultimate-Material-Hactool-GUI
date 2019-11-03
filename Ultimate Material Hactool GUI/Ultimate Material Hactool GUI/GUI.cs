using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading;

namespace Ultimate_Material_Hactool_GUI
{
    public partial class GUI_Main : MaterialForm
    {
        Hactoolstarter Hactool;
        Hactoolstarter Killprocess;

        public GUI_Main()
        {
            InitializeComponent();
             
            Hactool = new Hactoolstarter();
            Killprocess = new Hactoolstarter();
            
            //FORM DESIGNER (MaterialSkin)
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red100, TextShade.WHITE);
        }



        //INPUT/OUTPUT SECTION



        //NSP

        //INPUT NSP
        private void NspInButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog NspInBrowse = new OpenFileDialog
            {
                Title = "Browse for NSP file",
                Filter = "NSP Files (*.nsp*)|*.nsp*",
                FilterIndex = 1
            };

            if (NspInBrowse.ShowDialog() == DialogResult.OK)
                NspInTextbox.Text = NspInBrowse.FileName;
        }

        //OUTPUT NSP
        private void NspOutButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog NspOutBrowse = new FolderBrowserDialog
            {
                SelectedPath = Application.StartupPath,
                Description = "Select NSP output folder"
            };

            if (NspOutBrowse.ShowDialog() == DialogResult.OK)
            {
                NspOutTextbox.Text = NspOutBrowse.SelectedPath;
            }
        }

        //INPUT SWITCH-KEYS
        private void KeysButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog KeysIn = new OpenFileDialog
            {
                Title = "Browse for Keys file",
                Filter = "Keys Files (*.txt, *.dat)|*.txt;*.dat",
                FilterIndex = 1
            };

            if (KeysIn.ShowDialog() == DialogResult.OK)
            {
                NspKeysTextbox.Text = KeysIn.FileName;
            }
        }



        //NCA

        //INPUT NCA
        private void NcaInBrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog NcaInBrowse = new OpenFileDialog
            {
                Title = "Browse for NCA file",
                Filter = "NCA Files (*.nca*)|*.nca*",
                FilterIndex = 1
            };

            if (NcaInBrowse.ShowDialog() == DialogResult.OK)
            {
                NcaInTextbox.Text = NcaInBrowse.FileName;
            }
        }

        //OUTPUT NCA
        private void NcaOutBrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog NcaOutBrowse = new FolderBrowserDialog
            {
                SelectedPath = Application.StartupPath,
                Description = "Select NCA output folder"
            };

            if (NcaOutBrowse.ShowDialog() == DialogResult.OK)
            {
                NcaOutTextbox.Text = NcaOutBrowse.SelectedPath;
            }
        }

        //INPUT SWITCH-KEYS
        private void NcaKeysBrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog NcaKeysIn = new OpenFileDialog
            {
                Title = "Browse for Keys file",
                Filter = "Keys Files (*.txt, *.dat)|*.txt;*.dat",
                FilterIndex = 1
            };

            if (NcaKeysIn.ShowDialog() == DialogResult.OK)
            {
                NcaKeysTextbox.Text = NcaKeysIn.FileName;
            }
        }



        //XCI

        //INPUT XCI
        private void XciInBrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog XciInBrowse = new OpenFileDialog
            {
                Title = "Browse for XCI file",
                Filter = "XCI Files (*.xci*)|*.xci*",
                FilterIndex = 1
            };

            if (XciInBrowse.ShowDialog() == DialogResult.OK)
            {
                XciInTextbox.Text = XciInBrowse.FileName;
            }
        }

        //OUPUT XCI
        private void XciOutBrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog XciOutBrowse = new FolderBrowserDialog
            {
                SelectedPath = Application.StartupPath,
                Description = "Select XCI output folder"
            };

            if (XciOutBrowse.ShowDialog() == DialogResult.OK)
            {
                XciOutTextbox.Text = XciOutBrowse.SelectedPath;
            }
        }

        //INPUT SWITCH-KEYS
        private void XciKeysBrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog XciKeysIn = new OpenFileDialog
            {
                Title = "Browse for Keys file",
                Filter = "Keys Files (*.txt, *.dat)|*.txt;*.dat",
                FilterIndex = 1
            };

            if (XciKeysIn.ShowDialog() == DialogResult.OK)
            {
                XciKeysTextbox.Text = XciKeysIn.FileName;
            }
        }



        //RomFS

        //INPUT ROMFS
        private void RomFSInButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog romFSInBrowse = new OpenFileDialog
            {
                Title = "Browse for romFS file",
                Filter = "romFS Files (*.romfs, *.istorage)|*.romfs;*.istorage",
                FilterIndex = 1
            };

            if (romFSInBrowse.ShowDialog() == DialogResult.OK)
            {
                romFSInTextbox.Text = romFSInBrowse.FileName;
            }
        }

        //OUT PUT ROMFS
        private void RomFSOutButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog romFSOutBrowse = new FolderBrowserDialog
            {
                SelectedPath = Application.StartupPath,
                Description = "Select romFS output folder"
            };

            if (romFSOutBrowse.ShowDialog() == DialogResult.OK)
            {
                romFSOutTextbox.Text = romFSOutBrowse.SelectedPath;
            }
        }

        //INPUT SWITCH-KEYS
        private void RomFSKeysButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog romFSKeysIn = new OpenFileDialog
            {
                Title = "Browse for Keys file",
                Filter = "Keys Files (*.txt, *.dat)|*.txt;*.dat",
                FilterIndex = 1
            };

            if (romFSKeysIn.ShowDialog() == DialogResult.OK)
            {
                romFSKeysTextbox.Text = romFSKeysIn.FileName;
            }
        }



        //EXTRACT SECTION



        //NSP EXTRACTING

        private void NspExtractButton_Click(object sender, EventArgs e)
        {
            //CHECK CORRECT NSP PATH
            if (NspInTextbox.Text == string.Empty)
            {
                MessageBox.Show("Invalid NSP path!", "Error.", MessageBoxButtons.OK);
                return;
            }
            //CHECK CORRECT OUTPUT PATH
            else if (NspOutTextbox.Text == string.Empty)
            {
                MessageBox.Show("Invalid NSP output path!", "Error.", MessageBoxButtons.OK);
                return;
            }

            else
            {
                ProcessHelper();

                //HACTOOL COMMAND TO EXTRACT NSP
                Hactool.RunCommand($" --keyset \"{NspKeysTextbox.Text}\" -t pfs0 \"{NspInTextbox.Text}\" --outdir=\"{NspOutTextbox.Text}\"");
            }
        }


        //NCA EXTRACTING

        private void NcaExtractButton_Click(object sender, EventArgs e)
        {
            //CHECK CORRECT NCA PATH
            if (NcaInTextbox.Text == string.Empty)
            {
                MessageBox.Show("Invalid NCA path!", "Error.", MessageBoxButtons.OK);
                return;
            }

            //CHECK CORRECT OUTPUT PATH
            else if (NcaOutTextbox.Text == string.Empty)
            {
                MessageBox.Show("Invalid NCA output path!", "Error.", MessageBoxButtons.OK);
                return;
            }

            //CHECK CORRECT TITLE-KEY
            else if (NcaTitleKeyTextbox.Text != string.Empty)
            {
                if (NcaTitleKeyTextbox.Text.Length > 32 || NcaTitleKeyTextbox.Text.Length < 32)
                {
                    MessageBox.Show("Invalid title-key!", "Error.", MessageBoxButtons.OK);
                    return;
                }
            }
            
            if (NcaTitleKeyTextbox.Text != string.Empty)
            {
                ProcessHelper();

                //HACTOOL COMMAND TO EXTRACT NCA WITHOUT TITLE-KEY
                Hactool.RunCommand($"--keyset \"{NcaKeysTextbox.Text}\" --titlekey={NcaTitleKeyTextbox.Text} \"{NcaInTextbox.Text}\" --section0dir=\"{NcaOutTextbox.Text}/exefs\" --romfsdir=\"{NcaOutTextbox.Text}/romfs\"");
            }
            else
            {
                ProcessHelper();

                //HACTOOL COMMAND TO EXTRACT NCA WITH TITLE-KEY
                Hactool.RunCommand($" \"{NcaInTextbox.Text}\" --keyset \"{NcaKeysTextbox.Text}\" --section0dir=\"{NcaOutTextbox.Text}/exefs\" --romfsdir=\"{NcaOutTextbox.Text}/romfs\"");
            }
        }



        //XCI EXTRACTING

        private void XciExtractButton_Click(object sender, EventArgs e)
        {
            //CHECK CORRECT XCI PATH
            if (XciInTextbox.Text == string.Empty)
            {
                MessageBox.Show("Invalid XCI path!", "Error.", MessageBoxButtons.OK);
                return;
            }
            //CHECK CORRECT OUTPUT PATH
            else if (XciOutTextbox.Text == string.Empty)
            {
                MessageBox.Show("Invalid XCI output path!", "Error.", MessageBoxButtons.OK);
                return;
            }
            else
            {
                ProcessHelper();

                //HACTOOL COMMAND TO EXTRACT XCI
                Hactool.RunCommand($"--keyset \"{XciKeysTextbox.Text}\" -t xci \"{XciInTextbox.Text}\" --outdir=\"{XciOutTextbox.Text}\"");
            }
        }


        
        //ROMFS EXTRACTING

        private void RomFSExtractButton_Click(object sender, EventArgs e)
        {
            //CHECK CORRECT ROMFS PATH
            if (romFSInTextbox.Text == string.Empty)
            {
                MessageBox.Show("Invalid romFS path!", "Error.", MessageBoxButtons.OK);
                return;
            }
            //CHECK CORRECT OUTPUT PATH
            else if (romFSOutTextbox.Text == string.Empty)
            {
                MessageBox.Show("Invalid romFS output path!", "Error.", MessageBoxButtons.OK);
                return;
            }
            else
            {
                ProcessHelper();

                //HACTOOL COMMAND TO EXTRACT ROMFS
                Hactool.RunCommand($"-t romfs \"{romFSInTextbox.Text}\" --romfsdir=\"{romFSOutTextbox.Text}/romfs\"");

                display("Extracting completed successfully");
            }
        }



        //EXECUTE HELPER SECTION



        //DISPLAY WORKING SYMBOL
        private void LoadingPicON()
        {
            ProcessGIF.Visible = true;
            ExtractingLabel.Visible = true;
        }

        //HIDE WORKING SYMBOL
        private void LoadingPicOFF()
        {
            ProcessGIF.Visible = false;
            ExtractingLabel.Visible = false;
        }

        //ENABLE EXTRACT BUTTON
        private void ExtractBtnOn()
        {
            NspExtractButton.Enabled = true;
            NcaExtractButton.Enabled = true;
            XciExtractButton.Enabled = true;
            RomFSExtractButton.Enabled = true;
        }

        //DISABLE EXTRACT BUTTON
        private void ExtractBtnOff()
        {
            NspExtractButton.Enabled = false;
            NcaExtractButton.Enabled = false;
            XciExtractButton.Enabled = false;
            RomFSExtractButton.Enabled = false;
        }

        //ENABLE TEXTFIELDS
        private void TextFieldOn()
        {
            NspInTextbox.Enabled = true;
            NspOutTextbox.Enabled = true;
            NspKeysTextbox.Enabled = true;
            NcaInTextbox.Enabled = true;
            NcaOutTextbox.Enabled = true;
            NcaKeysTextbox.Enabled = true;
            NcaTitleKeyTextbox.Enabled = true;
            XciInTextbox.Enabled = true;
            XciOutTextbox.Enabled = true;
            XciKeysTextbox.Enabled = true;
        }

        //DISABLE TEXTFIELDS
        private void TextFieldOff()
        {
            NspInTextbox.Enabled = false;
            NspOutTextbox.Enabled = false;
            NspKeysTextbox.Enabled = false;
            NcaInTextbox.Enabled = false;
            NcaOutTextbox.Enabled = false;
            NcaKeysTextbox.Enabled = false;
            NcaTitleKeyTextbox.Enabled = false;
            XciInTextbox.Enabled = false;
            XciOutTextbox.Enabled = false;
            XciKeysTextbox.Enabled = false;
        }

        // EXECUTE HELPER
        private void ProcessHelper()
        {
            ExtractBtnOff();
            TextFieldOff();
            CancelButton.Enabled = true;
            backgroundWorker1.RunWorkerAsync();
            LoadingPicON();
        }



        //BACKGROUNDWORKER AND CANCELLING SECTION

        

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //REQUEST CANCELLATION
            Kill();
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.CancelAsync();
            ExtractBtnOn();
            TextFieldOn();
            LoadingPicOFF();
        }

        //BACKGROUNDWORKER
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                //CHECK FOR CANCELLATION FIRST
                if (backgroundWorker1.CancellationPending)
                {
                    //CANCEL
                    e.Cancel = true;
                }
                else
                {
                    simulateHeavyJob();
                }
            }
        }


        //WHEN JOB IS DONE THIS IS CALLED.
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                display("You have cancelled the extracting");
            }
            else
            {
                //HIDE WORKING SYMBOL
                LoadingPicOFF();

                //DISABLE CANCEL BUTTON
                CancelButton.Enabled = false;

                //ENABEL EXTRACT BUTTON
                ExtractBtnOn();
                
                //ENABLE TEXTFIELDS
                TextFieldOn();

                display("Extracting completed successfully");
            }
        }
        
        private void Kill()
        {
            //CANCELLING HACTOOL PROCESS
            Hactool.KillProcess();
        }

        //SIMULATE HEAVY JOB
        private void simulateHeavyJob()
        {
            //SUSPEND THREAD FOR 100 MS
            Thread.Sleep(100);
        }

        //DISPLAY MSG BOX
        private void display(String text)
        {
            MessageBox.Show(text);
        }
    }
}
