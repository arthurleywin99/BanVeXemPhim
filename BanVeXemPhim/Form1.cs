using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeXemPhim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KhoiTaoGhe(3, 5);
        }

        private void KhoiTaoGhe(int dong, int cot)
        {
            int x = 8, y = 8, height = 108, width = 114, count = 1;
            Button btnGhe;

            for (int i = 0; i < dong; ++i)
            {
                for (int j = 0; j < cot; ++j)
                {
                    btnGhe = new Button();
                    btnGhe.Text = count++.ToString();
                    btnGhe.BackColor = Color.White;
                    btnGhe.Location = new Point(x, y);
                    btnGhe.Size = new Size(width, height);
                    btnGhe.Font = new Font("Microsoft Sans Serif", 20);
                    btnGhe.Click += BtnGhe_Click;
                    btnGhe.Tag = i.ToString();
                    pnlContainer.Controls.Add(btnGhe);
                    x += width + 8;
                }
                y += height + 8;
            }
        }

        private void BtnGhe_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.BackColor == Color.White)
            {
                button.BackColor = Color.Blue;
            }
            else if (button.BackColor == Color.Blue)
            {
                button.BackColor = Color.Blue;
            }
            else
            {
                MessageBox.Show("Ghế này đã được mua");
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            double TongTien = 0;
            foreach (Button item in pnlContainer.Controls)
            {
                if (item.BackColor == Color.Blue)
                {
                    if (item.Tag.Equals("0"))
                    {
                        TongTien += 5000;
                    }
                    else if (item.Tag.Equals("1"))
                    {
                        TongTien += 6500;
                    }
                    else
                    {
                        TongTien += 8000;
                    }
                    item.BackColor = Color.Yellow;
                }
            }
            txtThanhTien.Text = TongTien.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
