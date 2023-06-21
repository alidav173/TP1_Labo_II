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
            this.SuspendLayout();
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(45, 24);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(73, 15);
            this.lblRazonSocial.TabIndex = 1;
            this.lblRazonSocial.Text = "Razon Social";
            // 
            // txtBxRazonSocial
            // 
            this.txtBxRazonSocial.Location = new System.Drawing.Point(44, 53);
            this.txtBxRazonSocial.Name = "txtBxRazonSocial";
            this.txtBxRazonSocial.PlaceholderText = "Razon Social";
            this.txtBxRazonSocial.Size = new System.Drawing.Size(164, 23);
            this.txtBxRazonSocial.TabIndex = 2;
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(266, 26);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(32, 15);
            this.lblCuit.TabIndex = 3;
            this.lblCuit.Text = "CUIT";
            // 
            // txtbxCuit
            // 
            this.txtbxCuit.Location = new System.Drawing.Point(266, 53);
            this.txtbxCuit.Name = "txtbxCuit";
            this.txtbxCuit.PlaceholderText = "Razon Social";
            this.txtbxCuit.Size = new System.Drawing.Size(141, 23);
            this.txtbxCuit.TabIndex = 4;
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.Location = new System.Drawing.Point(45, 105);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(70, 15);
            this.lblTipoCliente.TabIndex = 5;
            this.lblTipoCliente.Text = "Tipo Cliente";
            // 
            // listBoxTipoCliente
            // 
            this.listBoxTipoCliente.FormattingEnabled = true;
            this.listBoxTipoCliente.ItemHeight = 15;
            this.listBoxTipoCliente.Location = new System.Drawing.Point(40, 134);
            this.listBoxTipoCliente.Name = "listBoxTipoCliente";
            this.listBoxTipoCliente.Size = new System.Drawing.Size(168, 34);
            this.listBoxTipoCliente.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(93, 234);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(167, 51);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(336, 236);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(178, 50);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ClienteVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
  }
}