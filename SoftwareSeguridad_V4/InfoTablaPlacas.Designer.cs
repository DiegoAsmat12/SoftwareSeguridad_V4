namespace SoftwareSeguridad_V4
{
    partial class InfoTablaPlacas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.maskedTextBoxNumeroDePagina = new System.Windows.Forms.MaskedTextBox();
            this.labelNumeroDePagina = new System.Windows.Forms.Label();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.maskedTextBoxCantidadDeDatos = new System.Windows.Forms.MaskedTextBox();
            this.labelPlacas = new System.Windows.Forms.Label();
            this.dataGridViewTablaPlacas = new System.Windows.Forms.DataGridView();
            this.panelBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablaPlacas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelBusqueda.Controls.Add(this.maskedTextBoxNumeroDePagina);
            this.panelBusqueda.Controls.Add(this.labelNumeroDePagina);
            this.panelBusqueda.Controls.Add(this.labelFiltro);
            this.panelBusqueda.Controls.Add(this.labelCantidad);
            this.panelBusqueda.Controls.Add(this.textBoxFiltro);
            this.panelBusqueda.Controls.Add(this.maskedTextBoxCantidadDeDatos);
            this.panelBusqueda.Controls.Add(this.labelPlacas);
            this.panelBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBusqueda.Location = new System.Drawing.Point(0, 0);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(364, 57);
            this.panelBusqueda.TabIndex = 4;
            // 
            // maskedTextBoxNumeroDePagina
            // 
            this.maskedTextBoxNumeroDePagina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxNumeroDePagina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.maskedTextBoxNumeroDePagina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBoxNumeroDePagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxNumeroDePagina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.maskedTextBoxNumeroDePagina.Location = new System.Drawing.Point(312, 30);
            this.maskedTextBoxNumeroDePagina.Mask = "9999";
            this.maskedTextBoxNumeroDePagina.Name = "maskedTextBoxNumeroDePagina";
            this.maskedTextBoxNumeroDePagina.PromptChar = ' ';
            this.maskedTextBoxNumeroDePagina.Size = new System.Drawing.Size(40, 22);
            this.maskedTextBoxNumeroDePagina.TabIndex = 10;
            this.maskedTextBoxNumeroDePagina.Text = "1";
            this.maskedTextBoxNumeroDePagina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelNumeroDePagina
            // 
            this.labelNumeroDePagina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNumeroDePagina.AutoSize = true;
            this.labelNumeroDePagina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNumeroDePagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroDePagina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.labelNumeroDePagina.Location = new System.Drawing.Point(275, 30);
            this.labelNumeroDePagina.Name = "labelNumeroDePagina";
            this.labelNumeroDePagina.Size = new System.Drawing.Size(29, 20);
            this.labelNumeroDePagina.TabIndex = 9;
            this.labelNumeroDePagina.Text = "N°:";
            this.labelNumeroDePagina.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFiltro
            // 
            this.labelFiltro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFiltro.AutoSize = true;
            this.labelFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.labelFiltro.Location = new System.Drawing.Point(12, 27);
            this.labelFiltro.Name = "labelFiltro";
            this.labelFiltro.Size = new System.Drawing.Size(53, 20);
            this.labelFiltro.TabIndex = 7;
            this.labelFiltro.Text = "Filtrar:";
            this.labelFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCantidad
            // 
            this.labelCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.labelCantidad.Location = new System.Drawing.Point(125, 5);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(171, 20);
            this.labelCantidad.TabIndex = 6;
            this.labelCantidad.Text = "Cantidad de Registros:";
            this.labelCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBoxFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.textBoxFiltro.Location = new System.Drawing.Point(71, 26);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(181, 26);
            this.textBoxFiltro.TabIndex = 5;
            this.textBoxFiltro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // maskedTextBoxCantidadDeDatos
            // 
            this.maskedTextBoxCantidadDeDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxCantidadDeDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.maskedTextBoxCantidadDeDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBoxCantidadDeDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxCantidadDeDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.maskedTextBoxCantidadDeDatos.Location = new System.Drawing.Point(302, 5);
            this.maskedTextBoxCantidadDeDatos.Mask = "999";
            this.maskedTextBoxCantidadDeDatos.Name = "maskedTextBoxCantidadDeDatos";
            this.maskedTextBoxCantidadDeDatos.PromptChar = ' ';
            this.maskedTextBoxCantidadDeDatos.Size = new System.Drawing.Size(50, 22);
            this.maskedTextBoxCantidadDeDatos.TabIndex = 4;
            this.maskedTextBoxCantidadDeDatos.Text = "10";
            this.maskedTextBoxCantidadDeDatos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelPlacas
            // 
            this.labelPlacas.AutoSize = true;
            this.labelPlacas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPlacas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlacas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.labelPlacas.Location = new System.Drawing.Point(12, 3);
            this.labelPlacas.Name = "labelPlacas";
            this.labelPlacas.Size = new System.Drawing.Size(62, 20);
            this.labelPlacas.TabIndex = 0;
            this.labelPlacas.Text = "Placas";
            this.labelPlacas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewTablaPlacas
            // 
            this.dataGridViewTablaPlacas.AllowUserToAddRows = false;
            this.dataGridViewTablaPlacas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewTablaPlacas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTablaPlacas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dataGridViewTablaPlacas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTablaPlacas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTablaPlacas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTablaPlacas.ColumnHeadersHeight = 25;
            this.dataGridViewTablaPlacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewTablaPlacas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTablaPlacas.EnableHeadersVisualStyles = false;
            this.dataGridViewTablaPlacas.Location = new System.Drawing.Point(0, 57);
            this.dataGridViewTablaPlacas.Name = "dataGridViewTablaPlacas";
            this.dataGridViewTablaPlacas.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTablaPlacas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTablaPlacas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTablaPlacas.Size = new System.Drawing.Size(364, 735);
            this.dataGridViewTablaPlacas.TabIndex = 5;
            // 
            // InfoTablaPlacas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(364, 792);
            this.Controls.Add(this.dataGridViewTablaPlacas);
            this.Controls.Add(this.panelBusqueda);
            this.Name = "InfoTablaPlacas";
            this.Text = "InfoTablaPlacas";
            this.Load += new System.EventHandler(this.InfoTablaPlacas_Load);
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablaPlacas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumeroDePagina;
        private System.Windows.Forms.Label labelNumeroDePagina;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCantidadDeDatos;
        private System.Windows.Forms.Label labelPlacas;
        private System.Windows.Forms.DataGridView dataGridViewTablaPlacas;
    }
}