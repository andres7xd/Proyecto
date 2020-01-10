namespace Proyecto
{
    partial class HistorialForm
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
            this.dtgHistorial = new System.Windows.Forms.DataGridView();
            this.FechaColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccionColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LugarColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InformacionAdicionalColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgHistorial
            // 
            this.dtgHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaColum,
            this.UsuarioColum,
            this.AccionColum,
            this.LugarColum,
            this.InformacionAdicionalColum});
            this.dtgHistorial.Location = new System.Drawing.Point(125, 57);
            this.dtgHistorial.Name = "dtgHistorial";
            this.dtgHistorial.RowHeadersWidth = 51;
            this.dtgHistorial.RowTemplate.Height = 24;
            this.dtgHistorial.Size = new System.Drawing.Size(773, 437);
            this.dtgHistorial.TabIndex = 0;
            this.dtgHistorial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FechaColum
            // 
            this.FechaColum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaColum.HeaderText = "Fecha";
            this.FechaColum.MinimumWidth = 6;
            this.FechaColum.Name = "FechaColum";
            // 
            // UsuarioColum
            // 
            this.UsuarioColum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UsuarioColum.HeaderText = "Usuario";
            this.UsuarioColum.MinimumWidth = 6;
            this.UsuarioColum.Name = "UsuarioColum";
            // 
            // AccionColum
            // 
            this.AccionColum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AccionColum.HeaderText = "Accion";
            this.AccionColum.MinimumWidth = 6;
            this.AccionColum.Name = "AccionColum";
            // 
            // LugarColum
            // 
            this.LugarColum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LugarColum.HeaderText = "Lugar";
            this.LugarColum.MinimumWidth = 6;
            this.LugarColum.Name = "LugarColum";
            // 
            // InformacionAdicionalColum
            // 
            this.InformacionAdicionalColum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InformacionAdicionalColum.HeaderText = "Informacion Adicional";
            this.InformacionAdicionalColum.MinimumWidth = 6;
            this.InformacionAdicionalColum.Name = "InformacionAdicionalColum";
            // 
            // HistorialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 547);
            this.Controls.Add(this.dtgHistorial);
            this.Name = "HistorialForm";
            this.Text = "Historial";
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccionColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn LugarColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn InformacionAdicionalColum;
    }
}