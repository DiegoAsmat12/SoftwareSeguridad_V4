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
            this.splitContainerInfoTablaPlacas = new System.Windows.Forms.SplitContainer();
            this.panelInformacion = new System.Windows.Forms.Panel();
            this.dataGridViewTablaPlacas = new System.Windows.Forms.DataGridView();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.maskedTextBoxNumeroDePagina = new System.Windows.Forms.MaskedTextBox();
            this.labelNumeroDePagina = new System.Windows.Forms.Label();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.maskedTextBoxCantidadDeDatos = new System.Windows.Forms.MaskedTextBox();
            this.labelPlacas = new System.Windows.Forms.Label();
            this.panelDenunciaYImagen = new System.Windows.Forms.Panel();
            this.splitContainerImagenesDenuncia = new System.Windows.Forms.SplitContainer();
            this.panelImagenes = new System.Windows.Forms.Panel();
            this.labelCodigoPlaca = new System.Windows.Forms.Label();
            this.pictureBoxImagenPlaca = new System.Windows.Forms.PictureBox();
            this.pictureBoxImagenAuto = new System.Windows.Forms.PictureBox();
            this.panelDenuncia = new System.Windows.Forms.Panel();
            this.labelColoquePlaca = new System.Windows.Forms.Label();
            this.ButtonAlerta = new System.Windows.Forms.Button();
            this.textBoxPlacaDenuncia = new System.Windows.Forms.TextBox();
            this.expandirButtonDenuncia = new SoftwareSeguridad_V4.ExpandirButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerInfoTablaPlacas)).BeginInit();
            this.splitContainerInfoTablaPlacas.Panel1.SuspendLayout();
            this.splitContainerInfoTablaPlacas.Panel2.SuspendLayout();
            this.splitContainerInfoTablaPlacas.SuspendLayout();
            this.panelInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablaPlacas)).BeginInit();
            this.panelBusqueda.SuspendLayout();
            this.panelDenunciaYImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerImagenesDenuncia)).BeginInit();
            this.splitContainerImagenesDenuncia.Panel1.SuspendLayout();
            this.splitContainerImagenesDenuncia.Panel2.SuspendLayout();
            this.splitContainerImagenesDenuncia.SuspendLayout();
            this.panelImagenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenPlaca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenAuto)).BeginInit();
            this.panelDenuncia.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerInfoTablaPlacas
            // 
            this.splitContainerInfoTablaPlacas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.splitContainerInfoTablaPlacas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerInfoTablaPlacas.Location = new System.Drawing.Point(0, 0);
            this.splitContainerInfoTablaPlacas.Name = "splitContainerInfoTablaPlacas";
            this.splitContainerInfoTablaPlacas.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerInfoTablaPlacas.Panel1
            // 
            this.splitContainerInfoTablaPlacas.Panel1.Controls.Add(this.panelInformacion);
            this.splitContainerInfoTablaPlacas.Panel1MinSize = 0;
            // 
            // splitContainerInfoTablaPlacas.Panel2
            // 
            this.splitContainerInfoTablaPlacas.Panel2.Controls.Add(this.panelDenunciaYImagen);
            this.splitContainerInfoTablaPlacas.Panel2MinSize = 0;
            this.splitContainerInfoTablaPlacas.Size = new System.Drawing.Size(364, 792);
            this.splitContainerInfoTablaPlacas.SplitterDistance = 417;
            this.splitContainerInfoTablaPlacas.TabIndex = 0;
            // 
            // panelInformacion
            // 
            this.panelInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panelInformacion.Controls.Add(this.expandirButtonDenuncia);
            this.panelInformacion.Controls.Add(this.dataGridViewTablaPlacas);
            this.panelInformacion.Controls.Add(this.panelBusqueda);
            this.panelInformacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInformacion.Location = new System.Drawing.Point(0, 0);
            this.panelInformacion.Name = "panelInformacion";
            this.panelInformacion.Size = new System.Drawing.Size(364, 417);
            this.panelInformacion.TabIndex = 0;
            // 
            // dataGridViewTablaPlacas
            // 
            this.dataGridViewTablaPlacas.AllowUserToAddRows = false;
            this.dataGridViewTablaPlacas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dataGridViewTablaPlacas.EnableHeadersVisualStyles = false;
            this.dataGridViewTablaPlacas.GridColor = System.Drawing.Color.Black;
            this.dataGridViewTablaPlacas.Location = new System.Drawing.Point(0, 57);
            this.dataGridViewTablaPlacas.Name = "dataGridViewTablaPlacas";
            this.dataGridViewTablaPlacas.ReadOnly = true;
            this.dataGridViewTablaPlacas.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTablaPlacas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTablaPlacas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTablaPlacas.Size = new System.Drawing.Size(364, 321);
            this.dataGridViewTablaPlacas.TabIndex = 7;
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
            this.panelBusqueda.TabIndex = 6;
            // 
            // maskedTextBoxNumeroDePagina
            // 
            this.maskedTextBoxNumeroDePagina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this.labelNumeroDePagina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this.labelFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this.labelCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this.textBoxFiltro.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.maskedTextBoxCantidadDeDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this.labelPlacas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            // panelDenunciaYImagen
            // 
            this.panelDenunciaYImagen.Controls.Add(this.splitContainerImagenesDenuncia);
            this.panelDenunciaYImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDenunciaYImagen.Location = new System.Drawing.Point(0, 0);
            this.panelDenunciaYImagen.Name = "panelDenunciaYImagen";
            this.panelDenunciaYImagen.Size = new System.Drawing.Size(364, 371);
            this.panelDenunciaYImagen.TabIndex = 0;
            // 
            // splitContainerImagenesDenuncia
            // 
            this.splitContainerImagenesDenuncia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.splitContainerImagenesDenuncia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerImagenesDenuncia.Location = new System.Drawing.Point(0, 0);
            this.splitContainerImagenesDenuncia.Name = "splitContainerImagenesDenuncia";
            this.splitContainerImagenesDenuncia.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerImagenesDenuncia.Panel1
            // 
            this.splitContainerImagenesDenuncia.Panel1.Controls.Add(this.panelImagenes);
            this.splitContainerImagenesDenuncia.Panel1MinSize = 280;
            // 
            // splitContainerImagenesDenuncia.Panel2
            // 
            this.splitContainerImagenesDenuncia.Panel2.Controls.Add(this.panelDenuncia);
            this.splitContainerImagenesDenuncia.Panel2MinSize = 104;
            this.splitContainerImagenesDenuncia.Size = new System.Drawing.Size(364, 388);
            this.splitContainerImagenesDenuncia.SplitterDistance = 280;
            this.splitContainerImagenesDenuncia.TabIndex = 0;
            // 
            // panelImagenes
            // 
            this.panelImagenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panelImagenes.Controls.Add(this.labelCodigoPlaca);
            this.panelImagenes.Controls.Add(this.pictureBoxImagenPlaca);
            this.panelImagenes.Controls.Add(this.pictureBoxImagenAuto);
            this.panelImagenes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImagenes.Location = new System.Drawing.Point(0, 0);
            this.panelImagenes.Name = "panelImagenes";
            this.panelImagenes.Size = new System.Drawing.Size(364, 280);
            this.panelImagenes.TabIndex = 0;
            // 
            // labelCodigoPlaca
            // 
            this.labelCodigoPlaca.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCodigoPlaca.AutoSize = true;
            this.labelCodigoPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoPlaca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.labelCodigoPlaca.Location = new System.Drawing.Point(206, 187);
            this.labelCodigoPlaca.Name = "labelCodigoPlaca";
            this.labelCodigoPlaca.Size = new System.Drawing.Size(145, 37);
            this.labelCodigoPlaca.TabIndex = 2;
            this.labelCodigoPlaca.Text = "Codigo-I";
            // 
            // pictureBoxImagenPlaca
            // 
            this.pictureBoxImagenPlaca.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxImagenPlaca.Location = new System.Drawing.Point(206, 74);
            this.pictureBoxImagenPlaca.Name = "pictureBoxImagenPlaca";
            this.pictureBoxImagenPlaca.Size = new System.Drawing.Size(146, 50);
            this.pictureBoxImagenPlaca.TabIndex = 1;
            this.pictureBoxImagenPlaca.TabStop = false;
            // 
            // pictureBoxImagenAuto
            // 
            this.pictureBoxImagenAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxImagenAuto.Location = new System.Drawing.Point(16, 44);
            this.pictureBoxImagenAuto.Name = "pictureBoxImagenAuto";
            this.pictureBoxImagenAuto.Size = new System.Drawing.Size(184, 189);
            this.pictureBoxImagenAuto.TabIndex = 0;
            this.pictureBoxImagenAuto.TabStop = false;
            // 
            // panelDenuncia
            // 
            this.panelDenuncia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panelDenuncia.Controls.Add(this.labelColoquePlaca);
            this.panelDenuncia.Controls.Add(this.ButtonAlerta);
            this.panelDenuncia.Controls.Add(this.textBoxPlacaDenuncia);
            this.panelDenuncia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDenuncia.Location = new System.Drawing.Point(0, 0);
            this.panelDenuncia.Name = "panelDenuncia";
            this.panelDenuncia.Size = new System.Drawing.Size(364, 104);
            this.panelDenuncia.TabIndex = 0;
            // 
            // labelColoquePlaca
            // 
            this.labelColoquePlaca.AutoSize = true;
            this.labelColoquePlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColoquePlaca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.labelColoquePlaca.Location = new System.Drawing.Point(13, 19);
            this.labelColoquePlaca.Name = "labelColoquePlaca";
            this.labelColoquePlaca.Size = new System.Drawing.Size(241, 16);
            this.labelColoquePlaca.TabIndex = 8;
            this.labelColoquePlaca.Text = "Coloque el número de placa aquí:";
            this.labelColoquePlaca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButtonAlerta
            // 
            this.ButtonAlerta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonAlerta.FlatAppearance.BorderSize = 0;
            this.ButtonAlerta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAlerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAlerta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ButtonAlerta.Location = new System.Drawing.Point(259, 44);
            this.ButtonAlerta.Name = "ButtonAlerta";
            this.ButtonAlerta.Size = new System.Drawing.Size(75, 25);
            this.ButtonAlerta.TabIndex = 7;
            this.ButtonAlerta.Text = "Alerta";
            this.ButtonAlerta.UseVisualStyleBackColor = true;
            // 
            // textBoxPlacaDenuncia
            // 
            this.textBoxPlacaDenuncia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPlacaDenuncia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.textBoxPlacaDenuncia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPlacaDenuncia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlacaDenuncia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.textBoxPlacaDenuncia.Location = new System.Drawing.Point(16, 43);
            this.textBoxPlacaDenuncia.Name = "textBoxPlacaDenuncia";
            this.textBoxPlacaDenuncia.Size = new System.Drawing.Size(217, 26);
            this.textBoxPlacaDenuncia.TabIndex = 6;
            this.textBoxPlacaDenuncia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // expandirButtonDenuncia
            // 
            this.expandirButtonDenuncia.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.expandirButtonDenuncia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.expandirButtonDenuncia.FlatAppearance.BorderSize = 0;
            this.expandirButtonDenuncia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expandirButtonDenuncia.Image = global::SoftwareSeguridad_V4.Properties.Resources.IconoExpandirVertical;
            this.expandirButtonDenuncia.Location = new System.Drawing.Point(141, 395);
            this.expandirButtonDenuncia.Name = "expandirButtonDenuncia";
            this.expandirButtonDenuncia.Size = new System.Drawing.Size(75, 23);
            this.expandirButtonDenuncia.TabIndex = 8;
            this.expandirButtonDenuncia.UseVisualStyleBackColor = false;
            this.expandirButtonDenuncia.Click += new System.EventHandler(this.expandirButtonDenuncia_Click);
            // 
            // InfoTablaPlacas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(364, 792);
            this.Controls.Add(this.splitContainerInfoTablaPlacas);
            this.Name = "InfoTablaPlacas";
            this.Text = "InfoTablaPlacas";
            this.Load += new System.EventHandler(this.InfoTablaPlacas_Load);
            this.splitContainerInfoTablaPlacas.Panel1.ResumeLayout(false);
            this.splitContainerInfoTablaPlacas.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerInfoTablaPlacas)).EndInit();
            this.splitContainerInfoTablaPlacas.ResumeLayout(false);
            this.panelInformacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablaPlacas)).EndInit();
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            this.panelDenunciaYImagen.ResumeLayout(false);
            this.splitContainerImagenesDenuncia.Panel1.ResumeLayout(false);
            this.splitContainerImagenesDenuncia.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerImagenesDenuncia)).EndInit();
            this.splitContainerImagenesDenuncia.ResumeLayout(false);
            this.panelImagenes.ResumeLayout(false);
            this.panelImagenes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenPlaca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenAuto)).EndInit();
            this.panelDenuncia.ResumeLayout(false);
            this.panelDenuncia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerInfoTablaPlacas;
        private System.Windows.Forms.Panel panelInformacion;
        private System.Windows.Forms.DataGridView dataGridViewTablaPlacas;
        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumeroDePagina;
        private System.Windows.Forms.Label labelNumeroDePagina;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCantidadDeDatos;
        private System.Windows.Forms.Label labelPlacas;
        private System.Windows.Forms.Panel panelDenunciaYImagen;
        private System.Windows.Forms.SplitContainer splitContainerImagenesDenuncia;
        private System.Windows.Forms.Panel panelImagenes;
        private System.Windows.Forms.Panel panelDenuncia;
        private ExpandirButton expandirButtonDenuncia;
        private System.Windows.Forms.Label labelCodigoPlaca;
        private System.Windows.Forms.PictureBox pictureBoxImagenPlaca;
        private System.Windows.Forms.PictureBox pictureBoxImagenAuto;
        private System.Windows.Forms.Label labelColoquePlaca;
        private System.Windows.Forms.Button ButtonAlerta;
        private System.Windows.Forms.TextBox textBoxPlacaDenuncia;
    }
}