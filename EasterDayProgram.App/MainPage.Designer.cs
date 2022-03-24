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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.labelInputYear = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SearchForEaster = new System.Windows.Forms.Button();
            this.orthodoxCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelInputYear
            // 
            this.labelInputYear.AutoSize = true;
            this.labelInputYear.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInputYear.Location = new System.Drawing.Point(147, 9);
            this.labelInputYear.Name = "labelInputYear";
            this.labelInputYear.Size = new System.Drawing.Size(127, 25);
            this.labelInputYear.TabIndex = 0;
            this.labelInputYear.Text = "Indtaste årtal ";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Result.Location = new System.Drawing.Point(18, 81);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 89);
            this.Result.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(160, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(78, 32);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // SearchForEaster
            // 
            this.SearchForEaster.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchForEaster.Location = new System.Drawing.Point(439, 25);
            this.SearchForEaster.Name = "SearchForEaster";
            this.SearchForEaster.Size = new System.Drawing.Size(183, 44);
            this.SearchForEaster.TabIndex = 4;
            this.SearchForEaster.Text = "Søg efter påskedag";
            this.SearchForEaster.UseVisualStyleBackColor = true;
            this.SearchForEaster.Click += new System.EventHandler(this.SearchForEaster_Click);
            // 
            // orthodoxCheckbox
            // 
            this.orthodoxCheckbox.AutoSize = true;
            this.orthodoxCheckbox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orthodoxCheckbox.Location = new System.Drawing.Point(254, 37);
            this.orthodoxCheckbox.Name = "orthodoxCheckbox";
            this.orthodoxCheckbox.Size = new System.Drawing.Size(179, 29);
            this.orthodoxCheckbox.TabIndex = 5;
            this.orthodoxCheckbox.Text = "Ortodokse Påske?";
            this.orthodoxCheckbox.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 204);
            this.Controls.Add(this.orthodoxCheckbox);
            this.Controls.Add(this.SearchForEaster);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.labelInputYear);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainPage";
            this.Text = "Software for at søge efter påske";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelInputYear;
        private Label Result;
        private DateTimePicker dateTimePicker1;
        private Button SearchForEaster;
        private CheckBox orthodoxCheckbox;
    }
}