﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriTabaniIlkUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ogrenciEvDataBaseDataSet.Tbl_Ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            this.tbl_OgrenciTableAdapter.Fill(this.ogrenciEvDataBaseDataSet.Tbl_Ogrenci);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
