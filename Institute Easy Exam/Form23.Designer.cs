
namespace Institute_Easy_Exam
{
    partial class Form23
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form23));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.enrollDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cplusscoreboardBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mcqset1DataSet12 = new Institute_Easy_Exam.mcqset1DataSet12();
            this.cplusscoreboardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mcqset1DataSet11 = new Institute_Easy_Exam.mcqset1DataSet11();
            this.cplusscoreboardTableAdapter = new Institute_Easy_Exam.mcqset1DataSet11TableAdapters.cplusscoreboardTableAdapter();
            this.cplusscoreboardTableAdapter1 = new Institute_Easy_Exam.mcqset1DataSet12TableAdapters.cplusscoreboardTableAdapter();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cplusscoreboardBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcqset1DataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cplusscoreboardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcqset1DataSet11)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.enrollDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn,
            this.percentageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cplusscoreboardBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.Size = new System.Drawing.Size(557, 354);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // enrollDataGridViewTextBoxColumn
            // 
            this.enrollDataGridViewTextBoxColumn.DataPropertyName = "Enroll";
            this.enrollDataGridViewTextBoxColumn.HeaderText = "Enroll";
            this.enrollDataGridViewTextBoxColumn.Name = "enrollDataGridViewTextBoxColumn";
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "score";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            // 
            // percentageDataGridViewTextBoxColumn
            // 
            this.percentageDataGridViewTextBoxColumn.DataPropertyName = "percentage";
            this.percentageDataGridViewTextBoxColumn.HeaderText = "percentage";
            this.percentageDataGridViewTextBoxColumn.Name = "percentageDataGridViewTextBoxColumn";
            // 
            // cplusscoreboardBindingSource1
            // 
            this.cplusscoreboardBindingSource1.DataMember = "cplusscoreboard";
            this.cplusscoreboardBindingSource1.DataSource = this.mcqset1DataSet12;
            // 
            // mcqset1DataSet12
            // 
            this.mcqset1DataSet12.DataSetName = "mcqset1DataSet12";
            this.mcqset1DataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cplusscoreboardBindingSource
            // 
            this.cplusscoreboardBindingSource.DataMember = "cplusscoreboard";
            this.cplusscoreboardBindingSource.DataSource = this.mcqset1DataSet11;
            // 
            // mcqset1DataSet11
            // 
            this.mcqset1DataSet11.DataSetName = "mcqset1DataSet11";
            this.mcqset1DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cplusscoreboardTableAdapter
            // 
            this.cplusscoreboardTableAdapter.ClearBeforeFill = true;
            // 
            // cplusscoreboardTableAdapter1
            // 
            this.cplusscoreboardTableAdapter1.ClearBeforeFill = true;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.panel2);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(193)))), ((int)(((byte)(149)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(173)))), ((int)(((byte)(164)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(173)))), ((int)(((byte)(164)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(571, 450);
            this.bunifuGradientPanel1.TabIndex = 3;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(524, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(209, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Results!!!";
            // 
            // Form23
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "Form23";
            this.Text = "Form23";
            this.Load += new System.EventHandler(this.Form23_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cplusscoreboardBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcqset1DataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cplusscoreboardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcqset1DataSet11)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private mcqset1DataSet11 mcqset1DataSet11;
        private System.Windows.Forms.BindingSource cplusscoreboardBindingSource;
        private mcqset1DataSet11TableAdapters.cplusscoreboardTableAdapter cplusscoreboardTableAdapter;
        private mcqset1DataSet12 mcqset1DataSet12;
        private System.Windows.Forms.BindingSource cplusscoreboardBindingSource1;
        private mcqset1DataSet12TableAdapters.cplusscoreboardTableAdapter cplusscoreboardTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn enrollDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentageDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}