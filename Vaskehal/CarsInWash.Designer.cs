namespace Vaskehal
{
    partial class CarsInWash
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
            this.flowpanel_Washes = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowpanel_Washes
            // 
            this.flowpanel_Washes.AutoSize = true;
            this.flowpanel_Washes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowpanel_Washes.Location = new System.Drawing.Point(12, 42);
            this.flowpanel_Washes.Name = "flowpanel_Washes";
            this.flowpanel_Washes.Size = new System.Drawing.Size(220, 127);
            this.flowpanel_Washes.TabIndex = 0;
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.Location = new System.Drawing.Point(12, 12);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(75, 23);
            this.btn_GoBack.TabIndex = 1;
            this.btn_GoBack.Text = "Go back";
            this.btn_GoBack.UseVisualStyleBackColor = true;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // CarsInWash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 181);
            this.Controls.Add(this.btn_GoBack);
            this.Controls.Add(this.flowpanel_Washes);
            this.Name = "CarsInWash";
            this.Text = "CarsInWash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowpanel_Washes;
        private System.Windows.Forms.Button btn_GoBack;
    }
}