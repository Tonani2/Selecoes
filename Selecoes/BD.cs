using MySql.Data.MySqlClient;
using System.Text.Json;

namespace Selecoes;

internal class BD
{
	private static string StringConexao = Environment.GetEnvironmentVariable("MYSQL_URI")!;

	public static void InserirCadastro(Cadastro novoCadastro) 
	{
		try
		{
			var mysqlConexao = new MySqlConnection(StringConexao);
			mysqlConexao.Open();

			var sql = "INSERT INTO cadastros(cidade, turnos, data_termo_aceito) VALUES(@cidade, @turnos, @data_termo_aceito)";

			var mysqlComando = new MySqlCommand(sql, mysqlConexao);

			mysqlComando.Parameters.AddWithValue("@cidade", novoCadastro.Cidade);
			mysqlComando.Parameters.AddWithValue("@turnos", JsonSerializer.Serialize(novoCadastro.Turnos));
			mysqlComando.Parameters.AddWithValue("@data_termo_aceito", novoCadastro.DataTermoAceito);

			var LinhasAfetadas =  mysqlComando.ExecuteNonQuery();

			if(LinhasAfetadas > 0)
			{
				MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		catch
		{
			MessageBox.Show("Ocorreu um erro ao tentar inserir um novo cadastro.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}

	public static List<Cadastro> RecuperarCadastros()
	{
		try
		{
			var mysqlConexao = new MySqlConnection(StringConexao);
			mysqlConexao.Open();

			var sql = "SELECT * FROM cadastros";

			var mysqlComando = new MySqlCommand(sql, mysqlConexao);

			var leitor = mysqlComando.ExecuteReader();

			List<Cadastro> cadastrosExternos = [];

			while (leitor.Read()) // Executa o bloco de código repetidamente para cada linha (registro) retornada pela consulta ao banco de dados. O método Read() avança o cursor para o próximo registro e retorna 'true' se houver dados ou 'false' quando a leitura terminar.
			{
				var cadastroBanco = new Cadastro(); // Cria (instancia) um novo objeto limpo da classe 'Cadastro' a cada volta do loop, garantindo que os dados de uma linha não se misturem com os da linha anterior.

				cadastroBanco.Cidade = leitor["cidade"].ToString()!; // Acessa a coluna "cidade" da linha atual do banco, converte o valor bruto para texto plano (string) e atribui à propriedade 'Cidade' do objeto.


				cadastroBanco.Turnos = JsonSerializer.Deserialize<List<string>>(leitor["turnos"].ToString()!)!; // Pega a string em formato JSON armazenada na coluna "turnos" do banco e a desserializa(converte) em uma lista de strings real do C# (List<string>).	

				cadastroBanco.DataTermoAceito = Convert.ToDateTime(leitor["data_termo_aceito"]); // Pega o valor da coluna "data_termo_aceito" e faz a conversão explícita para o tipo de dado de data e hora (DateTime) do C#.

				cadastrosExternos.Add(cadastroBanco); // Adiciona o objeto 'cadastroBanco' preenchido à lista principal 'cadastrosExternos', salvando o registro atual para uso posterior no sistema.
			}

			return cadastrosExternos;
		}
		catch
		{
			MessageBox.Show("Não foi possível recuperar os cadastros salvos no banco de dados!", "Erro ao recuperar dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return [];
		}
	}

}
