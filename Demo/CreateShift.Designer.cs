namespace Demo
{
    partial class CreateShift
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.User_ComboBox = new System.Windows.Forms.ComboBox();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Employees_DataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Employees_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(139, 22);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(208, 20);
            this.DateTimePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пользователь";
            // 
            // User_ComboBox
            // 
            this.User_ComboBox.FormattingEnabled = true;
            this.User_ComboBox.Location = new System.Drawing.Point(139, 65);
            this.User_ComboBox.Name = "User_ComboBox";
            this.User_ComboBox.Size = new System.Drawing.Size(208, 21);
            this.User_ComboBox.TabIndex = 3;
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(139, 93);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(208, 23);
            this.Add_Button.TabIndex = 4;
            this.Add_Button.Text = "Добавить";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Employees_DataGridView
            // 
            this.Employees_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Employees_DataGridView.Location = new System.Drawing.Point(12, 122);
            this.Employees_DataGridView.Name = "Employees_DataGridView";
            this.Employees_DataGridView.Size = new System.Drawing.Size(465, 110);
            this.Employees_DataGridView.TabIndex = 5;
            // 
            // CreateShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(493, 248);
            this.Controls.Add(this.Employees_DataGridView);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.User_ComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateTimePicker);
            this.Name = "CreateShift";
            this.Text = "Создать смену";
            this.Load += new System.EventHandler(this.CreateShift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Employees_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox User_ComboBox;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.DataGridView Employees_DataGridView;
    }
}