namespace Temp_Arduino
{
    partial class Termometro
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
            this.bt_Iniciar = new System.Windows.Forms.Button();
            this.bt_Finalizar = new System.Windows.Forms.Button();
            this.Lb_Porta = new System.Windows.Forms.Label();
            this.TxPorta = new System.Windows.Forms.TextBox();
            this.thermControl1 = new ThermometerControl.ThermControl();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // bt_Iniciar
            // 
            this.bt_Iniciar.Location = new System.Drawing.Point(45, 426);
            this.bt_Iniciar.Name = "bt_Iniciar";
            this.bt_Iniciar.Size = new System.Drawing.Size(110, 66);
            this.bt_Iniciar.TabIndex = 1;
            this.bt_Iniciar.Text = "&Iniciar";
            this.bt_Iniciar.UseVisualStyleBackColor = true;
            this.bt_Iniciar.Click += new System.EventHandler(this.bt_Iniciar_Click);
            // 
            // bt_Finalizar
            // 
            this.bt_Finalizar.Location = new System.Drawing.Point(195, 426);
            this.bt_Finalizar.Name = "bt_Finalizar";
            this.bt_Finalizar.Size = new System.Drawing.Size(110, 66);
            this.bt_Finalizar.TabIndex = 1;
            this.bt_Finalizar.Text = "Finaliza&r";
            this.bt_Finalizar.UseVisualStyleBackColor = true;
            this.bt_Finalizar.Click += new System.EventHandler(this.bt_Finalizar_Click);
            // 
            // Lb_Porta
            // 
            this.Lb_Porta.AutoSize = true;
            this.Lb_Porta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Porta.Location = new System.Drawing.Point(48, 394);
            this.Lb_Porta.Name = "Lb_Porta";
            this.Lb_Porta.Size = new System.Drawing.Size(141, 29);
            this.Lb_Porta.TabIndex = 2;
            this.Lb_Porta.Text = "Porta COM";
            // 
            // TxPorta
            // 
            this.TxPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxPorta.Location = new System.Drawing.Point(205, 398);
            this.TxPorta.Name = "TxPorta";
            this.TxPorta.Size = new System.Drawing.Size(100, 22);
            this.TxPorta.TabIndex = 3;
            this.TxPorta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // thermControl1
            // 
            this.thermControl1.Location = new System.Drawing.Point(77, 12);
            this.thermControl1.MinimumSize = new System.Drawing.Size(180, 315);
            this.thermControl1.Name = "thermControl1";
            this.thermControl1.Size = new System.Drawing.Size(180, 315);
            this.thermControl1.TabIndex = 4;
            this.thermControl1.Value = 0;
            // 
            // Termometro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 518);
            this.Controls.Add(this.thermControl1);
            this.Controls.Add(this.TxPorta);
            this.Controls.Add(this.Lb_Porta);
            this.Controls.Add(this.bt_Finalizar);
            this.Controls.Add(this.bt_Iniciar);
            this.Name = "Termometro";
            this.Text = "Termometro";
            this.Load += new System.EventHandler(this.Termometro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Iniciar;
        private System.Windows.Forms.Button bt_Finalizar;
        private System.Windows.Forms.Label Lb_Porta;
        private System.Windows.Forms.TextBox TxPorta;
        private ThermometerControl.ThermControl thermControl1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

