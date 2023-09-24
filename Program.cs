using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial5_Variables
{
    internal class Program
    {

        //variavel global vs local
        //scope 
        //static variable
       

        static void Main(string[] args)
        {
            //oque uma instancia de um objeto?

            //vamos prepara um cafe'
            //temos que ter:  colher, agua, cafe' moido, fogo, panela, coador, copo, opcional: acucar = 8 ingredientes

            Receita preparoDeCafe; //definir variavel para guardar uma receita
            Receita preparoOvoCozido;//definir variavel para guardar uma receita
            preparoDeCafe = new Receita();

            Console.ReadLine();

            preparoOvoCozido = new Receita("Ovo Cozido");
                         
            Console.ReadLine();

            Console.WriteLine("Nome da receita: " + preparoOvoCozido.nomeDaReceita);

            //assumir que usuario digitou 8 para fazer cafe'
            preparoDeCafe.Ingredientes = new string[8];
            preparoDeCafe.quantidateIngredientes = new int[8];
            preparoDeCafe.Ingredientes[0] = "colher";
            preparoDeCafe.quantidateIngredientes[0] = 1;
            preparoDeCafe.Ingredientes[1] = "agua em ml";
            preparoDeCafe.quantidateIngredientes[1] = 300;
            preparoDeCafe.Ingredientes[2] = "panela";
            preparoDeCafe.quantidateIngredientes[2] = 1;
            preparoDeCafe.nomeDaReceita = "Preparo do cafe";
            preparoDeCafe.tempoDePreparo = 5;

            
            

            //preparoDeCafe.Ingredientes = { "colher","agua"....}

            //a melhor solucao e' usar um loop...
            Console.ReadLine();
            Console.WriteLine("Imprimir a receita para fazer cafe");
            Receita.ImprimirReceita(preparoDeCafe);
            Console.ReadLine();

        }
 
    }
}
