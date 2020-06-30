namespace BD1
{
    partial class Banco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Banco));
            this.BTNexecutar = new System.Windows.Forms.Button();
            this.textSERVIDOR = new System.Windows.Forms.Label();
            this.TXTSERVIDOR = new System.Windows.Forms.TextBox();
            this.TXTUSUARIO = new System.Windows.Forms.TextBox();
            this.textUSUARIO = new System.Windows.Forms.Label();
            this.TXTSENHA = new System.Windows.Forms.TextBox();
            this.textSENHA = new System.Windows.Forms.Label();
            this.textBANCO = new System.Windows.Forms.Label();
            this.TXTBANCO = new System.Windows.Forms.TextBox();
            this.textSQL = new System.Windows.Forms.Label();
            this.TXTSQL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTNexecutar
            // 
            this.BTNexecutar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BTNexecutar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTNexecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNexecutar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNexecutar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTNexecutar.Location = new System.Drawing.Point(380, 164);
            this.BTNexecutar.MaximumSize = new System.Drawing.Size(200, 110);
            this.BTNexecutar.MinimumSize = new System.Drawing.Size(160, 50);
            this.BTNexecutar.Name = "BTNexecutar";
            this.BTNexecutar.Size = new System.Drawing.Size(200, 50);
            this.BTNexecutar.TabIndex = 0;
            this.BTNexecutar.Text = "Executar!";
            this.BTNexecutar.UseVisualStyleBackColor = false;
            this.BTNexecutar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textSERVIDOR
            // 
            this.textSERVIDOR.BackColor = System.Drawing.Color.Transparent;
            this.textSERVIDOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSERVIDOR.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textSERVIDOR.Location = new System.Drawing.Point(28, 40);
            this.textSERVIDOR.Name = "textSERVIDOR";
            this.textSERVIDOR.Size = new System.Drawing.Size(89, 20);
            this.textSERVIDOR.TabIndex = 1;
            this.textSERVIDOR.Text = "Servidor";
            // 
            // TXTSERVIDOR
            // 
            this.TXTSERVIDOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTSERVIDOR.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TXTSERVIDOR.Location = new System.Drawing.Point(135, 40);
            this.TXTSERVIDOR.MaximumSize = new System.Drawing.Size(300, 300);
            this.TXTSERVIDOR.MinimumSize = new System.Drawing.Size(100, 30);
            this.TXTSERVIDOR.Name = "TXTSERVIDOR";
            this.TXTSERVIDOR.Size = new System.Drawing.Size(189, 26);
            this.TXTSERVIDOR.TabIndex = 2;
            // 
            // TXTUSUARIO
            // 
            this.TXTUSUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTUSUARIO.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TXTUSUARIO.Location = new System.Drawing.Point(135, 86);
            this.TXTUSUARIO.MaximumSize = new System.Drawing.Size(300, 300);
            this.TXTUSUARIO.MinimumSize = new System.Drawing.Size(100, 30);
            this.TXTUSUARIO.Name = "TXTUSUARIO";
            this.TXTUSUARIO.Size = new System.Drawing.Size(189, 26);
            this.TXTUSUARIO.TabIndex = 3;
            // 
            // textUSUARIO
            // 
            this.textUSUARIO.AutoSize = true;
            this.textUSUARIO.BackColor = System.Drawing.Color.Transparent;
            this.textUSUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUSUARIO.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textUSUARIO.Location = new System.Drawing.Point(28, 86);
            this.textUSUARIO.Name = "textUSUARIO";
            this.textUSUARIO.Size = new System.Drawing.Size(71, 20);
            this.textUSUARIO.TabIndex = 4;
            this.textUSUARIO.Text = "Usuário";
            // 
            // TXTSENHA
            // 
            this.TXTSENHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTSENHA.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TXTSENHA.Location = new System.Drawing.Point(135, 133);
            this.TXTSENHA.MaximumSize = new System.Drawing.Size(300, 300);
            this.TXTSENHA.MinimumSize = new System.Drawing.Size(100, 30);
            this.TXTSENHA.Name = "TXTSENHA";
            this.TXTSENHA.Size = new System.Drawing.Size(189, 26);
            this.TXTSENHA.TabIndex = 5;
            // 
            // textSENHA
            // 
            this.textSENHA.AutoSize = true;
            this.textSENHA.BackColor = System.Drawing.Color.Transparent;
            this.textSENHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSENHA.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textSENHA.Location = new System.Drawing.Point(28, 133);
            this.textSENHA.Name = "textSENHA";
            this.textSENHA.Size = new System.Drawing.Size(61, 20);
            this.textSENHA.TabIndex = 6;
            this.textSENHA.Text = "Senha";
            // 
            // textBANCO
            // 
            this.textBANCO.AutoSize = true;
            this.textBANCO.BackColor = System.Drawing.Color.Transparent;
            this.textBANCO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBANCO.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBANCO.Location = new System.Drawing.Point(28, 179);
            this.textBANCO.Name = "textBANCO";
            this.textBANCO.Size = new System.Drawing.Size(60, 20);
            this.textBANCO.TabIndex = 7;
            this.textBANCO.Text = "Banco";
            // 
            // TXTBANCO
            // 
            this.TXTBANCO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBANCO.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TXTBANCO.Location = new System.Drawing.Point(135, 179);
            this.TXTBANCO.MaximumSize = new System.Drawing.Size(300, 300);
            this.TXTBANCO.MinimumSize = new System.Drawing.Size(100, 30);
            this.TXTBANCO.Name = "TXTBANCO";
            this.TXTBANCO.Size = new System.Drawing.Size(189, 26);
            this.TXTBANCO.TabIndex = 8;
            // 
            // textSQL
            // 
            this.textSQL.AutoSize = true;
            this.textSQL.BackColor = System.Drawing.Color.Transparent;
            this.textSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSQL.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textSQL.Location = new System.Drawing.Point(28, 233);
            this.textSQL.Name = "textSQL";
            this.textSQL.Size = new System.Drawing.Size(44, 20);
            this.textSQL.TabIndex = 9;
            this.textSQL.Text = "SQL";
            // 
            // TXTSQL
            // 
            this.TXTSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTSQL.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TXTSQL.Location = new System.Drawing.Point(135, 234);
            this.TXTSQL.MaximumSize = new System.Drawing.Size(600, 300);
            this.TXTSQL.MinimumSize = new System.Drawing.Size(100, 90);
            this.TXTSQL.Name = "TXTSQL";
            this.TXTSQL.Size = new System.Drawing.Size(445, 26);
            this.TXTSQL.TabIndex = 10;
            // 
            // Banco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(608, 274);
            this.Controls.Add(this.TXTSQL);
            this.Controls.Add(this.textSQL);
            this.Controls.Add(this.TXTBANCO);
            this.Controls.Add(this.textBANCO);
            this.Controls.Add(this.textSENHA);
            this.Controls.Add(this.TXTSENHA);
            this.Controls.Add(this.textUSUARIO);
            this.Controls.Add(this.TXTUSUARIO);
            this.Controls.Add(this.TXTSERVIDOR);
            this.Controls.Add(this.textSERVIDOR);
            this.Controls.Add(this.BTNexecutar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "Banco";
            this.Text = "Conectar";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNexecutar;
        private System.Windows.Forms.Label textSERVIDOR;
        private System.Windows.Forms.TextBox TXTSERVIDOR;
        private System.Windows.Forms.TextBox TXTUSUARIO;
        private System.Windows.Forms.Label textUSUARIO;
        private System.Windows.Forms.TextBox TXTSENHA;
        private System.Windows.Forms.Label textSENHA;
        private System.Windows.Forms.Label textBANCO;
        private System.Windows.Forms.TextBox TXTBANCO;
        private System.Windows.Forms.Label textSQL;
        private System.Windows.Forms.TextBox TXTSQL;
    }
}

