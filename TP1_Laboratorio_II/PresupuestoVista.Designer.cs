namespace TP1_Laboratorio_II
{
  partial class PresupuestoVista
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
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.txtBxNombreCliente = new System.Windows.Forms.TextBox();
            this.txtbxCuit = new System.Windows.Forms.TextBox();
            this.lblCuit = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtBxSubtotal = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblIVA = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblIIBB = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lblImpuestos = new System.Windows.Forms.Label();
            this.btnCrearPres = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTipoCliente = new System.Windows.Forms.Label();
            this.listBoxTipoCliente = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(66, 165);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(145, 25);
            this.btnAgregarProducto.TabIndex = 1;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(237, 165);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(145, 25);
            this.btnEliminarProducto.TabIndex = 2;
            this.btnEliminarProducto.Text = "Quitar Producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(66, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(364, 71);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(66, 22);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(73, 15);
            this.lblRazonSocial.TabIndex = 4;
            this.lblRazonSocial.Text = "Razon Social";
            // 
            // txtBxNombreCliente
            // 
            this.txtBxNombreCliente.Location = new System.Drawing.Point(66, 52);
            this.txtBxNombreCliente.Name = "txtBxNombreCliente";
            this.txtBxNombreCliente.PlaceholderText = "Nombre Cliente";
            this.txtBxNombreCliente.Size = new System.Drawing.Size(161, 23);
            this.txtBxNombreCliente.TabIndex = 5;
            this.txtBxNombreCliente.TextChanged += new System.EventHandler(this.txtBxNombreCliente_TextChanged);
            // 
            // txtbxCuit
            // 
            this.txtbxCuit.Location = new System.Drawing.Point(257, 52);
            this.txtbxCuit.Name = "txtbxCuit";
            this.txtbxCuit.PlaceholderText = "Nombre Cliente";
            this.txtbxCuit.Size = new System.Drawing.Size(161, 23);
            this.txtbxCuit.TabIndex = 7;
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(257, 22);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(70, 15);
            this.lblCuit.TabIndex = 6;
            this.lblCuit.Text = "CUIT cliente";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(72, 224);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(51, 15);
            this.lblSubtotal.TabIndex = 8;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // txtBxSubtotal
            // 
            this.txtBxSubtotal.Enabled = false;
            this.txtBxSubtotal.Location = new System.Drawing.Point(72, 254);
            this.txtBxSubtotal.Name = "txtBxSubtotal";
            this.txtBxSubtotal.PlaceholderText = "$0";
            this.txtBxSubtotal.Size = new System.Drawing.Size(161, 23);
            this.txtBxSubtotal.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(72, 327);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "$0";
            this.textBox2.Size = new System.Drawing.Size(161, 23);
            this.textBox2.TabIndex = 11;
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Location = new System.Drawing.Point(72, 297);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(24, 15);
            this.lblIVA.TabIndex = 10;
            this.lblIVA.Text = "IVA";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(257, 327);
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "$0";
            this.textBox3.Size = new System.Drawing.Size(161, 23);
            this.textBox3.TabIndex = 13;
            // 
            // lblIIBB
            // 
            this.lblIIBB.AutoSize = true;
            this.lblIIBB.Location = new System.Drawing.Point(257, 297);
            this.lblIIBB.Name = "lblIIBB";
            this.lblIIBB.Size = new System.Drawing.Size(27, 15);
            this.lblIIBB.TabIndex = 12;
            this.lblIIBB.Text = "IIBB";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(440, 327);
            this.textBox4.Name = "textBox4";
            this.textBox4.PlaceholderText = "$0";
            this.textBox4.Size = new System.Drawing.Size(161, 23);
            this.textBox4.TabIndex = 15;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(440, 297);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(32, 15);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Total";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(282, 237);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(265, 40);
            this.checkedListBox1.TabIndex = 16;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // lblImpuestos
            // 
            this.lblImpuestos.AutoSize = true;
            this.lblImpuestos.Location = new System.Drawing.Point(282, 219);
            this.lblImpuestos.Name = "lblImpuestos";
            this.lblImpuestos.Size = new System.Drawing.Size(62, 15);
            this.lblImpuestos.TabIndex = 17;
            this.lblImpuestos.Text = "Impuestos";
            // 
            // btnCrearPres
            // 
            this.btnCrearPres.Location = new System.Drawing.Point(182, 386);
            this.btnCrearPres.Name = "btnCrearPres";
            this.btnCrearPres.Size = new System.Drawing.Size(145, 36);
            this.btnCrearPres.TabIndex = 18;
            this.btnCrearPres.Text = "Generar Presupuesto";
            this.btnCrearPres.UseVisualStyleBackColor = true;
            this.btnCrearPres.Click += new System.EventHandler(this.btnCrearPres_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(609, 38);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(127, 37);
            this.btnAgregarCliente.TabIndex = 19;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(370, 386);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(145, 36);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.Location = new System.Drawing.Point(440, 22);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(70, 15);
            this.lblTipoCliente.TabIndex = 23;
            this.lblTipoCliente.Text = "Tipo Cliente";
            // 
            // listBoxTipoCliente
            // 
            this.listBoxTipoCliente.FormattingEnabled = true;
            this.listBoxTipoCliente.ItemHeight = 15;
            this.listBoxTipoCliente.Location = new System.Drawing.Point(440, 52);
            this.listBoxTipoCliente.Name = "listBoxTipoCliente";
            this.listBoxTipoCliente.Size = new System.Drawing.Size(141, 19);
            this.listBoxTipoCliente.TabIndex = 24;
            this.listBoxTipoCliente.SelectedIndexChanged += new System.EventHandler(this.listBoxTipoCliente_SelectedIndexChanged);
            // 
            // PresupuestoVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxTipoCliente);
            this.Controls.Add(this.lblTipoCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.btnCrearPres);
            this.Controls.Add(this.lblImpuestos);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblIIBB);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblIVA);
            this.Controls.Add(this.txtBxSubtotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.txtbxCuit);
            this.Controls.Add(this.lblCuit);
            this.Controls.Add(this.txtBxNombreCliente);
            this.Controls.Add(this.lblRazonSocial);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnAgregarProducto);
            this.IsMdiContainer = true;
            this.Name = "PresupuestoVista";
            this.Text = "CRM Blue - Presupuesto";
            this.Load += new System.EventHandler(this.PresupuestoVista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Button btnAgregarProducto;
    private Button btnEliminarProducto;
    private DataGridView dataGridView1;
    private Label lblRazonSocial;
    private TextBox txtBxNombreCliente;
    private TextBox txtbxCuit;
    private Label lblCuit;
    private Label lblSubtotal;
    private TextBox txtBxSubtotal;
    private TextBox textBox2;
    private Label lblIVA;
    private TextBox textBox3;
    private Label lblIIBB;
    private TextBox textBox4;
    private Label lblTotal;
    private CheckedListBox checkedListBox1;
    private Label lblImpuestos;
    private Button btnCrearPres;
    private Button btnAgregarCliente;
    private Button btnCancelar;
    private Label lblTipoCliente;
    private ListBox listBoxTipoCliente;
  }
}