
namespace Institute_Easy_Exam
{
    partial class Form20
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.questionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.option1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.option2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.option3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.option4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.javaquestionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mcqset2DataSet = new Institute_Easy_Exam.mcqset2DataSet();
            this.java_questionsTableAdapter = new Institute_Easy_Exam.mcqset2DataSetTableAdapters.java_questionsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.javaquestionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcqset2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 124);
            this.panel1.TabIndex = 3;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(708, 42);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(17, 16);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(237, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Check Questions for JAVA";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(127, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(554, 323);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.questionsDataGridViewTextBoxColumn,
            this.option1DataGridViewTextBoxColumn,
            this.option2DataGridViewTextBoxColumn,
            this.option3DataGridViewTextBoxColumn,
            this.option4DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.javaquestionsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(69, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(10, 15);
            this.dataGridView1.TabIndex = 0;
            // 
            // questionsDataGridViewTextBoxColumn
            // 
            this.questionsDataGridViewTextBoxColumn.DataPropertyName = "questions";
            this.questionsDataGridViewTextBoxColumn.HeaderText = "questions";
            this.questionsDataGridViewTextBoxColumn.Name = "questionsDataGridViewTextBoxColumn";
            // 
            // option1DataGridViewTextBoxColumn
            // 
            this.option1DataGridViewTextBoxColumn.DataPropertyName = "option1";
            this.option1DataGridViewTextBoxColumn.HeaderText = "option1";
            this.option1DataGridViewTextBoxColumn.Name = "option1DataGridViewTextBoxColumn";
            // 
            // option2DataGridViewTextBoxColumn
            // 
            this.option2DataGridViewTextBoxColumn.DataPropertyName = "option2";
            this.option2DataGridViewTextBoxColumn.HeaderText = "option2";
            this.option2DataGridViewTextBoxColumn.Name = "option2DataGridViewTextBoxColumn";
            // 
            // option3DataGridViewTextBoxColumn
            // 
            this.option3DataGridViewTextBoxColumn.DataPropertyName = "option3";
            this.option3DataGridViewTextBoxColumn.HeaderText = "option3";
            this.option3DataGridViewTextBoxColumn.Name = "option3DataGridViewTextBoxColumn";
            // 
            // option4DataGridViewTextBoxColumn
            // 
            this.option4DataGridViewTextBoxColumn.DataPropertyName = "option4";
            this.option4DataGridViewTextBoxColumn.HeaderText = "option4";
            this.option4DataGridViewTextBoxColumn.Name = "option4DataGridViewTextBoxColumn";
            // 
            // javaquestionsBindingSource
            // 
            this.javaquestionsBindingSource.DataMember = "java_questions";
            this.javaquestionsBindingSource.DataSource = this.mcqset2DataSet;
            // 
            // mcqset2DataSet
            // 
            this.mcqset2DataSet.DataSetName = "mcqset2DataSet";
            this.mcqset2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // java_questionsTableAdapter
            // 
            this.java_questionsTableAdapter.ClearBeforeFill = true;
            // 
            // Form20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Institute_Easy_Exam.Properties.Resources.main_dashboard_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form20";
            this.Text = "Form20";
            this.Load += new System.EventHandler(this.Form20_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.javaquestionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcqset2DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private mcqset2DataSet mcqset2DataSet;
        private System.Windows.Forms.BindingSource javaquestionsBindingSource;
        private mcqset2DataSetTableAdapters.java_questionsTableAdapter java_questionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn option1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn option2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn option3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn option4DataGridViewTextBoxColumn;
    }
}