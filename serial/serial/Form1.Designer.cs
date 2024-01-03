namespace serial
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timerCom = new System.Windows.Forms.Timer(this.components);
            this.txtEnviar = new System.Windows.Forms.TextBox();
            this.txtRecebido = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timerCom
            // 
            this.timerCom.Interval = 1000;
            this.timerCom.Tick += new System.EventHandler(this.timerCom_Tick);
            // 
            // txtEnviar
            // 
            this.txtEnviar.Location = new System.Drawing.Point(131, 56);
            this.txtEnviar.Name = "txtEnviar";
            this.txtEnviar.Size = new System.Drawing.Size(121, 22);
            this.txtEnviar.TabIndex = 0;
            // 
            // txtRecebido
            // 
            this.txtRecebido.Location = new System.Drawing.Point(28, 103);
            this.txtRecebido.Multiline = true;
            this.txtRecebido.Name = "txtRecebido";
            this.txtRecebido.Size = new System.Drawing.Size(329, 180);
            this.txtRecebido.TabIndex = 1;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(28, 56);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(28, 13);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 3;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(131, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtRecebido);
            this.Controls.Add(this.txtEnviar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timerCom;
        private System.Windows.Forms.TextBox txtEnviar;
        private System.Windows.Forms.TextBox txtRecebido;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

