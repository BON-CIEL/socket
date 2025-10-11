namespace socketUDP
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxLocal = new System.Windows.Forms.GroupBox();
            this.txtLocalPort = new System.Windows.Forms.TextBox();
            this.txtLocalIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxDest = new System.Windows.Forms.GroupBox();
            this.txtDestPort = new System.Windows.Forms.TextBox();
            this.txtDestIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxEnvoi = new System.Windows.Forms.GroupBox();
            this.buttonEnvoyer = new System.Windows.Forms.Button();
            this.textBoxEnvoi = new System.Windows.Forms.TextBox();
            this.groupBoxReception = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxRecp = new System.Windows.Forms.TextBox();
            this.buttonCreer = new System.Windows.Forms.Button();
            this.buttonRecevoir = new System.Windows.Forms.Button();
            this.buttonFermer = new System.Windows.Forms.Button();
            this.timerReceive = new System.Windows.Forms.Timer(this.components);
            this.groupBoxLocal.SuspendLayout();
            this.groupBoxDest.SuspendLayout();
            this.groupBoxEnvoi.SuspendLayout();
            this.groupBoxReception.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLocal
            // 
            this.groupBoxLocal.Controls.Add(this.txtLocalPort);
            this.groupBoxLocal.Controls.Add(this.txtLocalIP);
            this.groupBoxLocal.Controls.Add(this.label2);
            this.groupBoxLocal.Controls.Add(this.label1);
            this.groupBoxLocal.Location = new System.Drawing.Point(12, 12);
            this.groupBoxLocal.Name = "groupBoxLocal";
            this.groupBoxLocal.Size = new System.Drawing.Size(250, 80);
            this.groupBoxLocal.TabIndex = 0;
            this.groupBoxLocal.TabStop = false;
            this.groupBoxLocal.Text = "Local (Réception)";
            // 
            // txtLocalPort
            // 
            this.txtLocalPort.Location = new System.Drawing.Point(70, 45);
            this.txtLocalPort.Name = "txtLocalPort";
            this.txtLocalPort.Size = new System.Drawing.Size(160, 20);
            this.txtLocalPort.TabIndex = 3;
            // 
            // txtLocalIP
            // 
            this.txtLocalIP.Location = new System.Drawing.Point(70, 19);
            this.txtLocalIP.Name = "txtLocalIP";
            this.txtLocalIP.Size = new System.Drawing.Size(160, 20);
            this.txtLocalIP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:";
            // 
            // groupBoxDest
            // 
            this.groupBoxDest.Controls.Add(this.txtDestPort);
            this.groupBoxDest.Controls.Add(this.txtDestIP);
            this.groupBoxDest.Controls.Add(this.label3);
            this.groupBoxDest.Controls.Add(this.label4);
            this.groupBoxDest.Location = new System.Drawing.Point(280, 12);
            this.groupBoxDest.Name = "groupBoxDest";
            this.groupBoxDest.Size = new System.Drawing.Size(250, 80);
            this.groupBoxDest.TabIndex = 1;
            this.groupBoxDest.TabStop = false;
            this.groupBoxDest.Text = "Destination (Envoi)";
            // 
            // txtDestPort
            // 
            this.txtDestPort.Location = new System.Drawing.Point(70, 45);
            this.txtDestPort.Name = "txtDestPort";
            this.txtDestPort.Size = new System.Drawing.Size(160, 20);
            this.txtDestPort.TabIndex = 3;
            // 
            // txtDestIP
            // 
            this.txtDestIP.Location = new System.Drawing.Point(70, 19);
            this.txtDestIP.Name = "txtDestIP";
            this.txtDestIP.Size = new System.Drawing.Size(160, 20);
            this.txtDestIP.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Port:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "IP:";
            // 
            // groupBoxEnvoi
            // 
            this.groupBoxEnvoi.Controls.Add(this.buttonEnvoyer);
            this.groupBoxEnvoi.Controls.Add(this.textBoxEnvoi);
            this.groupBoxEnvoi.Location = new System.Drawing.Point(12, 110);
            this.groupBoxEnvoi.Name = "groupBoxEnvoi";
            this.groupBoxEnvoi.Size = new System.Drawing.Size(518, 100);
            this.groupBoxEnvoi.TabIndex = 2;
            this.groupBoxEnvoi.TabStop = false;
            this.groupBoxEnvoi.Text = "Message à envoyer";
            // 
            // buttonEnvoyer
            // 
            this.buttonEnvoyer.Location = new System.Drawing.Point(400, 25);
            this.buttonEnvoyer.Name = "buttonEnvoyer";
            this.buttonEnvoyer.Size = new System.Drawing.Size(100, 60);
            this.buttonEnvoyer.TabIndex = 1;
            this.buttonEnvoyer.Text = "Envoyer";
            this.buttonEnvoyer.UseVisualStyleBackColor = true;
            this.buttonEnvoyer.Click += new System.EventHandler(this.buttonEnvoyer_Click);
            // 
            // textBoxEnvoi
            // 
            this.textBoxEnvoi.Location = new System.Drawing.Point(18, 25);
            this.textBoxEnvoi.Multiline = true;
            this.textBoxEnvoi.Name = "textBoxEnvoi";
            this.textBoxEnvoi.Size = new System.Drawing.Size(365, 60);
            this.textBoxEnvoi.TabIndex = 0;
            // 
            // groupBoxReception
            // 
            this.groupBoxReception.Controls.Add(this.buttonClear);
            this.groupBoxReception.Controls.Add(this.textBoxRecp);
            this.groupBoxReception.Location = new System.Drawing.Point(12, 225);
            this.groupBoxReception.Name = "groupBoxReception";
            this.groupBoxReception.Size = new System.Drawing.Size(518, 200);
            this.groupBoxReception.TabIndex = 3;
            this.groupBoxReception.TabStop = false;
            this.groupBoxReception.Text = "Messages reçus / Statut";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(400, 160);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 30);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Effacer";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxRecp
            // 
            this.textBoxRecp.Location = new System.Drawing.Point(18, 25);
            this.textBoxRecp.Multiline = true;
            this.textBoxRecp.Name = "textBoxRecp";
            this.textBoxRecp.ReadOnly = true;
            this.textBoxRecp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRecp.Size = new System.Drawing.Size(482, 125);
            this.textBoxRecp.TabIndex = 0;
            // 
            // buttonCreer
            // 
            this.buttonCreer.Location = new System.Drawing.Point(30, 440);
            this.buttonCreer.Name = "buttonCreer";
            this.buttonCreer.Size = new System.Drawing.Size(120, 35);
            this.buttonCreer.TabIndex = 4;
            this.buttonCreer.Text = "Créer socket UDP";
            this.buttonCreer.UseVisualStyleBackColor = true;
            this.buttonCreer.Click += new System.EventHandler(this.buttonCreer_Click);
            // 
            // buttonRecevoir
            // 
            this.buttonRecevoir.Location = new System.Drawing.Point(170, 440);
            this.buttonRecevoir.Name = "buttonRecevoir";
            this.buttonRecevoir.Size = new System.Drawing.Size(120, 35);
            this.buttonRecevoir.TabIndex = 5;
            this.buttonRecevoir.Text = "Recevoir";
            this.buttonRecevoir.UseVisualStyleBackColor = true;
            this.buttonRecevoir.Click += new System.EventHandler(this.buttonRecevoir_Click);
            // 
            // buttonFermer
            // 
            this.buttonFermer.Location = new System.Drawing.Point(310, 440);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(120, 35);
            this.buttonFermer.TabIndex = 6;
            this.buttonFermer.Text = "Fermer socket";
            this.buttonFermer.UseVisualStyleBackColor = true;
            this.buttonFermer.Click += new System.EventHandler(this.buttonFermer_Click);
            // 
            // timerReceive
            // 
            this.timerReceive.Interval = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 491);
            this.Controls.Add(this.buttonFermer);
            this.Controls.Add(this.buttonRecevoir);
            this.Controls.Add(this.buttonCreer);
            this.Controls.Add(this.groupBoxReception);
            this.Controls.Add(this.groupBoxEnvoi);
            this.Controls.Add(this.groupBoxDest);
            this.Controls.Add(this.groupBoxLocal);
            this.Name = "Form1";
            this.Text = "Communication par socket UDP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxLocal.ResumeLayout(false);
            this.groupBoxLocal.PerformLayout();
            this.groupBoxDest.ResumeLayout(false);
            this.groupBoxDest.PerformLayout();
            this.groupBoxEnvoi.ResumeLayout(false);
            this.groupBoxEnvoi.PerformLayout();
            this.groupBoxReception.ResumeLayout(false);
            this.groupBoxReception.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLocal;
        private System.Windows.Forms.TextBox txtLocalPort;
        private System.Windows.Forms.TextBox txtLocalIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxDest;
        private System.Windows.Forms.TextBox txtDestPort;
        private System.Windows.Forms.TextBox txtDestIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxEnvoi;
        private System.Windows.Forms.Button buttonEnvoyer;
        private System.Windows.Forms.TextBox textBoxEnvoi;
        private System.Windows.Forms.GroupBox groupBoxReception;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxRecp;
        private System.Windows.Forms.Button buttonCreer;
        private System.Windows.Forms.Button buttonRecevoir;
        private System.Windows.Forms.Button buttonFermer;
        private System.Windows.Forms.Timer timerReceive;
    }
}