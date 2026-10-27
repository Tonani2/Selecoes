namespace Selecoes;

public class Cadastro
{
	public string Cidade { get; set; } = string.Empty;
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