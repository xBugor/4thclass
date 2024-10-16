namespace VeriTabaniIlkUygulama
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrenciEvDataBaseDataSet = new VeriTabaniIlkUygulama.OgrenciEvDataBaseDataSet();
            this.tblOgrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_OgrenciTableAdapter = new VeriTabaniIlkUygulama.OgrenciEvDataBaseDataSetTableAdapters.Tbl_OgrenciTableAdapter();
            this.ogranciNumarasıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_listele = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Soyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_no = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_burs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_bolum = new System.Windows.Forms.TextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciEvDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOgrenciBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogranciNumarasıDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.sehirDataGridViewTextBoxColumn,
            this.bursDataGridViewTextBoxColumn,
            this.bolumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblOgrenciBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 394);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(715, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ogrenciEvDataBaseDataSet
            // 
            this.ogrenciEvDataBaseDataSet.DataSetName = "OgrenciEvDataBaseDataSet";
            this.ogrenciEvDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblOgrenciBindingSource
            // 
            this.tblOgrenciBindingSource.DataMember = "Tbl_Ogrenci";
            this.tblOgrenciBindingSource.DataSource = this.ogrenciEvDataBaseDataSet;
            // 
            // tbl_OgrenciTableAdapter
            // 
            this.tbl_OgrenciTableAdapter.ClearBeforeFill = true;
            // 
            // ogranciNumarasıDataGridViewTextBoxColumn
            // 
            this.ogranciNumarasıDataGridViewTextBoxColumn.DataPropertyName = "OgranciNumarası";
            this.ogranciNumarasıDataGridViewTextBoxColumn.HeaderText = "OgranciNumarası";
            this.ogranciNumarasıDataGridViewTextBoxColumn.Name = "ogranciNumarasıDataGridViewTextBoxColumn";
            this.ogranciNumarasıDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // sehirDataGridViewTextBoxColumn
            // 
            this.sehirDataGridViewTextBoxColumn.DataPropertyName = "Sehir";
            this.sehirDataGridViewTextBoxColumn.HeaderText = "Sehir";
            this.sehirDataGridViewTextBoxColumn.Name = "sehirDataGridViewTextBoxColumn";
            // 
            // bursDataGridViewTextBoxColumn
            // 
            this.bursDataGridViewTextBoxColumn.DataPropertyName = "Burs";
            this.bursDataGridViewTextBoxColumn.HeaderText = "Burs";
            this.bursDataGridViewTextBoxColumn.Name = "bursDataGridViewTextBoxColumn";
            // 
            // bolumDataGridViewTextBoxColumn
            // 
            this.bolumDataGridViewTextBoxColumn.DataPropertyName = "Bolum";
            this.bolumDataGridViewTextBoxColumn.HeaderText = "Bolum";
            this.bolumDataGridViewTextBoxColumn.Name = "bolumDataGridViewTextBoxColumn";
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(178, 209);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(75, 23);
            this.btn_listele.TabIndex = 1;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_bolum);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_burs);
            this.groupBox1.Controls.Add(this.txt_soyad);
            this.groupBox1.Controls.Add(this.txt_ad);
            this.groupBox1.Controls.Add(this.txt_no);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Soyad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(54, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 238);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_temizle);
            this.groupBox2.Controls.Add(this.btn_guncelle);
            this.groupBox2.Controls.Add(this.btn_sil);
            this.groupBox2.Controls.Add(this.btn_listele);
            this.groupBox2.Controls.Add(this.btn_kaydet);
            this.groupBox2.Location = new System.Drawing.Point(489, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 238);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "OgrenciNo";
            // 
            // Soyad
            // 
            this.Soyad.AutoSize = true;
            this.Soyad.Location = new System.Drawing.Point(26, 51);
            this.Soyad.Name = "Soyad";
            this.Soyad.Size = new System.Drawing.Size(20, 13);
            this.Soyad.TabIndex = 1;
            this.Soyad.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sehir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Burs";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_no
            // 
            this.txt_no.Location = new System.Drawing.Point(111, 16);
            this.txt_no.Name = "txt_no";
            this.txt_no.Size = new System.Drawing.Size(100, 20);
            this.txt_no.TabIndex = 5;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(111, 51);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(100, 20);
            this.txt_ad.TabIndex = 6;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(111, 86);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(100, 20);
            this.txt_soyad.TabIndex = 7;
            // 
            // txt_burs
            // 
            this.txt_burs.Location = new System.Drawing.Point(111, 158);
            this.txt_burs.Name = "txt_burs";
            this.txt_burs.Size = new System.Drawing.Size(100, 20);
            this.txt_burs.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bölüm";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kilis",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Şanlıurfa",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.comboBox1.Location = new System.Drawing.Point(111, 123);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // txt_bolum
            // 
            this.txt_bolum.Location = new System.Drawing.Point(111, 188);
            this.txt_bolum.Name = "txt_bolum";
            this.txt_bolum.Size = new System.Drawing.Size(100, 20);
            this.txt_bolum.TabIndex = 11;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(32, 40);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 0;
            this.btn_kaydet.Text = "Kisi Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(32, 69);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 1;
            this.btn_sil.Text = "Kayıt Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(32, 98);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_guncelle.TabIndex = 2;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(32, 127);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(75, 23);
            this.btn_temizle.TabIndex = 3;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(901, 608);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciEvDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOgrenciBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private OgrenciEvDataBaseDataSet ogrenciEvDataBaseDataSet;
        private System.Windows.Forms.BindingSource tblOgrenciBindingSource;
        private OgrenciEvDataBaseDataSetTableAdapters.Tbl_OgrenciTableAdapter tbl_OgrenciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogranciNumarasıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_burs;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_no;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Soyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_bolum;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_kaydet;
    }
}

