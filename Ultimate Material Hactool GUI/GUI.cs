using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Ultimate_Material_Hactool_GUI
{
    public partial class GUI_Main : MaterialForm
    {
        Hactoolstarter Hactool;

        public GUI_Main()
        {
            InitializeComponent();

            Hactool = new Hactoolstarter();

            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red100, TextShade.WHITE);
        }
        private void ExtractedCompleted()
        {
            MessageBox.Show("Extractet!", "Finish.", MessageBoxButtons.OK);
        }

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

        private void NspOutButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog NspOutBrowse = new FolderBrowserDialog
            {
                SelectedPath    = Application.StartupPath,
                Description     = "Select NSP output folder"
            };

            if (NspOutBrowse.ShowDialog() == DialogResult.OK)
            {
                NspOutTextbox.Text = NspOutBrowse.SelectedPath;
            }
        }

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

        private void NspExtractButton_Click(object sender, EventArgs e)
        {
            if (NspInTextbox.Text == string.Empty)
            {
                MessageBox.Show("Invalid NSP path!", "Error.", MessageBoxButtons.OK);
                return;
            }
            else if (NspOutTextbox.Text == string.Empty)
            {
                MessageBox.Show("Invalid NSP output path!", "Error.", MessageBoxButtons.OK);
                return;
            }
            else
            {
                Hactool.RunCommand($" --keyset \"{NspKeysTextbox.Text}\" -t pfs0 \"{NspInTextbox.Text}\" --outdir=\"{NspOutTextbox.Text}\"");

                ExtractedCompleted();
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/W4c78K7");
        }

        private void NsptabPage_Click(object sender, EventArgs e)
        {

        }

        private void NcaFileLabel_Click(object sender, EventArgs e)
        {

        }

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

        private void NcaExtractButton_Click(object sender, EventArgs e)
        {
            if (NcaInTextbox.Text == string.Empty)
            {
                MessageBox.Show("Invalid NCA path!", "Error.", MessageBoxButtons.OK);
                return;
            }
            else if (NcaOutTextbox.Text == string.Empty)
            {
                MessageBox.Show("Invalid NCA output path!", "Error.", MessageBoxButtons.OK);
                return;
            }
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
                Hactool.RunCommand($"--keyset \"{NcaKeysTextbox.Text}\" --titlekey={NcaTitleKeyTextbox.Text} \"{NcaInTextbox.Text}\" --section0dir=\"{NcaOutTextbox.Text}/exefs\" --romfsdir=\"{NcaOutTextbox.Text}/romfs\"");

                ExtractedCompleted();
            }
            else
            {
                Hactool.RunCommand($" \"{NcaInTextbox.Text}\" --keyset \"{NcaKeysTextbox.Text}\" --section0dir=\"{NcaOutTextbox.Text}/exefs\" --romfsdir=\"{NcaOutTextbox.Text}/romfs\"");

                ExtractedCompleted();
            }
        }

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

        private void XciExtractButton_Click(object sender, EventArgs e)
        {
            if (XciInTextbox.Text == string.Empty)
            {
                MessageBox.Show("Invalid XCI path!", "Error.", MessageBoxButtons.OK);
                return;
            }
            else if (XciOutTextbox.Text == string.Empty)
            {
                MessageBox.Show("Invalid XCI output path!", "Error.", MessageBoxButtons.OK);
                return;
            }
            else
            {
                Hactool.RunCommand($"--keyset \"{XciKeysTextbox.Text}\" -t xci \"{XciInTextbox.Text}\" --outdir=\"{XciOutTextbox.Text}\"");

                ExtractedCompleted();
            }
        }

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

        private void RomFSExtractButton_Click(object sender, EventArgs e)
        {
            if (romFSInTextbox.Text == string.Empty)
            {
                MessageBox.Show("Invalid romFS path!", "Error.", MessageBoxButtons.OK);
                return;
            }
            else if (romFSOutTextbox.Text == string.Empty)
            {
                MessageBox.Show("Invalid romFS output path!", "Error.", MessageBoxButtons.OK);
                return;
            }
            else
            {
                Hactool.RunCommand($"-t romfs \"{romFSInTextbox.Text}\" --romfsdir=\"{romFSOutTextbox.Text}/romfs\"");

                ExtractedCompleted();
            }
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
