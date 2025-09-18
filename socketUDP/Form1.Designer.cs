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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxRecp
            // 
            this.textBoxRecp.Location = new System.Drawing.Point(24, 41);
            this.textBoxRecp.Name = "textBoxRecp";
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(536, 73);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(202, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "créer Socket et Bind(IPerR)";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(276, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "3031";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(392, 77);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "IPeR";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(150, 77);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "127.0.01";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(24, 77);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 6;
            this.textBox5.Text = "Recp";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(801, 469);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}

