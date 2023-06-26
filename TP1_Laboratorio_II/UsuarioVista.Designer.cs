namespace TP1_Laboratorio_II
{
  partial class UsuarioVista
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
            this.lblId = new System.Windows.Forms.Label();
            this.txtBxID = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtBxEmail = new System.Windows.Forms.TextBox();
            this.txtBxContraseña = new System.Windows.Forms.TextBox();
            this.txtBxRContraseña = new System.Windows.Forms.TextBox();
            this.txtBxDni = new System.Windows.Forms.TextBox();
            this.listBoxTipoUsuario = new System.Windows.Forms.ListBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRContraseña = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(36, 24);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(17, 15);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Id";
            // 
            // txtBxID
            // 
            this.txtBxID.Location = new System.Drawing.Point(37, 47);
            this.txtBxID.Name = "txtBxID";
            this.txtBxID.PlaceholderText = "Ingrese el Id del Usuario";
            this.txtBxID.Size = new System.Drawing.Size(136, 23);
            this.txtBxID.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(228, 37);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 32);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(37, 106);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Nombre del Usuario";
            this.txtNombre.Size = new System.Drawing.Size(132, 23);
            this.txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(228, 106);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PlaceholderText = "Apellido Usuario";
            this.txtApellido.Size = new System.Drawing.Size(132, 23);
            this.txtApellido.TabIndex = 5;
            // 
            // txtBxEmail
            // 
            this.txtBxEmail.Location = new System.Drawing.Point(36, 163);
            this.txtBxEmail.Name = "txtBxEmail";
            this.txtBxEmail.PlaceholderText = "Email Usuario";
            this.txtBxEmail.Size = new System.Drawing.Size(132, 23);
            this.txtBxEmail.TabIndex = 6;
            // 
            // txtBxContraseña
            // 
            this.txtBxContraseña.Location = new System.Drawing.Point(228, 163);
            this.txtBxContraseña.Name = "txtBxContraseña";
            this.txtBxContraseña.PlaceholderText = "Contraseña Usuario";
            this.txtBxContraseña.Size = new System.Drawing.Size(132, 23);
            this.txtBxContraseña.TabIndex = 7;
            // 
            // txtBxRContraseña
            // 
            this.txtBxRContraseña.Location = new System.Drawing.Point(409, 163);
            this.txtBxRContraseña.Name = "txtBxRContraseña";
            this.txtBxRContraseña.PlaceholderText = "Repetir Contraseña";
            this.txtBxRContraseña.Size = new System.Drawing.Size(132, 23);
            this.txtBxRContraseña.TabIndex = 8;
            // 
            // txtBxDni
            // 
            this.txtBxDni.Location = new System.Drawing.Point(36, 214);
            this.txtBxDni.Name = "txtBxDni";
            this.txtBxDni.PlaceholderText = "DNI Usuario";
            this.txtBxDni.Size = new System.Drawing.Size(127, 23);
            this.txtBxDni.TabIndex = 9;
            // 
            // listBoxTipoUsuario
            // 
            this.listBoxTipoUsuario.FormattingEnabled = true;
            this.listBoxTipoUsuario.ItemHeight = 15;
            this.listBoxTipoUsuario.Location = new System.Drawing.Point(231, 218);
            this.listBoxTipoUsuario.Name = "listBoxTipoUsuario";
            this.listBoxTipoUsuario.Size = new System.Drawing.Size(129, 19);
            this.listBoxTipoUsuario.TabIndex = 10;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(36, 88);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(94, 15);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre Usuario";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(228, 88);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(94, 15);
            this.lblApellido.TabIndex = 12;
            this.lblApellido.Text = "Nombre Usuario";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(228, 145);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(67, 15);
            this.lblContraseña.TabIndex = 14;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(36, 145);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email";
            // 
            // lblRContraseña
            // 
            this.lblRContraseña.AutoSize = true;
            this.lblRContraseña.Location = new System.Drawing.Point(409, 145);
            this.lblRContraseña.Name = "lblRContraseña";
            this.lblRContraseña.Size = new System.Drawing.Size(101, 15);
            this.lblRContraseña.TabIndex = 15;
            this.lblRContraseña.Text = "Repita contraseña";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(37, 196);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(27, 15);
            this.lblDni.TabIndex = 16;
            this.lblDni.Text = "DNI";
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Location = new System.Drawing.Point(231, 200);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(73, 15);
            this.lblTipoUsuario.TabIndex = 17;
            this.lblTipoUsuario.Text = "Tipo Usuario";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(53, 288);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(115, 28);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar ";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(213, 288);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(115, 28);
            this.Eliminar.TabIndex = 19;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(371, 288);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 28);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // UsuarioVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblTipoUsuario);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblRContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.listBoxTipoUsuario);
            this.Controls.Add(this.txtBxDni);
            this.Controls.Add(this.txtBxRContraseña);
            this.Controls.Add(this.txtBxContraseña);
            this.Controls.Add(this.txtBxEmail);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBxID);
            this.Controls.Add(this.lblId);
            this.IsMdiContainer = true;
            this.Name = "UsuarioVista";
            this.Text = "UsuarioVista";
            this.Load += new System.EventHandler(this.UsuarioVista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label lblId;
    private TextBox txtBxID;
    private Button btnBuscar;
    private TextBox txtNombre;
    private TextBox txtApellido;
    private TextBox txtBxEmail;
    private TextBox txtBxContraseña;
    private TextBox txtBxRContraseña;
    private TextBox txtBxDni;
    private ListBox listBoxTipoUsuario;
    private Label lblNombre;
    private Label lblApellido;
    private Label lblContraseña;
    private Label lblEmail;
    private Label lblRContraseña;
    private Label lblDni;
    private Label lblTipoUsuario;
    private Button btnModificar;
    private Button Eliminar;
    private Button btnCancelar;
  }
}