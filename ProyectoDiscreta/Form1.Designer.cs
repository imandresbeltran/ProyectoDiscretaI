namespace ProyectoDiscreta
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
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblIngeniera = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnComenzar = new System.Windows.Forms.Button();
            this.BtnGrupo = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LblTitulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(215, 22);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(392, 23);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "PROYECTO FINAL MATEMÁTICA DISCRETA I";
            // 
            // LblIngeniera
            // 
            this.LblIngeniera.AutoSize = true;
            this.LblIngeniera.BackColor = System.Drawing.SystemColors.Window;
            this.LblIngeniera.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIngeniera.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblIngeniera.Location = new System.Drawing.Point(320, 55);
            this.LblIngeniera.Name = "LblIngeniera";
            this.LblIngeniera.Size = new System.Drawing.Size(181, 20);
            this.LblIngeniera.TabIndex = 1;
            this.LblIngeniera.Text = "Ingeniera Cindy Garcia";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BtnComenzar
            // 
            this.BtnComenzar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnComenzar.Location = new System.Drawing.Point(107, 142);
            this.BtnComenzar.Name = "BtnComenzar";
            this.BtnComenzar.Size = new System.Drawing.Size(108, 23);
            this.BtnComenzar.TabIndex = 3;
            this.BtnComenzar.Text = "COMENZAR";
            this.BtnComenzar.UseVisualStyleBackColor = true;
            this.BtnComenzar.Click += new System.EventHandler(this.BtnComenzar_Click);
            // 
            // BtnGrupo
            // 
            this.BtnGrupo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGrupo.Location = new System.Drawing.Point(595, 142);
            this.BtnGrupo.Name = "BtnGrupo";
            this.BtnGrupo.Size = new System.Drawing.Size(108, 23);
            this.BtnGrupo.TabIndex = 4;
            this.BtnGrupo.Text = "GRUPITO BB";
            this.BtnGrupo.UseVisualStyleBackColor = true;
            this.BtnGrupo.Click += new System.EventHandler(this.BtnGrupo_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(367, 401);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(108, 23);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnGrupo);
            this.Controls.Add(this.BtnComenzar);
            this.Controls.Add(this.LblIngeniera);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblIngeniera;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnComenzar;
        private System.Windows.Forms.Button BtnGrupo;
        private System.Windows.Forms.Button BtnSalir;
    }
}

