using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private const string ColumnName = "";
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }
        static int qty = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("item");
            dt.Columns.Add("Qty");
            dt.Columns.Add("Price");
            dt.Columns.Add("Total");
            dataGridView1.DataSource = dt;
        }

        private void tshirtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bttn_add1.Visible = true;
            bttn_add2.Visible = true;
            bttn_add3.Visible = true;
            pictureBox1.Image = imageList_tshirt.Images[0];
            pictureBox2.Image = imageList_tshirt.Images[1];
            pictureBox3.Image= imageList_tshirt.Images[2];
            nama1.Text = "U Crew Neck Short-Sleeve";
            harga1.Text = "170000";
            nama2.Text = "U Crew Neck Short-Sleeve";
            harga2.Text = "200000";
            nama3.Text = "DRY-EX Crew Neck Short-Sleeve";
            harga3.Text = "220000";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void shirtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bttn_add1.Visible = true;
            bttn_add2.Visible = true;
            bttn_add3.Visible = true;
            pictureBox1.Image = imageList_shirt.Images[0];
            pictureBox2.Image = imageList_shirt.Images[1];
            pictureBox3.Image = imageList_shirt.Images[2];
            nama1.Text = "Premium Linen Long-Sleeve";
            harga1.Text = "350000";
            nama2.Text = "DRY-EX Short-Sleeve Polo";
            harga2.Text = "230000";
            nama3.Text = "Open Collar Short-Sleeve";
            harga3.Text = "450000";
        }

        private void shortsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bttn_add1.Visible = true;
            bttn_add2.Visible = true;
            bttn_add3.Visible = true;
            pictureBox1.Image = imageList_shorts.Images[0];
            pictureBox2.Image = imageList_shorts.Images[1];
            pictureBox3.Image = imageList_shorts.Images[2];
            nama1.Text = "Baker";
            harga1.Text = "450000";
            nama2.Text = "Dry Stretch Easy";
            harga2.Text = "350000";
            nama3.Text = "Celana dalam";
            harga3.Text = "1000000000";
        }

        private void longPantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bttn_add1.Visible = true;
            bttn_add2.Visible = true;
            bttn_add3.Visible = true;
            pictureBox1.Image = imageList_Lpants.Images[0];
            pictureBox2.Image = imageList_Lpants.Images[1];
            pictureBox3.Image = imageList_Lpants.Images[2];
            nama1.Text = "AIRism UV Protection Pocketed Soft Leggings";
            harga1.Text = "350000";
            nama2.Text = "AIRism Soft Flare Leggings";
            harga2.Text = "350000";
            nama3.Text = "celana panjang dia";
            harga3.Text = "100000";
        }

        private void jewelleriessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bttn_add1.Visible = true;
            bttn_add2.Visible = true;
            bttn_add3.Visible = true;
            pictureBox1.Image = imageList_jwlrs.Images[0];
            pictureBox2.Image = imageList_jwlrs.Images[1];
            pictureBox3.Image = imageList_jwlrs.Images[2];
            nama1.Text = "sarung tangan thanos";
            harga1.Text = "450000";
            nama2.Text = "emas batangan";
            harga2.Text = "3500000";
            nama3.Text = "diamond ML";
            harga3.Text = "10000000";
        }

        private void shoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bttn_add1.Visible = true;
            bttn_add2.Visible = true;
            bttn_add3.Visible = true;
            pictureBox1.Image = imageList_shoes.Images[0];
            pictureBox2.Image = imageList_shoes.Images[1];
            pictureBox3.Image = imageList_shoes.Images[2];
            nama1.Text = "karimun kuning";
            harga1.Text = "450";
            nama2.Text = "sepatu biru";
            harga2.Text = "35000";
            nama3.Text = "sepatu pink";
            harga3.Text = "10000";
        }

        private void bttn_add1_Click(object sender, EventArgs e)
        {
           
            if(dt.Rows.Count==0)
            {
                qty++;
                dt.Rows.Add(nama1.Text, qty, harga1.Text, int.Parse(harga1.Text) * qty);
            }
            else
            {
                bool kembar = false;
                int a = 0;
                int b = 0;
                int c = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][0].ToString() == nama1.Text)
                    {
                        kembar = true;
                        c = i;
                    }
                }
                if (kembar == true)
                {
                    dt.Rows[c][1] = a + 1;
                    dt.Rows[c][3] = b * (a + 1);
                }
                else
                {
                    dt.Rows.Add(nama1.Text, qty, harga1.Text, int.Parse(harga1.Text) * qty);
                }
            }
           dataGridView1.DataSource = dt;
           
        }

        private void bttn_add2_Click(object sender, EventArgs e)
        {
            qty = 1;
            if (dt.Rows.Count == 0)
            {
                qty++;
                dt.Rows.Add(nama2.Text, qty, harga2.Text, int.Parse(harga2.Text) * qty);
            }
            else
            {
                bool kembar = false;
                int a = 0;
                int b = 0;
                int c = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][0].ToString() == nama2.Text)
                    {
                        kembar = true;
                        c = i;
                    }
                }
                if (kembar == true)
                {
                    dt.Rows[c][1] = a + 1;
                    dt.Rows[c][3] = b * (a + 1);
                }
                else
                {
                    dt.Rows.Add(nama2.Text, qty, harga2.Text, int.Parse(harga2.Text) * qty);
                }
            }
        }

        private void bttn_add3_Click(object sender, EventArgs e)
        {
            qty = 1;
            if (dt.Rows.Count == 0)
            {
                qty++;
                dt.Rows.Add(nama3.Text, qty, harga3.Text, int.Parse(harga3.Text) * qty);
            }
            else
            {
                bool kembar = false;
                int a = 0;
                int b = 0;
                int c = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][0].ToString() == nama3.Text)
                    {
                        kembar = true;
                        c = i;
                    }
                }
                if (kembar == true)
                {
                    dt.Rows[c][1] = a + 1;
                    dt.Rows[c][3] = b * (a + 1);
                }
                else
                {
                    dt.Rows.Add(nama3.Text, qty, harga3.Text, int.Parse(harga3.Text) * qty);
                }
            }
        }
    }
}
