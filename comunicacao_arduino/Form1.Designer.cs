using System.IO.Ports;
namespace comunicacao_arduino
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnConectar = new Button();
            btnEnviar = new Button();
            comboBox1 = new ComboBox();
            txtEnviar = new TextBox();
            txtReceber = new TextBox();
            timerCom = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(27, 14);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(94, 29);
            btnConectar.TabIndex = 0;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(27, 59);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(94, 29);
            btnEnviar.TabIndex = 1;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(145, 14);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(233, 28);
            comboBox1.TabIndex = 2;
            // 
            // txtEnviar
            // 
            txtEnviar.Location = new Point(145, 61);
            txtEnviar.Name = "txtEnviar";
            txtEnviar.Size = new Size(233, 27);
            txtEnviar.TabIndex = 3;
            // 
            // txtReceber
            // 
            txtReceber.Location = new Point(43, 112);
            txtReceber.Multiline = true;
            txtReceber.Name = "txtReceber";
            txtReceber.Size = new Size(335, 197);
            txtReceber.TabIndex = 4;
            // 
            // timerCom
            // 
            timerCom.Interval = 1000;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 450);
            Controls.Add(txtReceber);
            Controls.Add(txtEnviar);
            Controls.Add(comboBox1);
            Controls.Add(btnEnviar);
            Controls.Add(btnConectar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConectar;
        private Button btnEnviar;
        private ComboBox comboBox1;
        private TextBox txtEnviar;
        private TextBox txtReceber;
        private System.Windows.Forms.Timer timerCom;
    }
}
