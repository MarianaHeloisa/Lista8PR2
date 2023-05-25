using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista8PR2
{
    internal class Program
    {
        public static void Exercico1()  {
            Console.WriteLine("aqui esta codificado o exercicio 1");
        } public static void Exercico2()  {
            Console.WriteLine("aqui esta codificado o exercicio 1");
        } public static void Exercico3()  {
            Console.WriteLine("aqui esta codificado o exercicio 1");
        } public static void Exercico4()  {
            Console.WriteLine("aqui esta codificado o exercicio 1");
        } public static void Exercico5()  {
            Console.WriteLine("aqui esta codificado o exercicio 1");
        } public static void Exercico6()  {
            Console.WriteLine("aqui esta codificado o exercicio 1");
        } public static void Exercico7()  {
            Console.WriteLine("aqui esta codificado o exercicio 1");
        }
        static void Main(string[] args)
        {

            int num, i;

            do
            {

                Console.WriteLine("Escolha um exercicio: ");

                Console.WriteLine("================MENU=================");
                Console.WriteLine(" Para sair - digite 0");
                Console.WriteLine(" Para executar exercicio 1 - digite 1");
                Console.WriteLine(" Para executar exercicio 2 - digite 2");
                Console.WriteLine(" Para executar exercicio 3 - digite 3");
                Console.WriteLine(" Para executar exercicio 4 - digite 4");
                Console.WriteLine(" Para executar exercicio 5 - digite 5");
                Console.WriteLine(" Para executar exercicio 6 - digite 6");
                Console.WriteLine(" Para executar exercicio 7 - digite 7");
                Console.WriteLine("=====================================");

                num = int.Parse(Console.ReadLine());

                switch (num)
                {
                    case 1:

                        float quantidade, preco, valortotal = 0, totalitens = 0;

                        quantidade = 1;

                        do

                        {
                            Console.WriteLine("Adicione um produto ao carrinho: ");
                            quantidade = float.Parse(Console.ReadLine());
                            if (quantidade == 0)
                            {
                                break;
                            }

                            Console.WriteLine("Adicione o preço do produto: ");
                            preco = float.Parse(Console.ReadLine());

                            if (quantidade > 0)
                            {
                                valortotal = valortotal + quantidade * preco;

                                totalitens += quantidade;

                            }
                            break;


                        } while (quantidade < 0);

                        Console.WriteLine("O valor final é: " + valortotal);
                        Console.WriteLine("A quantidade de itens é: " + totalitens);
                        Console.ReadKey();
                        break;


                    case 2:

                        string nomeproduto, nomeMenor = "", nomeMaior = "";
                        int numitens, parada = 2;
                        float valor, menorvalor, maiorvalor, total;

                        menorvalor = float.MaxValue;
                        maiorvalor = float.MinValue;


                        do
                        {

                            Console.WriteLine("Qual o nome do produto? ");
                            nomeproduto = Console.ReadLine();

                            Console.WriteLine("Qual o numero de itens? ");
                            numitens = int.Parse(Console.ReadLine());

                            Console.WriteLine("qual o valor da compra? ");
                            valor = float.Parse(Console.ReadLine());

                            total = numitens * valor;
                            if (total > maiorvalor)
                            {
                                maiorvalor = total;
                                nomeMaior = nomeproduto;

                            }
                            if (total < menorvalor)
                            {
                                menorvalor = total;
                                nomeMenor = nomeproduto;


                            }
                            Console.WriteLine("digite 1 para sair e 2 para continuar ");
                            parada = int.Parse(Console.ReadLine());


                        } while (parada != 1);

                        Console.WriteLine("Maior quantia investida {0} no produto {1} " + maiorvalor);
                        Console.WriteLine("Menor quantia investida {0} no produto {1}" + menorvalor);
                        Console.ReadKey();
                        break;


                    case 3:

                        float peso, pesototal = 0;

                        Console.WriteLine(" Digite o total de avaliaçoes:  ");
                        int Quantidadeavaliacao = int.Parse(Console.ReadLine());
                        pesototal = 0;

                        i = 1;

                        do
                        {
                            Console.WriteLine(" Digite os pesos das notas {i} ");
                            peso = float.Parse(Console.ReadLine());
                            pesototal += peso;
                            i++;
                        } while (i <= Quantidadeavaliacao);

                        Console.WriteLine("A soma dos pesos sao: " + pesototal);
                        if (pesototal > 100)

                            Console.WriteLine("Pesos insuficientes");


                        else if (pesototal > 100)

                            Console.WriteLine("Superior a 100% alcansada ");

                        else
                        {
                            Console.WriteLine("Porcentagem de 100% alcansada");
                        }



                        break;



                    case 4:

                        string ESTADO;

                        Console.WriteLine("======MENU======");
                        Console.WriteLine(" AC ");
                        Console.WriteLine(" AL ");
                        Console.WriteLine(" AP ");
                        Console.WriteLine(" AM ");
                        Console.WriteLine(" BA ");
                        Console.WriteLine(" CE ");
                        Console.WriteLine(" DF ");
                        Console.WriteLine(" ES ");
                        Console.WriteLine(" GO ");
                        Console.WriteLine(" MA ");
                        Console.WriteLine(" MT ");
                        Console.WriteLine(" MS ");
                        Console.WriteLine(" MG ");
                        Console.WriteLine(" PA ");
                        Console.WriteLine(" PB ");
                        Console.WriteLine(" PR ");
                        Console.WriteLine(" PE ");
                        Console.WriteLine(" PI ");
                        Console.WriteLine(" RJ ");
                        Console.WriteLine(" RN ");
                        Console.WriteLine(" RS ");
                        Console.WriteLine(" RO ");
                        Console.WriteLine(" RR ");
                        Console.WriteLine(" SC ");
                        Console.WriteLine(" SP ");
                        Console.WriteLine(" SE ");
                        Console.WriteLine(" TO ");
                        Console.WriteLine("===================");

                        Console.WriteLine(" Digite um número ");
                        ESTADO = (Console.ReadLine());

                        switch (ESTADO)

                        {
                            case "AC":
                                Console.WriteLine(" Acre ");
                                break;

                            case "AL":
                                Console.WriteLine(" Alagoas ");
                                break;

                            case "AP":
                                Console.WriteLine(" Amapá ");
                                break;

                            case "AM":
                                Console.WriteLine(" Amazonas ");
                                break;

                            case "BA":
                                Console.WriteLine(" Bahia ");
                                break;

                            case "CE":
                                Console.WriteLine(" Ceará ");
                                break;

                            case "DF":
                                Console.WriteLine(" Distrito Federal ");
                                break;

                            case "ES":
                                Console.WriteLine(" Espirito Santo ");
                                break;

                            case "GO":
                                Console.WriteLine(" Goais ");
                                break;

                            case "MA":
                                Console.WriteLine(" Maranhão ");
                                break;

                            case "MT":
                                Console.WriteLine(" Mato Grosso ");
                                break;

                            case "MS":
                                Console.WriteLine(" Mato Grosso do Sul ");
                                break;

                            case "MG":
                                Console.WriteLine(" Minas Gerais");
                                break;

                            case "PA":
                                Console.WriteLine(" Para ");
                                break;

                            case "PB":
                                Console.WriteLine(" Paraiba ");
                                break;

                            case "PR":
                                Console.WriteLine(" Parana ");
                                break;

                            case "PE":
                                Console.WriteLine(" Pernambuco ");
                                break;

                            case "PI":
                                Console.WriteLine(" Piuai");
                                break;

                            case "Rj":
                                Console.WriteLine(" Rio de Janeiro ");
                                break;

                            case "RN":
                                Console.WriteLine(" Rio Grande do Norte ");
                                break;

                            case "RS":
                                Console.WriteLine(" Rio Grande do Sul");
                                break;


                            case "RO":
                                Console.WriteLine(" Rondônia ");
                                break;

                            case "RR":
                                Console.WriteLine(" Roraima ");
                                break;

                            case "SC":
                                Console.WriteLine(" Santa Catarina ");
                                break;

                            case "SP":
                                Console.WriteLine(" Sao Paulo ");
                                break;

                            case "SE":
                                Console.WriteLine(" Sergipe ");
                                break;

                            case "TO":
                                Console.WriteLine(" Tocatins ");
                                break;

                            default:
                                Console.WriteLine(" Opcao Invalida! ");
                                break;
                        }
                        break;

                    case 5:

                        
                            int mes, dias;

                            Console.WriteLine("digite um numero entre 1 e 12: ");
                            mes = int.Parse(Console.ReadLine());

                            switch (mes)
                            {
                                case 1:

                                    Console.WriteLine("estaçao verao!");
                                    break;

                                case 2:

                                    Console.WriteLine("estaçao verao!");
                                    break;

                                case 3:

                                    Console.WriteLine("me informe o dia: ");
                                    dias = int.Parse(Console.ReadLine());

                                    if (dias >= 20)
                                        Console.WriteLine("a estaçao é outono");
                                    else
                                        Console.WriteLine("a estaçao é verao");
                                    break;

                                case 4:

                                    Console.WriteLine("a estaçao é outono");
                                    break; ;

                                case 5:

                                    Console.WriteLine("a estaçao é outono");
                                    break;

                                case 6:

                                    Console.WriteLine("me informe o dia: ");
                                    dias = int.Parse(Console.ReadLine());

                                    if (dias >= 20)
                                        Console.WriteLine("a estaçao é inverno");
                                    else
                                        Console.WriteLine("a estaçao é outono");
                                    break;

                                case 7:

                                    Console.WriteLine("a estaçao é inverno");
                                    break;

                                case 8:

                                    Console.WriteLine("a estaçao é inverno");
                                    break;

                                case 9:

                                    Console.WriteLine("me informe o dia: ");
                                    dias = int.Parse(Console.ReadLine());

                                    if (dias >= 22)
                                        Console.WriteLine(" a estaçao é primavera");
                                    else
                                        Console.WriteLine("a estaçao é inverno");
                                    break;

                                case 10:

                                    Console.WriteLine("a estaçao é primavera");
                                    break;

                                case 11:

                                    Console.WriteLine("a estaçao é primavera");
                                    break;

                                case 12:

                                    Console.WriteLine(" me informe o dia: ");
                                    dias = int.Parse(Console.ReadLine());

                                    if (dias >= 21)
                                        Console.WriteLine("a estaçao é verao");
                                    else
                                        Console.WriteLine(" a estaçao é primavera");
                                    break;


                            }
                        break;
                

                    case 6:

                        float PS, altura, imc;

                        Console.WriteLine("Digite seu peso:");
                        PS = float.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a sua altura:");
                        altura = float.Parse(Console.ReadLine());

                        imc = PS / (altura * altura);

                        if (imc < 18.5)
                            Console.WriteLine(" abaixo do peso ");

                        else if (imc == 18.5 && imc == 34.90)
                            Console.WriteLine("Peso normal");

                        else if (imc == 25.0 && imc == 29.9)
                            Console.WriteLine("Sobrepeso");

                        else if (imc == 30.0 && imc == 34.9)
                            Console.WriteLine("Obesidade grau 1");

                        else if (imc == 35.0 && imc == 39.9)
                            Console.WriteLine("Obesidade de grau 2");

                        else
                            Console.WriteLine("Obesidade de grau 3 (morbita) ");

                        break;

                    case 7:

                        int number;

                        Console.WriteLine("Digite um numero maior que zero:");
                        number = int.Parse(Console.ReadLine());

                        Console.WriteLine("Divisores de " + number + ":");

                        i = 1;
                        do
                        {
                            if (number % i == 0)
                            {
                                Console.WriteLine(i);
                                i++;
                            }
                        } while (i <= number);
                        break;


                    default:
                        Console.WriteLine("Opçao invalida");

                        break;
                }
            } while (num !=0 );
            Console.ReadKey();
       
        }
    }
}


