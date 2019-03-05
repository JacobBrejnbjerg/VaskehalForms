namespace Vaskehal
{
    partial class CarwashForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkbox_WashNotification = new System.Windows.Forms.CheckBox();
            this.tbox_WashCollectPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbox_WashType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_CarName = new System.Windows.Forms.TextBox();
            this.lbl_Plate = new System.Windows.Forms.Label();
            this.tbox_CarPlate = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_StartWash = new System.Windows.Forms.Button();
            this.btn_CurrentWashes = new System.Windows.Forms.Button();
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.btn_Statistics = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Car";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.checkbox_WashNotification);
            this.panel2.Controls.Add(this.tbox_WashCollectPassword);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cbox_WashType);
            this.panel2.Location = new System.Drawing.Point(186, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 116);
            this.panel2.TabIndex = 3;
            // 
            // checkbox_WashNotification
            // 
            this.checkbox_WashNotification.AutoSize = true;
            this.checkbox_WashNotification.Location = new System.Drawing.Point(153, 25);
            this.checkbox_WashNotification.Name = "checkbox_WashNotification";
            this.checkbox_WashNotification.Size = new System.Drawing.Size(147, 17);
            this.checkbox_WashNotification.TabIndex = 5;
            this.checkbox_WashNotification.Text = "Notification when finished";
            this.checkbox_WashNotification.UseVisualStyleBackColor = true;
            // 
            // tbox_WashCollectPassword
            // 
            this.tbox_WashCollectPassword.Location = new System.Drawing.Point(7, 77);
            this.tbox_WashCollectPassword.Name = "tbox_WashCollectPassword";
            this.tbox_WashCollectPassword.Size = new System.Drawing.Size(118, 20);
            this.tbox_WashCollectPassword.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Collect password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Type";
            // 
            // cbox_WashType
            // 
            this.cbox_WashType.FormattingEnabled = true;
            this.cbox_WashType.Location = new System.Drawing.Point(7, 25);
            this.cbox_WashType.Name = "cbox_WashType";
            this.cbox_WashType.Size = new System.Drawing.Size(121, 21);
            this.cbox_WashType.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Wash";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // tbox_CarName
            // 
            this.tbox_CarName.Location = new System.Drawing.Point(20, 25);
            this.tbox_CarName.Name = "tbox_CarName";
            this.tbox_CarName.Size = new System.Drawing.Size(100, 20);
            this.tbox_CarName.TabIndex = 1;
            // 
            // lbl_Plate
            // 
            this.lbl_Plate.AutoSize = true;
            this.lbl_Plate.Location = new System.Drawing.Point(17, 61);
            this.lbl_Plate.Name = "lbl_Plate";
            this.lbl_Plate.Size = new System.Drawing.Size(31, 13);
            this.lbl_Plate.TabIndex = 2;
            this.lbl_Plate.Text = "Plate";
            // 
            // tbox_CarPlate
            // 
            this.tbox_CarPlate.Location = new System.Drawing.Point(20, 77);
            this.tbox_CarPlate.Name = "tbox_CarPlate";
            this.tbox_CarPlate.Size = new System.Drawing.Size(100, 20);
            this.tbox_CarPlate.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbox_CarPlate);
            this.panel1.Controls.Add(this.lbl_Plate);
            this.panel1.Controls.Add(this.tbox_CarName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 116);
            this.panel1.TabIndex = 1;
            // 
            // btn_StartWash
            // 
            this.btn_StartWash.Location = new System.Drawing.Point(15, 13);
            this.btn_StartWash.Name = "btn_StartWash";
            this.btn_StartWash.Size = new System.Drawing.Size(75, 23);
            this.btn_StartWash.TabIndex = 5;
            this.btn_StartWash.Text = "Start Wash";
            this.btn_StartWash.UseVisualStyleBackColor = true;
            this.btn_StartWash.Click += new System.EventHandler(this.btn_StartWash_Click);
            // 
            // btn_CurrentWashes
            // 
            this.btn_CurrentWashes.Location = new System.Drawing.Point(96, 12);
            this.btn_CurrentWashes.Name = "btn_CurrentWashes";
            this.btn_CurrentWashes.Size = new System.Drawing.Size(95, 23);
            this.btn_CurrentWashes.TabIndex = 6;
            this.btn_CurrentWashes.Text = "Current washes";
            this.btn_CurrentWashes.UseVisualStyleBackColor = true;
            this.btn_CurrentWashes.Click += new System.EventHandler(this.btn_CurrentWashes_Click);
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.Location = new System.Drawing.Point(412, 12);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(75, 23);
            this.btn_GoBack.TabIndex = 7;
            this.btn_GoBack.Text = "Go back";
            this.btn_GoBack.UseVisualStyleBackColor = true;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // btn_Statistics
            // 
            this.btn_Statistics.Location = new System.Drawing.Point(197, 12);
            this.btn_Statistics.Name = "btn_Statistics";
            this.btn_Statistics.Size = new System.Drawing.Size(75, 23);
            this.btn_Statistics.TabIndex = 8;
            this.btn_Statistics.Text = "Statistics";
            this.btn_Statistics.UseVisualStyleBackColor = true;
            this.btn_Statistics.Click += new System.EventHandler(this.btn_Statistics_Click);
            // 
            // CarwashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 265);
            this.Controls.Add(this.btn_Statistics);
            this.Controls.Add(this.btn_GoBack);
            this.Controls.Add(this.btn_CurrentWashes);
            this.Controls.Add(this.btn_StartWash);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "CarwashForm";
            this.Text = "CarwashForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbox_WashCollectPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbox_WashType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkbox_WashNotification;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_CarName;
        private System.Windows.Forms.Label lbl_Plate;
        private System.Windows.Forms.TextBox tbox_CarPlate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_StartWash;
        private System.Windows.Forms.Button btn_CurrentWashes;
        private System.Windows.Forms.Button btn_GoBack;
        private System.Windows.Forms.Button btn_Statistics;
    }
}