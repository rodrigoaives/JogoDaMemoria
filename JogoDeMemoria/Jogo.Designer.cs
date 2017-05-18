namespace JogoDeMemoria
{
    partial class Jogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jogo));
            this.lblPontuacao = new System.Windows.Forms.Label();
            this.exibePontuacao = new System.Windows.Forms.Label();
            this.timerBonito = new System.Windows.Forms.Timer(this.components);
            this.timerBowser = new System.Windows.Forms.Timer(this.components);
            this.timerCogu = new System.Windows.Forms.Timer(this.components);
            this.timerLuigi = new System.Windows.Forms.Timer(this.components);
            this.timerMario = new System.Windows.Forms.Timer(this.components);
            this.timerWario = new System.Windows.Forms.Timer(this.components);
            this.moedinha = new System.Windows.Forms.PictureBox();
            this.cogu2 = new System.Windows.Forms.PictureBox();
            this.mario2 = new System.Windows.Forms.PictureBox();
            this.luigi2 = new System.Windows.Forms.PictureBox();
            this.bowser2 = new System.Windows.Forms.PictureBox();
            this.wario2 = new System.Windows.Forms.PictureBox();
            this.wario1 = new System.Windows.Forms.PictureBox();
            this.mario1 = new System.Windows.Forms.PictureBox();
            this.luigi1 = new System.Windows.Forms.PictureBox();
            this.cogu1 = new System.Windows.Forms.PictureBox();
            this.bowser1 = new System.Windows.Forms.PictureBox();
            this.bonito2 = new System.Windows.Forms.PictureBox();
            this.bonito1 = new System.Windows.Forms.PictureBox();
            this.btnCogu2 = new System.Windows.Forms.Button();
            this.btnMario2 = new System.Windows.Forms.Button();
            this.btnLuigi1 = new System.Windows.Forms.Button();
            this.btnLuigi2 = new System.Windows.Forms.Button();
            this.btnWario2 = new System.Windows.Forms.Button();
            this.btnBowser2 = new System.Windows.Forms.Button();
            this.btnWario1 = new System.Windows.Forms.Button();
            this.btnBonito2 = new System.Windows.Forms.Button();
            this.btnMario1 = new System.Windows.Forms.Button();
            this.btnCogu1 = new System.Windows.Forms.Button();
            this.btnBowser1 = new System.Windows.Forms.Button();
            this.btnBonito1 = new System.Windows.Forms.Button();
            this.lblCliques = new System.Windows.Forms.Label();
            this.exibeCliques = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.moedinha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mario2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luigi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowser2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wario2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wario1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mario1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luigi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowser1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonito2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonito1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPontuacao
            // 
            this.lblPontuacao.AutoSize = true;
            this.lblPontuacao.BackColor = System.Drawing.Color.Transparent;
            this.lblPontuacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontuacao.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPontuacao.Location = new System.Drawing.Point(398, 21);
            this.lblPontuacao.Name = "lblPontuacao";
            this.lblPontuacao.Size = new System.Drawing.Size(150, 29);
            this.lblPontuacao.TabIndex = 24;
            this.lblPontuacao.Text = "Pontuação: ";
            // 
            // exibePontuacao
            // 
            this.exibePontuacao.AutoSize = true;
            this.exibePontuacao.BackColor = System.Drawing.Color.Transparent;
            this.exibePontuacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exibePontuacao.ForeColor = System.Drawing.Color.White;
            this.exibePontuacao.Location = new System.Drawing.Point(554, 21);
            this.exibePontuacao.Name = "exibePontuacao";
            this.exibePontuacao.Size = new System.Drawing.Size(34, 29);
            this.exibePontuacao.TabIndex = 25;
            this.exibePontuacao.Text = "   ";
            // 
            // timerBonito
            // 
            this.timerBonito.Interval = 1500;
            this.timerBonito.Tick += new System.EventHandler(this.timerBonito_Tick);
            // 
            // timerBowser
            // 
            this.timerBowser.Interval = 1500;
            this.timerBowser.Tick += new System.EventHandler(this.timerBowser_Tick);
            // 
            // timerCogu
            // 
            this.timerCogu.Interval = 1500;
            this.timerCogu.Tick += new System.EventHandler(this.timerCogu_Tick);
            // 
            // timerLuigi
            // 
            this.timerLuigi.Interval = 1500;
            this.timerLuigi.Tick += new System.EventHandler(this.timerLuigi_Tick);
            // 
            // timerMario
            // 
            this.timerMario.Interval = 1500;
            this.timerMario.Tick += new System.EventHandler(this.timerMario_Tick);
            // 
            // timerWario
            // 
            this.timerWario.Interval = 1500;
            this.timerWario.Tick += new System.EventHandler(this.timerWario_Tick);
            // 
            // moedinha
            // 
            this.moedinha.BackColor = System.Drawing.Color.Transparent;
            this.moedinha.BackgroundImage = global::JogoDeMemoria.Properties.Resources.moedinha;
            this.moedinha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.moedinha.Location = new System.Drawing.Point(594, 21);
            this.moedinha.Name = "moedinha";
            this.moedinha.Size = new System.Drawing.Size(70, 31);
            this.moedinha.TabIndex = 26;
            this.moedinha.TabStop = false;
            this.moedinha.Visible = false;
            // 
            // cogu2
            // 
            this.cogu2.Image = global::JogoDeMemoria.Properties.Resources.cogu;
            this.cogu2.Location = new System.Drawing.Point(632, 439);
            this.cogu2.Name = "cogu2";
            this.cogu2.Size = new System.Drawing.Size(146, 128);
            this.cogu2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cogu2.TabIndex = 23;
            this.cogu2.TabStop = false;
            this.cogu2.Visible = false;
            // 
            // mario2
            // 
            this.mario2.BackColor = System.Drawing.Color.White;
            this.mario2.Image = global::JogoDeMemoria.Properties.Resources.mario;
            this.mario2.Location = new System.Drawing.Point(431, 439);
            this.mario2.Name = "mario2";
            this.mario2.Size = new System.Drawing.Size(145, 128);
            this.mario2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mario2.TabIndex = 22;
            this.mario2.TabStop = false;
            this.mario2.Visible = false;
            // 
            // luigi2
            // 
            this.luigi2.BackColor = System.Drawing.Color.White;
            this.luigi2.Image = global::JogoDeMemoria.Properties.Resources.luigi;
            this.luigi2.Location = new System.Drawing.Point(243, 439);
            this.luigi2.Name = "luigi2";
            this.luigi2.Size = new System.Drawing.Size(146, 128);
            this.luigi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.luigi2.TabIndex = 21;
            this.luigi2.TabStop = false;
            this.luigi2.Visible = false;
            // 
            // bowser2
            // 
            this.bowser2.Image = global::JogoDeMemoria.Properties.Resources.bowser;
            this.bowser2.Location = new System.Drawing.Point(60, 439);
            this.bowser2.Name = "bowser2";
            this.bowser2.Size = new System.Drawing.Size(146, 128);
            this.bowser2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bowser2.TabIndex = 20;
            this.bowser2.TabStop = false;
            this.bowser2.Visible = false;
            // 
            // wario2
            // 
            this.wario2.Image = global::JogoDeMemoria.Properties.Resources.wario;
            this.wario2.Location = new System.Drawing.Point(632, 270);
            this.wario2.Name = "wario2";
            this.wario2.Size = new System.Drawing.Size(146, 128);
            this.wario2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wario2.TabIndex = 19;
            this.wario2.TabStop = false;
            this.wario2.Visible = false;
            // 
            // wario1
            // 
            this.wario1.Image = global::JogoDeMemoria.Properties.Resources.wario;
            this.wario1.Location = new System.Drawing.Point(243, 270);
            this.wario1.Name = "wario1";
            this.wario1.Size = new System.Drawing.Size(146, 128);
            this.wario1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wario1.TabIndex = 18;
            this.wario1.TabStop = false;
            this.wario1.Visible = false;
            // 
            // mario1
            // 
            this.mario1.BackColor = System.Drawing.Color.White;
            this.mario1.Image = global::JogoDeMemoria.Properties.Resources.mario;
            this.mario1.Location = new System.Drawing.Point(60, 270);
            this.mario1.Name = "mario1";
            this.mario1.Size = new System.Drawing.Size(146, 128);
            this.mario1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mario1.TabIndex = 17;
            this.mario1.TabStop = false;
            this.mario1.Visible = false;
            // 
            // luigi1
            // 
            this.luigi1.BackColor = System.Drawing.Color.White;
            this.luigi1.Image = global::JogoDeMemoria.Properties.Resources.luigi;
            this.luigi1.Location = new System.Drawing.Point(632, 78);
            this.luigi1.Name = "luigi1";
            this.luigi1.Size = new System.Drawing.Size(146, 128);
            this.luigi1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.luigi1.TabIndex = 16;
            this.luigi1.TabStop = false;
            this.luigi1.Visible = false;
            // 
            // cogu1
            // 
            this.cogu1.Image = global::JogoDeMemoria.Properties.Resources.cogu;
            this.cogu1.Location = new System.Drawing.Point(431, 78);
            this.cogu1.Name = "cogu1";
            this.cogu1.Size = new System.Drawing.Size(146, 128);
            this.cogu1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cogu1.TabIndex = 15;
            this.cogu1.TabStop = false;
            this.cogu1.Visible = false;
            // 
            // bowser1
            // 
            this.bowser1.Image = global::JogoDeMemoria.Properties.Resources.bowser;
            this.bowser1.Location = new System.Drawing.Point(243, 78);
            this.bowser1.Name = "bowser1";
            this.bowser1.Size = new System.Drawing.Size(146, 128);
            this.bowser1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bowser1.TabIndex = 14;
            this.bowser1.TabStop = false;
            this.bowser1.Visible = false;
            // 
            // bonito2
            // 
            this.bonito2.BackColor = System.Drawing.Color.White;
            this.bonito2.Image = global::JogoDeMemoria.Properties.Resources.bonito;
            this.bonito2.Location = new System.Drawing.Point(431, 270);
            this.bonito2.Name = "bonito2";
            this.bonito2.Size = new System.Drawing.Size(146, 128);
            this.bonito2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bonito2.TabIndex = 13;
            this.bonito2.TabStop = false;
            this.bonito2.Visible = false;
            // 
            // bonito1
            // 
            this.bonito1.BackColor = System.Drawing.Color.White;
            this.bonito1.Image = global::JogoDeMemoria.Properties.Resources.bonito;
            this.bonito1.Location = new System.Drawing.Point(60, 78);
            this.bonito1.Name = "bonito1";
            this.bonito1.Size = new System.Drawing.Size(146, 128);
            this.bonito1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bonito1.TabIndex = 12;
            this.bonito1.TabStop = false;
            this.bonito1.Visible = false;
            // 
            // btnCogu2
            // 
            this.btnCogu2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCogu2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCogu2.BackgroundImage")));
            this.btnCogu2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCogu2.Location = new System.Drawing.Point(632, 439);
            this.btnCogu2.Name = "btnCogu2";
            this.btnCogu2.Size = new System.Drawing.Size(146, 128);
            this.btnCogu2.TabIndex = 11;
            this.btnCogu2.UseVisualStyleBackColor = false;
            this.btnCogu2.Click += new System.EventHandler(this.btnCogu2_Click);
            // 
            // btnMario2
            // 
            this.btnMario2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMario2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMario2.BackgroundImage")));
            this.btnMario2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMario2.Location = new System.Drawing.Point(431, 439);
            this.btnMario2.Name = "btnMario2";
            this.btnMario2.Size = new System.Drawing.Size(146, 128);
            this.btnMario2.TabIndex = 10;
            this.btnMario2.UseVisualStyleBackColor = false;
            this.btnMario2.Click += new System.EventHandler(this.btnMario2_Click);
            // 
            // btnLuigi1
            // 
            this.btnLuigi1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLuigi1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLuigi1.BackgroundImage")));
            this.btnLuigi1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLuigi1.Location = new System.Drawing.Point(632, 78);
            this.btnLuigi1.Name = "btnLuigi1";
            this.btnLuigi1.Size = new System.Drawing.Size(146, 128);
            this.btnLuigi1.TabIndex = 9;
            this.btnLuigi1.UseVisualStyleBackColor = false;
            this.btnLuigi1.Click += new System.EventHandler(this.btnLuigi1_Click);
            // 
            // btnLuigi2
            // 
            this.btnLuigi2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLuigi2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLuigi2.BackgroundImage")));
            this.btnLuigi2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLuigi2.Location = new System.Drawing.Point(243, 439);
            this.btnLuigi2.Name = "btnLuigi2";
            this.btnLuigi2.Size = new System.Drawing.Size(146, 128);
            this.btnLuigi2.TabIndex = 8;
            this.btnLuigi2.UseVisualStyleBackColor = false;
            this.btnLuigi2.Click += new System.EventHandler(this.btnLuigi2_Click);
            // 
            // btnWario2
            // 
            this.btnWario2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnWario2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWario2.BackgroundImage")));
            this.btnWario2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWario2.Location = new System.Drawing.Point(632, 270);
            this.btnWario2.Name = "btnWario2";
            this.btnWario2.Size = new System.Drawing.Size(146, 128);
            this.btnWario2.TabIndex = 7;
            this.btnWario2.UseVisualStyleBackColor = false;
            this.btnWario2.Click += new System.EventHandler(this.btnWario2_Click);
            // 
            // btnBowser2
            // 
            this.btnBowser2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBowser2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBowser2.BackgroundImage")));
            this.btnBowser2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBowser2.Location = new System.Drawing.Point(60, 439);
            this.btnBowser2.Name = "btnBowser2";
            this.btnBowser2.Size = new System.Drawing.Size(146, 128);
            this.btnBowser2.TabIndex = 6;
            this.btnBowser2.UseVisualStyleBackColor = false;
            this.btnBowser2.Click += new System.EventHandler(this.btnBowser2_Click);
            // 
            // btnWario1
            // 
            this.btnWario1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnWario1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWario1.BackgroundImage")));
            this.btnWario1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWario1.Location = new System.Drawing.Point(243, 270);
            this.btnWario1.Name = "btnWario1";
            this.btnWario1.Size = new System.Drawing.Size(146, 128);
            this.btnWario1.TabIndex = 5;
            this.btnWario1.UseVisualStyleBackColor = false;
            this.btnWario1.Click += new System.EventHandler(this.btnWario1_Click);
            // 
            // btnBonito2
            // 
            this.btnBonito2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBonito2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBonito2.BackgroundImage")));
            this.btnBonito2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBonito2.Location = new System.Drawing.Point(431, 270);
            this.btnBonito2.Name = "btnBonito2";
            this.btnBonito2.Size = new System.Drawing.Size(146, 128);
            this.btnBonito2.TabIndex = 4;
            this.btnBonito2.UseVisualStyleBackColor = false;
            this.btnBonito2.Click += new System.EventHandler(this.btnBonito2_Click);
            // 
            // btnMario1
            // 
            this.btnMario1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMario1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMario1.BackgroundImage")));
            this.btnMario1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMario1.Location = new System.Drawing.Point(60, 270);
            this.btnMario1.Name = "btnMario1";
            this.btnMario1.Size = new System.Drawing.Size(146, 128);
            this.btnMario1.TabIndex = 3;
            this.btnMario1.UseVisualStyleBackColor = false;
            this.btnMario1.Click += new System.EventHandler(this.btnMario1_Click);
            // 
            // btnCogu1
            // 
            this.btnCogu1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCogu1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCogu1.BackgroundImage")));
            this.btnCogu1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCogu1.Location = new System.Drawing.Point(431, 78);
            this.btnCogu1.Name = "btnCogu1";
            this.btnCogu1.Size = new System.Drawing.Size(146, 128);
            this.btnCogu1.TabIndex = 2;
            this.btnCogu1.UseVisualStyleBackColor = false;
            this.btnCogu1.Click += new System.EventHandler(this.btnCogu1_Click);
            // 
            // btnBowser1
            // 
            this.btnBowser1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBowser1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBowser1.BackgroundImage")));
            this.btnBowser1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBowser1.Location = new System.Drawing.Point(243, 78);
            this.btnBowser1.Name = "btnBowser1";
            this.btnBowser1.Size = new System.Drawing.Size(146, 128);
            this.btnBowser1.TabIndex = 1;
            this.btnBowser1.UseVisualStyleBackColor = false;
            this.btnBowser1.Click += new System.EventHandler(this.btnBowser1_Click);
            // 
            // btnBonito1
            // 
            this.btnBonito1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBonito1.BackgroundImage = global::JogoDeMemoria.Properties.Resources.box;
            this.btnBonito1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBonito1.ForeColor = System.Drawing.Color.White;
            this.btnBonito1.Location = new System.Drawing.Point(60, 78);
            this.btnBonito1.Name = "btnBonito1";
            this.btnBonito1.Size = new System.Drawing.Size(146, 128);
            this.btnBonito1.TabIndex = 0;
            this.btnBonito1.UseVisualStyleBackColor = false;
            this.btnBonito1.Click += new System.EventHandler(this.btnBonito1_Click);
            // 
            // lblCliques
            // 
            this.lblCliques.AutoSize = true;
            this.lblCliques.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliques.ForeColor = System.Drawing.Color.White;
            this.lblCliques.Location = new System.Drawing.Point(42, 21);
            this.lblCliques.Name = "lblCliques";
            this.lblCliques.Size = new System.Drawing.Size(107, 29);
            this.lblCliques.TabIndex = 27;
            this.lblCliques.Text = "Cliques: ";
            // 
            // exibeCliques
            // 
            this.exibeCliques.AutoSize = true;
            this.exibeCliques.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exibeCliques.ForeColor = System.Drawing.Color.White;
            this.exibeCliques.Location = new System.Drawing.Point(155, 21);
            this.exibeCliques.Name = "exibeCliques";
            this.exibeCliques.Size = new System.Drawing.Size(0, 29);
            this.exibeCliques.TabIndex = 28;
            // 
            // Jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(812, 679);
            this.Controls.Add(this.exibeCliques);
            this.Controls.Add(this.lblCliques);
            this.Controls.Add(this.moedinha);
            this.Controls.Add(this.exibePontuacao);
            this.Controls.Add(this.lblPontuacao);
            this.Controls.Add(this.cogu2);
            this.Controls.Add(this.mario2);
            this.Controls.Add(this.luigi2);
            this.Controls.Add(this.bowser2);
            this.Controls.Add(this.wario2);
            this.Controls.Add(this.wario1);
            this.Controls.Add(this.mario1);
            this.Controls.Add(this.luigi1);
            this.Controls.Add(this.cogu1);
            this.Controls.Add(this.bowser1);
            this.Controls.Add(this.bonito2);
            this.Controls.Add(this.bonito1);
            this.Controls.Add(this.btnCogu2);
            this.Controls.Add(this.btnMario2);
            this.Controls.Add(this.btnLuigi1);
            this.Controls.Add(this.btnLuigi2);
            this.Controls.Add(this.btnWario2);
            this.Controls.Add(this.btnBowser2);
            this.Controls.Add(this.btnWario1);
            this.Controls.Add(this.btnBonito2);
            this.Controls.Add(this.btnMario1);
            this.Controls.Add(this.btnCogu1);
            this.Controls.Add(this.btnBowser1);
            this.Controls.Add(this.btnBonito1);
            this.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.Name = "Jogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo Da Memória";
            ((System.ComponentModel.ISupportInitialize)(this.moedinha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mario2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luigi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowser2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wario2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wario1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mario1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luigi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowser1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonito2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonito1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBonito1;
        private System.Windows.Forms.Button btnBowser1;
        private System.Windows.Forms.Button btnCogu1;
        private System.Windows.Forms.Button btnWario1;
        private System.Windows.Forms.Button btnBonito2;
        private System.Windows.Forms.Button btnMario1;
        private System.Windows.Forms.Button btnLuigi2;
        private System.Windows.Forms.Button btnWario2;
        private System.Windows.Forms.Button btnBowser2;
        private System.Windows.Forms.Button btnLuigi1;
        private System.Windows.Forms.Button btnCogu2;
        private System.Windows.Forms.Button btnMario2;
        private System.Windows.Forms.PictureBox bonito1;
        private System.Windows.Forms.PictureBox bonito2;
        private System.Windows.Forms.PictureBox bowser1;
        private System.Windows.Forms.PictureBox cogu1;
        private System.Windows.Forms.PictureBox luigi1;
        private System.Windows.Forms.PictureBox mario1;
        private System.Windows.Forms.PictureBox wario1;
        private System.Windows.Forms.PictureBox wario2;
        private System.Windows.Forms.PictureBox bowser2;
        private System.Windows.Forms.PictureBox luigi2;
        private System.Windows.Forms.PictureBox mario2;
        private System.Windows.Forms.PictureBox cogu2;
        private System.Windows.Forms.Label lblPontuacao;
        private System.Windows.Forms.Label exibePontuacao;
        private System.Windows.Forms.Timer timerBonito;
        private System.Windows.Forms.Timer timerBowser;
        private System.Windows.Forms.Timer timerCogu;
        private System.Windows.Forms.Timer timerLuigi;
        private System.Windows.Forms.Timer timerMario;
        private System.Windows.Forms.Timer timerWario;
        private System.Windows.Forms.PictureBox moedinha;
        private System.Windows.Forms.Label lblCliques;
        private System.Windows.Forms.Label exibeCliques;
    }
}

