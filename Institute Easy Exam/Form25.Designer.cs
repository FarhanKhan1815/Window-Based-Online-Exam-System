
namespace Institute_Easy_Exam
{
    partial class Form25
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
            this.examBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recordsDataSet5 = new Institute_Easy_Exam.RecordsDataSet5();
            this.examTableAdapter = new Institute_Easy_Exam.RecordsDataSet5TableAdapters.ExamTableAdapter();
            this.recordsDataSet6 = new Institute_Easy_Exam.RecordsDataSet6();
            this.examBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.examTableAdapter1 = new Institute_Easy_Exam.RecordsDataSet6TableAdapters.ExamTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Purple;
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 134);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(254, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Percentage For Vb.Net";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(169, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 326);
            this.panel2.TabIndex = 2;
            // 
            // examBindingSource
            // 
            this.examBindingSource.DataMember = "Exam";
            this.examBindingSource.DataSource = this.recordsDataSet5;
            // 
            // recordsDataSet5
            // 
            this.recordsDataSet5.DataSetName = "RecordsDataSet5";
            this.recordsDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examTableAdapter
            // 
            this.examTableAdapter.ClearBeforeFill = true;
            // 
            // recordsDataSet6
            // 
            this.recordsDataSet6.DataSetName = "RecordsDataSet6";
            this.recordsDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examBindingSource1
            // 
            this.examBindingSource1.DataMember = "Exam";
            this.examBindingSource1.DataSource = this.recordsDataSet6;
            // 
            // examTableAdapter1
            // 
            this.examTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(427, 292);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form25
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form25";
            this.Text = "Form25";
            this.Load += new System.EventHandler(this.Form25_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private RecordsDataSet5 recordsDataSet5;
        private System.Windows.Forms.BindingSource examBindingSource;
        private RecordsDataSet5TableAdapters.ExamTableAdapter examTableAdapter;
        private RecordsDataSet6 recordsDataSet6;
        private System.Windows.Forms.BindingSource examBindingSource1;
        private RecordsDataSet6TableAdapters.ExamTableAdapter examTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}