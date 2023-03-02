using System;

namespace Calculator
{
    internal class Program
    {
        enum OperacaoDescricao {Soma, Divisao, Subtracao, Multiplicacao, Invalido};
        static void Main(string[] args)
        {
            OperacaoDescricao Descricao = OperacaoDescricao.Soma;
            double Valor1 = 0;
            double Valor2 = 0;
            double result = 0;
                
            Show("Primeiro Valor: ");
            Valor1 = LeiaDouble(Valor1);

            Show("Informe o Operador numerico: ");
            string Operador = Console.ReadLine();

            Show("Segundo Valor: ");
            Valor2 = LeiaDouble(Valor2);

            switch (Operador){
                case "+":
                    result = Soma(Valor1, Valor2);
                    Descricao = OperacaoDescricao.Soma;
                    break;
                case "-":
                    result = Subtracao(Valor1, Valor2);
                    Descricao = OperacaoDescricao.Subtracao;
                    break;
                case "*":
                    result = Multiplicacao(Valor1, Valor2);
                    Descricao = OperacaoDescricao.Multiplicacao;
                    break;
                case "/":
                    result = Divisao(Valor1, Valor2);
                    Descricao = OperacaoDescricao.Divisao;
                    break;
                default:
                    Descricao = OperacaoDescricao.Invalido;
                    break;
            }
            if(Descricao != OperacaoDescricao.Invalido){
                Console.WriteLine($"Valor total da {Descricao}: {Valor1} {Operador} {Valor2} = {result}");
            }else{
                Show("Operador numerico invalido.");
            }
        }
        
        public static double Soma(double valor1, double valor2){
                var result = valor1 + valor2;
                return result;
        }
        
        public static double Subtracao(double valor1, double valor2){
                var result = valor1 - valor2;
                return result;
        }

        public static double Divisao(double valor1, double valor2){
                var result = valor1 / valor2;
                return result;
        }

        public static double Multiplicacao(double valor1, double valor2){
                var result = valor1 * valor2;
                return result;
        }
        public static double LeiaDouble(double value){
            value = double.Parse(Console.ReadLine());
            return value;
        }
        public static void Show(string message){
            Console.WriteLine(message);
        }
    }
}