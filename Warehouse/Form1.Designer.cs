﻿
namespace Warehouse
{
    partial class Good_record_form
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.recieved_date = new System.Windows.Forms.DateTimePicker();
            this.description = new System.Windows.Forms.RichTextBox();
            this.cube = new System.Windows.Forms.ComboBox();
            this.client_email = new System.Windows.Forms.ComboBox();
            this.log = new System.Windows.Forms.Label();
            this.Err = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_store = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.Err)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Good Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Client Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cube";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Recieved Date";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(193, 35);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(227, 20);
            this.name.TabIndex = 6;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // recieved_date
            // 
            this.recieved_date.CustomFormat = "";
            this.recieved_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.recieved_date.Location = new System.Drawing.Point(193, 140);
            this.recieved_date.Margin = new System.Windows.Forms.Padding(2);
            this.recieved_date.Name = "recieved_date";
            this.recieved_date.Size = new System.Drawing.Size(227, 20);
            this.recieved_date.TabIndex = 10;
            this.recieved_date.Value = new System.DateTime(2021, 4, 15, 16, 10, 20, 0);
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(193, 184);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(227, 96);
            this.description.TabIndex = 11;
            this.description.Text = "";
            // 
            // cube
            // 
            this.cube.FormattingEnabled = true;
            this.cube.Location = new System.Drawing.Point(193, 70);
            this.cube.Name = "cube";
            this.cube.Size = new System.Drawing.Size(227, 21);
            this.cube.TabIndex = 13;
            // 
            // client_email
            // 
            this.client_email.FormattingEnabled = true;
            this.client_email.Location = new System.Drawing.Point(193, 106);
            this.client_email.Name = "client_email";
            this.client_email.Size = new System.Drawing.Size(227, 21);
            this.client_email.TabIndex = 14;
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(58, 332);
            this.log.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(176, 97);
            this.log.TabIndex = 15;
            this.log.Text = "label5";
            // 
            // Err
            // 
            this.Err.ContainerControl = this;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(40, 326);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(101, 43);
            this.btn_back.TabIndex = 28;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // btn_store
            // 
            this.btn_store.Location = new System.Drawing.Point(316, 326);
            this.btn_store.Name = "btn_store";
            this.btn_store.Size = new System.Drawing.Size(101, 43);
            this.btn_store.TabIndex = 27;
            this.btn_store.Text = "Store Good";
            this.btn_store.UseVisualStyleBackColor = true;
            this.btn_store.Click += new System.EventHandler(this.btn_store_Click_1);
            // 
            // Good_record_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 407);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_store);
            this.Controls.Add(this.client_email);
            this.Controls.Add(this.cube);
            this.Controls.Add(this.description);
            this.Controls.Add(this.recieved_date);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Good_record_form";
            this.Text = "Good_record_form";
            this.Load += new System.EventHandler(this.Good_record_form_Load);
            ((System.ComponentModel.ISupportInitialize) (this.Err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btn_store;
        private System.Windows.Forms.Button btn_back;

        private System.Windows.Forms.Label log;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.DateTimePicker recieved_date;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.ComboBox cube;
        private System.Windows.Forms.ComboBox client_email;
        private System.Windows.Forms.ErrorProvider Err;
    }
}

