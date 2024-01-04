namespace STUDENTSYSTEM
{
    partial class delete
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
            this.tblogrenciTableAdapter = new STUDENTSYSTEM.OgrenciIslemDataSet2TableAdapters.tblogrenciTableAdapter();
            this.tblogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciIslemDataSet2 = new STUDENTSYSTEM.OgrenciIslemDataSet2();
            this.label6 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btncıkıs = new System.Windows.Forms.Button();
            this.btnlistele = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.ogrsehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciIslemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblogrenciTableAdapter
            // 
            this.tblogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // tblogrenciBindingSource
            // 
            this.tblogrenciBindingSource.DataMember = "tblogrenci";
            this.tblogrenciBindingSource.DataSource = this.ogrenciIslemDataSet2;
            this.tblogrenciBindingSource.CurrentChanged += new System.EventHandler(this.tblogrenciBindingSource_CurrentChanged);
            // 
            // ogrenciIslemDataSet2
            // 
            this.ogrenciIslemDataSet2.DataSetName = "OgrenciIslemDataSet2";
            this.ogrenciIslemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(642, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 24);
            this.label6.TabIndex = 28;
            this.label6.Text = "ID:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textId
            // 
            this.textId.BackColor = System.Drawing.SystemColors.Info;
            this.textId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textId.Location = new System.Drawing.Point(692, 139);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(226, 29);
            this.textId.TabIndex = 29;
            this.textId.TextChanged += new System.EventHandler(this.textId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(642, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "AD:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(600, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "SOYAD:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(582, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "NUMARA:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(609, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "ŞEHİR:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(692, 174);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 29);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(692, 209);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(226, 29);
            this.textBox2.TabIndex = 19;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Info;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(692, 244);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(226, 29);
            this.textBox3.TabIndex = 20;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "01- Adana",
            "02- Adıyaman",
            "03- Afyonkarahisar",
            "04- Ağrı",
            "05- Amasya",
            "06- Ankara",
            "07- Antalya",
            "08- Artvin",
            "09- Aydın",
            "10- Balıkesir",
            "11- Bilecik",
            "12- Bingöl",
            "13- Bitlis",
            "14- Bolu",
            "15- Burdur",
            "16- Bursa",
            "17- Çanakkale",
            "18- Çankırı",
            "19- Çorum",
            "20- Denizli",
            "21- Diyarbakır",
            "22- Edirne",
            "23- Elazığ",
            "24- Erzincan",
            "25- Erzurum",
            "26- Eskişehir",
            "27- Gaziantep",
            "28- Giresun",
            "29- Gümüşhane",
            "30- Hakkari",
            "31- Hatay",
            "32- Isparta",
            "33- Mersin",
            "34- İstanbul",
            "35- İzmir",
            "36- Kars",
            "37- Kastamonu",
            "38- Kayseri",
            "39- Kırklareli",
            "40- Kırşehir",
            "41- Kocaeli",
            "42- Konya",
            "43- Kütahya",
            "44- Malatya",
            "45- Manisa",
            "46- K.Maraş",
            "47- Mardin",
            "48- Muğla",
            "49- Muş",
            "50- Nevşehir",
            "51- Niğde",
            "52- Ordu",
            "53- Rize",
            "54- Sakarya",
            "55- Samsun",
            "56- Siirt",
            "57- Sinop",
            "58- Sivas",
            "59- Tekirdağ",
            "60- Tokat",
            "61- Trabzon",
            "62- Tunceli",
            "63- Şanlıurfa",
            "64- Uşak",
            "65- Van",
            "66- Yozgat",
            "67- Zonguldak",
            "68- Aksaray",
            "69- Bayburt",
            "70- Karaman",
            "71- Kırıkkale",
            "72- Batman",
            "73- Şırnak",
            "74- Bartın",
            "75- Ardahan",
            "76- Iğdır",
            "77- Yalova",
            "78- Karabük",
            "79- Kilis",
            "80- Osmaniye",
            "81- Düzce"});
            this.comboBox1.Location = new System.Drawing.Point(692, 279);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 32);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btncıkıs
            // 
            this.btncıkıs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btncıkıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncıkıs.ForeColor = System.Drawing.Color.White;
            this.btncıkıs.Location = new System.Drawing.Point(692, 384);
            this.btncıkıs.Name = "btncıkıs";
            this.btncıkıs.Size = new System.Drawing.Size(103, 40);
            this.btncıkıs.TabIndex = 22;
            this.btncıkıs.Text = "GERİ";
            this.btncıkıs.UseVisualStyleBackColor = false;
            this.btncıkıs.Click += new System.EventHandler(this.btncıkıs_Click);
            // 
            // btnlistele
            // 
            this.btnlistele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnlistele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnlistele.ForeColor = System.Drawing.Color.White;
            this.btnlistele.Location = new System.Drawing.Point(815, 384);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(103, 40);
            this.btnlistele.TabIndex = 23;
            this.btnlistele.Text = "LİSTELE";
            this.btnlistele.UseVisualStyleBackColor = false;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.Red;
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.ForeColor = System.Drawing.Color.White;
            this.btnekle.Location = new System.Drawing.Point(692, 338);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(226, 40);
            this.btnekle.TabIndex = 24;
            this.btnekle.Text = "SİL";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // ogrsehirDataGridViewTextBoxColumn
            // 
            this.ogrsehirDataGridViewTextBoxColumn.DataPropertyName = "ogrsehir";
            this.ogrsehirDataGridViewTextBoxColumn.HeaderText = "ogrsehir";
            this.ogrsehirDataGridViewTextBoxColumn.Name = "ogrsehirDataGridViewTextBoxColumn";
            // 
            // ogrnoDataGridViewTextBoxColumn
            // 
            this.ogrnoDataGridViewTextBoxColumn.DataPropertyName = "ogrno";
            this.ogrnoDataGridViewTextBoxColumn.HeaderText = "ogrno";
            this.ogrnoDataGridViewTextBoxColumn.Name = "ogrnoDataGridViewTextBoxColumn";
            // 
            // ogrsoyadDataGridViewTextBoxColumn
            // 
            this.ogrsoyadDataGridViewTextBoxColumn.DataPropertyName = "ogrsoyad";
            this.ogrsoyadDataGridViewTextBoxColumn.HeaderText = "ogrsoyad";
            this.ogrsoyadDataGridViewTextBoxColumn.Name = "ogrsoyadDataGridViewTextBoxColumn";
            // 
            // ogradDataGridViewTextBoxColumn
            // 
            this.ogradDataGridViewTextBoxColumn.DataPropertyName = "ograd";
            this.ogradDataGridViewTextBoxColumn.HeaderText = "ograd";
            this.ogradDataGridViewTextBoxColumn.Name = "ogradDataGridViewTextBoxColumn";
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.ogradDataGridViewTextBoxColumn,
            this.ogrsoyadDataGridViewTextBoxColumn,
            this.ogrnoDataGridViewTextBoxColumn,
            this.ogrsehirDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblogrenciBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 463);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(565, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(384, 45);
            this.label5.TabIndex = 26;
            this.label5.Text = "ÖĞRENCİ SİLME SAYFASI";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(993, 461);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.btncıkıs);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "delete";
            this.Text = "delete";
            this.Load += new System.EventHandler(this.delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciIslemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OgrenciIslemDataSet2TableAdapters.tblogrenciTableAdapter tblogrenciTableAdapter;
        private System.Windows.Forms.BindingSource tblogrenciBindingSource;
        private OgrenciIslemDataSet2 ogrenciIslemDataSet2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btncıkıs;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrsehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
    }
}