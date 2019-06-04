using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carregador_de_Bateria_Fotovoltaico
{
    public partial class Principal : Form
    {

        Timer timerAtualizaTela;
        Timer timerConexao;
        string curDir;
        int numImagemCUK = 0;
        int numImagemBat = 0;
        StreamWriter csv;

        public Principal()
        {
            InitializeComponent();
            string[] Portas = SerialPort.GetPortNames();
            foreach(string port in Portas)
            {
                cbxPorta.Items.Add(port);
            }
            timerAtualizaTela = new Timer();
            timerAtualizaTela.Interval = Convert.ToInt16(Properties.Settings.Default.TempoTimerAtualizaTela);
            timerAtualizaTela.Enabled = false;
            timerAtualizaTela.Tick += new EventHandler(atualizaTela);
            timerConexao = new Timer();
            timerConexao.Interval = 1500;
            timerConexao.Enabled = true;
            timerConexao.Tick += new EventHandler(statusConexao);
            curDir = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory.ToString()) + "\\Imagens\\";
            PbxBat.ImageLocation = curDir + "batt.jpg";
            PbxPainel.ImageLocation = curDir + "painel.jpg";
            PbxCuk.ImageLocation = curDir + "Cukk.jpg";
            lblTensaoCUK.Text = "-";
            lblCorrenteCUK.Text = "-";
            lblTensaoPainel.Text = "-";
            lblCorrentePainel.Text = "-";
            lblPotenciaCUK.Text = "-";
            lblPotenciaPainel.Text = "-";
            lblDuty.Text = "-";
            if(!File.Exists(Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory.ToString()) + "\\Dados.csv"))
            {
                StreamWriter csv = new StreamWriter(Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory.ToString()) + "\\Dados.csv", true, Encoding.GetEncoding("iso-8859-1"));
                csv.WriteLine("Date - Hora;Tensão Painel;Corrente Painel;Tensão CUK;Corrente CUK;Duty Cicle");
                csv.Close();
            }
            
            btnDesconectar.Enabled = false;            
            numImagemBat = 0;
            numImagemCUK = 0;
            MudaImagemBat();
            //MudaImagemCUK();
            lblStatusBat.Text = "        -   ";
            //mySerialPort.PortName = Properties.Settings.Default.PortaCOM;
            
        }


        string rxString = "";
        string[] resposta;
        private void mySerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
                   
            rxString = mySerialPort.ReadExisting().Replace("\r","").Replace("\n","");            
            resposta = rxString.Split(';');
            if (resposta.Length > 1)
            {
                escreveArquivoCSV(resposta[1].Replace(".", ",") + ";" + resposta[2].Replace(".", ",") + ";" +
                resposta[3].Replace(".", ",") + ";" + resposta[4].Replace(".", ",") + ";" +
                resposta[5].Replace(".", ","));
            }
            this.Invoke(new EventHandler(displayText));
            this.Invoke(new EventHandler(atualizaTela));
        }

        private void displayText(object o, EventArgs e)
        {
            
            RtxLog.AppendText(DateTime.Now + " - Dados Recebidos: " + rxString + Environment.NewLine);
            RtxLog.SelectionStart = RtxLog.TextLength;
            RtxLog.ScrollToCaret();
        }

        private void atualizaTela(object o, EventArgs e)
        {
            if (resposta != null)
            {

                try
                {
                    if (resposta.Length > 1)
                    {
                        lblTensaoPainel.Text = resposta[1].Replace(".", ",") + " V";
                        lblCorrentePainel.Text = resposta[2].Replace(".", ",") + " A";
                        lblPotenciaPainel.Text = (Convert.ToDouble(resposta[1].Replace(".", ",")) * Convert.ToDouble(resposta[2].Replace(".", ","))).ToString();
                        lblTensaoCUK.Text = resposta[3].Replace(".", ",") + " V";
                        lblCorrenteCUK.Text = resposta[4].Replace(".",",") + " A";
                        lblPotenciaCUK.Text = (Convert.ToDouble(resposta[3].Replace(".", ",")) * Convert.ToDouble(resposta[4].Replace(".", ","))).ToString();
                        double duty = Convert.ToDouble(resposta[5].Replace(".", ","));
                        lblDuty.Text = (duty/800).ToString();


                        if (resposta.Length >= 7)
                        {
                            if (Convert.ToInt16(resposta[6]) > 0)
                            {
                                numImagemBat = 2;
                                MudaImagemBat();
                                lblStatusBat.Location = new System.Drawing.Point(87, 237);
                                lblStatusBat.Text = "Bateria Carregada!";
                                
                            }
                            else
                            {
                                
                                MudaImagemBat();
                                lblStatusBat.Text = "Carregando...";
                            }

                        }

                        if (resposta.Length >= 8)
                        {
                            MudaModo(Convert.ToInt16(resposta[7]));

                        }
                    }
                }
                catch (Exception ex)
                {

                    RtxLog.Text = DateTime.Now + ex.Message;
                }
            }

            MudaImagemCUK();          

        }

        private void MudaModo(int modo)
        {
            switch (modo)
            {
                case 0:
                    lblModo.Location = new System.Drawing.Point(87, 261);
                    lblModo.Text = "Malha de Corrente";
                    break;
                case 1:
                    lblModo.Location = new System.Drawing.Point(125, 261);
                    lblModo.Text = "MPPT";
                    break;
                case 2:
                    lblModo.Location = new System.Drawing.Point(87, 261);
                    lblModo.Text = "Malha de tensão";
                    break;
                
            }
        }

        private void MudaImagemCUK()
        {
            switch (numImagemCUK)
            {

                case 0:
                    PbxCuk.ImageLocation = curDir + "Cukk.jpg";
                    numImagemCUK = 1;
                    break;

                case 1:
                    PbxCuk.ImageLocation = curDir + "Cuk1.jpg";
                    numImagemCUK = 2;
                    break;

                case 2:
                    PbxCuk.ImageLocation = curDir + "Cuk2.jpg";
                    numImagemCUK = 1;
                    break;

                default:
                    break;
            }

        }

        private void MudaImagemBat()
        {
            switch (numImagemBat)
            {

                case 0:
                    PbxBat.ImageLocation = curDir + "batt1.jpg";
                    lblStatusBat.Text = "       -        ";
                    numImagemBat = 1;
                    break;

                case 1:
                    PbxBat.ImageLocation = curDir + "batt2.jpg";
                    lblStatusBat.Text = "Carregando.";
                    numImagemBat = 2;
                    break;

                case 2:
                    PbxBat.ImageLocation = curDir + "batt3.jpg";
                    lblStatusBat.Text = "Carregando...";
                    numImagemBat = 0;
                    break;

                default:
                    break;
            }

        }

        private void escreveArquivoCSV(string texto)
        {
            try
            {

                csv = new StreamWriter(Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory.ToString()) + "\\Dados.csv", true);
                csv.WriteLine(DateTime.Now + ";" + texto);
                csv.Close();
            }
            catch (Exception ex)
            {
                //csv.Close();
                RtxLog.Text = DateTime.Now + ex.Message + Environment.NewLine;
            }
        }

        private void statusConexao(object o, EventArgs e)
        {
            if (!mySerialPort.IsOpen)
            {
                timerAtualizaTela.Enabled = false;
                btnConectar.Enabled = true;
                btnDesconectar.Enabled = false;
                lblStatus.Text = "Offline";
                lblStatus.ForeColor = System.Drawing.Color.Red;

            }
            else
            {
                timerAtualizaTela.Enabled = true;
                btnConectar.Enabled = false;
                btnDesconectar.Enabled = true;
                lblStatus.Text = "Online";
                lblStatus.ForeColor = System.Drawing.Color.ForestGreen;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            RtxLog.Clear();
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            mySerialPort.Close();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (!(cbxPorta.SelectedIndex < 0))
            {
                mySerialPort.PortName = cbxPorta.SelectedItem.ToString();
                if (!mySerialPort.IsOpen)
                {
                    try
                    {
                        mySerialPort.Open();
                        RtxLog.Text = DateTime.Now + " - Porta aberta!" + Environment.NewLine;
                        //timerAtualizaTela.Enabled = true;
                        btnDesconectar.Enabled = true;
                        btnConectar.Enabled = false;
                        lblStatus.Text = "Online";
                        lblStatus.ForeColor = System.Drawing.Color.ForestGreen;
                    }
                    catch
                    {
                        RtxLog.Text = DateTime.Now + " - Erro ao abrir Porta!" + Environment.NewLine;
                        lblStatus.Text = "Offline";
                        lblStatus.ForeColor = System.Drawing.Color.Red;
                    }

                }
                else
                    RtxLog.Text = DateTime.Now + " - Porta Ocupada!" + Environment.NewLine;

            }
            else
            {
                MessageBox.Show("Selecione uma porta para conexão!");
            }
            
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            mySerialPort.Close();
            btnConectar.Enabled = true;
            btnDesconectar.Enabled = false;
            //timerAtualizaTela.Enabled = false;
            lblStatusBat.Text = "        -   ";
            lblModo.Text = "-";
            lblModo.Location = new System.Drawing.Point(146, 261);
            numImagemCUK = 0;
            numImagemBat = 0;
            MudaImagemCUK();
            MudaImagemBat();
            lblStatus.Text = "Offline";
            lblStatus.ForeColor = System.Drawing.Color.Red;
        }

    }
}
