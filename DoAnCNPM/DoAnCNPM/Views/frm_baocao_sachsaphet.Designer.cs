﻿namespace DoAnCNPM.Views
{
    partial class frm_baocao_sachsaphet
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
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.cbx_option_search = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(609, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh sách Sách sắp được mượn hết";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(168, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "Danh sách chi tiết của sách";
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.Location = new System.Drawing.Point(565, 125);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(219, 25);
            this.txt_timkiem.TabIndex = 42;
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(352, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 45;
            this.label7.Text = "Tìm kiếm theo";
            // 
            // dtgv
            // 
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.GridColor = System.Drawing.SystemColors.Control;
            this.dtgv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtgv.Location = new System.Drawing.Point(171, 177);
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv.Size = new System.Drawing.Size(845, 243);
            this.dtgv.TabIndex = 46;
            // 
            // cbx_option_search
            // 
            this.cbx_option_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_option_search.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_option_search.FormattingEnabled = true;
            this.cbx_option_search.Items.AddRange(new object[] {
            "Mã khoa",
            "Tên khoa",
            "Địa chỉ",
            "Điện thoại"});
            this.cbx_option_search.Location = new System.Drawing.Point(450, 125);
            this.cbx_option_search.Name = "cbx_option_search";
            this.cbx_option_search.Size = new System.Drawing.Size(110, 25);
            this.cbx_option_search.TabIndex = 43;
            // 
            // frm_baocao_sachsaphet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 464);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.cbx_option_search);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_baocao_sachsaphet";
            this.Text = "frm_baocao_sachhong";
            this.Load += new System.EventHandler(this.frm_capnhat_sach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.ComboBox cbx_option_search;
    }
}