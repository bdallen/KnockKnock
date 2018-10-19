namespace KnockKnock
{
    partial class frmMain
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
            this.lstSavedDevices = new System.Windows.Forms.ListBox();
            this.btnKnock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstSavedDevices
            // 
            this.lstSavedDevices.FormattingEnabled = true;
            this.lstSavedDevices.Location = new System.Drawing.Point(12, 12);
            this.lstSavedDevices.Name = "lstSavedDevices";
            this.lstSavedDevices.Size = new System.Drawing.Size(252, 420);
            this.lstSavedDevices.TabIndex = 0;
            // 
            // btnKnock
            // 
            this.btnKnock.Location = new System.Drawing.Point(270, 12);
            this.btnKnock.Name = "btnKnock";
            this.btnKnock.Size = new System.Drawing.Size(112, 24);
            this.btnKnock.TabIndex = 1;
            this.btnKnock.Text = "Knock";
            this.btnKnock.UseVisualStyleBackColor = true;
            this.btnKnock.Click += new System.EventHandler(this.btnKnock_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 450);
            this.Controls.Add(this.btnKnock);
            this.Controls.Add(this.lstSavedDevices);
            this.Name = "frmMain";
            this.Text = "KnockKnock";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstSavedDevices;
        private System.Windows.Forms.Button btnKnock;
    }
}

