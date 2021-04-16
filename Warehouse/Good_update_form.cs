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
    public partial class Good_update_form : Form
    {
        private List<Client> clients = Client.GetAll();
        private List<Cube> cubes = Cube.GetAll();
        
        static Good good = null;
        public Good_update_form()
        {
            InitializeComponent();
            cube_id.DropDownStyle = ComboBoxStyle.DropDownList;
            client_email.DropDownStyle = ComboBoxStyle.DropDownList;
            recieved_date.Format = DateTimePickerFormat.Custom;
            recieved_date.CustomFormat = "dd MM yyyy hh:mm";
            recieved_date.MaxDate = DateTime.Now;
            btn_back.Click += new EventHandler(this.back);
            name.KeyPress += new KeyPressEventHandler(this.InputValidator);
            foreach (var client in clients)
            {
                client_email.Items.Add(client.Email);
            }

            foreach (var cube in cubes)
            {
                this.cube_id.Items.Add(cube.Id + ". " + cube.Name);
            }
        }

        private void InputValidator(object sender, KeyPressEventArgs e)
        {
            TextBox text;
            if (sender is TextBox)
            {
                text = (TextBox) sender;
                if (text.Name == name.Name)
                {
                    if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char) 8)
                        e.Handled = false;
                    else if (e.KeyChar == ' ')
                        e.Handled = false;
                    else
                        e.Handled = true;
                }
            }
        }
        private void back(object sender, EventArgs e)
        {
            var form = new Main_Form();
            this.Hide();
            form.Show();
        }
        private void btn_update_Click(object sender, EventArgs e)
            {

                var cubeId = cube_id.Text.Split('.')[0];
                var good = new Good(name.Text,description.Text,  recieved_date.Value, client_email.Text, int.Parse(cubeId));
                good.Save();
                name.Text = "";
                cube_id.SelectedIndex = -1;
                cube_id.SelectedIndex = -1;
                client_email.SelectedIndex = -1;
                recieved_date.Text = "";
                description.Text = "";
            }

        private void button1_Click(object sender, EventArgs e)
        {
            good = Good.GetWithId(int.Parse(good_id.Text));
            name.Text = good.Name;
            cube_id.Text = good.CubeId.ToString();
            client_email.Text = good.ClientId.ToString();
            recieved_date.Text = good.ReceivedDate.ToString();
            description.Text = good.Description;
        }
    }
    }