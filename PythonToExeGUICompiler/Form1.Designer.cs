namespace PythonToExeGUICompiler
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.target_btn = new System.Windows.Forms.Button();
            this.targetPath_textbox = new System.Windows.Forms.TextBox();
            this.convertOutType_label = new System.Windows.Forms.Label();
            this.oneFile_check = new System.Windows.Forms.CheckBox();
            this.oneDir_check = new System.Windows.Forms.CheckBox();
            this.window_check = new System.Windows.Forms.CheckBox();
            this.console_check = new System.Windows.Forms.CheckBox();
            this.displayMode_label = new System.Windows.Forms.Label();
            this.fileName_label = new System.Windows.Forms.Label();
            this.outputName_textbox = new System.Windows.Forms.TextBox();
            this.outputDir_textbox = new System.Windows.Forms.TextBox();
            this.outputPath_label = new System.Windows.Forms.Label();
            this.bottomStrip = new System.Windows.Forms.StatusStrip();
            this.bottomStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.bottomStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.logo_app = new System.Windows.Forms.PictureBox();
            this.title_label = new System.Windows.Forms.Label();
            this.by_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.indicator_label = new System.Windows.Forms.Label();
            this.outputDir_btn = new System.Windows.Forms.Button();
            this.bottomStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.bottomStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_app)).BeginInit();
            this.SuspendLayout();
            // 
            // target_btn
            // 
            this.target_btn.BackColor = System.Drawing.Color.Gray;
            this.target_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.target_btn.Location = new System.Drawing.Point(12, 86);
            this.target_btn.Name = "target_btn";
            this.target_btn.Size = new System.Drawing.Size(110, 23);
            this.target_btn.TabIndex = 1;
            this.target_btn.Text = "Target Python file";
            this.target_btn.UseVisualStyleBackColor = false;
            this.target_btn.Click += new System.EventHandler(this.target_btn_Click);
            // 
            // targetPath_textbox
            // 
            this.targetPath_textbox.BackColor = System.Drawing.Color.White;
            this.targetPath_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.targetPath_textbox.Location = new System.Drawing.Point(179, 89);
            this.targetPath_textbox.Name = "targetPath_textbox";
            this.targetPath_textbox.Size = new System.Drawing.Size(205, 20);
            this.targetPath_textbox.TabIndex = 2;
            this.toolTip1.SetToolTip(this.targetPath_textbox, "Target of the python script file.");
            // 
            // convertOutType_label
            // 
            this.convertOutType_label.AutoSize = true;
            this.convertOutType_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertOutType_label.ForeColor = System.Drawing.Color.White;
            this.convertOutType_label.Location = new System.Drawing.Point(58, 123);
            this.convertOutType_label.Name = "convertOutType_label";
            this.convertOutType_label.Size = new System.Drawing.Size(251, 25);
            this.convertOutType_label.TabIndex = 3;
            this.convertOutType_label.Text = "Converter Output Type\r\n";
            this.toolTip1.SetToolTip(this.convertOutType_label, "This option is OBLIGATORY.\r\nYou can only choose one checkbox at a time.");
            // 
            // oneFile_check
            // 
            this.oneFile_check.AutoSize = true;
            this.oneFile_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneFile_check.ForeColor = System.Drawing.Color.White;
            this.oneFile_check.Location = new System.Drawing.Point(63, 151);
            this.oneFile_check.Name = "oneFile_check";
            this.oneFile_check.Size = new System.Drawing.Size(102, 28);
            this.oneFile_check.TabIndex = 4;
            this.oneFile_check.Text = "One File";
            this.toolTip1.SetToolTip(this.oneFile_check, "The final file will only be a EXE.");
            this.oneFile_check.UseVisualStyleBackColor = true;
            this.oneFile_check.CheckedChanged += new System.EventHandler(this.oneFile_check_CheckedChanged);
            // 
            // oneDir_check
            // 
            this.oneDir_check.AutoSize = true;
            this.oneDir_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneDir_check.ForeColor = System.Drawing.Color.White;
            this.oneDir_check.Location = new System.Drawing.Point(169, 151);
            this.oneDir_check.Name = "oneDir_check";
            this.oneDir_check.Size = new System.Drawing.Size(145, 28);
            this.oneDir_check.TabIndex = 5;
            this.oneDir_check.Text = "One Directory";
            this.toolTip1.SetToolTip(this.oneDir_check, "The exe will be with other directories.\r\n");
            this.oneDir_check.UseVisualStyleBackColor = true;
            this.oneDir_check.CheckedChanged += new System.EventHandler(this.oneDir_check_CheckedChanged);
            // 
            // window_check
            // 
            this.window_check.AutoSize = true;
            this.window_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.window_check.ForeColor = System.Drawing.Color.White;
            this.window_check.Location = new System.Drawing.Point(203, 235);
            this.window_check.Name = "window_check";
            this.window_check.Size = new System.Drawing.Size(156, 28);
            this.window_check.TabIndex = 8;
            this.window_check.Text = "Window Based";
            this.toolTip1.SetToolTip(this.window_check, "When Final EXE is excuted, hide the console.");
            this.window_check.UseVisualStyleBackColor = true;
            this.window_check.CheckedChanged += new System.EventHandler(this.window_check_CheckedChanged);
            // 
            // console_check
            // 
            this.console_check.AutoSize = true;
            this.console_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.console_check.ForeColor = System.Drawing.Color.White;
            this.console_check.Location = new System.Drawing.Point(40, 235);
            this.console_check.Name = "console_check";
            this.console_check.Size = new System.Drawing.Size(157, 28);
            this.console_check.TabIndex = 7;
            this.console_check.Text = "Console Based";
            this.toolTip1.SetToolTip(this.console_check, "When Final EXE is excuted, show console.");
            this.console_check.UseVisualStyleBackColor = true;
            this.console_check.CheckedChanged += new System.EventHandler(this.console_check_CheckedChanged);
            // 
            // displayMode_label
            // 
            this.displayMode_label.AutoSize = true;
            this.displayMode_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayMode_label.ForeColor = System.Drawing.Color.White;
            this.displayMode_label.Location = new System.Drawing.Point(110, 207);
            this.displayMode_label.Name = "displayMode_label";
            this.displayMode_label.Size = new System.Drawing.Size(155, 25);
            this.displayMode_label.TabIndex = 6;
            this.displayMode_label.Text = "Display Mode";
            this.toolTip1.SetToolTip(this.displayMode_label, "This option is OBLIGATORY.\r\nYou can only choose one checkbox at a time.\r\n");
            // 
            // fileName_label
            // 
            this.fileName_label.AutoSize = true;
            this.fileName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileName_label.ForeColor = System.Drawing.Color.White;
            this.fileName_label.Location = new System.Drawing.Point(12, 281);
            this.fileName_label.Name = "fileName_label";
            this.fileName_label.Size = new System.Drawing.Size(373, 25);
            this.fileName_label.TabIndex = 9;
            this.fileName_label.Text = "File name(No extension)(Optional)";
            // 
            // outputName_textbox
            // 
            this.outputName_textbox.BackColor = System.Drawing.Color.White;
            this.outputName_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputName_textbox.Location = new System.Drawing.Point(91, 309);
            this.outputName_textbox.Name = "outputName_textbox";
            this.outputName_textbox.Size = new System.Drawing.Size(205, 20);
            this.outputName_textbox.TabIndex = 10;
            this.toolTip1.SetToolTip(this.outputName_textbox, "Name of the final exe file.");
            // 
            // outputDir_textbox
            // 
            this.outputDir_textbox.BackColor = System.Drawing.Color.White;
            this.outputDir_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputDir_textbox.Location = new System.Drawing.Point(179, 382);
            this.outputDir_textbox.Name = "outputDir_textbox";
            this.outputDir_textbox.Size = new System.Drawing.Size(205, 20);
            this.outputDir_textbox.TabIndex = 12;
            this.toolTip1.SetToolTip(this.outputDir_textbox, "Where the final exe will be outputed.");
            // 
            // outputPath_label
            // 
            this.outputPath_label.AutoSize = true;
            this.outputPath_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputPath_label.ForeColor = System.Drawing.Color.White;
            this.outputPath_label.Location = new System.Drawing.Point(222, 354);
            this.outputPath_label.Name = "outputPath_label";
            this.outputPath_label.Size = new System.Drawing.Size(137, 25);
            this.outputPath_label.TabIndex = 11;
            this.outputPath_label.Text = "Output Path";
            this.toolTip1.SetToolTip(this.outputPath_label, "This option is OBLIGATORY");
            // 
            // bottomStrip
            // 
            this.bottomStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bottomStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bottomStripStatusLabel1,
            this.bottomStripStatusLabel2,
            this.bottomStripStatusLabel3});
            this.bottomStrip.Location = new System.Drawing.Point(0, 478);
            this.bottomStrip.Name = "bottomStrip";
            this.bottomStrip.Size = new System.Drawing.Size(397, 22);
            this.bottomStrip.SizingGrip = false;
            this.bottomStrip.Stretch = false;
            this.bottomStrip.TabIndex = 13;
            this.bottomStrip.Text = "statusStrip1";
            // 
            // bottomStripStatusLabel1
            // 
            this.bottomStripStatusLabel1.Name = "bottomStripStatusLabel1";
            this.bottomStripStatusLabel1.Size = new System.Drawing.Size(53, 17);
            this.bottomStripStatusLabel1.Text = "Made by";
            // 
            // bottomStripStatusLabel2
            // 
            this.bottomStripStatusLabel2.Name = "bottomStripStatusLabel2";
            this.bottomStripStatusLabel2.Size = new System.Drawing.Size(265, 17);
            this.bottomStripStatusLabel2.Spring = true;
            this.bottomStripStatusLabel2.Text = "P1NGU! (Independent-Coder)";
            // 
            // logo_app
            // 
            this.logo_app.Image = global::PythonToExeGUICompiler.Properties.Resources.python_icon_512x512_48og66bp;
            this.logo_app.Location = new System.Drawing.Point(0, 3);
            this.logo_app.Name = "logo_app";
            this.logo_app.Size = new System.Drawing.Size(100, 67);
            this.logo_app.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_app.TabIndex = 14;
            this.logo_app.TabStop = false;
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.ForeColor = System.Drawing.Color.White;
            this.title_label.Location = new System.Drawing.Point(106, 9);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(278, 24);
            this.title_label.TabIndex = 15;
            this.title_label.Text = "Python To Exe GUI Compiler\r\n";
            // 
            // by_label
            // 
            this.by_label.AutoSize = true;
            this.by_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.by_label.ForeColor = System.Drawing.Color.DimGray;
            this.by_label.Location = new System.Drawing.Point(106, 33);
            this.by_label.Name = "by_label";
            this.by_label.Size = new System.Drawing.Size(113, 24);
            this.by_label.TabIndex = 16;
            this.by_label.Text = "By P1NGU!\r\n";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(298, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Compile !";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.compile_btn_Click);
            // 
            // indicator_label
            // 
            this.indicator_label.AutoSize = true;
            this.indicator_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicator_label.ForeColor = System.Drawing.Color.White;
            this.indicator_label.Location = new System.Drawing.Point(60, 453);
            this.indicator_label.Name = "indicator_label";
            this.indicator_label.Size = new System.Drawing.Size(98, 18);
            this.indicator_label.TabIndex = 17;
            this.indicator_label.Text = "Not started";
            // 
            // outputDir_btn
            // 
            this.outputDir_btn.BackColor = System.Drawing.Color.Gray;
            this.outputDir_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outputDir_btn.Location = new System.Drawing.Point(12, 382);
            this.outputDir_btn.Name = "outputDir_btn";
            this.outputDir_btn.Size = new System.Drawing.Size(110, 23);
            this.outputDir_btn.TabIndex = 18;
            this.outputDir_btn.Text = "Output Directory";
            this.outputDir_btn.UseVisualStyleBackColor = false;
            this.outputDir_btn.Click += new System.EventHandler(this.outputDir_btn_Click);
            // 
            // bottomStripStatusLabel3
            // 
            this.bottomStripStatusLabel3.ForeColor = System.Drawing.Color.Red;
            this.bottomStripStatusLabel3.Name = "bottomStripStatusLabel3";
            this.bottomStripStatusLabel3.Size = new System.Drawing.Size(64, 17);
            this.bottomStripStatusLabel3.Text = "Pyinstaller:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(397, 500);
            this.Controls.Add(this.outputDir_btn);
            this.Controls.Add(this.indicator_label);
            this.Controls.Add(this.by_label);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.logo_app);
            this.Controls.Add(this.bottomStrip);
            this.Controls.Add(this.outputDir_textbox);
            this.Controls.Add(this.outputPath_label);
            this.Controls.Add(this.outputName_textbox);
            this.Controls.Add(this.fileName_label);
            this.Controls.Add(this.window_check);
            this.Controls.Add(this.console_check);
            this.Controls.Add(this.displayMode_label);
            this.Controls.Add(this.oneDir_check);
            this.Controls.Add(this.oneFile_check);
            this.Controls.Add(this.convertOutType_label);
            this.Controls.Add(this.targetPath_textbox);
            this.Controls.Add(this.target_btn);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PythonToExeGUICompiler";
            this.bottomStrip.ResumeLayout(false);
            this.bottomStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_app)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button target_btn;
        private System.Windows.Forms.TextBox targetPath_textbox;
        private System.Windows.Forms.Label convertOutType_label;
        private System.Windows.Forms.CheckBox oneFile_check;
        private System.Windows.Forms.CheckBox oneDir_check;
        private System.Windows.Forms.CheckBox window_check;
        private System.Windows.Forms.CheckBox console_check;
        private System.Windows.Forms.Label displayMode_label;
        private System.Windows.Forms.Label fileName_label;
        private System.Windows.Forms.TextBox outputName_textbox;
        private System.Windows.Forms.TextBox outputDir_textbox;
        private System.Windows.Forms.Label outputPath_label;
        private System.Windows.Forms.StatusStrip bottomStrip;
        private System.Windows.Forms.ToolStripStatusLabel bottomStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel bottomStripStatusLabel2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox logo_app;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label by_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label indicator_label;
        private System.Windows.Forms.Button outputDir_btn;
        private System.Windows.Forms.ToolStripStatusLabel bottomStripStatusLabel3;
    }
}

