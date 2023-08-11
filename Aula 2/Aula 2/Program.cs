using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aula_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Leitura e escritade arquivos
            string caminhoArquivo = "C:/Users/autologon.CSED/Documents/Visual Studio 2019/Aula 2/aula1Dados.csv"; //Caminho do Arqiuvo
            if (File.Exists(caminhoArquivo))
            {
                Stream file = File.Open(caminhoArquivo, FileMode.Open);
                StreamReader leitor = new StreamReader(file);
                string linha = leitor.ReadLine();

                while (linha != null)
                {
                    //Criar um produto por linha
                    //
                    List<Produto> produtos = new List<Produto>();
                    Console.WriteLine(linha);
                    linha = leitor.ReadLine();
                }
                leitor.Close();
                file.Close();


            }
            else
            {
                Console.WriteLine("Nenhum arquivo encontrado");
            }

            Console.ReadLine();
        }
    }
}
