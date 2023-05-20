namespace TP1_Laboratorio_II
{
  partial class Login
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.label_password = new System.Windows.Forms.Label();
            this.label_usuario = new System.Windows.Forms.Label();
            this.boton_Login = new System.Windows.Forms.Button();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(180, 143);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(67, 15);
            this.label_password.TabIndex = 9;
            this.label_password.Text = "Contraseña";
            // 
            // label_usuario
            // 
            this.label_usuario.AutoSize = true;
            this.label_usuario.Location = new System.Drawing.Point(180, 92);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(36, 15);
            this.label_usuario.TabIndex = 8;
            this.label_usuario.Text = "Email";
            // 
            // boton_Login
            // 
            this.boton_Login.Location = new System.Drawing.Point(201, 220);
            this.boton_Login.Name = "boton_Login";
            this.boton_Login.Size = new System.Drawing.Size(75, 23);
            this.boton_Login.TabIndex = 7;
            this.boton_Login.Text = "Ingresar";
            this.boton_Login.UseVisualStyleBackColor = true;
            this.boton_Login.Click += new System.EventHandler(this.boton_Login_Click);
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(177, 161);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(121, 23);
            this.textBoxContraseña.TabIndex = 6;
            this.textBoxContraseña.UseSystemPasswordChar = true;
            this.textBoxContraseña.TextChanged += new System.EventHandler(this.textBoxContraseña_TextChanged);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(177, 111);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(121, 23);
            this.textBoxUsuario.TabIndex = 5;
            this.textBoxUsuario.TextChanged += new System.EventHandler(this.textBoxUsuario_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 338);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_usuario);
            this.Controls.Add(this.boton_Login);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.textBoxUsuario);
            this.Name = "Login";
            this.Text = "Blue CRM - Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label label_password;
    private Label label_usuario;
    private Button boton_Login;
    private TextBox textBoxContraseña;
    private TextBox textBoxUsuario;
  }
}
