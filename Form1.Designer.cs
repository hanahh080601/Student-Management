
namespace QLSV
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
            this.groupDSSV = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butSort = new System.Windows.Forms.Button();
            this.butShow = new System.Windows.Forms.Button();
            this.butDel = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.butEdit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbbLSH = new System.Windows.Forms.ComboBox();
            this.butSearch = new System.Windows.Forms.Button();
            this.labLopSH = new System.Windows.Forms.Label();
            this.groupDSSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupDSSV
            // 
            this.groupDSSV.Controls.Add(this.comboBox2);
            this.groupDSSV.Controls.Add(this.dataGridView1);
            this.groupDSSV.Controls.Add(this.butSort);
            this.groupDSSV.Controls.Add(this.butShow);
            this.groupDSSV.Controls.Add(this.butDel);
            this.groupDSSV.Controls.Add(this.butAdd);
            this.groupDSSV.Controls.Add(this.butEdit);
            this.groupDSSV.Location = new System.Drawing.Point(45, 79);
            this.groupDSSV.Name = "groupDSSV";
            this.groupDSSV.Size = new System.Drawing.Size(960, 436);
            this.groupDSSV.TabIndex = 17;
            this.groupDSSV.TabStop = false;
            this.groupDSSV.Text = "Danh sách sinh viên";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "MSSV",
            "NameSV",
            "Gender",
            "NS",
            "ID_Lop"});
            this.comboBox2.Location = new System.Drawing.Point(746, 402);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(202, 24);
            this.comboBox2.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(942, 328);
            this.dataGridView1.TabIndex = 11;
            // 
            // butSort
            // 
            this.butSort.Location = new System.Drawing.Point(635, 396);
            this.butSort.Name = "butSort";
            this.butSort.Size = new System.Drawing.Size(86, 34);
            this.butSort.TabIndex = 5;
            this.butSort.Text = "Sort";
            this.butSort.UseVisualStyleBackColor = true;
            this.butSort.Click += new System.EventHandler(this.butSort_Click);
            // 
            // butShow
            // 
            this.butShow.Location = new System.Drawing.Point(6, 396);
            this.butShow.Name = "butShow";
            this.butShow.Size = new System.Drawing.Size(76, 34);
            this.butShow.TabIndex = 1;
            this.butShow.Text = "Show";
            this.butShow.UseVisualStyleBackColor = true;
            this.butShow.Click += new System.EventHandler(this.butShow_Click);
            // 
            // butDel
            // 
            this.butDel.Location = new System.Drawing.Point(472, 396);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(83, 34);
            this.butDel.TabIndex = 4;
            this.butDel.Text = "Delete";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(142, 396);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(79, 34);
            this.butAdd.TabIndex = 2;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butEdit
            // 
            this.butEdit.Location = new System.Drawing.Point(303, 396);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(79, 34);
            this.butEdit.TabIndex = 3;
            this.butEdit.Text = "Edit";
            this.butEdit.UseVisualStyleBackColor = true;
            this.butEdit.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(690, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 22);
            this.textBox1.TabIndex = 16;
            // 
            // cbbLSH
            // 
            this.cbbLSH.FormattingEnabled = true;
            this.cbbLSH.Location = new System.Drawing.Point(157, 30);
            this.cbbLSH.Name = "cbbLSH";
            this.cbbLSH.Size = new System.Drawing.Size(171, 24);
            this.cbbLSH.TabIndex = 15;
            // 
            // butSearch
            // 
            this.butSearch.Location = new System.Drawing.Point(913, 27);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(80, 28);
            this.butSearch.TabIndex = 14;
            this.butSearch.Text = "Search";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // labLopSH
            // 
            this.labLopSH.AutoSize = true;
            this.labLopSH.Location = new System.Drawing.Point(42, 33);
            this.labLopSH.Name = "labLopSH";
            this.labLopSH.Size = new System.Drawing.Size(98, 17);
            this.labLopSH.TabIndex = 13;
            this.labLopSH.Text = "Lớp Sinh Hoạt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 633);
            this.Controls.Add(this.groupDSSV);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbbLSH);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.labLopSH);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupDSSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupDSSV;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butSort;
        private System.Windows.Forms.Button butShow;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butEdit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbbLSH;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.Label labLopSH;
    }
}

