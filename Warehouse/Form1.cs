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
    public partial class Good_record_form : Form
    {
        private List<Client> clients = Client.GetAll();
        private List<Cube> cubes = Cube.GetAll();

        public Good_record_form()
        {
            InitializeComponent();
            cube.DropDownStyle = ComboBoxStyle.DropDownList;
            client_email.DropDownStyle = ComboBoxStyle.DropDownList;
            recieved_date.Format = DateTimePickerFormat.Custom;
            recieved_date.CustomFormat = "dd MM yyyy hh:mm";
            recieved_date.MaxDate = DateTime.Now;
            btn_back.Click += new EventHandler(this.back);
            foreach (var client in clients)
            {
                client_email.Items.Add(client.Email);
            }

            foreach (var cube in cubes)
            {
                if (!cube.Occupied)
                {
                    this.cube.Items.Add(cube.Id + ". " + cube.Name);    
                }
            }
        }

        private void Good_record_form_Load(object sender, EventArgs e)
        {
        }

        private void btn_store_Click(object sender, EventArgs e)
        {
        }


        private void name_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
        }

        private void back(object sender, EventArgs e)
        {
            var form = new Main_Form();
            this.Hide();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btn_store_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (name.Text == string.Empty)
                    Err.SetError(name, "Name cannot be null!!");
                if (cube.Text == string.Empty)
                    Err.SetError(name, "Cube ID cannot be null!!");
                if (client_email.Text == string.Empty)
                    Err.SetError(name, "Name cannot be null!!");
                if (recieved_date.Text == string.Empty)
                    Err.SetError(name, "Name cannot be null!!");
                var cubeId = cube.Text.Split('.')[0];
                var good = new Good(name.Text, description.Text, recieved_date.Value, client_email.Text,
                    int.Parse(cubeId));
                var deriveCube = Cube.GetWithId(int.Parse(cubeId));

                if (deriveCube.Occupied)
                {
                    throw new Exception("Cube occupied please select another cube.");
                }

                if (cube.Text == string.Empty)
                {
                    throw new Exception("Cube ID cannot be null!!");
                }
                if (client_email.Text == string.Empty)
                {
                    throw new Exception("Client Email cannot be null!!");
                }
                if (recieved_date.Text == string.Empty)
                {
                    throw new Exception("Received date cannot be null!!");
                }
                if (name.Text == string.Empty)
                {
                    throw new Exception("Name cannot be null!!");
                }
                deriveCube.Occupied = true;
                deriveCube.Update();
                good.Save();
                name.Text = "";
                cube.SelectedIndex = -1;
                cube.SelectedIndex = -1;
                client_email.SelectedIndex = -1;
                recieved_date.Text = "";
                description.Text = "";
                MessageBox.Show("Your good has been stored successfully",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}