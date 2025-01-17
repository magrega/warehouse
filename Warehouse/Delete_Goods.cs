﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class Delete_Goods : Form
    {
        public Delete_Goods()
        {
            InitializeComponent();
            btnBack.Click += new EventHandler(this.back);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
           
        }
        private void back(object sender, EventArgs e)
        {
            var form = new Main_Form();
            this.Hide();
            form.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                var good = Good.GetWithId(int.Parse(name.Text));
                good.Delete();
                MessageBox.Show("Good deleted.");
                name.Text = "";
            }
            catch (Exception exception)
            {
                MessageBox.Show("Good name cannot be null!!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            
        }
    }
}
