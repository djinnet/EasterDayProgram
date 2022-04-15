namespace EasterDayProgram.App
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Result = new System.Windows.Forms.Label();
            this.NavBarPanel = new System.Windows.Forms.Panel();
            this.LanguagesDropdown = new System.Windows.Forms.ComboBox();
            this.QuitButton = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SidebarPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.LogoName = new System.Windows.Forms.Label();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.SearchForEaster = new System.Windows.Forms.Button();
            this.labelInputYear = new System.Windows.Forms.Label();
            this.SelectYear = new System.Windows.Forms.DateTimePicker();
            this.orthodoxCheckbox = new System.Windows.Forms.CheckBox();
            this.ResultPanel = new System.Windows.Forms.Panel();
            this.NavBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuitButton)).BeginInit();
            this.SidebarPanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.InputPanel.SuspendLayout();
            this.ResultPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Segoe UI", 52F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Result.Location = new System.Drawing.Point(6, 71);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(733, 129);
            this.Result.TabIndex = 0;
            this.Result.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NavBarPanel
            // 
            this.NavBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.NavBarPanel.Controls.Add(this.LanguagesDropdown);
            this.NavBarPanel.Controls.Add(this.QuitButton);
            this.NavBarPanel.Controls.Add(this.TitleLabel);
            this.NavBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavBarPanel.Location = new System.Drawing.Point(215, 0);
            this.NavBarPanel.Name = "NavBarPanel";
            this.NavBarPanel.Size = new System.Drawing.Size(751, 38);
            this.NavBarPanel.TabIndex = 3;
            // 
            // LanguagesDropdown
            // 
            this.LanguagesDropdown.FormattingEnabled = true;
            this.LanguagesDropdown.Location = new System.Drawing.Point(593, 9);
            this.LanguagesDropdown.Name = "LanguagesDropdown";
            this.LanguagesDropdown.Size = new System.Drawing.Size(121, 23);
            this.LanguagesDropdown.TabIndex = 2;
            this.LanguagesDropdown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // QuitButton
            // 
            this.QuitButton.BackColor = System.Drawing.Color.Transparent;
            this.QuitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.QuitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.QuitButton.Image = global::EasterDayProgram.App.Properties.Resources.IconClose;
            this.QuitButton.Location = new System.Drawing.Point(718, 0);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(33, 38);
            this.QuitButton.TabIndex = 1;
            this.QuitButton.TabStop = false;
            this.QuitButton.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(6, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(170, 25);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Software til påske";
            // 
            // SidebarPanel
            // 
            this.SidebarPanel.AutoSize = true;
            this.SidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.SidebarPanel.Controls.Add(this.LogoPanel);
            this.SidebarPanel.Controls.Add(this.InputPanel);
            this.SidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.SidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.SidebarPanel.Name = "SidebarPanel";
            this.SidebarPanel.Size = new System.Drawing.Size(215, 261);
            this.SidebarPanel.TabIndex = 4;
            this.SidebarPanel.WrapContents = false;
            // 
            // LogoPanel
            // 
            this.LogoPanel.Controls.Add(this.Logo);
            this.LogoPanel.Controls.Add(this.LogoName);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(3, 3);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(209, 100);
            this.LogoPanel.TabIndex = 10;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImage = global::EasterDayProgram.App.Properties.Resources.easter_egg_with_different_lines_design;
            this.Logo.Image = global::EasterDayProgram.App.Properties.Resources.easter_egg_with_different_lines_design;
            this.Logo.Location = new System.Drawing.Point(108, 9);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(78, 73);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // LogoName
            // 
            this.LogoName.AutoSize = true;
            this.LogoName.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogoName.ForeColor = System.Drawing.Color.White;
            this.LogoName.Location = new System.Drawing.Point(9, 18);
            this.LogoName.Name = "LogoName";
            this.LogoName.Size = new System.Drawing.Size(93, 51);
            this.LogoName.TabIndex = 0;
            this.LogoName.Text = "SAP";
            // 
            // InputPanel
            // 
            this.InputPanel.Controls.Add(this.SearchForEaster);
            this.InputPanel.Controls.Add(this.labelInputYear);
            this.InputPanel.Controls.Add(this.SelectYear);
            this.InputPanel.Controls.Add(this.orthodoxCheckbox);
            this.InputPanel.Location = new System.Drawing.Point(3, 109);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(209, 145);
            this.InputPanel.TabIndex = 11;
            // 
            // SearchForEaster
            // 
            this.SearchForEaster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.SearchForEaster.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SearchForEaster.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.SearchForEaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchForEaster.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchForEaster.ForeColor = System.Drawing.Color.White;
            this.SearchForEaster.Location = new System.Drawing.Point(0, 92);
            this.SearchForEaster.Name = "SearchForEaster";
            this.SearchForEaster.Size = new System.Drawing.Size(209, 53);
            this.SearchForEaster.TabIndex = 0;
            this.SearchForEaster.Text = "Søg efter påskedag";
            this.SearchForEaster.UseVisualStyleBackColor = false;
            this.SearchForEaster.Click += new System.EventHandler(this.SearchForEaster_Click);
            // 
            // labelInputYear
            // 
            this.labelInputYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInputYear.ForeColor = System.Drawing.Color.White;
            this.labelInputYear.Location = new System.Drawing.Point(9, 12);
            this.labelInputYear.Name = "labelInputYear";
            this.labelInputYear.Size = new System.Drawing.Size(101, 25);
            this.labelInputYear.TabIndex = 1;
            this.labelInputYear.Text = "Indtaste årtal";
            // 
            // SelectYear
            // 
            this.SelectYear.CustomFormat = "yyyy";
            this.SelectYear.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SelectYear.Location = new System.Drawing.Point(122, 12);
            this.SelectYear.Name = "SelectYear";
            this.SelectYear.ShowUpDown = true;
            this.SelectYear.Size = new System.Drawing.Size(78, 32);
            this.SelectYear.TabIndex = 7;
            // 
            // orthodoxCheckbox
            // 
            this.orthodoxCheckbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orthodoxCheckbox.ForeColor = System.Drawing.Color.White;
            this.orthodoxCheckbox.Location = new System.Drawing.Point(9, 57);
            this.orthodoxCheckbox.Name = "orthodoxCheckbox";
            this.orthodoxCheckbox.Size = new System.Drawing.Size(179, 29);
            this.orthodoxCheckbox.TabIndex = 8;
            this.orthodoxCheckbox.Text = "orthodokse påske?";
            this.orthodoxCheckbox.UseVisualStyleBackColor = true;
            // 
            // ResultPanel
            // 
            this.ResultPanel.BackColor = System.Drawing.Color.White;
            this.ResultPanel.Controls.Add(this.Result);
            this.ResultPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultPanel.Location = new System.Drawing.Point(215, 38);
            this.ResultPanel.Name = "ResultPanel";
            this.ResultPanel.Size = new System.Drawing.Size(751, 223);
            this.ResultPanel.TabIndex = 5;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 261);
            this.ControlBox = false;
            this.Controls.Add(this.ResultPanel);
            this.Controls.Add(this.NavBarPanel);
            this.Controls.Add(this.SidebarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.NavBarPanel.ResumeLayout(false);
            this.NavBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuitButton)).EndInit();
            this.SidebarPanel.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            this.LogoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.InputPanel.ResumeLayout(false);
            this.ResultPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label Result;
        private Panel NavBarPanel;
        private FlowLayoutPanel SidebarPanel;
        private Panel ResultPanel;
        private CheckBox orthodoxCheckbox;
        private Button SearchForEaster;
        private DateTimePicker SelectYear;
        private Label labelInputYear;
        private Label TitleLabel;
        private Panel LogoPanel;
        private PictureBox Logo;
        private Label LogoName;
        private Panel InputPanel;
        private PictureBox QuitButton;
        private ComboBox LanguagesDropdown;
    }
}