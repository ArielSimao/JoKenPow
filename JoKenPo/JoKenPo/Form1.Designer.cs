namespace JoKenPo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.botaoPedra = new System.Windows.Forms.Button();
            this.botaoPapel = new System.Windows.Forms.Button();
            this.botaoTesoura = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.imgEscolhaJogador = new System.Windows.Forms.PictureBox();
            this.imgEscolhaComputado = new System.Windows.Forms.PictureBox();
            this.grupoPlacar = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.placarJogador = new System.Windows.Forms.Label();
            this.placarComputador = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgEscolhaJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEscolhaComputado)).BeginInit();
            this.grupoPlacar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.grupoPlacar);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.botaoTesoura);
            this.splitContainer1.Panel2.Controls.Add(this.botaoPapel);
            this.splitContainer1.Panel2.Controls.Add(this.botaoPedra);
            this.splitContainer1.Size = new System.Drawing.Size(686, 562);
            this.splitContainer1.SplitterDistance = 343;
            this.splitContainer1.TabIndex = 0;
            // 
            // botaoPedra
            // 
            this.botaoPedra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoPedra.BackgroundImage")));
            this.botaoPedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoPedra.Dock = System.Windows.Forms.DockStyle.Left;
            this.botaoPedra.Location = new System.Drawing.Point(0, 0);
            this.botaoPedra.Name = "botaoPedra";
            this.botaoPedra.Size = new System.Drawing.Size(234, 215);
            this.botaoPedra.TabIndex = 0;
            this.botaoPedra.Text = "Pedra";
            this.botaoPedra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botaoPedra.UseVisualStyleBackColor = true;
            this.botaoPedra.Click += new System.EventHandler(this.botaoPedra_Click);
            // 
            // botaoPapel
            // 
            this.botaoPapel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoPapel.BackgroundImage")));
            this.botaoPapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoPapel.Dock = System.Windows.Forms.DockStyle.Left;
            this.botaoPapel.Location = new System.Drawing.Point(234, 0);
            this.botaoPapel.Name = "botaoPapel";
            this.botaoPapel.Size = new System.Drawing.Size(218, 215);
            this.botaoPapel.TabIndex = 1;
            this.botaoPapel.Text = "Papel";
            this.botaoPapel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botaoPapel.UseVisualStyleBackColor = true;
            this.botaoPapel.Click += new System.EventHandler(this.botaoPapel_Click);
            // 
            // botaoTesoura
            // 
            this.botaoTesoura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoTesoura.BackgroundImage")));
            this.botaoTesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoTesoura.Dock = System.Windows.Forms.DockStyle.Left;
            this.botaoTesoura.Location = new System.Drawing.Point(452, 0);
            this.botaoTesoura.Name = "botaoTesoura";
            this.botaoTesoura.Size = new System.Drawing.Size(234, 215);
            this.botaoTesoura.TabIndex = 2;
            this.botaoTesoura.Text = "Tesoura";
            this.botaoTesoura.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botaoTesoura.UseVisualStyleBackColor = true;
            this.botaoTesoura.Click += new System.EventHandler(this.botaoTesoura_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.imgEscolhaJogador);
            this.groupBox1.Location = new System.Drawing.Point(6, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Minha Jogada";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.imgEscolhaComputado);
            this.groupBox2.Location = new System.Drawing.Point(455, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 193);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Jogada Computador";
            // 
            // imgEscolhaJogador
            // 
            this.imgEscolhaJogador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgEscolhaJogador.Location = new System.Drawing.Point(15, 19);
            this.imgEscolhaJogador.Name = "imgEscolhaJogador";
            this.imgEscolhaJogador.Size = new System.Drawing.Size(204, 168);
            this.imgEscolhaJogador.TabIndex = 0;
            this.imgEscolhaJogador.TabStop = false;
            // 
            // imgEscolhaComputado
            // 
            this.imgEscolhaComputado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgEscolhaComputado.Location = new System.Drawing.Point(7, 19);
            this.imgEscolhaComputado.Name = "imgEscolhaComputado";
            this.imgEscolhaComputado.Size = new System.Drawing.Size(218, 168);
            this.imgEscolhaComputado.TabIndex = 0;
            this.imgEscolhaComputado.TabStop = false;
            // 
            // grupoPlacar
            // 
            this.grupoPlacar.AutoSize = true;
            this.grupoPlacar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grupoPlacar.Controls.Add(this.label3);
            this.grupoPlacar.Controls.Add(this.placarComputador);
            this.grupoPlacar.Controls.Add(this.placarJogador);
            this.grupoPlacar.Controls.Add(this.label2);
            this.grupoPlacar.Controls.Add(this.label1);
            this.grupoPlacar.Location = new System.Drawing.Point(237, 147);
            this.grupoPlacar.Name = "grupoPlacar";
            this.grupoPlacar.Size = new System.Drawing.Size(212, 193);
            this.grupoPlacar.TabIndex = 2;
            this.grupoPlacar.TabStop = false;
            this.grupoPlacar.Text = "Placar";
            this.grupoPlacar.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jogador";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Computador";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // placarJogador
            // 
            this.placarJogador.AutoSize = true;
            this.placarJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placarJogador.Location = new System.Drawing.Point(18, 92);
            this.placarJogador.Name = "placarJogador";
            this.placarJogador.Size = new System.Drawing.Size(32, 36);
            this.placarJogador.TabIndex = 2;
            this.placarJogador.Text = "0";
            // 
            // placarComputador
            // 
            this.placarComputador.AutoSize = true;
            this.placarComputador.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placarComputador.Location = new System.Drawing.Point(149, 92);
            this.placarComputador.Name = "placarComputador";
            this.placarComputador.Size = new System.Drawing.Size(32, 36);
            this.placarComputador.TabIndex = 3;
            this.placarComputador.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 138);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(232, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(447, 136);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(686, 562);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "JoKenPo - Pedra Papel Tesoura";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgEscolhaJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEscolhaComputado)).EndInit();
            this.grupoPlacar.ResumeLayout(false);
            this.grupoPlacar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox imgEscolhaComputado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox imgEscolhaJogador;
        private System.Windows.Forms.Button botaoTesoura;
        private System.Windows.Forms.Button botaoPapel;
        private System.Windows.Forms.Button botaoPedra;
        private System.Windows.Forms.GroupBox grupoPlacar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label placarComputador;
        private System.Windows.Forms.Label placarJogador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

