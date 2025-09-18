namespace socketUDP
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxRecp = new System.Windows.Forms.TextBox();
            this.textBoxIP_RE = new System.Windows.Forms.TextBox();
            this.textBoxIPeR = new System.Windows.Forms.TextBox();
            this.textBoxPort_RE = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonFemer = new System.Windows.Forms.Button();
            this.textBoxPort_DES = new System.Windows.Forms.TextBox();
            this.textBoxIPed = new System.Windows.Forms.TextBox();
            this.textBoxport_dest = new System.Windows.Forms.TextBox();
            this.textBoxDest = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxenvoi = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4_Envoyer = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox_recp_messa = new System.Windows.Forms.TextBox();
            this.button4_CLS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxRecp
            // 
            this.textBoxRecp.Location = new System.Drawing.Point(24, 41);
            this.textBoxRecp.Name = "textBoxRecp";
            this.textBoxRecp.ReadOnly = true;
            this.textBoxRecp.Size = new System.Drawing.Size(100, 20);
            this.textBoxRecp.TabIndex = 0;
            this.textBoxRecp.Text = "Recp";
            // 
            // textBoxIP_RE
            // 
            this.textBoxIP_RE.Location = new System.Drawing.Point(150, 41);
            this.textBoxIP_RE.Name = "textBoxIP_RE";
            this.textBoxIP_RE.Size = new System.Drawing.Size(100, 20);
            this.textBoxIP_RE.TabIndex = 1;
            this.textBoxIP_RE.Text = "127.0.01";
            this.textBoxIP_RE.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxIPeR
            // 
            this.textBoxIPeR.Location = new System.Drawing.Point(392, 41);
            this.textBoxIPeR.Name = "textBoxIPeR";
            this.textBoxIPeR.Size = new System.Drawing.Size(100, 20);
            this.textBoxIPeR.TabIndex = 2;
            this.textBoxIPeR.Text = "IPeR";
            // 
            // textBoxPort_RE
            // 
            this.textBoxPort_RE.Location = new System.Drawing.Point(276, 41);
            this.textBoxPort_RE.Name = "textBoxPort_RE";
            this.textBoxPort_RE.Size = new System.Drawing.Size(100, 20);
            this.textBoxPort_RE.TabIndex = 3;
            this.textBoxPort_RE.Text = "3031";
            this.textBoxPort_RE.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(536, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "créer Socket et Bind(IPerR)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonFemer
            // 
            this.buttonFemer.Location = new System.Drawing.Point(536, 73);
            this.buttonFemer.Name = "buttonFemer";
            this.buttonFemer.Size = new System.Drawing.Size(202, 23);
            this.buttonFemer.TabIndex = 10;
            this.buttonFemer.Text = "Femer Close()";
            this.buttonFemer.UseVisualStyleBackColor = true;
            // 
            // textBoxPort_DES
            // 
            this.textBoxPort_DES.Location = new System.Drawing.Point(276, 77);
            this.textBoxPort_DES.Name = "textBoxPort_DES";
            this.textBoxPort_DES.Size = new System.Drawing.Size(100, 20);
            this.textBoxPort_DES.TabIndex = 9;
            this.textBoxPort_DES.Text = "3032";
            // 
            // textBoxIPed
            // 
            this.textBoxIPed.Location = new System.Drawing.Point(392, 77);
            this.textBoxIPed.Name = "textBoxIPed";
            this.textBoxIPed.Size = new System.Drawing.Size(100, 20);
            this.textBoxIPed.TabIndex = 8;
            this.textBoxIPed.Text = "IPeD";
            // 
            // textBoxport_dest
            // 
            this.textBoxport_dest.Location = new System.Drawing.Point(150, 77);
            this.textBoxport_dest.Name = "textBoxport_dest";
            this.textBoxport_dest.Size = new System.Drawing.Size(100, 20);
            this.textBoxport_dest.TabIndex = 7;
            this.textBoxport_dest.Text = "127.0.01";
            // 
            // textBoxDest
            // 
            this.textBoxDest.Location = new System.Drawing.Point(24, 77);
            this.textBoxDest.Name = "textBoxDest";
            this.textBoxDest.ReadOnly = true;
            this.textBoxDest.Size = new System.Drawing.Size(100, 20);
            this.textBoxDest.TabIndex = 6;
            this.textBoxDest.Text = "Dest.";
            this.textBoxDest.TextChanged += new System.EventHandler(this.textBox5_TextChanged_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(150, 129);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 60);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "Bonjour UDP";
            // 
            // textBoxenvoi
            // 
            this.textBoxenvoi.Location = new System.Drawing.Point(24, 129);
            this.textBoxenvoi.Name = "textBoxenvoi";
            this.textBoxenvoi.ReadOnly = true;
            this.textBoxenvoi.Size = new System.Drawing.Size(100, 20);
            this.textBoxenvoi.TabIndex = 11;
            this.textBoxenvoi.Text = "envoi";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(486, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 45);
            this.button2.TabIndex = 14;
            this.button2.Text = "recevoir Rzxzive From() Bloquant Timrout";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4_Envoyer
            // 
            this.button4_Envoyer.Location = new System.Drawing.Point(457, 152);
            this.button4_Envoyer.Name = "button4_Envoyer";
            this.button4_Envoyer.Size = new System.Drawing.Size(202, 23);
            this.button4_Envoyer.TabIndex = 13;
            this.button4_Envoyer.Text = "Envoyer sendTO(IPeD)";
            this.button4_Envoyer.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(150, 229);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(226, 152);
            this.textBox3.TabIndex = 16;
            this.textBox3.Text = "Bonjour UDP";
            // 
            // textBox_recp_messa
            // 
            this.textBox_recp_messa.Location = new System.Drawing.Point(24, 229);
            this.textBox_recp_messa.Name = "textBox_recp_messa";
            this.textBox_recp_messa.ReadOnly = true;
            this.textBox_recp_messa.Size = new System.Drawing.Size(100, 20);
            this.textBox_recp_messa.TabIndex = 15;
            this.textBox_recp_messa.Text = "Recp.";
            // 
            // button4_CLS
            // 
            this.button4_CLS.Location = new System.Drawing.Point(426, 327);
            this.button4_CLS.Name = "button4_CLS";
            this.button4_CLS.Size = new System.Drawing.Size(90, 35);
            this.button4_CLS.TabIndex = 17;
            this.button4_CLS.Text = "CLS";
            this.button4_CLS.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(801, 469);
            this.Controls.Add(this.button4_CLS);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox_recp_messa);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4_Envoyer);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxenvoi);
            this.Controls.Add(this.buttonFemer);
            this.Controls.Add(this.textBoxPort_DES);
            this.Controls.Add(this.textBoxIPed);
            this.Controls.Add(this.textBoxport_dest);
            this.Controls.Add(this.textBoxDest);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBoxPort_RE);
            this.Controls.Add(this.textBoxIPeR);
            this.Controls.Add(this.textBoxIP_RE);
            this.Controls.Add(this.textBoxRecp);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_recp;
        private System.Windows.Forms.TextBox textBox_ip_resp;
        private System.Windows.Forms.TextBox textBox_port_recp;
        private System.Windows.Forms.TextBox textBox1_iper;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1_dest;
        private System.Windows.Forms.TextBox textBox1_ip_dest;
        private System.Windows.Forms.TextBox textBox1_port_dest;
        private System.Windows.Forms.TextBox textBox1_IPeD;
        private System.Windows.Forms.Button button2_Femer;
        private System.Windows.Forms.TextBox textBox1_Envoi;
        private System.Windows.Forms.TextBox textBox1_txtMessage;
        private System.Windows.Forms.TextBox textBox1_resp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2_envoyer;
        private System.Windows.Forms.Button button2_Recevoir;
        private System.Windows.Forms.Button button3_CLS;
        private System.Windows.Forms.TextBox textBoxRecp;
        private System.Windows.Forms.TextBox textBoxIP_RE;
        private System.Windows.Forms.TextBox textBoxIPeR;
        private System.Windows.Forms.TextBox textBoxPort_RE;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonFemer;
        private System.Windows.Forms.TextBox textBoxPort_DES;
        private System.Windows.Forms.TextBox textBoxIPed;
        private System.Windows.Forms.TextBox textBoxport_dest;
        private System.Windows.Forms.TextBox textBoxDest;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxenvoi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4_Envoyer;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox_recp_messa;
        private System.Windows.Forms.Button button4_CLS;
    }
}

