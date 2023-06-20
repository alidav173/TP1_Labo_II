namespace TP1_Laboratorio_II
{
  partial class Buscador
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
            this.btnBuscarID = new System.Windows.Forms.Button();
            this.btnBuscarValor = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtBxId = new System.Windows.Forms.TextBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.txtBxCampo = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtBxValor = new System.Windows.Forms.TextBox();
            this.lblObjeto = new System.Windows.Forms.Label();
            this.txtBxId2 = new System.Windows.Forms.TextBox();
            this.lblId2 = new System.Windows.Forms.Label();
            this.txtBxNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBxApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtBxDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtBxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBxContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBuscarID
            // 
            this.btnBuscarID.Location = new System.Drawing.Point(107, 263);
            this.btnBuscarID.Name = "btnBuscarID";
            this.btnBuscarID.Size = new System.Drawing.Size(107, 48);
            this.btnBuscarID.TabIndex = 1;
            this.btnBuscarID.Text = "Buscar por Id";
            this.btnBuscarID.UseVisualStyleBackColor = true;
            this.btnBuscarID.Click += new System.EventHandler(this.btnBuscarID_Click);
            // 
            // btnBuscarValor
            // 
            this.btnBuscarValor.Location = new System.Drawing.Point(248, 265);
            this.btnBuscarValor.Name = "btnBuscarValor";
            this.btnBuscarValor.Size = new System.Drawing.Size(116, 45);
            this.btnBuscarValor.TabIndex = 2;
            this.btnBuscarValor.Text = "BuscarPorValor";
            this.btnBuscarValor.UseVisualStyleBackColor = true;
            this.btnBuscarValor.Click += new System.EventHandler(this.btnBuscarValor_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(43, 30);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(17, 15);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Id";
            // 
            // txtBxId
            // 
            this.txtBxId.Location = new System.Drawing.Point(43, 58);
            this.txtBxId.Name = "txtBxId";
            this.txtBxId.PlaceholderText = "Introduzca ID";
            this.txtBxId.Size = new System.Drawing.Size(122, 23);
            this.txtBxId.TabIndex = 4;
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(219, 30);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(46, 15);
            this.lblCampo.TabIndex = 5;
            this.lblCampo.Text = "Campo";
            // 
            // txtBxCampo
            // 
            this.txtBxCampo.Location = new System.Drawing.Point(219, 58);
            this.txtBxCampo.Name = "txtBxCampo";
            this.txtBxCampo.PlaceholderText = "Introduzca el campo";
            this.txtBxCampo.Size = new System.Drawing.Size(123, 23);
            this.txtBxCampo.TabIndex = 6;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(377, 30);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(81, 15);
            this.lblValor.TabIndex = 7;
            this.lblValor.Text = "Valor buscado";
            // 
            // txtBxValor
            // 
            this.txtBxValor.Location = new System.Drawing.Point(377, 58);
            this.txtBxValor.Name = "txtBxValor";
            this.txtBxValor.PlaceholderText = "Valor buscado";
            this.txtBxValor.Size = new System.Drawing.Size(176, 23);
            this.txtBxValor.TabIndex = 8;
            // 
            // lblObjeto
            // 
            this.lblObjeto.AutoSize = true;
            this.lblObjeto.Location = new System.Drawing.Point(47, 102);
            this.lblObjeto.Name = "lblObjeto";
            this.lblObjeto.Size = new System.Drawing.Size(47, 15);
            this.lblObjeto.TabIndex = 12;
            this.lblObjeto.Text = "Usuario";
            // 
            // txtBxId2
            // 
            this.txtBxId2.Enabled = false;
            this.txtBxId2.Location = new System.Drawing.Point(43, 161);
            this.txtBxId2.Name = "txtBxId2";
            this.txtBxId2.PlaceholderText = "Introduzca ID";
            this.txtBxId2.Size = new System.Drawing.Size(122, 23);
            this.txtBxId2.TabIndex = 14;
            // 
            // lblId2
            // 
            this.lblId2.AutoSize = true;
            this.lblId2.Location = new System.Drawing.Point(43, 133);
            this.lblId2.Name = "lblId2";
            this.lblId2.Size = new System.Drawing.Size(17, 15);
            this.lblId2.TabIndex = 13;
            this.lblId2.Text = "Id";
            // 
            // txtBxNombre
            // 
            this.txtBxNombre.Location = new System.Drawing.Point(176, 161);
            this.txtBxNombre.Name = "txtBxNombre";
            this.txtBxNombre.PlaceholderText = "Introduzca el nombre";
            this.txtBxNombre.Size = new System.Drawing.Size(122, 23);
            this.txtBxNombre.TabIndex = 16;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(176, 133);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Nombre";
            // 
            // txtBxApellido
            // 
            this.txtBxApellido.Location = new System.Drawing.Point(313, 161);
            this.txtBxApellido.Name = "txtBxApellido";
            this.txtBxApellido.PlaceholderText = "Introduzca el apellido";
            this.txtBxApellido.Size = new System.Drawing.Size(122, 23);
            this.txtBxApellido.TabIndex = 18;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(313, 133);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 15);
            this.lblApellido.TabIndex = 17;
            this.lblApellido.Text = "Apellido";
            // 
            // txtBxDni
            // 
            this.txtBxDni.Location = new System.Drawing.Point(456, 161);
            this.txtBxDni.Name = "txtBxDni";
            this.txtBxDni.PlaceholderText = "Introduzca DNI";
            this.txtBxDni.Size = new System.Drawing.Size(122, 23);
            this.txtBxDni.TabIndex = 20;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(456, 133);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(27, 15);
            this.lblDni.TabIndex = 19;
            this.lblDni.Text = "DNI";
            // 
            // txtBxEmail
            // 
            this.txtBxEmail.Location = new System.Drawing.Point(43, 215);
            this.txtBxEmail.Name = "txtBxEmail";
            this.txtBxEmail.PlaceholderText = "Introduzca email";
            this.txtBxEmail.Size = new System.Drawing.Size(122, 23);
            this.txtBxEmail.TabIndex = 22;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(43, 197);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "Email";
            // 
            // txtBxContraseña
            // 
            this.txtBxContraseña.Location = new System.Drawing.Point(176, 216);
            this.txtBxContraseña.Name = "txtBxContraseña";
            this.txtBxContraseña.PlaceholderText = "Introduzca contraseña";
            this.txtBxContraseña.Size = new System.Drawing.Size(122, 23);
            this.txtBxContraseña.TabIndex = 24;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(176, 198);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(67, 15);
            this.lblContraseña.TabIndex = 23;
            this.lblContraseña.Text = "Contraseña";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(313, 216);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(160, 34);
            this.listBox1.TabIndex = 25;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Location = new System.Drawing.Point(313, 198);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(73, 15);
            this.lblTipoUsuario.TabIndex = 26;
            this.lblTipoUsuario.Text = "Tipo Usuario";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(402, 266);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(134, 45);
            this.btnActualizar.TabIndex = 27;
            this.btnActualizar.Text = "Actualizar Campos";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(568, 267);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(146, 44);
            this.btnEliminar.TabIndex = 29;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Buscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblTipoUsuario);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtBxContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txtBxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtBxDni);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.txtBxApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtBxNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtBxId2);
            this.Controls.Add(this.lblId2);
            this.Controls.Add(this.lblObjeto);
            this.Controls.Add(this.txtBxValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtBxCampo);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.txtBxId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnBuscarValor);
            this.Controls.Add(this.btnBuscarID);
            this.IsMdiContainer = true;
            this.Name = "Buscador";
            this.Text = "Buscador";
            this.Load += new System.EventHandler(this.Buscador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Button btnBuscarID;
    private Button btnBuscarValor;
    private Label lblId;
    private TextBox txtBxId;
    private Label lblCampo;
    private TextBox txtBxCampo;
    private Label lblValor;
    private TextBox txtBxValor;
    private Label lblObjeto;
    private TextBox txtBxId2;
    private Label lblId2;
    private TextBox txtBxNombre;
    private Label lblNombre;
    private TextBox txtBxApellido;
    private Label lblApellido;
    private TextBox txtBxDni;
    private Label lblDni;
    private TextBox txtBxEmail;
    private Label lblEmail;
    private TextBox txtBxContraseña;
    private Label lblContraseña;
    private ListBox listBox1;
    private Label lblTipoUsuario;
    private Button btnActualizar;
    private Button btnEliminar;
  }
}