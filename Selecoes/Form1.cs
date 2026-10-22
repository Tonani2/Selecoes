using System.ComponentModel;

namespace Selecoes;

public partial class Form1 : Form
{
    private List<string> ListaCidades = ["Vitória", "Vila Velha", "Serra", "Cariacica", "Viana", "Guarapari", "Fundão"];
    private BindingList<Cadastro> ListaCadastros = [];

    public Form1()
    {
        InitializeComponent();
        cmbCidade.DataSource = ListaCidades;
        dgvCadastro.DataSource = ListaCadastros;
        if (dgvCadastro.Columns.Contains("TurnosString"))
        {
            dgvCadastro.Columns["TurnosString"].HeaderText = "Turnos";
        }

        if (dgvCadastro.Columns.Contains("DataTermoAceito"))
        {
            dgvCadastro.Columns["DataTermoAceito"].HeaderText = "Termo Aceito";
        }

    }

    private void chkTermosPoliticas_CheckedChanged(object sender, EventArgs e)
    {
        bntCadastrar.Enabled = chkTermosPoliticas.Checked;

    }

    private void bntCadastrar_Click(object sender, EventArgs e)
    {
        if (!chkMatutino.Checked && !chkVespertino.Checked && !chkNoturno.Checked)
        {
            MessageBox.Show("Você precisa selecionar algum turno!", "Turnos não selecionados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!chkTermosPoliticas.Checked)
        {
            MessageBox.Show("Aceite os termos e políticas para continuar", "Termos e Políticas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var novoCadastro = new Cadastro();
        novoCadastro.Cidade = cmbCidade.Text;
        if(chkMatutino.Checked) novoCadastro.Turnos.Add("Matutino");
        if(chkVespertino.Checked) novoCadastro.Turnos.Add("Vespertino");
        if(chkNoturno.Checked) novoCadastro.Turnos.Add("Noturno");
        novoCadastro.DataTermoAceito = DateTime.Now;
        ListaCadastros.Add(novoCadastro);
    }
}

public class Cadastro
{
    public string Cidade { get; set; }
    public List<string> Turnos { get; set; } = [];
    public DateTime DataTermoAceito { get; set; }

    public string TurnosString 
    { 
        get 
        {
            return string.Join(", ", Turnos);
        }
    }
}
// Cidade
// Turnos
// DataAceite
