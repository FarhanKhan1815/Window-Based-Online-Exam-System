
namespace Institute_Easy_Exam
{
    partial class Form22
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form22));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.enrollDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filepathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagesDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.javapercentageBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mcqset2DataSet3 = new Institute_Easy_Exam.mcqset2DataSet3();
            this.javapercentageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mcqset2DataSet2 = new Institute_Easy_Exam.mcqset2DataSet2();
            this.cplusscoreboardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mcqset1DataSet10 = new Institute_Easy_Exam.mcqset1DataSet10();
            this.compareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mcqset1DataSet8 = new Institute_Easy_Exam.mcqset1DataSet8();
            this.cpercentageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mcqset1DataSet7 = new Institute_Easy_Exam.mcqset1DataSet7();
            this.c__percentageTableAdapter = new Institute_Easy_Exam.mcqset1DataSet7TableAdapters.c__percentageTableAdapter();
            this.compareTableAdapter = new Institute_Easy_Exam.mcqset1DataSet8TableAdapters.compareTableAdapter();
            this.cplusscoreboardTableAdapter = new Institute_Easy_Exam.mcqset1DataSet10TableAdapters.cplusscoreboardTableAdapter();
            this.java_percentageTableAdapter = new Institute_Easy_Exam.mcqset2DataSet2TableAdapters.java_percentageTableAdapter();
            this.java_percentageTableAdapter1 = new Institute_Easy_Exam.mcqset2DataSet3TableAdapters.java_percentageTableAdapter();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.javapercentageBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcqset2DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.javapercentageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcqset2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cplusscoreboardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcqset1DataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcqset1DataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpercentageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcqset1DataSet7)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(213, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Results!!!";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(3, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(565, 371);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.enrollDataGridViewTextBoxColumn,
            this.filepathDataGridViewTextBoxColumn,
            this.imagesDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.javapercentageBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.Size = new System.Drawing.Size(557, 363);
            this.dataGridView1.TabIndex = 0;
            // 
            // enrollDataGridViewTextBoxColumn
            // 
            this.enrollDataGridViewTextBoxColumn.DataPropertyName = "Enroll";
            this.enrollDataGridViewTextBoxColumn.HeaderText = "Enroll";
            this.enrollDataGridViewTextBoxColumn.Name = "enrollDataGridViewTextBoxColumn";
            // 
            // filepathDataGridViewTextBoxColumn
            // 
            this.filepathDataGridViewTextBoxColumn.DataPropertyName = "filepath";
            this.filepathDataGridViewTextBoxColumn.HeaderText = "filepath";
            this.filepathDataGridViewTextBoxColumn.Name = "filepathDataGridViewTextBoxColumn";
            // 
            // imagesDataGridViewImageColumn
            // 
            this.imagesDataGridViewImageColumn.DataPropertyName = "images";
            this.imagesDataGridViewImageColumn.HeaderText = "images";
            this.imagesDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.imagesDataGridViewImageColumn.Name = "imagesDataGridViewImageColumn";
            // 
            // javapercentageBindingSource1
            // 
            this.javapercentageBindingSource1.DataMember = "java_percentage";
            this.javapercentageBindingSource1.DataSource = this.mcqset2DataSet3;
            // 
            // mcqset2DataSet3
            // 
            this.mcqset2DataSet3.DataSetName = "mcqset2DataSet3";
            this.mcqset2DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // javapercentageBindingSource
            // 
            this.javapercentageBindingSource.DataMember = "java_percentage";
            this.javapercentageBindingSource.DataSource = this.mcqset2DataSet2;
            // 
            // mcqset2DataSet2
            // 
            this.mcqset2DataSet2.DataSetName = "mcqset2DataSet2";
            this.mcqset2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cplusscoreboardBindingSource
            // 
            this.cplusscoreboardBindingSource.DataMember = "cplusscoreboard";
            this.cplusscoreboardBindingSource.DataSource = this.mcqset1DataSet10;
            // 
            // mcqset1DataSet10
            // 
            this.mcqset1DataSet10.DataSetName = "mcqset1DataSet10";
            this.mcqset1DataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // compareBindingSource
            // 
            this.compareBindingSource.DataMember = "compare";
            this.compareBindingSource.DataSource = this.mcqset1DataSet8;
            // 
            // mcqset1DataSet8
            // 
            this.mcqset1DataSet8.DataSetName = "mcqset1DataSet8";
            this.mcqset1DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cpercentageBindingSource
            // 
            this.cpercentageBindingSource.DataMember = "c++percentage";
            this.cpercentageBindingSource.DataSource = this.mcqset1DataSet7;
            // 
            // mcqset1DataSet7
            // 
            this.mcqset1DataSet7.DataSetName = "mcqset1DataSet7";
            this.mcqset1DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // c__percentageTableAdapter
            // 
            this.c__percentageTableAdapter.ClearBeforeFill = true;
            // 
            // compareTableAdapter
            // 
            this.compareTableAdapter.ClearBeforeFill = true;
            // 
            // cplusscoreboardTableAdapter
            // 
            this.cplusscoreboardTableAdapter.ClearBeforeFill = true;
            // 
            // java_percentageTableAdapter
            // 
            this.java_percentageTableAdapter.ClearBeforeFill = true;
            // 
            // java_percentageTableAdapter1
            // 
            this.java_percentageTableAdapter1.ClearBeforeFill = true;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.panel2);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(193)))), ((int)(((byte)(149)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(173)))), ((int)(((byte)(164)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(173)))), ((int)(((byte)(164)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(571, 450);
            this.bunifuGradientPanel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(533, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Form22
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 450);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "Form22";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form22";
            this.Load += new System.EventHandler(this.Form22_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.javapercentageBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcqset2DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.javapercentageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcqset2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cplusscoreboardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcqset1DataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcqset1DataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpercentageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcqset1DataSet7)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private mcqset1DataSet7 mcqset1DataSet7;
        private System.Windows.Forms.BindingSource cpercentageBindingSource;
        private mcqset1DataSet7TableAdapters.c__percentageTableAdapter c__percentageTableAdapter;
        private mcqset1DataSet8 mcqset1DataSet8;
        private System.Windows.Forms.BindingSource compareBindingSource;
        private mcqset1DataSet8TableAdapters.compareTableAdapter compareTableAdapter;
        private mcqset1DataSet10 mcqset1DataSet10;
        private System.Windows.Forms.BindingSource cplusscoreboardBindingSource;
        private mcqset1DataSet10TableAdapters.cplusscoreboardTableAdapter cplusscoreboardTableAdapter;
        private mcqset2DataSet2 mcqset2DataSet2;
        private System.Windows.Forms.BindingSource javapercentageBindingSource;
        private mcqset2DataSet2TableAdapters.java_percentageTableAdapter java_percentageTableAdapter;
        private mcqset2DataSet3 mcqset2DataSet3;
        private System.Windows.Forms.BindingSource javapercentageBindingSource1;
        private mcqset2DataSet3TableAdapters.java_percentageTableAdapter java_percentageTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn enrollDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filepathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imagesDataGridViewImageColumn;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label2;
    }
}