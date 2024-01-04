namespace STUDENTSYSTEM
{
    partial class list
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrsehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciIslemDataSet8 = new STUDENTSYSTEM.OgrenciIslemDataSet8();
            this.btncıkıs = new System.Windows.Forms.Button();
            this.tblogrenciTableAdapter = new STUDENTSYSTEM.OgrenciIslemDataSet8TableAdapters.tblogrenciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciIslemDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.ogradDataGridViewTextBoxColumn,
            this.ogrsoyadDataGridViewTextBoxColumn,
            this.ogrnoDataGridViewTextBoxColumn,
            this.ogrsehirDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblogrenciBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 446);
            this.dataGridView1.TabIndex = 0;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogradDataGridViewTextBoxColumn
            // 
            this.ogradDataGridViewTextBoxColumn.DataPropertyName = "ograd";
            this.ogradDataGridViewTextBoxColumn.HeaderText = "ograd";
            this.ogradDataGridViewTextBoxColumn.Name = "ogradDataGridViewTextBoxColumn";
            // 
            // ogrsoyadDataGridViewTextBoxColumn
            // 
            this.ogrsoyadDataGridViewTextBoxColumn.DataPropertyName = "ogrsoyad";
            this.ogrsoyadDataGridViewTextBoxColumn.HeaderText = "ogrsoyad";
            this.ogrsoyadDataGridViewTextBoxColumn.Name = "ogrsoyadDataGridViewTextBoxColumn";
            // 
            // ogrnoDataGridViewTextBoxColumn
            // 
            this.ogrnoDataGridViewTextBoxColumn.DataPropertyName = "ogrno";
            this.ogrnoDataGridViewTextBoxColumn.HeaderText = "ogrno";
            this.ogrnoDataGridViewTextBoxColumn.Name = "ogrnoDataGridViewTextBoxColumn";
            // 
            // ogrsehirDataGridViewTextBoxColumn
            // 
            this.ogrsehirDataGridViewTextBoxColumn.DataPropertyName = "ogrsehir";
            this.ogrsehirDataGridViewTextBoxColumn.HeaderText = "ogrsehir";
            this.ogrsehirDataGridViewTextBoxColumn.Name = "ogrsehirDataGridViewTextBoxColumn";
            // 
            // tblogrenciBindingSource
            // 
            this.tblogrenciBindingSource.DataMember = "tblogrenci";
            this.tblogrenciBindingSource.DataSource = this.ogrenciIslemDataSet8;
            // 
            // ogrenciIslemDataSet8
            // 
            this.ogrenciIslemDataSet8.DataSetName = "OgrenciIslemDataSet8";
            this.ogrenciIslemDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btncıkıs
            // 
            this.btncıkıs.BackColor = System.Drawing.Color.Tomato;
            this.btncıkıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncıkıs.ForeColor = System.Drawing.Color.White;
            this.btncıkıs.Location = new System.Drawing.Point(544, 339);
            this.btncıkıs.Name = "btncıkıs";
            this.btncıkıs.Size = new System.Drawing.Size(74, 108);
            this.btncıkıs.TabIndex = 23;
            this.btncıkıs.Text = "GERİ";
            this.btncıkıs.UseVisualStyleBackColor = false;
            this.btncıkıs.Click += new System.EventHandler(this.btncıkıs_Click);
            // 
            // tblogrenciTableAdapter
            // 
            this.tblogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(619, 450);
            this.Controls.Add(this.btncıkıs);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "list";
            this.Text = "list";
            this.Load += new System.EventHandler(this.list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciIslemDataSet8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btncıkıs;
        private OgrenciIslemDataSet8 ogrenciIslemDataSet8;
        private System.Windows.Forms.BindingSource tblogrenciBindingSource;
        private OgrenciIslemDataSet8TableAdapters.tblogrenciTableAdapter tblogrenciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrsehirDataGridViewTextBoxColumn;
    }
}