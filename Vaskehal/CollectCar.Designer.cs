namespace Vaskehal
{
    partial class CollectCar
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
            this.lbl_Text = new System.Windows.Forms.Label();
            this.tbox_CollectPassword = new System.Windows.Forms.TextBox();
            this.btn_Collect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Text
            // 
            this.lbl_Text.AutoSize = true;
            this.lbl_Text.Location = new System.Drawing.Point(69, 44);
            this.lbl_Text.Name = "lbl_Text";
            this.lbl_Text.Size = new System.Drawing.Size(164, 13);
            this.lbl_Text.TabIndex = 0;
            this.lbl_Text.Text = "Enter the code to collect your car";
            // 
            // tbox_CollectPassword
            // 
            this.tbox_CollectPassword.Location = new System.Drawing.Point(72, 73);
            this.tbox_CollectPassword.Name = "tbox_CollectPassword";
            this.tbox_CollectPassword.Size = new System.Drawing.Size(161, 20);
            this.tbox_CollectPassword.TabIndex = 1;
            // 
            // btn_Collect
            // 
            this.btn_Collect.Location = new System.Drawing.Point(109, 99);
            this.btn_Collect.Name = "btn_Collect";
            this.btn_Collect.Size = new System.Drawing.Size(75, 23);
            this.btn_Collect.TabIndex = 2;
            this.btn_Collect.Text = "Collect";
            this.btn_Collect.UseVisualStyleBackColor = true;
            this.btn_Collect.Click += new System.EventHandler(this.btn_Collect_Click);
            // 
            // CollectCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 153);
            this.Controls.Add(this.btn_Collect);
            this.Controls.Add(this.tbox_CollectPassword);
            this.Controls.Add(this.lbl_Text);
            this.Name = "CollectCar";
            this.Text = "CollectCar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Text;
        private System.Windows.Forms.TextBox tbox_CollectPassword;
        private System.Windows.Forms.Button btn_Collect;
    }
}