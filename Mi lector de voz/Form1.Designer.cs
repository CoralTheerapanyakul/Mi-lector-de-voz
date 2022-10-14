namespace Mi_lector_de_voz
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.botonpausa = new System.Windows.Forms.Button();
            this.botoncuadro = new System.Windows.Forms.Button();
            this.botonplay = new System.Windows.Forms.Button();
            this.bandeja = new System.Windows.Forms.Button();
            this.lbtexto = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.bandeja);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.botonpausa);
            this.panel1.Controls.Add(this.botoncuadro);
            this.panel1.Controls.Add(this.botonplay);
            this.panel1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 88);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.Location = new System.Drawing.Point(393, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 65);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // botonpausa
            // 
            this.botonpausa.BackColor = System.Drawing.Color.Transparent;
            this.botonpausa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonpausa.BackgroundImage")));
            this.botonpausa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonpausa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonpausa.Location = new System.Drawing.Point(111, 9);
            this.botonpausa.Name = "botonpausa";
            this.botonpausa.Size = new System.Drawing.Size(74, 65);
            this.botonpausa.TabIndex = 2;
            this.botonpausa.UseVisualStyleBackColor = false;
            this.botonpausa.Click += new System.EventHandler(this.button3_Click);
            // 
            // botoncuadro
            // 
            this.botoncuadro.BackColor = System.Drawing.Color.Transparent;
            this.botoncuadro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botoncuadro.BackgroundImage")));
            this.botoncuadro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botoncuadro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botoncuadro.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.botoncuadro.Location = new System.Drawing.Point(213, 9);
            this.botoncuadro.Name = "botoncuadro";
            this.botoncuadro.Size = new System.Drawing.Size(74, 65);
            this.botoncuadro.TabIndex = 1;
            this.botoncuadro.UseVisualStyleBackColor = false;
            this.botoncuadro.Click += new System.EventHandler(this.botoncuadro_Click);
            // 
            // botonplay
            // 
            this.botonplay.BackColor = System.Drawing.Color.Transparent;
            this.botonplay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonplay.BackgroundImage")));
            this.botonplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonplay.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.botonplay.Location = new System.Drawing.Point(13, 9);
            this.botonplay.Name = "botonplay";
            this.botonplay.Size = new System.Drawing.Size(74, 65);
            this.botonplay.TabIndex = 0;
            this.botonplay.UseVisualStyleBackColor = false;
            this.botonplay.Click += new System.EventHandler(this.button1_Click);
            // 
            // bandeja
            // 
            this.bandeja.BackColor = System.Drawing.Color.Transparent;
            this.bandeja.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bandeja.BackgroundImage")));
            this.bandeja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bandeja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bandeja.Location = new System.Drawing.Point(482, 12);
            this.bandeja.Name = "bandeja";
            this.bandeja.Size = new System.Drawing.Size(74, 65);
            this.bandeja.TabIndex = 4;
            this.bandeja.UseVisualStyleBackColor = false;
            this.bandeja.Click += new System.EventHandler(this.button5_Click);
            // 
            // lbtexto
            // 
            this.lbtexto.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbtexto.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtexto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbtexto.Location = new System.Drawing.Point(-1, 91);
            this.lbtexto.Name = "lbtexto";
            this.lbtexto.Size = new System.Drawing.Size(580, 363);
            this.lbtexto.TabIndex = 1;
            this.lbtexto.Text = " Lector de texto avanzado:";
            this.lbtexto.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.lbtexto);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botonplay;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button botonpausa;
        private System.Windows.Forms.Button botoncuadro;
        private System.Windows.Forms.Button bandeja;
        private System.Windows.Forms.Label lbtexto;
    }
}

