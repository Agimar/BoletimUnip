using System;

	namespace BoletimFinal
	{
		public class Program
		{
			public static void Main()
			{
					string[] nome = new string[2];
					string[] ra = new string[2];
					string[] cpf = new string[2];
					int[] idade = new int[2];
					string[] endereco = new string[2];
					string[] curso = new string[2];
					string[] turma = new string[2];
					int[] serie = new int[2];
					string[] unidade = new string[2];
					string[] status = new string[2];
					double[] np1 = new double[2];
					double[] np2 = new double[2];
					double[] pim = new double[2];
					double[] exame = new double[2];
					double[] media = new double[2];
					double[] mediaExame = new double[2];

					for (int i = 0; i < nome.Length; i++)
					{
						Console.Write((i + 1) + "- DIGITE NOME: ");
						nome[i] = Console.ReadLine();
						Console.Write((i + 1) + "- DIGITE RA: ");
						ra[i] = Console.ReadLine();
						Console.Write((i + 1) + "- DIGITE CPF: ");
						cpf[i] = Console.ReadLine();
						Console.Write((i + 1) + "- DIGITE  IDADE: ");
						idade[i] = Convert.ToInt16(Console.ReadLine());
						Console.Write((i + 1) + "- DIGITE ENDEREÇO: ");
						endereco[i] = Console.ReadLine();
						Console.Write((i + 1) + "- DIGITE CURSO: ");
						curso[i] = Console.ReadLine();
						Console.Write((i + 1) + "- DIGITE TURMA: ");
						turma[i] = Console.ReadLine();
						Console.Write((i + 1) + "- DIGITE SERIE: ");
						serie[i] = Convert.ToInt16(Console.ReadLine());
						Console.Write((i + 1) + "- DIGITE UNIDADE: ");
						unidade[i] = Console.ReadLine();
						Console.Write((i + 1) + "- DIGITE STATUS: ");
						status[i] = Console.ReadLine();
					}		

					string faixa = "";
					string aluno;

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

					//np1 + np2 = 80%
					//pim = 20%

					for (int n = 0; n < nome.Length; n++)
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
							aluno = "APROVADO";
							if (media[n] == 10)
							{
								aluno = "APROVADO COM LOUVOR";
							}
						} else {
							aluno = "REPROVADO";
						}

						if (aluno == "REPROVADO")
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

							mediaExame[n] = (media[n] + exame[n]) / 2;

						int w = 0;
						while (w < nome.Length)
						{
							Console.WriteLine("====================\n");
							Console.WriteLine("Nome: " + nome[w].ToUpper());
							Console.WriteLine("RA: " + ra[w].ToUpper());
							Console.WriteLine("Cpf: " + cpf[w]);
							Console.WriteLine("Idade: " + idade[w] + " anos");
							Console.WriteLine("Endereço: " + endereco[w].ToUpper());
							Console.WriteLine("--------------------");
							Console.WriteLine(faixa);
							Console.WriteLine("====================\n");
							Console.WriteLine("Curso: " + curso[w].ToUpper());
							Console.WriteLine("Turma: " + turma[w].ToUpper());
							Console.WriteLine("Serie: " + serie[w] + "ª");
							Console.WriteLine("Unidade: " + unidade[w].ToUpper());
							Console.WriteLine("Status: " + status[w].ToUpper());
							Console.WriteLine("\n--------------------");
							Console.WriteLine("Média do aluno: " + media[n]);
							Console.WriteLine("Aluno: " + nome[n].ToUpper() + ", " + aluno);
							Console.WriteLine("--------------------");
							Console.WriteLine("Nota de exame: " + exame[n]);
							Console.WriteLine("Aluno: " + nome[n].ToUpper() + ", " + aluno);
							Console.WriteLine("Média final do Aluno: " + nome[n].ToUpper() +", "+ mediaExame[n]);
							Console.WriteLine("====================\n");
							
							w++;
						}

					}

				}
			}
		}
	}
