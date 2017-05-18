namespace JogoDeMemoria
{
    partial class TelaMemorizar
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
            this.exibeMemorizar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timerMemorizar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.exibeMemorizar)).BeginInit();
            this.SuspendLayout();
            // 
            // exibeMemorizar
            // 
            this.exibeMemorizar.Image = global::JogoDeMemoria.Properties.Resources.memorizar;
            this.exibeMemorizar.Location = new System.Drawing.Point(12, 37);
            this.exibeMemorizar.Name = "exibeMemorizar";
            this.exibeMemorizar.Size = new System.Drawing.Size(788, 630);
            this.exibeMemorizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exibeMemorizar.TabIndex = 0;
            this.exibeMemorizar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(251, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hora de memorizar! :)";
            // 
            // timerMemorizar
            // 
            this.timerMemorizar.Interval = 7000;
            this.timerMemorizar.Tick += new System.EventHandler(this.timerMemorizar_Tick);
            // 
            // TelaMemorizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(812, 679);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exibeMemorizar);
            this.Name = "TelaMemorizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hora de memorizar! :D";
            this.Load += new System.EventHandler(this.TelaMemorizar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exibeMemorizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox exibeMemorizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerMemorizar;
    }
}