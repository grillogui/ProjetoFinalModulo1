using System;
using ProjetoFinalRoupas.src;
using System.Collections.Generic;

namespace ProjetoFinalRoupas
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string oper;
            Estoque estoque = new Estoque();
            Console.WriteLine("Aperte a tecla 's' para ligar o sistema!");
            if (Console.ReadKey().Key == ConsoleKey.S)
            {
                while (Console.ReadKey().Key != ConsoleKey.S)
                {
                    Console.WriteLine("O que você deseja fazer no estoque?\n-Acrescentar(A)\n-Remover(R)");
                    if (Console.ReadKey().Key == ConsoleKey.A)
                    {
                        Console.WriteLine("\nO que você deseja acrescentar ao estoque?\n-Calca (cl)\n-Camisa (cs)\n-Vestido (vs)");
                        oper = Console.ReadLine();

                        switch (oper)
                        {
                            case "cl":

                                Roupa calca = LerProduto("Calca");
                                estoque.Adicionar(calca);

                                break;


                            case "cs":

                                Roupa camisa = LerProduto("Camisa");
                                estoque.Adicionar(camisa);
                                break;


                            case "vs":

                                Roupa vestido = LerProduto("Vestido");
                                estoque.Adicionar(vestido);
                                break;

                        }
                        Console.WriteLine("Aperte 'Enter' para continuar ou 's' para encerrar!");
                    }

                    else
                        Console.WriteLine("O que você deseja remover do estoque?\n-Calca (cl)\n-Camisa (cs)\n-Vestido (vs)");
                        oper = Console.ReadLine();

                        switch (oper)
                        {
                            case "cl":

                                Roupa calca = LerProduto("Calca");
                                estoque.Remover(calca);

                                break;


                            case "cs":

                                Roupa camisa = LerProduto("Camisa");
                                estoque.Remover(camisa);
                                break;


                            case "vs":

                                Roupa vestido = LerProduto("Vestido");
                                estoque.Remover(vestido);
                                break;
                        }

                        Console.WriteLine("Aperte 'Enter' para continuar ou 's' para encerrar!");
                }
            }

                

            foreach (Roupa roupa in estoque.Roupa)
            {
                Console.WriteLine($"\n\n\n\nPeça {roupa.Tipo}:\n  Tamanho: {roupa.Tamanho}\n  Cor: {roupa.Cor}\n  Marca: {roupa.Marca}\n  Preco: {roupa.Preco}\n  Quantidade: {roupa.Quantidade}");

            }
        }

        public static Roupa LerProduto(string tipo)
        {
            if (tipo == "Calca")
            {
                Roupa objCalca = new Calca();

                Console.WriteLine("Qual o tamanho da calça?");
                objCalca.Tamanho = Console.ReadLine();
                Console.WriteLine("Qual a cor da calça?");
                objCalca.Cor = Console.ReadLine();
                Console.WriteLine("Qual a marca da calça?");
                objCalca.Marca = Console.ReadLine();
                Console.WriteLine("Qual o preço da calça?");
                objCalca.Preco = double.Parse(Console.ReadLine());
                Console.WriteLine("Qual a quantidade da calça?");
                objCalca.Quantidade = Int32.Parse(Console.ReadLine());
                return objCalca;
            }
            else if (tipo == "Camisa")
            {
                Roupa objCamisa = new Camisa();

                Console.WriteLine("Qual o tamanho da camisa??");
                objCamisa.Tamanho = Console.ReadLine();
                Console.WriteLine("Qual a cor da camisa??");
                objCamisa.Cor = Console.ReadLine();
                Console.WriteLine("Qual a marca da camisa??");
                objCamisa.Marca = Console.ReadLine();
                Console.WriteLine("Qual o Preço da camisa??");
                objCamisa.Preco = double.Parse(Console.ReadLine());
                Console.WriteLine("Qual a quantidade da camisa?");
                objCamisa.Quantidade = Int32.Parse(Console.ReadLine());
                return objCamisa;
            }
            else if (tipo == "Vestido")
            {
                Roupa objVestido = new Vestido();

                Console.WriteLine("Qual o tamanho do vestido?");
                objVestido.Tamanho = Console.ReadLine();
                Console.WriteLine("Qual a cor do vestido?");
                objVestido.Cor = Console.ReadLine();
                Console.WriteLine("Qual a marca do vestido?");
                objVestido.Marca = Console.ReadLine();
                Console.WriteLine("Qual o preço do vestido?");
                objVestido.Preco = double.Parse(Console.ReadLine());
                Console.WriteLine("Qual a quantidade do vestido?");
                objVestido.Quantidade = Int32.Parse(Console.ReadLine());
                return objVestido;
            }
            return null;
        }
    }
}
