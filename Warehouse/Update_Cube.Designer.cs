﻿
namespace Warehouse
{
    partial class Update_Cube
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
            this.name = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.get_name = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cube_id = new System.Windows.Forms.TextBox();
            this.Err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Cube";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(242, 154);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(198, 26);
            this.name.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(308, 496);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(158, 45);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(782, 496);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(158, 45);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // get_name
            // 
            this.get_name.Location = new System.Drawing.Point(700, 243);
            this.get_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.get_name.Name = "get_name";
            this.get_name.Size = new System.Drawing.Size(158, 35);
            this.get_name.TabIndex = 5;
            this.get_name.Text = "Fetch";
            this.get_name.UseVisualStyleBackColor = true;
            this.get_name.Click += new System.EventHandler(this.get_name_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 317);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cube ID";
            // 
            // cube_id
            // 
            this.cube_id.Location = new System.Drawing.Point(242, 314);
            this.cube_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cube_id.Name = "cube_id";
            this.cube_id.Size = new System.Drawing.Size(198, 26);
            this.cube_id.TabIndex = 7;
            this.cube_id.TextChanged += new System.EventHandler(this.cube_id_TextChanged);
            // 
            // Err
            // 
            this.Err.ContainerControl = this;
            // 
            // Update_Cube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1037);
            this.Controls.Add(this.cube_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.get_name);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Update_Cube";
            this.Text = "Update_Cube";
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button get_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cube_id;
        private System.Windows.Forms.ErrorProvider Err;
    }
}