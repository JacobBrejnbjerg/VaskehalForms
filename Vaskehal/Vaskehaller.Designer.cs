﻿namespace Vaskehal
{
    partial class Vaskehaller
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
            this.combo_Carwashes = new System.Windows.Forms.ComboBox();
            this.lbl_Carwashes = new System.Windows.Forms.Label();
            this.btn_CreateCarwash = new System.Windows.Forms.Button();
            this.lbl_CarwashName = new System.Windows.Forms.Label();
            this.tbox_CarwashName = new System.Windows.Forms.TextBox();
            this.btn_GoToCarwash = new System.Windows.Forms.Button();
            this.btn_DeleteCarwash = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combo_Carwashes
            // 
            this.combo_Carwashes.FormattingEnabled = true;
            this.combo_Carwashes.Location = new System.Drawing.Point(28, 54);
            this.combo_Carwashes.Name = "combo_Carwashes";
            this.combo_Carwashes.Size = new System.Drawing.Size(178, 21);
            this.combo_Carwashes.TabIndex = 0;
            // 
            // lbl_Carwashes
            // 
            this.lbl_Carwashes.AutoSize = true;
            this.lbl_Carwashes.Location = new System.Drawing.Point(28, 35);
            this.lbl_Carwashes.Name = "lbl_Carwashes";
            this.lbl_Carwashes.Size = new System.Drawing.Size(62, 13);
            this.lbl_Carwashes.TabIndex = 1;
            this.lbl_Carwashes.Text = "Vaskehaller";
            // 
            // btn_CreateCarwash
            // 
            this.btn_CreateCarwash.Location = new System.Drawing.Point(27, 223);
            this.btn_CreateCarwash.Name = "btn_CreateCarwash";
            this.btn_CreateCarwash.Size = new System.Drawing.Size(178, 23);
            this.btn_CreateCarwash.TabIndex = 2;
            this.btn_CreateCarwash.Text = "Ny vaskehal";
            this.btn_CreateCarwash.UseVisualStyleBackColor = true;
            this.btn_CreateCarwash.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_CarwashName
            // 
            this.lbl_CarwashName.AutoSize = true;
            this.lbl_CarwashName.Location = new System.Drawing.Point(27, 181);
            this.lbl_CarwashName.Name = "lbl_CarwashName";
            this.lbl_CarwashName.Size = new System.Drawing.Size(78, 13);
            this.lbl_CarwashName.TabIndex = 3;
            this.lbl_CarwashName.Text = "Vaskehal navn";
            this.lbl_CarwashName.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbox_CarwashName
            // 
            this.tbox_CarwashName.Location = new System.Drawing.Point(27, 197);
            this.tbox_CarwashName.Name = "tbox_CarwashName";
            this.tbox_CarwashName.Size = new System.Drawing.Size(178, 20);
            this.tbox_CarwashName.TabIndex = 4;
            // 
            // btn_GoToCarwash
            // 
            this.btn_GoToCarwash.Location = new System.Drawing.Point(31, 82);
            this.btn_GoToCarwash.Name = "btn_GoToCarwash";
            this.btn_GoToCarwash.Size = new System.Drawing.Size(174, 23);
            this.btn_GoToCarwash.TabIndex = 5;
            this.btn_GoToCarwash.Text = "Go to";
            this.btn_GoToCarwash.UseVisualStyleBackColor = true;
            this.btn_GoToCarwash.Click += new System.EventHandler(this.btn_GoToCarwash_Click);
            // 
            // btn_DeleteCarwash
            // 
            this.btn_DeleteCarwash.Location = new System.Drawing.Point(31, 122);
            this.btn_DeleteCarwash.Name = "btn_DeleteCarwash";
            this.btn_DeleteCarwash.Size = new System.Drawing.Size(175, 23);
            this.btn_DeleteCarwash.TabIndex = 6;
            this.btn_DeleteCarwash.Text = "Delete";
            this.btn_DeleteCarwash.UseVisualStyleBackColor = true;
            this.btn_DeleteCarwash.Click += new System.EventHandler(this.btn_DeleteCarwash_Click);
            // 
            // Vaskehaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 268);
            this.Controls.Add(this.btn_DeleteCarwash);
            this.Controls.Add(this.btn_GoToCarwash);
            this.Controls.Add(this.tbox_CarwashName);
            this.Controls.Add(this.lbl_CarwashName);
            this.Controls.Add(this.btn_CreateCarwash);
            this.Controls.Add(this.lbl_Carwashes);
            this.Controls.Add(this.combo_Carwashes);
            this.Name = "Vaskehaller";
            this.Text = "Vaskehaller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_Carwashes;
        private System.Windows.Forms.Label lbl_Carwashes;
        private System.Windows.Forms.Button btn_CreateCarwash;
        private System.Windows.Forms.Label lbl_CarwashName;
        private System.Windows.Forms.TextBox tbox_CarwashName;
        private System.Windows.Forms.Button btn_GoToCarwash;
        private System.Windows.Forms.Button btn_DeleteCarwash;
    }
}

