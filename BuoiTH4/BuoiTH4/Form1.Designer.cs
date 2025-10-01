namespace BuoiTH4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtnhap = new TextBox();
            btnnhap = new Button();
            btnin = new Button();
            button1 = new Button();
            btnthoat = new Button();
            btntang = new Button();
            btngiam = new Button();
            btntonghaimang = new Button();
            btnlonnhat = new Button();
            btsohoanhao = new Button();
            btnsonhonhat = new Button();
            btnsonguyento = new Button();
            btntrungbinh = new Button();
            btndemsole = new Button();
            btndemsochan = new Button();
            btnucln = new Button();
            txtkq = new TextBox();
            SuspendLayout();
            // 
            // txtnhap
            // 
            txtnhap.Location = new Point(144, 38);
            txtnhap.Name = "txtnhap";
            txtnhap.Size = new Size(149, 23);
            txtnhap.TabIndex = 1;
            // 
            // btnnhap
            // 
            btnnhap.Location = new Point(12, 38);
            btnnhap.Name = "btnnhap";
            btnnhap.Size = new Size(116, 23);
            btnnhap.TabIndex = 2;
            btnnhap.Text = "Nhập 1 phần tử";
            btnnhap.UseVisualStyleBackColor = true;
            btnnhap.Click += btnnhap_Click;
            // 
            // btnin
            // 
            btnin.Location = new Point(316, 38);
            btnin.Name = "btnin";
            btnin.Size = new Size(115, 23);
            btnin.TabIndex = 3;
            btnin.Text = "In mảng";
            btnin.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(437, 37);
            button1.Name = "button1";
            button1.Size = new Size(112, 23);
            button1.TabIndex = 4;
            button1.Text = "Xóa";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(555, 38);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(113, 23);
            btnthoat.TabIndex = 5;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            // 
            // btntang
            // 
            btntang.Location = new Point(555, 81);
            btntang.Name = "btntang";
            btntang.Size = new Size(113, 23);
            btntang.TabIndex = 7;
            btntang.Text = "Sắp xếp tăng dần";
            btntang.UseVisualStyleBackColor = true;
            // 
            // btngiam
            // 
            btngiam.Location = new Point(555, 127);
            btngiam.Name = "btngiam";
            btngiam.Size = new Size(113, 23);
            btngiam.TabIndex = 8;
            btngiam.Text = "sắp xếp giảm dần";
            btngiam.UseVisualStyleBackColor = true;
            // 
            // btntonghaimang
            // 
            btntonghaimang.Location = new Point(555, 172);
            btntonghaimang.Name = "btntonghaimang";
            btntonghaimang.Size = new Size(113, 23);
            btntonghaimang.TabIndex = 9;
            btntonghaimang.Text = "Tổng hai mảng";
            btntonghaimang.UseVisualStyleBackColor = true;
            // 
            // btnlonnhat
            // 
            btnlonnhat.Location = new Point(555, 217);
            btnlonnhat.Name = "btnlonnhat";
            btnlonnhat.Size = new Size(113, 23);
            btnlonnhat.TabIndex = 10;
            btnlonnhat.Text = "Số lớn nhất";
            btnlonnhat.UseVisualStyleBackColor = true;
            // 
            // btsohoanhao
            // 
            btsohoanhao.Location = new Point(396, 172);
            btsohoanhao.Name = "btsohoanhao";
            btsohoanhao.Size = new Size(115, 23);
            btsohoanhao.TabIndex = 11;
            btsohoanhao.Text = "Số hoàn hảo ";
            btsohoanhao.UseVisualStyleBackColor = true;
            // 
            // btnsonhonhat
            // 
            btnsonhonhat.Location = new Point(396, 217);
            btnsonhonhat.Name = "btnsonhonhat";
            btnsonhonhat.Size = new Size(115, 23);
            btnsonhonhat.TabIndex = 12;
            btnsonhonhat.Text = "Số nhỏ nhất";
            btnsonhonhat.UseVisualStyleBackColor = true;
            // 
            // btnsonguyento
            // 
            btnsonguyento.Location = new Point(252, 172);
            btnsonguyento.Name = "btnsonguyento";
            btnsonguyento.Size = new Size(115, 23);
            btnsonguyento.TabIndex = 13;
            btnsonguyento.Text = "Số nguyên tố";
            btnsonguyento.UseVisualStyleBackColor = true;
            // 
            // btntrungbinh
            // 
            btntrungbinh.Location = new Point(255, 217);
            btntrungbinh.Name = "btntrungbinh";
            btntrungbinh.Size = new Size(112, 23);
            btntrungbinh.TabIndex = 14;
            btntrungbinh.Text = "Trung bình mảng";
            btntrungbinh.UseVisualStyleBackColor = true;
            // 
            // btndemsole
            // 
            btndemsole.Location = new Point(128, 172);
            btndemsole.Name = "btndemsole";
            btndemsole.Size = new Size(96, 23);
            btndemsole.TabIndex = 15;
            btndemsole.Text = "Đếm số lẻ";
            btndemsole.UseVisualStyleBackColor = true;
            // 
            // btndemsochan
            // 
            btndemsochan.Location = new Point(12, 172);
            btndemsochan.Name = "btndemsochan";
            btndemsochan.Size = new Size(94, 23);
            btndemsochan.TabIndex = 16;
            btndemsochan.Text = "Đếm số chẵn";
            btndemsochan.UseVisualStyleBackColor = true;
            // 
            // btnucln
            // 
            btnucln.Location = new Point(12, 217);
            btnucln.Name = "btnucln";
            btnucln.Size = new Size(212, 23);
            btnucln.TabIndex = 17;
            btnucln.Text = "Ước chung lơn nhất 2 phần tử đầu tiên";
            btnucln.UseVisualStyleBackColor = true;
            // 
            // txtkq
            // 
            txtkq.BackColor = Color.Bisque;
            txtkq.ForeColor = SystemColors.MenuText;
            txtkq.Location = new Point(12, 67);
            txtkq.Multiline = true;
            txtkq.Name = "txtkq";
            txtkq.Size = new Size(537, 99);
            txtkq.TabIndex = 18;
            txtkq.TextChanged += txtkq_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(txtkq);
            Controls.Add(btnucln);
            Controls.Add(btndemsochan);
            Controls.Add(btndemsole);
            Controls.Add(btntrungbinh);
            Controls.Add(btnsonguyento);
            Controls.Add(btnsonhonhat);
            Controls.Add(btsohoanhao);
            Controls.Add(btnlonnhat);
            Controls.Add(btntonghaimang);
            Controls.Add(btngiam);
            Controls.Add(btntang);
            Controls.Add(btnthoat);
            Controls.Add(button1);
            Controls.Add(btnin);
            Controls.Add(btnnhap);
            Controls.Add(txtnhap);
            ForeColor = Color.FromArgb(64, 64, 64);
            Name = "Form1";
            Text = "mang so nguen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnhap;
        private Button btnnhap;
        private Button btnin;
        private Button button1;
        private Button btnthoat;
        private Button btntang;
        private Button btngiam;
        private Button btntonghaimang;
        private Button btnlonnhat;
        private Button btsohoanhao;
        private Button btnsonhonhat;
        private Button btnsonguyento;
        private Button btntrungbinh;
        private Button btndemsole;
        private Button btndemsochan;
        private Button btnucln;
        private TextBox txtkq;
    }
}
