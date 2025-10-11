using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace socketUDP
{
    public partial class Form1 : Form
    {
        // Déclaration des variables membres (Commit #3)
        private Socket SSockUDP;
        private IPEndPoint IPedD;  // Point de terminaison destination
        private IPEndPoint IPedR;  // Point de terminaison réception (local)
        private EndPoint IPedFrom; // Point de terminaison émetteur

        public Form1()
        {
            InitializeComponent();
            // Commit #2 - Titre de la fenêtre
            this.Text = "Communication par socket UDP";

            // Initialiser IPedFrom
            IPedFrom = new IPEndPoint(IPAddress.Any, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Valeurs par défaut pour les textbox
            txtLocalIP.Text = "127.0.0.1";
            txtLocalPort.Text = "50000";
            txtDestIP.Text = "127.0.0.1";
            txtDestPort.Text = "50001";
        }

        // Commit #3 - Bouton Créer Socket UDP
        private void buttonCreer_Click(object sender, EventArgs e)
        {
            
            {
                // Commit #4 - 
                

                // Création du socket UDP
                SSockUDP = new Socket(AddressFamily.InterNetwork,
                                      SocketType.Dgram,
                                      ProtocolType.Udp);

                // Création du point de terminaison local (réception)
                IPAddress localIP = IPAddress.Parse(txtLocalIP.Text.Trim());
                int localPort = int.Parse(txtLocalPort.Text.Trim());
                IPedR = new IPEndPoint(localIP, localPort);

                // Lier le socket au point de terminaison local
                SSockUDP.Bind(IPedR);

                textBoxRecp.AppendText($"Socket créé et lié sur {localIP}:{localPort}\r\n");

            }
            
        }

        // Commit #3 - Bouton Envoyer
        private void buttonEnvoyer_Click(object sender, EventArgs e)
        {
           
            
                // Commit #4 - 
                

                // Création du point de terminaison destination
                IPAddress destIP = IPAddress.Parse(txtDestIP.Text.Trim());
                int destPort = int.Parse(txtDestPort.Text.Trim());
                IPedD = new IPEndPoint(destIP, destPort);

                // Mise en forme du message à envoyer
                string message = textBoxEnvoi.Text;
                var msg = Encoding.ASCII.GetBytes(message);

                // Envoi du message
                int bytesSent = SSockUDP.SendTo(msg, IPedD);
                textBoxRecp.AppendText($"Envoyé {bytesSent} octets à {destIP}:{destPort}\r\n");
            
            
        }

        // Commit #3 - Bouton Recevoir
        private void buttonRecevoir_Click(object sender, EventArgs e)
        {
           
                // Commit #4 
                

                // Buffer de réception
                var buffer = new byte[1024];

                // Réception du message (bloquant avec timeout)
                int bytesReceived = SSockUDP.ReceiveFrom(buffer, ref IPedFrom);

                // Affichage du message
                string messageRecu = Encoding.ASCII.GetString(buffer, 0, bytesReceived);
                textBoxRecp.AppendText($"Reçu de {IPedFrom} : {messageRecu}\r\n");
          
            
               
            
        }

        // Commit #3 - Bouton Fermer Socket
        private void buttonFermer_Click(object sender, EventArgs e)
        {

            // Commit #4 
            if (SSockUDP == null)
            {
                textBoxRecp.AppendText("Erreur : Socket déjà fermé ou non créé.\r\n");
                return;
            }

            // Arrêter le timer
            if (timerReceive != null)
            {
                timerReceive.Stop();
            }

            // Fermeture du socket
            SSockUDP.Close();
            SSockUDP = null;
        }

        

        // Bouton pour vider la zone de réception
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxRecp.Clear();
        }
    }
}