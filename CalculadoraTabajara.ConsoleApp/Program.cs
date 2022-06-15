using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTabajara.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            Notificador notificador = new Notificador();

            string[] historico = new string[10];

            int contHistorico = 0;

            while (true)
            {
                #region Menu Principal

                Console.Clear();

                Console.WriteLine("Calculadora Tabajara\n");

                Console.WriteLine("Tela Principal\n");

                Console.WriteLine("Digite 1 para realizar adição");
                Console.WriteLine("Digite 2 para realizar subtração");
                Console.WriteLine("Digite 3 para realizar multiplicação");
                Console.WriteLine("Digite 4 para realizar divisão\n");

                Console.WriteLine("Digite H para ver o histórico\n");

                Console.WriteLine("Digite S para sair\n");

                Console.Write("Opção: ");
                opcao = Console.ReadLine();

                //Validação opções menu
                if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao.ToLower() != "s" && opcao.ToLower() != "h")
                {
                    notificador.ApresentarMensagem("Escolha uma das opções do menu!", ConsoleColor.Red);
                    continue;
                }

                string operacao = "";

                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                    break;
                else if (opcao.Equals("1"))
                    operacao = "Adição";
                else if (opcao.Equals("2"))
                    operacao = "Subtração";
                else if (opcao.Equals("3"))
                    operacao = "Multiplicação";
                else if (opcao.Equals("4"))
                    operacao = "Divisão";

                else if (opcao.Equals("h", StringComparison.OrdinalIgnoreCase))
                {
                    foreach (string item in historico)
                    { Console.WriteLine(item); }
                    Console.ReadKey(); break;
                }

                #endregion

                #region Realizar Calculo

                Console.Clear();

                Console.WriteLine("Calculadora Tabajara\n");

                string subtitulo = $"Novo calculo de {operacao}";

                Console.WriteLine(subtitulo + "\n");

                Console.Write($"Digite o primeiro número: ");
                double primeiroNumero = Convert.ToDouble(Console.ReadLine());

                Console.Write($"Digite o segundo número: ");
                double segundoNumero = Convert.ToDouble(Console.ReadLine());

                double resultado = 0;

                //Validação divisão por zero
                if (opcao == "4" & segundoNumero == 0)
                {
                    notificador.ApresentarMensagem("Impossível dividir por zero", ConsoleColor.Red);
                    continue;
                }

                switch (opcao)
                {
                    case "1":
                        resultado = primeiroNumero + segundoNumero;
                        break;

                    case "2":
                        resultado = primeiroNumero - segundoNumero;
                        break;

                    case "3":
                        resultado = primeiroNumero * segundoNumero;
                        break;

                    case "4":
                        resultado = primeiroNumero / segundoNumero;
                        break;

                    default:
                        break;
                }
                #endregion

                #region Mostrar Resultado
                Console.Clear();

                Console.WriteLine("Calculadora Tabajara\n");

                Console.WriteLine("Tela de Resultados\n");

                Console.Write($"O resultado da operação de {operacao} é: {resultado}");

                historico[contHistorico] = operacao + " entre " + primeiroNumero + " e " + segundoNumero + " = " + resultado;
                contHistorico++;

                Console.WriteLine();

                Console.ReadLine();

                Console.Clear();
                #endregion
            }
        }
    }
}
/* 
 * ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠿⠿⠿⠿⠿⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
 * ⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⣉⡥⠶⢶⣿⣿⣿⣿⣷⣆⠉⠛⠿⣿⣿⣿⣿⣿⣿⣿
 * ⣿⣿⣿⣿⣿⣿⣿⡿⢡⡞⠁⠀⠀⠤⠈⠿⠿⠿⠿⣿⠀⢻⣦⡈⠻⣿⣿⣿⣿⣿
 * ⣿⣿⣿⣿⣿⣿⣿⡇⠘⡁⠀⢀⣀⣀⣀⣈⣁⣐⡒⠢⢤⡈⠛⢿⡄⠻⣿⣿⣿⣿
 * ⣿⣿⣿⣿⣿⣿⣿⡇⠀⢀⣼⣿⣿⣿⣿⣿⣿⣿⣿⣶⣄⠉⠐⠄⡈⢀⣿⣿⣿⣿
 * ⣿⣿⣿⣿⣿⣿⣿⠇⢠⣿⣿⣿⣿⡿⢿⣿⣿⣿⠁⢈⣿⡄⠀⢀⣀⠸⣿⣿⣿⣿
 * ⣿⣿⣿⣿⡿⠟⣡⣶⣶⣬⣭⣥⣴⠀⣾⣿⣿⣿⣶⣾⣿⣧⠀⣼⣿⣷⣌⡻⢿⣿
 * ⣿⣿⠟⣋⣴⣾⣿⣿⣿⣿⣿⣿⣿⡇⢿⣿⣿⣿⣿⣿⣿⡿⢸⣿⣿⣿⣿⣷⠄⢻
 * ⡏⠰⢾⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠟⢂⣭⣿⣿⣿⣿⣿⠇⠘⠛⠛⢉⣉⣠⣴⣾
 * ⣿⣷⣦⣬⣍⣉⣉⣛⣛⣉⠉⣤⣶⣾⣿⣿⣿⣿⣿⣿⡿⢰⣿⣿⣿⣿⣿⣿⣿⣿
 * ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⡘⣿⣿⣿⣿⣿⣿⣿⣿⡇⣼⣿⣿⣿⣿⣿⣿⣿⣿
 * ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣇⢸⣿⣿⣿⣿⣿⣿⣿⠁⣿⣿⣿⣿⣿⣿⣿⣿⣿
 */