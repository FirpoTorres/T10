namespace TPEncuestaWin {
  partial class FrmMain {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        this.principalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.administrarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.completarEncuestaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.menuStrip1.SuspendLayout();
        this.SuspendLayout();
        // 
        // menuStrip1
        // 
        this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalToolStripMenuItem,
            this.ayudaToolStripMenuItem});
        this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        this.menuStrip1.Name = "menuStrip1";
        this.menuStrip1.Size = new System.Drawing.Size(571, 24);
        this.menuStrip1.TabIndex = 0;
        this.menuStrip1.Text = "menuStrip1";
        // 
        // principalToolStripMenuItem
        // 
        this.principalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarUsuariosToolStripMenuItem,
            this.completarEncuestaToolStripMenuItem});
        this.principalToolStripMenuItem.Name = "principalToolStripMenuItem";
        this.principalToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
        this.principalToolStripMenuItem.Text = "Principal";
        // 
        // administrarUsuariosToolStripMenuItem
        // 
        this.administrarUsuariosToolStripMenuItem.Name = "administrarUsuariosToolStripMenuItem";
        this.administrarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
        this.administrarUsuariosToolStripMenuItem.Text = "Administrar usuarios";
        // 
        // completarEncuestaToolStripMenuItem
        // 
        this.completarEncuestaToolStripMenuItem.Name = "completarEncuestaToolStripMenuItem";
        this.completarEncuestaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
        this.completarEncuestaToolStripMenuItem.Text = "Completar encuesta";
        // 
        // ayudaToolStripMenuItem
        // 
        this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
        this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
        this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
        this.ayudaToolStripMenuItem.Text = "Ayuda";
        // 
        // acercaDeToolStripMenuItem
        // 
        this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
        this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        this.acercaDeToolStripMenuItem.Text = "Acerca de...";
        // 
        // FrmMain
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(571, 321);
        this.Controls.Add(this.menuStrip1);
        this.MainMenuStrip = this.menuStrip1;
        this.Name = "FrmMain";
        this.Text = "FrmMain";
        this.menuStrip1.ResumeLayout(false);
        this.menuStrip1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem principalToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem administrarUsuariosToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem completarEncuestaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
  }
}