namespace Carregador_de_Bateria_Fotovoltaico
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPotenciaPainel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCorrentePainel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTensaoPainel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PbxPainel = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDuty = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPotenciaCUK = new System.Windows.Forms.Label();
            this.PbxCuk = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCorrenteCUK = new System.Windows.Forms.Label();
            this.lblTensaoCUK = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblModo = new System.Windows.Forms.Label();
            this.lblStatusBat = new System.Windows.Forms.Label();
            this.PbxBat = new System.Windows.Forms.PictureBox();
            this.RtxLog = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mySerialPort = new System.IO.Ports.SerialPort(this.components);
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cbxPorta = new System.Windows.Forms.ComboBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPainel)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCuk)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxBat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carregador de Bateria Fotovoltáico";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblPotenciaPainel);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblCorrentePainel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblTensaoPainel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.PbxPainel);
            this.panel1.Location = new System.Drawing.Point(12, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 300);
            this.panel1.TabIndex = 1;
            // 
            // lblPotenciaPainel
            // 
            this.lblPotenciaPainel.AutoSize = true;
            this.lblPotenciaPainel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPotenciaPainel.Location = new System.Drawing.Point(139, 261);
            this.lblPotenciaPainel.Name = "lblPotenciaPainel";
            this.lblPotenciaPainel.Size = new System.Drawing.Size(22, 17);
            this.lblPotenciaPainel.TabIndex = 13;
            this.lblPotenciaPainel.Text = "W";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(65, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Potência:";
            // 
            // lblCorrentePainel
            // 
            this.lblCorrentePainel.AutoSize = true;
            this.lblCorrentePainel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrentePainel.Location = new System.Drawing.Point(201, 225);
            this.lblCorrentePainel.Name = "lblCorrentePainel";
            this.lblCorrentePainel.Size = new System.Drawing.Size(18, 17);
            this.lblCorrentePainel.TabIndex = 10;
            this.lblCorrentePainel.Text = "A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(127, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Corrente:";
            // 
            // lblTensaoPainel
            // 
            this.lblTensaoPainel.AutoSize = true;
            this.lblTensaoPainel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTensaoPainel.Location = new System.Drawing.Point(68, 225);
            this.lblTensaoPainel.Name = "lblTensaoPainel";
            this.lblTensaoPainel.Size = new System.Drawing.Size(18, 17);
            this.lblTensaoPainel.TabIndex = 7;
            this.lblTensaoPainel.Text = "V";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tensão:";
            // 
            // PbxPainel
            // 
            this.PbxPainel.Location = new System.Drawing.Point(20, 10);
            this.PbxPainel.Name = "PbxPainel";
            this.PbxPainel.Size = new System.Drawing.Size(213, 200);
            this.PbxPainel.TabIndex = 0;
            this.PbxPainel.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblDuty);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblPotenciaCUK);
            this.panel2.Controls.Add(this.PbxCuk);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.lblCorrenteCUK);
            this.panel2.Controls.Add(this.lblTensaoCUK);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(285, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 300);
            this.panel2.TabIndex = 2;
            // 
            // lblDuty
            // 
            this.lblDuty.AutoSize = true;
            this.lblDuty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuty.Location = new System.Drawing.Point(201, 189);
            this.lblDuty.Name = "lblDuty";
            this.lblDuty.Size = new System.Drawing.Size(40, 17);
            this.lblDuty.TabIndex = 21;
            this.lblDuty.Text = "0.50";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(119, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Duty Cicle:";
            // 
            // lblPotenciaCUK
            // 
            this.lblPotenciaCUK.AutoSize = true;
            this.lblPotenciaCUK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPotenciaCUK.Location = new System.Drawing.Point(196, 261);
            this.lblPotenciaCUK.Name = "lblPotenciaCUK";
            this.lblPotenciaCUK.Size = new System.Drawing.Size(22, 17);
            this.lblPotenciaCUK.TabIndex = 19;
            this.lblPotenciaCUK.Text = "W";
            // 
            // PbxCuk
            // 
            this.PbxCuk.Location = new System.Drawing.Point(10, 48);
            this.PbxCuk.Name = "PbxCuk";
            this.PbxCuk.Size = new System.Drawing.Size(326, 116);
            this.PbxCuk.TabIndex = 1;
            this.PbxCuk.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(122, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Potência:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(59, 224);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "Tensão:";
            // 
            // lblCorrenteCUK
            // 
            this.lblCorrenteCUK.AutoSize = true;
            this.lblCorrenteCUK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrenteCUK.Location = new System.Drawing.Point(270, 225);
            this.lblCorrenteCUK.Name = "lblCorrenteCUK";
            this.lblCorrenteCUK.Size = new System.Drawing.Size(18, 17);
            this.lblCorrenteCUK.TabIndex = 17;
            this.lblCorrenteCUK.Text = "A";
            // 
            // lblTensaoCUK
            // 
            this.lblTensaoCUK.AutoSize = true;
            this.lblTensaoCUK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTensaoCUK.Location = new System.Drawing.Point(125, 225);
            this.lblTensaoCUK.Name = "lblTensaoCUK";
            this.lblTensaoCUK.Size = new System.Drawing.Size(18, 17);
            this.lblTensaoCUK.TabIndex = 15;
            this.lblTensaoCUK.Text = "V";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(196, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Corrente:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblModo);
            this.panel3.Controls.Add(this.lblStatusBat);
            this.panel3.Controls.Add(this.PbxBat);
            this.panel3.Location = new System.Drawing.Point(652, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 300);
            this.panel3.TabIndex = 2;
            // 
            // lblModo
            // 
            this.lblModo.AutoSize = true;
            this.lblModo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModo.Location = new System.Drawing.Point(149, 261);
            this.lblModo.Name = "lblModo";
            this.lblModo.Size = new System.Drawing.Size(14, 17);
            this.lblModo.TabIndex = 23;
            this.lblModo.Text = "-";
            // 
            // lblStatusBat
            // 
            this.lblStatusBat.AutoSize = true;
            this.lblStatusBat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusBat.Location = new System.Drawing.Point(108, 237);
            this.lblStatusBat.Name = "lblStatusBat";
            this.lblStatusBat.Size = new System.Drawing.Size(108, 17);
            this.lblStatusBat.TabIndex = 22;
            this.lblStatusBat.Text = "Carregando...";
            // 
            // PbxBat
            // 
            this.PbxBat.Location = new System.Drawing.Point(10, 10);
            this.PbxBat.Name = "PbxBat";
            this.PbxBat.Size = new System.Drawing.Size(280, 200);
            this.PbxBat.TabIndex = 2;
            this.PbxBat.TabStop = false;
            // 
            // RtxLog
            // 
            this.RtxLog.Location = new System.Drawing.Point(12, 432);
            this.RtxLog.Name = "RtxLog";
            this.RtxLog.Size = new System.Drawing.Size(940, 87);
            this.RtxLog.TabIndex = 3;
            this.RtxLog.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Log";
            // 
            // mySerialPort
            // 
            this.mySerialPort.BaudRate = 115200;
            this.mySerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.mySerialPort_DataReceived);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(877, 525);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // cbxPorta
            // 
            this.cbxPorta.FormattingEnabled = true;
            this.cbxPorta.Location = new System.Drawing.Point(61, 66);
            this.cbxPorta.Name = "cbxPorta";
            this.cbxPorta.Size = new System.Drawing.Size(121, 21);
            this.cbxPorta.TabIndex = 6;
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(188, 66);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 7;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(269, 66);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(86, 23);
            this.btnDesconectar.TabIndex = 8;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Porta:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(884, 67);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(62, 20);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Offline";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(984, 567);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.cbxPorta);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RtxLog);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Principal";
            this.Text = "Projeto de Potência";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPainel)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCuk)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxBat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PbxPainel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PbxCuk;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox PbxBat;
        private System.Windows.Forms.Label lblCorrentePainel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTensaoPainel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox RtxLog;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort mySerialPort;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cbxPorta;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Label lblPotenciaPainel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPotenciaCUK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCorrenteCUK;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTensaoCUK;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblDuty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblStatusBat;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblModo;
    }
}

