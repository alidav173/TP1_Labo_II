namespace TP1_Laboratorio_II
{
  partial class PantallaPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "A";
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PantallaPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PantallaPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private MenuStrip menuStrip2;
    private ToolStripMenuItem inicioToolStripMenuItem;
    private ToolStripMenuItem loginToolStripMenuItem;
    private ToolStripMenuItem registroToolStripMenuItem;
    private ToolStripMenuItem salirToolStripMenuItem;
    private ToolStripMenuItem moduloToolStripMenuItem;
    private ToolStripMenuItem presupuestoToolStripMenuItem;
    private ToolStripMenuItem listaDePreciosMaterialesToolStripMenuItem;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem toolStripMenuItem1;
    private ToolStripMenuItem nuevoPresupuestoToolStripMenuItem;
    private ToolStripMenuItem buscarPresupuestoToolStripMenuItem;
    private ToolStripMenuItem editarPresupuestoToolStripMenuItem;
    private ToolStripMenuItem productoToolStripMenuItem;
    private ToolStripMenuItem nuevoProductoToolStripMenuItem;
    private ToolStripMenuItem buscarProductoToolStripMenuItem;
    private ToolStripMenuItem editarProductoToolStripMenuItem;
    private ToolStripMenuItem eliminarProductoToolStripMenuItem;
    private ToolStripMenuItem materiasPrimasToolStripMenuItem;
    private ToolStripMenuItem nuevoMaterialToolStripMenuItem;
    private ToolStripMenuItem buscarMaterialToolStripMenuItem;
    private ToolStripMenuItem editarMaterialToolStripMenuItem;
    private ToolStripMenuItem eliminarMaterialToolStripMenuItem;
    private ToolStripMenuItem inventarioToolStripMenuItem;
    private ToolStripMenuItem invetarioMaterialesToolStripMenuItem;
    private ToolStripMenuItem inventarioProductosToolStripMenuItem;
    private ToolStripMenuItem aboutToolStripMenuItem;
    private ToolStripMenuItem acercaDelSoftwareToolStripMenuItem;
    private ToolStripMenuItem contactoToolStripMenuItem;
  }
}