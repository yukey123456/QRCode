namespace GetQRCode
{
    partial class Form1
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
            this.btnLayMa = new System.Windows.Forms.Button();
            this.pbQr = new System.Windows.Forms.PictureBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSaveBmp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbQr)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLayMa
            // 
            this.btnLayMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLayMa.Location = new System.Drawing.Point(428, 178);
            this.btnLayMa.Name = "btnLayMa";
            this.btnLayMa.Size = new System.Drawing.Size(128, 70);
            this.btnLayMa.TabIndex = 3;
            this.btnLayMa.Text = "GET QR CODE";
            this.btnLayMa.UseVisualStyleBackColor = true;
            this.btnLayMa.Click += new System.EventHandler(this.btnLayMa_Click);
            // 
            // pbQr
            // 
            this.pbQr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbQr.Location = new System.Drawing.Point(12, 12);
            this.pbQr.Name = "pbQr";
            this.pbQr.Size = new System.Drawing.Size(380, 380);
            this.pbQr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQr.TabIndex = 2;
            this.pbQr.TabStop = false;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(30, 38);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(258, 29);
            this.txtID.TabIndex = 0;
            this.txtID.Text = "QRCode";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Location = new System.Drawing.Point(428, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 101);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ID";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(524, 324);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 68);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSaveBmp
            // 
            this.btnSaveBmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveBmp.Location = new System.Drawing.Point(622, 178);
            this.btnSaveBmp.Name = "btnSaveBmp";
            this.btnSaveBmp.Size = new System.Drawing.Size(122, 70);
            this.btnSaveBmp.TabIndex = 3;
            this.btnSaveBmp.Text = "SAVE AS BMP";
            this.btnSaveBmp.UseVisualStyleBackColor = true;
            this.btnSaveBmp.Click += new System.EventHandler(this.btnSaveBmp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 425);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaveBmp);
            this.Controls.Add(this.btnLayMa);
            this.Controls.Add(this.pbQr);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbQr)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLayMa;
        private System.Windows.Forms.PictureBox pbQr;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSaveBmp;
    }
}

