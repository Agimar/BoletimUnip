using System;

	namespace BoletimFinal
	{
		public class Program
		{
			public static void Main()
			{
				int cadastro = 1;

				string[] nome = new string[cadastro];
				string[] cpf = new string[cadastro];
				int[] idade = new int[cadastro];
				string[] endereco = new string[cadastro];
				string[] curso = new string[cadastro];
				string[] turma = new string[cadastro];
				int[] serie = new int[cadastro];
				string[] unidade = new string[cadastro];
				string[] status = new string[cadastro];
				double[] np1 = new double[cadastro];
				double[] np2 = new double[cadastro];
				double[] pim = new double[cadastro];
				double[] exame = new double[cadastro];
				double[] media = new double[cadastro];

				for (int i = 0; i < nome.Length; i++)
				{
					Console.Write((i + 1) + "- Digite nome ");
					nome[i] = Console.ReadLine();
					Console.Write((i + 1) + "- Digite cpf ");
					cpf[i] = Console.ReadLine();
					Console.Write((i + 1) + "- Digite  idade ");
					idade[i] = Convert.ToInt16(Console.ReadLine());
					Console.Write((i + 1) + "- Digite endereço ");
					endereco[i] = Console.ReadLine();
					Console.Write((i + 1) + "- Digite curso ");
					curso[i] = Console.ReadLine();
					Console.Write((i + 1) + "- Digite turma ");
					turma[i] = Console.ReadLine();
					Console.Write((i + 1) + "- Digite serie ");
					serie[i] = Convert.ToInt16(Console.ReadLine());
					Console.Write((i + 1) + "- Digite unidade ");
					unidade[i] = Console.ReadLine();
					Console.Write((i + 1) + "- Digite status ");
					status[i] = Console.ReadLine();
				}

				LimpaTela();

				int w = 0;
				while (w < nome.Length)
				{
					Console.WriteLine("====================\n");
					Console.WriteLine("Nome: " + nome[w].ToUpper());
					Console.WriteLine("Cpf: " + cpf[w]);
					Console.WriteLine("Idade: " + idade[w] + " anos");
					Console.WriteLine("Endereço: " + endereco[w].ToUpper());
					Console.WriteLine("Curso: " + curso[w].ToUpper());
					Console.WriteLine("Turma: " + turma[w].ToUpper());
					Console.WriteLine("Serie: " + serie[w] + "ª");
					Console.WriteLine("Unidade: " + unidade[w].ToUpper());
					Console.WriteLine("Status: " + status[w].ToUpper());
					w++;
				}

				string faixa = "";

				for (int y = 0; y < idade.Length; y++)
				{
					if (idade[y] <= 12)
					{
						faixa = "CRIANÇA";
					} else if ((idade[y] > 12) && (idade[y] <= 18)) {
						faixa = "ADOLESCENTE";
					} else if ((idade[y] > 18) && (idade[y] <= 29)) {
						faixa = "JOVEM";
					} else if ((idade[y] > 29) && (idade[y] <= 59)) {
						faixa = "ADULTO";
					} else {
						faixa = "IDOSO";
					}
				}

				Console.WriteLine("--------------------");
				Console.WriteLine(faixa);
				Console.WriteLine("====================\n");

				//np1 + np2 = 80%
				//pim = 20%

				string situacao, aluno;

				for (int n = 0; n < cadastro; n++)
				{
					Console.Write((n + 1) + "- Digite Np1: ");
					np1[n] = Convert.ToDouble(Console.ReadLine());
					Console.Write((n + 1) + "- Digite Np2: ");
					np2[n] = Convert.ToDouble(Console.ReadLine());
					Console.Write((n + 1) + "- Digite Pim: ");
					pim[n] = Convert.ToDouble(Console.ReadLine());

					media[n] = Math.Round((((np1[n] + np2[n]) * 0.8) / 2) + (pim[n] * 0.2), 2);

					if (media[n] >= 7)
					{
						situacao = "APROVADO";
						if (media[n] == 10)
						{
							situacao = "APROVADO COM LOUVOR";
						}
					} else {
						situacao = "REPROVADO";
					}

					Console.WriteLine("--------------------");
					Console.WriteLine("Média do aluno: " + media[n]);
					Console.WriteLine("Aluno: " + nome[n].ToUpper() + ", " + situacao);

					if (situacao == "REPROVADO")
					{
						Console.WriteLine("====================\n");
						Console.WriteLine("Aplicar exame para o aluno: " + nome[n].ToUpper());
						Console.Write((n + 1) + "- Digitar nota exame: ");
						exame[n] = Convert.ToDouble(Console.ReadLine());

						if (exame[n] < 5)
						{
							aluno = "REPROVADO EM EXAME";
						} else {
							aluno = "APROVADO EM EXAME";
						}

						Console.WriteLine("--------------------");
						Console.WriteLine("Nota de exame: " + exame[n]);
						Console.WriteLine("Aluno: " + nome[n].ToUpper() + ", " + aluno);
						Console.WriteLine("====================\n");
					}

				}

				static void LimpaTela()
				{
					Console.Clear();
				}

			}
		}
	}
