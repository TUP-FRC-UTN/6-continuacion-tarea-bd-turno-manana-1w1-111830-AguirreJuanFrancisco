namespace Tarea_Prog_DB_2
{
  partial class Form1
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
      this.txtNombre = new System.Windows.Forms.TextBox();
      this.txtApellido = new System.Windows.Forms.TextBox();
      this.txtDocumento = new System.Windows.Forms.TextBox();
      this.cboTipoDoc = new System.Windows.Forms.ComboBox();
      this.cboEstadoCivil = new System.Windows.Forms.ComboBox();
      this.cboPersonas = new System.Windows.Forms.ComboBox();
      this.lstPersonas = new System.Windows.Forms.ListBox();
      this.dgvPersonas = new System.Windows.Forms.DataGridView();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
      this.SuspendLayout();
      // 
      // txtNombre
      // 
      this.txtNombre.Location = new System.Drawing.Point(243, 87);
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.Size = new System.Drawing.Size(212, 31);
      this.txtNombre.TabIndex = 0;
      // 
      // txtApellido
      // 
      this.txtApellido.Location = new System.Drawing.Point(243, 135);
      this.txtApellido.Name = "txtApellido";
      this.txtApellido.Size = new System.Drawing.Size(212, 31);
      this.txtApellido.TabIndex = 0;
      // 
      // txtDocumento
      // 
      this.txtDocumento.Location = new System.Drawing.Point(243, 248);
      this.txtDocumento.Name = "txtDocumento";
      this.txtDocumento.Size = new System.Drawing.Size(212, 31);
      this.txtDocumento.TabIndex = 0;
      // 
      // cboTipoDoc
      // 
      this.cboTipoDoc.FormattingEnabled = true;
      this.cboTipoDoc.Location = new System.Drawing.Point(243, 193);
      this.cboTipoDoc.Name = "cboTipoDoc";
      this.cboTipoDoc.Size = new System.Drawing.Size(212, 33);
      this.cboTipoDoc.TabIndex = 1;
      // 
      // cboEstadoCivil
      // 
      this.cboEstadoCivil.FormattingEnabled = true;
      this.cboEstadoCivil.Location = new System.Drawing.Point(243, 303);
      this.cboEstadoCivil.Name = "cboEstadoCivil";
      this.cboEstadoCivil.Size = new System.Drawing.Size(212, 33);
      this.cboEstadoCivil.TabIndex = 1;
      // 
      // cboPersonas
      // 
      this.cboPersonas.FormattingEnabled = true;
      this.cboPersonas.Location = new System.Drawing.Point(873, 48);
      this.cboPersonas.Name = "cboPersonas";
      this.cboPersonas.Size = new System.Drawing.Size(212, 33);
      this.cboPersonas.TabIndex = 1;
      // 
      // lstPersonas
      // 
      this.lstPersonas.FormattingEnabled = true;
      this.lstPersonas.ItemHeight = 25;
      this.lstPersonas.Location = new System.Drawing.Point(658, 109);
      this.lstPersonas.Name = "lstPersonas";
      this.lstPersonas.Size = new System.Drawing.Size(905, 229);
      this.lstPersonas.TabIndex = 2;
      this.lstPersonas.SelectedIndexChanged += new System.EventHandler(this.lstPersonas_SelectedIndexChanged);
      // 
      // dgvPersonas
      // 
      this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvPersonas.Location = new System.Drawing.Point(47, 374);
      this.dgvPersonas.Name = "dgvPersonas";
      this.dgvPersonas.RowHeadersWidth = 82;
      this.dgvPersonas.RowTemplate.Height = 33;
      this.dgvPersonas.Size = new System.Drawing.Size(1598, 377);
      this.dgvPersonas.TabIndex = 3;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(45, 90);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(87, 25);
      this.label1.TabIndex = 4;
      this.label1.Text = "Nombre";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(45, 138);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(89, 25);
      this.label2.TabIndex = 4;
      this.label2.Text = "Apellido";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(45, 196);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(169, 25);
      this.label3.TabIndex = 4;
      this.label3.Text = "Tipo Documento";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(45, 251);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(121, 25);
      this.label4.TabIndex = 4;
      this.label4.Text = "Documento";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(45, 306);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(126, 25);
      this.label5.TabIndex = 4;
      this.label5.Text = "Estado Civil";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(653, 51);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(103, 25);
      this.label6.TabIndex = 4;
      this.label6.Text = "Personas";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1723, 763);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dgvPersonas);
      this.Controls.Add(this.lstPersonas);
      this.Controls.Add(this.cboPersonas);
      this.Controls.Add(this.cboEstadoCivil);
      this.Controls.Add(this.cboTipoDoc);
      this.Controls.Add(this.txtDocumento);
      this.Controls.Add(this.txtApellido);
      this.Controls.Add(this.txtNombre);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.TextBox txtApellido;
    private System.Windows.Forms.TextBox txtDocumento;
    private System.Windows.Forms.ComboBox cboTipoDoc;
    private System.Windows.Forms.ComboBox cboEstadoCivil;
    private System.Windows.Forms.ComboBox cboPersonas;
    private System.Windows.Forms.ListBox lstPersonas;
    private System.Windows.Forms.DataGridView dgvPersonas;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
  }
}

