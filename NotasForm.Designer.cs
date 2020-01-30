namespace Proyecto
{
    partial class NotasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotasForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textTitulo = new System.Windows.Forms.TextBox();
            this.richTextBoxNota = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbPrivacidad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbColorLetra = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textFechaModificacion = new System.Windows.Forms.TextBox();
            this.textFechaCreacion = new System.Windows.Forms.TextBox();
            this.cmbFuente = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(42, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textTitulo
            // 
            this.textTitulo.Location = new System.Drawing.Point(112, 93);
            this.textTitulo.Name = "textTitulo";
            this.textTitulo.Size = new System.Drawing.Size(100, 22);
            this.textTitulo.TabIndex = 1;
            this.textTitulo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // richTextBoxNota
            // 
            this.richTextBoxNota.Location = new System.Drawing.Point(12, 545);
            this.richTextBoxNota.Name = "richTextBoxNota";
            this.richTextBoxNota.Size = new System.Drawing.Size(379, 153);
            this.richTextBoxNota.TabIndex = 2;
            this.richTextBoxNota.Text = "";
            this.richTextBoxNota.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 720);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(71, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Agregar Nota";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(477, 96);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(565, 443);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(29, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Categoria: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(112, 139);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 24);
            this.cmbCategoria.TabIndex = 7;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbPrivacidad
            // 
            this.cmbPrivacidad.FormattingEnabled = true;
            this.cmbPrivacidad.Location = new System.Drawing.Point(112, 199);
            this.cmbPrivacidad.Name = "cmbPrivacidad";
            this.cmbPrivacidad.Size = new System.Drawing.Size(121, 24);
            this.cmbPrivacidad.TabIndex = 8;
            this.cmbPrivacidad.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(24, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Privacidad: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(24, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Color:";
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(112, 256);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(121, 24);
            this.cmbColor.TabIndex = 11;
            this.cmbColor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_2);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(24, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fuente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(24, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Color de letra:";
            // 
            // cmbColorLetra
            // 
            this.cmbColorLetra.FormattingEnabled = true;
            this.cmbColorLetra.Location = new System.Drawing.Point(127, 355);
            this.cmbColorLetra.Name = "cmbColorLetra";
            this.cmbColorLetra.Size = new System.Drawing.Size(121, 24);
            this.cmbColorLetra.TabIndex = 15;
            this.cmbColorLetra.SelectedIndexChanged += new System.EventHandler(this.cmbColorLetra_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(12, 438);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Fecha de creacion:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(12, 493);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Fecha de modificacion:";
            // 
            // textFechaModificacion
            // 
            this.textFechaModificacion.Enabled = false;
            this.textFechaModificacion.Location = new System.Drawing.Point(171, 488);
            this.textFechaModificacion.Name = "textFechaModificacion";
            this.textFechaModificacion.Size = new System.Drawing.Size(100, 22);
            this.textFechaModificacion.TabIndex = 19;
            // 
            // textFechaCreacion
            // 
            this.textFechaCreacion.Enabled = false;
            this.textFechaCreacion.Location = new System.Drawing.Point(171, 435);
            this.textFechaCreacion.Name = "textFechaCreacion";
            this.textFechaCreacion.Size = new System.Drawing.Size(100, 22);
            this.textFechaCreacion.TabIndex = 18;
            // 
            // cmbFuente
            // 
            this.cmbFuente.FormattingEnabled = true;
            this.cmbFuente.Location = new System.Drawing.Point(112, 308);
            this.cmbFuente.Name = "cmbFuente";
            this.cmbFuente.Size = new System.Drawing.Size(121, 24);
            this.cmbFuente.TabIndex = 13;
            this.cmbFuente.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // NotasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1099, 862);
            this.Controls.Add(this.textFechaModificacion);
            this.Controls.Add(this.textFechaCreacion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbColorLetra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbFuente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbPrivacidad);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBoxNota);
            this.Controls.Add(this.textTitulo);
            this.Controls.Add(this.label1);
            this.Name = "NotasForm";
            this.Text = "Notas";
            this.Load += new System.EventHandler(this.Notas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textTitulo;
        private System.Windows.Forms.RichTextBox richTextBoxNota;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbPrivacidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbColorLetra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textFechaModificacion;
        private System.Windows.Forms.TextBox textFechaCreacion;
        private System.Windows.Forms.ComboBox cmbFuente;
    }
}