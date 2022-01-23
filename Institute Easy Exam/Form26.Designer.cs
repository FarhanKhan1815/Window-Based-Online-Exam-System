
namespace Institute_Easy_Exam
{
    partial class Form26
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mcqset2DataSet1 = new Institute_Easy_Exam.mcqset2DataSet1();
            this.javapercentageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.java_percentageTableAdapter = new Institute_Easy_Exam.mcqset2DataSet1TableAdapters.java_percentageTableAdapter();
            this.percentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrollDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcqset2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.javapercentageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Purple;
            this.panel1.Location = new System.Drawing.Point(1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 134);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(254, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Percentage For Java";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(192, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 326);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.percentageDataGridViewTextBoxColumn,
            this.enrollDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.javapercentageBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(427, 292);
            this.dataGridView1.TabIndex = 0;
            // 
            // mcqset2DataSet1
            // 
            this.mcqset2DataSet1.DataSetName = "mcqset2DataSet1";
            this.mcqset2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // javapercentageBindingSource
            // 
            this.javapercentageBindingSource.DataMember = "java_percentage";
            this.javapercentageBindingSource.DataSource = this.mcqset2DataSet1;
            // 
            // java_percentageTableAdapter
            // 
            this.java_percentageTableAdapter.ClearBeforeFill = true;
            // 
            // percentageDataGridViewTextBoxColumn
            // 
            this.percentageDataGridViewTextBoxColumn.DataPropertyName = "percentage";
            this.percentageDataGridViewTextBoxColumn.HeaderText = "percentage";
            this.percentageDataGridViewTextBoxColumn.Name = "percentageDataGridViewTextBoxColumn";
            // 
            // enrollDataGridViewTextBoxColumn
            // 
            this.enrollDataGridViewTextBoxColumn.DataPropertyName = "Enroll";
            this.enrollDataGridViewTextBoxColumn.HeaderText = "Enroll";
            this.enrollDataGridViewTextBoxColumn.Name = "enrollDataGridViewTextBoxColumn";
            // 
            // Form26
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form26";
            this.Text = "Form26";
            this.Load += new System.EventHandler(this.Form26_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcqset2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.javapercentageBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private mcqset2DataSet1 mcqset2DataSet1;
        private System.Windows.Forms.BindingSource javapercentageBindingSource;
        private mcqset2DataSet1TableAdapters.java_percentageTableAdapter java_percentageTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enrollDataGridViewTextBoxColumn;
    }
}