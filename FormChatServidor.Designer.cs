namespace Chat_Line
{
    partial class FormChatServidor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChatServidor));
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lbEnderecoIP = new System.Windows.Forms.Label();
            this.btnAtender = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Calibri", 14F);
            this.txtIP.Location = new System.Drawing.Point(214, 233);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(312, 42);
            this.txtIP.TabIndex = 6;
            // 
            // lbEnderecoIP
            // 
            this.lbEnderecoIP.AutoSize = true;
            this.lbEnderecoIP.BackColor = System.Drawing.Color.Transparent;
            this.lbEnderecoIP.Font = new System.Drawing.Font("Calibri", 16F);
            this.lbEnderecoIP.ForeColor = System.Drawing.Color.White;
            this.lbEnderecoIP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbEnderecoIP.Location = new System.Drawing.Point(26, 233);
            this.lbEnderecoIP.Name = "lbEnderecoIP";
            this.lbEnderecoIP.Size = new System.Drawing.Size(182, 39);
            this.lbEnderecoIP.TabIndex = 5;
            this.lbEnderecoIP.Text = "Endereço IP:";
            // 
            // btnAtender
            // 
            this.btnAtender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(191)))), ((int)(((byte)(240)))));
            this.btnAtender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtender.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtender.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAtender.Location = new System.Drawing.Point(537, 215);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(167, 80);
            this.btnAtender.TabIndex = 7;
            this.btnAtender.Text = "Iniciar Atendimento";
            this.btnAtender.UseVisualStyleBackColor = false;
            this.btnAtender.Click += new System.EventHandler(this.btnAtenderClick);
            // 
            // txtLog
            // 
            this.txtLog.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(50, 301);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(627, 613);
            this.txtLog.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(148, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(436, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FormChatServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(724, 934);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnAtender);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.lbEnderecoIP);
            this.Name = "FormChatServidor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChatServidor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label lbEnderecoIP;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}