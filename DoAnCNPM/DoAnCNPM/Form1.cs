﻿using DoAnCNPM.Shareds;
using DoAnCNPM.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCNPM
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void item_thoat_Click(object sender, EventArgs e)
        {
            if (Utils.confirm_exit())
            {
                Application.Exit();
            }
        }

        private void btn_capnhat_docgia_Click(object sender, EventArgs e)
        {
            frm_capnhat_docgia temp = new frm_capnhat_docgia();
            Utils.add_form_to_panel(temp, panel1);
        }

        private void btn_capnhat_nhanvien_Click(object sender, EventArgs e)
        {
            frm_capnhat_nhanvien temp = new frm_capnhat_nhanvien();
            Utils.add_form_to_panel(temp, panel1);
        }

        private void btn_capnhat_sach_Click(object sender, EventArgs e)
        {
            frm_capnhat_sach temp = new frm_capnhat_sach();
            Utils.add_form_to_panel(temp, panel1);
        }

        private void btn_capnhat_tacgia_Click(object sender, EventArgs e)
        {
            frm_capnhat_tacgia temp = new frm_capnhat_tacgia();
            Utils.add_form_to_panel(temp, panel1);
        }

        private void btn_capnhat_nxb_Click(object sender, EventArgs e)
        {
            frm_capnhat_nxb temp = new frm_capnhat_nxb();
            Utils.add_form_to_panel(temp, panel1);
        }

        private void btn_capnhat_linhvuc_Click(object sender, EventArgs e)
        {
            frm_capnhat_linhvuc temp = new frm_capnhat_linhvuc();
            Utils.add_form_to_panel(temp, panel1);
        }

        private void btn_timkiem_sach_Click(object sender, EventArgs e)
        {
            frm_timkiem_sach temp = new frm_timkiem_sach();
            Utils.add_form_to_panel(temp, panel1);
        }
    }
}
