
namespace StudentsApp_CSharp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.numericUpDown_Age = new System.Windows.Forms.NumericUpDown();
            this.cmb_Year = new System.Windows.Forms.ComboBox();
            this.cmb_Note1 = new System.Windows.Forms.ComboBox();
            this.cmb_Note2 = new System.Windows.Forms.ComboBox();
            this.cmb_Note3 = new System.Windows.Forms.ComboBox();
            this.cmb_Note4 = new System.Windows.Forms.ComboBox();
            this.cmb_Note5 = new System.Windows.Forms.ComboBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_OrderByName = new System.Windows.Forms.Button();
            this.btn_OrderByNotes = new System.Windows.Forms.Button();
            this.btn_DisplayStudents = new System.Windows.Forms.Button();
            this.btn_SearchName = new System.Windows.Forms.Button();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.txt_SearchName = new System.Windows.Forms.TextBox();
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Age)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Year of studies:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Notes:";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(98, 37);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(143, 26);
            this.txt_Name.TabIndex = 4;
            // 
            // numericUpDown_Age
            // 
            this.numericUpDown_Age.Location = new System.Drawing.Point(98, 79);
            this.numericUpDown_Age.Name = "numericUpDown_Age";
            this.numericUpDown_Age.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_Age.TabIndex = 5;
            this.numericUpDown_Age.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // cmb_Year
            // 
            this.cmb_Year.FormattingEnabled = true;
            this.cmb_Year.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmb_Year.Location = new System.Drawing.Point(163, 115);
            this.cmb_Year.Name = "cmb_Year";
            this.cmb_Year.Size = new System.Drawing.Size(64, 28);
            this.cmb_Year.TabIndex = 6;
            // 
            // cmb_Note1
            // 
            this.cmb_Note1.FormattingEnabled = true;
            this.cmb_Note1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmb_Note1.Location = new System.Drawing.Point(98, 150);
            this.cmb_Note1.Name = "cmb_Note1";
            this.cmb_Note1.Size = new System.Drawing.Size(59, 28);
            this.cmb_Note1.TabIndex = 7;
            // 
            // cmb_Note2
            // 
            this.cmb_Note2.FormattingEnabled = true;
            this.cmb_Note2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmb_Note2.Location = new System.Drawing.Point(163, 149);
            this.cmb_Note2.Name = "cmb_Note2";
            this.cmb_Note2.Size = new System.Drawing.Size(59, 28);
            this.cmb_Note2.TabIndex = 8;
            // 
            // cmb_Note3
            // 
            this.cmb_Note3.FormattingEnabled = true;
            this.cmb_Note3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmb_Note3.Location = new System.Drawing.Point(228, 150);
            this.cmb_Note3.Name = "cmb_Note3";
            this.cmb_Note3.Size = new System.Drawing.Size(59, 28);
            this.cmb_Note3.TabIndex = 9;
            // 
            // cmb_Note4
            // 
            this.cmb_Note4.FormattingEnabled = true;
            this.cmb_Note4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmb_Note4.Location = new System.Drawing.Point(293, 150);
            this.cmb_Note4.Name = "cmb_Note4";
            this.cmb_Note4.Size = new System.Drawing.Size(59, 28);
            this.cmb_Note4.TabIndex = 10;
            // 
            // cmb_Note5
            // 
            this.cmb_Note5.FormattingEnabled = true;
            this.cmb_Note5.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmb_Note5.Location = new System.Drawing.Point(358, 150);
            this.cmb_Note5.Name = "cmb_Note5";
            this.cmb_Note5.Size = new System.Drawing.Size(59, 28);
            this.cmb_Note5.TabIndex = 11;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(98, 208);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(154, 45);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_SearchName);
            this.groupBox1.Controls.Add(this.cmbYear);
            this.groupBox1.Controls.Add(this.btn_SearchName);
            this.groupBox1.Controls.Add(this.btn_DisplayStudents);
            this.groupBox1.Controls.Add(this.btn_OrderByNotes);
            this.groupBox1.Controls.Add(this.btn_OrderByName);
            this.groupBox1.Location = new System.Drawing.Point(41, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 232);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display";
            // 
            // btn_OrderByName
            // 
            this.btn_OrderByName.Location = new System.Drawing.Point(6, 25);
            this.btn_OrderByName.Name = "btn_OrderByName";
            this.btn_OrderByName.Size = new System.Drawing.Size(240, 40);
            this.btn_OrderByName.TabIndex = 14;
            this.btn_OrderByName.Text = "Order by name";
            this.btn_OrderByName.UseVisualStyleBackColor = true;
            // 
            // btn_OrderByNotes
            // 
            this.btn_OrderByNotes.Location = new System.Drawing.Point(6, 79);
            this.btn_OrderByNotes.Name = "btn_OrderByNotes";
            this.btn_OrderByNotes.Size = new System.Drawing.Size(240, 40);
            this.btn_OrderByNotes.TabIndex = 15;
            this.btn_OrderByNotes.Text = "Order by notes";
            this.btn_OrderByNotes.UseVisualStyleBackColor = true;
            // 
            // btn_DisplayStudents
            // 
            this.btn_DisplayStudents.Location = new System.Drawing.Point(6, 125);
            this.btn_DisplayStudents.Name = "btn_DisplayStudents";
            this.btn_DisplayStudents.Size = new System.Drawing.Size(240, 40);
            this.btn_DisplayStudents.TabIndex = 16;
            this.btn_DisplayStudents.Text = "Display students of the year: ";
            this.btn_DisplayStudents.UseVisualStyleBackColor = true;
            // 
            // btn_SearchName
            // 
            this.btn_SearchName.Location = new System.Drawing.Point(6, 177);
            this.btn_SearchName.Name = "btn_SearchName";
            this.btn_SearchName.Size = new System.Drawing.Size(240, 40);
            this.btn_SearchName.TabIndex = 17;
            this.btn_SearchName.Text = "Search name: ";
            this.btn_SearchName.UseVisualStyleBackColor = true;
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbYear.Location = new System.Drawing.Point(252, 132);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(59, 28);
            this.cmbYear.TabIndex = 14;
            // 
            // txt_SearchName
            // 
            this.txt_SearchName.Location = new System.Drawing.Point(252, 184);
            this.txt_SearchName.Name = "txt_SearchName";
            this.txt_SearchName.Size = new System.Drawing.Size(143, 26);
            this.txt_SearchName.TabIndex = 14;
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.ItemHeight = 20;
            this.lstStudents.Location = new System.Drawing.Point(558, 37);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(497, 364);
            this.lstStudents.TabIndex = 14;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(901, 443);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(154, 45);
            this.btn_Delete.TabIndex = 15;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 522);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.lstStudents);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.cmb_Note5);
            this.Controls.Add(this.cmb_Note4);
            this.Controls.Add(this.cmb_Note3);
            this.Controls.Add(this.cmb_Note2);
            this.Controls.Add(this.cmb_Note1);
            this.Controls.Add(this.cmb_Year);
            this.Controls.Add(this.numericUpDown_Age);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Age)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.NumericUpDown numericUpDown_Age;
        private System.Windows.Forms.ComboBox cmb_Year;
        private System.Windows.Forms.ComboBox cmb_Note1;
        private System.Windows.Forms.ComboBox cmb_Note2;
        private System.Windows.Forms.ComboBox cmb_Note3;
        private System.Windows.Forms.ComboBox cmb_Note4;
        private System.Windows.Forms.ComboBox cmb_Note5;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_SearchName;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Button btn_SearchName;
        private System.Windows.Forms.Button btn_DisplayStudents;
        private System.Windows.Forms.Button btn_OrderByNotes;
        private System.Windows.Forms.Button btn_OrderByName;
        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.Button btn_Delete;
    }
}

