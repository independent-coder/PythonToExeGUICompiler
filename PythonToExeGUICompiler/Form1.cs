using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PythonToExeGUICompiler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Check if PyInstaller is installed
            string pyInstallerVersion = GetPyInstallerVersion();
            if (string.IsNullOrEmpty(pyInstallerVersion))
            {
                MessageBox.Show("PyInstaller is not installed. Please install PyInstaller to use this application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit(); // Close the application if PyInstaller is not installed
                return;
            }

            // Display PyInstaller version in bottom status strip
            bottomStripStatusLabel3.Text = "PyInstaller Version: " + pyInstallerVersion;

            MessageBox.Show("Welcome to Python To Exe GUI Compiler", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void target_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select Python File",
                Filter = "Python Files|*.py",
                Multiselect = false
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                targetPath_textbox.Text = filePath;
            }
        }

        private void compile_btn_Click(object sender, EventArgs e)
        {
            string pythonFilePath = targetPath_textbox.Text;
            string outputDirectory = outputDir_textbox.Text;
            string outputFileName = outputName_textbox.Text;

            if (!IsValidPath(pythonFilePath) || !IsValidPath(outputDirectory))
            {
                MessageBox.Show("Please enter valid script and output paths.", "Invalid Paths", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string compileArguments = $"--{GetCompilationType()} {pythonFilePath} {GetOutputType()}";

            if (!string.IsNullOrEmpty(outputDirectory))
            {
                compileArguments += $" --distpath {outputDirectory}";
            }

            if (!string.IsNullOrEmpty(outputFileName))
            {
                compileArguments += $" --name {outputFileName}";
            }

            ExecutePyInstallerCommand(compileArguments);
        }


        private void outputDir_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
            {
                Description = "Select Output Directory"
            };

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath;
                outputDir_textbox.Text = selectedPath;
            }
        }


        private void oneFile_check_CheckedChanged(object sender, EventArgs e)
        {
            if (oneFile_check.Checked)
            {
                oneDir_check.Enabled = false;
                oneDir_check.Checked = false;
            }
            else
            {
                oneDir_check.Enabled = true;
            }
        }

        private void oneDir_check_CheckedChanged(object sender, EventArgs e)
        {
            if (oneDir_check.Checked)
            {
                oneFile_check.Enabled = false;
                oneFile_check.Checked = false;
            }
            else
            {
                oneFile_check.Enabled = true;
            }
        }

        private void console_check_CheckedChanged(object sender, EventArgs e)
        {
            if (console_check.Checked)
            {
                window_check.Enabled = false;
                window_check.Checked = false;
            }
            else
            {
                window_check.Enabled = true;
            }
        }

        private void window_check_CheckedChanged(object sender, EventArgs e)
        {
            if (window_check.Checked)
            {
                console_check.Enabled = false;
                console_check.Checked = false;
            }
            else
            {
                console_check.Enabled = true;
            }
        }

        private string GetCompilationType()
        {
            if (oneFile_check.Checked)
            {
                return "onefile";
            }
            else if (oneDir_check.Checked)
            {
                return "onedir";
            }
            else
            {
                return "onedir"; // Default to onedir if none is selected
            }
        }

        private string GetOutputType()
        {
            if (console_check.Checked)
            {
                return "--console";
            }
            else if (window_check.Checked)
            {
                return "--windowed";
            }
            else
            {
                return "--console"; // Default to --console if none is selected
            }
        }

        private void ExecutePyInstallerCommand(string arguments)
        {
            // Update indicator_label to indicate compilation is in progress
            indicator_label.Text = "Compiling...";
            this.Text = "PythonToExeGUICompiler";
            indicator_label.ForeColor = Color.Orange; // Set color to black (default)

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "pyinstaller",
                Arguments = arguments,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = false
            };

            using (Process process = new Process { StartInfo = startInfo })
            {
                process.Start();
                process.WaitForExit();
                string output = process.StandardOutput.ReadToEnd();

                // Check if compilation was successful
                if (process.ExitCode == 0)
                {
                    // Update indicator_label to indicate successful compilation
                    indicator_label.Text = "Compiled Successfully";
                    this.Text = "PythonToExeGUICompiler - Compiled";
                    indicator_label.ForeColor = Color.Green;
                }
                else
                {
                    // Update indicator_label to indicate compilation failure
                    indicator_label.Text = "Compilation Failed";
                    this.Text = "PythonToExeGUICompiler - Compilation Failed";
                    indicator_label.ForeColor = Color.Red;
                }

                Console.WriteLine(output);
            }
        }



        private string GetPyInstallerVersion()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "pyinstaller",
                Arguments = "--version",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = new Process { StartInfo = startInfo })
            {
                process.Start();
                process.WaitForExit();
                if (process.ExitCode == 0)
                {
                    return process.StandardOutput.ReadToEnd().Trim(); // Trim to remove extra spaces or newlines
                }
                else
                {
                    return null;
                }
            }
        }



        private bool IsValidPath(string path)
        {
            try
            {
                // Check if the path is valid
                Path.GetFullPath(path);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
