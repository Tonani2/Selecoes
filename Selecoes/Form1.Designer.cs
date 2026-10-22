namespace Selecoes;

partial class Form1
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
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		lblTitulo = new Label();
		lblCidade = new Label();
		cmbCidade = new ComboBox();
		chkMatutino = new CheckBox();
		lblTurno = new Label();
		chkVespertino = new CheckBox();
		chkNoturno = new CheckBox();
		chkTermosPoliticas = new CheckBox();
		lblTermosPoliticas = new Label();
		bntCadastrar = new Button();
		dgvCadastro = new DataGridView();
		((System.ComponentModel.ISupportInitialize)dgvCadastro).BeginInit();
		SuspendLayout();
		// 
		// lblTitulo
		// 
		lblTitulo.AutoSize = true;
		lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
		lblTitulo.Location = new Point(12, 9);
		lblTitulo.Name = "lblTitulo";
		lblTitulo.Size = new Size(99, 30);
		lblTitulo.TabIndex = 0;
		lblTitulo.Text = "Cadastro";
		// 
		// lblCidade
		// 
		lblCidade.AutoSize = true;
		lblCidade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		lblCidade.Location = new Point(12, 47);
		lblCidade.Name = "lblCidade";
		lblCidade.Size = new Size(91, 21);
		lblCidade.TabIndex = 1;
		lblCidade.Text = "Sua Cidade:";
		// 
		// cmbCidade
		// 
		cmbCidade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		cmbCidade.FormattingEnabled = true;
		cmbCidade.Location = new Point(12, 79);
		cmbCidade.Name = "cmbCidade";
		cmbCidade.Size = new Size(160, 29);
		cmbCidade.TabIndex = 2;
		// 
		// chkMatutino
		// 
		chkMatutino.Location = new Point(12, 147);
		chkMatutino.Name = "chkMatutino";
		chkMatutino.Size = new Size(104, 24);
		chkMatutino.TabIndex = 3;
		chkMatutino.Text = "Matutino";
		chkMatutino.UseVisualStyleBackColor = true;
		// 
		// lblTurno
		// 
		lblTurno.AutoSize = true;
		lblTurno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		lblTurno.Location = new Point(12, 119);
		lblTurno.Name = "lblTurno";
		lblTurno.Size = new Size(54, 21);
		lblTurno.TabIndex = 4;
		lblTurno.Text = "Turno:";
		// 
		// chkVespertino
		// 
		chkVespertino.Location = new Point(12, 177);
		chkVespertino.Name = "chkVespertino";
		chkVespertino.Size = new Size(104, 24);
		chkVespertino.TabIndex = 5;
		chkVespertino.Text = "Vespertino";
		chkVespertino.UseVisualStyleBackColor = true;
		// 
		// chkNoturno
		// 
		chkNoturno.Location = new Point(12, 207);
		chkNoturno.Name = "chkNoturno";
		chkNoturno.Size = new Size(104, 24);
		chkNoturno.TabIndex = 6;
		chkNoturno.Text = "Noturno";
		chkNoturno.UseVisualStyleBackColor = true;
		// 
		// chkTermosPoliticas
		// 
		chkTermosPoliticas.AutoSize = true;
		chkTermosPoliticas.Location = new Point(12, 274);
		chkTermosPoliticas.Name = "chkTermosPoliticas";
		chkTermosPoliticas.Size = new Size(278, 19);
		chkTermosPoliticas.TabIndex = 7;
		chkTermosPoliticas.Text = "Aceito todos os Termos e Politicas do programa";
		chkTermosPoliticas.UseVisualStyleBackColor = true;
		chkTermosPoliticas.CheckedChanged += chkTermosPoliticas_CheckedChanged;
		// 
		// lblTermosPoliticas
		// 
		lblTermosPoliticas.AutoSize = true;
		lblTermosPoliticas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		lblTermosPoliticas.Location = new Point(12, 242);
		lblTermosPoliticas.Name = "lblTermosPoliticas";
		lblTermosPoliticas.Size = new Size(132, 21);
		lblTermosPoliticas.TabIndex = 8;
		lblTermosPoliticas.Text = "Termos e Politicas";
		// 
		// bntCadastrar
		// 
		bntCadastrar.AutoSize = true;
		bntCadastrar.Enabled = false;
		bntCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
		bntCadastrar.Location = new Point(12, 315);
		bntCadastrar.Name = "bntCadastrar";
		bntCadastrar.Size = new Size(92, 31);
		bntCadastrar.TabIndex = 9;
		bntCadastrar.Text = "Cadastrar";
		bntCadastrar.UseVisualStyleBackColor = true;
		bntCadastrar.Click += bntCadastrar_Click;
		// 
		// dgvCadastro
		// 
		dgvCadastro.AllowUserToAddRows = false;
		dgvCadastro.AllowUserToDeleteRows = false;
		dgvCadastro.AllowUserToResizeColumns = false;
		dgvCadastro.AllowUserToResizeRows = false;
		dgvCadastro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
		dgvCadastro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dgvCadastro.Enabled = false;
		dgvCadastro.Location = new Point(376, 12);
		dgvCadastro.Name = "dgvCadastro";
		dgvCadastro.Size = new Size(412, 426);
		dgvCadastro.TabIndex = 10;
		dgvCadastro.Text = "dataGridView1";
		// 
		// Form1
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(800, 450);
		Controls.Add(dgvCadastro);
		Controls.Add(bntCadastrar);
		Controls.Add(lblTermosPoliticas);
		Controls.Add(chkTermosPoliticas);
		Controls.Add(chkNoturno);
		Controls.Add(chkVespertino);
		Controls.Add(lblTurno);
		Controls.Add(chkMatutino);
		Controls.Add(cmbCidade);
		Controls.Add(lblCidade);
		Controls.Add(lblTitulo);
		Name = "Form1";
		Text = "Form1";
		((System.ComponentModel.ISupportInitialize)dgvCadastro).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}

	private System.Windows.Forms.DataGridView dgvCadastro;

    private System.Windows.Forms.CheckBox chkMatutino;

    private System.Windows.Forms.Button bntCadastrar;

    private System.Windows.Forms.CheckBox chkVespertino;
    private System.Windows.Forms.CheckBox chkNoturno;
    private System.Windows.Forms.Label lblTermosPoliticas;

    private System.Windows.Forms.CheckBox chkTermosPoliticas;
    private System.Windows.Forms.Label lblTurno;

    private System.Windows.Forms.ComboBox cmbCidade;

    private System.Windows.Forms.Label lblCidade;

    private System.Windows.Forms.Label lblTitulo;

    #endregion
}