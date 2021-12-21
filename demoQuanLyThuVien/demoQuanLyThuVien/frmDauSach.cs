﻿using demoQuanLyThuVien.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoQuanLyThuVien
{
    public partial class frmDauSach : Form
    {
        Model.ModelThuVien db = new Model.ModelThuVien();
        public frmDauSach()
        {
            InitializeComponent();
        }

        private void frmDauSach_Load(object sender, EventArgs e)
        {
            hienthi();
        }
        public void hienthi()
        {
            
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem li in listView1.SelectedItems)
            {
                txtTimKiem.Text = li.SubItems[0].Text;
                txtTenDS.Text = li.SubItems[1].Text;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DauSach ds = db.DauSach.Find(txtTimKiem.Text);
            if (ds != null)
            {
                listView1.Items.Clear();
                ListViewItem li = listView1.Items.Add(ds.mads);
                li.SubItems.Add(ds.tends);

            }
            else
            {
                MessageBox.Show("Không tìn thấy thông tin đầu sách!!!!!");
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQLSach ql = new frmQLSach();
            ql.ShowDialog();
        }

        private void btnHoantat_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
            

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DauSach ds = db.DauSach.Find(txtTimKiem.Text);
            if (ds == null)
            {
                MessageBox.Show("Đầu sách chưa tồn tại nên không thể xóa!!");
            }
            ds.tends = txtTenDS.Text;
            db.SaveChanges();
            hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            

        
    }
}
