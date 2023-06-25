namespace TP1_Laboratorio_II
{
  partial class ClienteVista
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
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.txtBxRazonSocial = new System.Windows.Forms.TextBox();
            this.lblCuit = new System.Windows.Forms.Label();
            this.txtbxCuit = new System.Windows.Forms.TextBox();
            this.lblTipoCliente = new System.Windows.Forms.Label();
            this.listBoxTipoCliente = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtBxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBxDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtBxTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblBuscarCliente = new System.Windows.Forms.Label();
            this.txtBxID = new System.Windows.Forms.TextBox();
            this.btnBuscarPorID = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(44, 84);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(73, 15);
            this.lblRazonSocial.TabIndex = 1;
            this.lblRazonSocial.Text = "Razon Social";
            // 
            // txtBxRazonSocial
            // 
            this.txtBxRazonSocial.Location = new System.Drawing.Point(43, 113);
            this.txtBxRazonSocial.Name = "txtBxRazonSocial";
            this.txtBxRazonSocial.PlaceholderText = "Razon Social";
            this.txtBxRazonSocial.Size = new System.Drawing.Size(164, 23);
            this.txtBxRazonSocial.TabIndex = 2;
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(227, 84);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(32, 15);
            this.lblCuit.TabIndex = 3;
            this.lblCuit.Text = "CUIT";
            // 
            // txtbxCuit
            // 
            this.txtbxCuit.Location = new System.Drawing.Point(227, 113);
            this.txtbxCuit.Name = "txtbxCuit";
            this.txtbxCuit.PlaceholderText = "Razon Social";
            this.txtbxCuit.Size = new System.Drawing.Size(141, 23);
            this.txtbxCuit.TabIndex = 4;
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.Location = new System.Drawing.Point(44, 165);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(70, 15);
            this.lblTipoCliente.TabIndex = 5;
            this.lblTipoCliente.Text = "Tipo Cliente";
            // 
            // listBoxTipoCliente
            // 
            this.listBoxTipoCliente.FormattingEnabled = true;
            this.listBoxTipoCliente.ItemHeight = 15;
            this.listBoxTipoCliente.Location = new System.Drawing.Point(39, 194);
            this.listBoxTipoCliente.Name = "listBoxTipoCliente";
            this.listBoxTipoCliente.Size = new System.Drawing.Size(168, 34);
            this.listBoxTipoCliente.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(39, 246);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(167, 51);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(227, 246);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(178, 50);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtBxEmail
            // 
            this.txtBxEmail.Location = new System.Drawing.Point(398, 113);
            this.txtBxEmail.Name = "txtBxEmail";
            this.txtBxEmail.PlaceholderText = "Email";
            this.txtBxEmail.Size = new System.Drawing.Size(141, 23);
            this.txtBxEmail.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(398, 84);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // txtBxDireccion
            // 
            this.txtBxDireccion.Location = new System.Drawing.Point(227, 203);
            this.txtBxDireccion.Name = "txtBxDireccion";
            this.txtBxDireccion.PlaceholderText = "Direccion";
            this.txtBxDireccion.Size = new System.Drawing.Size(141, 23);
            this.txtBxDireccion.TabIndex = 13;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(227, 176);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 12;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtBxTelefono
            // 
            this.txtBxTelefono.Location = new System.Drawing.Point(398, 203);
            this.txtBxTelefono.Name = "txtBxTelefono";
            this.txtBxTelefono.PlaceholderText = "Telefono";
            this.txtBxTelefono.Size = new System.Drawing.Size(141, 23);
            this.txtBxTelefono.TabIndex = 15;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(398, 176);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 15);
            this.lblTelefono.TabIndex = 14;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblBuscarCliente
            // 
            this.lblBuscarCliente.AutoSize = true;
            this.lblBuscarCliente.Location = new System.Drawing.Point(89, 35);
            this.lblBuscarCliente.Name = "lblBuscarCliente";
            this.lblBuscarCliente.Size = new System.Drawing.Size(117, 15);
            this.lblBuscarCliente.TabIndex = 16;
            this.lblBuscarCliente.Text = "Buscar Cliente por ID";
            // 
            // txtBxID
            // 
            this.txtBxID.Location = new System.Drawing.Point(232, 27);
            this.txtBxID.Name = "txtBxID";
            this.txtBxID.PlaceholderText = "Ingrese el ID del Cliente";
            this.txtBxID.Size = new System.Drawing.Size(136, 23);
            this.txtBxID.TabIndex = 17;
            // 
            // btnBuscarPorID
            // 
            this.btnBuscarPorID.Location = new System.Drawing.Point(423, 12);
            this.btnBuscarPorID.Name = "btnBuscarPorID";
            this.btnBuscarPorID.Size = new System.Drawing.Size(167, 51);
            this.btnBuscarPorID.TabIndex = 18;
            this.btnBuscarPorID.Text = "Buscar por ID";
            this.btnBuscarPorID.UseVisualStyleBackColor = true;
            this.btnBuscarPorID.Click += new System.EventHandler(this.btnBuscarPorID_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(423, 245);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(167, 51);
            this.btnActualizar.TabIndex = 19;
            this.btnActualizar.Text = "Actualizar Datos";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // ClienteVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBuscarPorID);
            this.Controls.Add(this.txtBxID);
            this.Controls.Add(this.lblBuscarCliente);
            this.Controls.Add(this.txtBxTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtBxDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtBxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.listBoxTipoCliente);
            this.Controls.Add(this.lblTipoCliente);
            this.Controls.Add(this.txtbxCuit);
            this.Controls.Add(this.lblCuit);
            this.Controls.Add(this.txtBxRazonSocial);
            this.Controls.Add(this.lblRazonSocial);
            this.IsMdiContainer = true;
            this.Name = "ClienteVista";
            this.Text = "ClienteVista";
            this.Load += new System.EventHandler(this.ClienteVista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label lblRazonSocial;
    private TextBox txtBxRazonSocial;
    private Label lblCuit;
    private TextBox txtbxCuit;
    private Label lblTipoCliente;
    private ListBox listBoxTipoCliente;
    private Button btnAgregar;
    private Button btnCancelar;
    private TextBox txtBxEmail;
    private Label lblEmail;
    private TextBox txtBxDireccion;
    private Label lblDireccion;
    private TextBox txtBxTelefono;
    private Label lblTelefono;
    private Label lblBuscarCliente;
    private TextBox txtBxID;
    private Button btnBuscarPorID;
    private Button btnActualizar;
  }
}