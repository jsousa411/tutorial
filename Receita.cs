using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial5_Variables
{
    /// <summary>
    /// Classe para receitas:
    ///receita de bolo ou comida em geral
    ///ingredientes:  nome, quantidade, estadoFisico
    ///instrucoes = como fazer ou como misturar
    ///tempo de preparo os condimentos
    ///tempo de cozinhar para poder servir
    ///ambiente: no fogo, no forno, na geladeira
    ///precisa de um cozinheiro = outra classe
    /// </summary>
    internal class Receita
    {
         
        public string nomeDaReceita; //variavel para guardar o nome da receita       
        public string[] Ingredientes;   //variavel para guardar o nome de cada ingrediente da receita     
        public int[] quantidateIngredientes;//variavel para guardar as quantidades dos ingredientes da receita
        public int tempoDePreparo;//variavel para guardar o tempo, em minutos, de preparo da receita
                           //constructor publico
        private int identidadeDaReceita;
        
        
        private static int ContagemDeReceitas;//manter contagem de quantas receitas total eu tenho



        /// <summary>
        /// Inicie uma receita nova
        /// </summary>

        //so' chamar esse constructor se contagendereceitas for = 0 ou menor que 1;
        public Receita()
        {
            ContagemDeReceitas = 1;
            Console.WriteLine("Criando uma instancia de Receita sem inicialisacao" + " agora temos " + ContagemDeReceitas + " receitas.");
            identidadeDaReceita = ContagemDeReceitas;
        }

        /// <summary>
        /// Inicie uma receita nova e indique o tempo total
        /// </summary>
        /// <param name="tempoTotal"> o tempo total para fazer a receita</param>
        public Receita(int tempoTotal)
        {
            ContagemDeReceitas = ContagemDeReceitas + 1;
            Console.WriteLine("iniciando receita com o tempo total: " + tempoTotal + " agora temos " + ContagemDeReceitas + " receitas.");
            tempoDePreparo = tempoTotal;
            nomeDaReceita = "ainda nao sei o nome da receita";
            identidadeDaReceita = ContagemDeReceitas;
        }

        /// <summary>
        /// Inicie uma receita nova e indique o nome da receita
        /// </summary>
        /// <param name="nomeDaNovaReceita">O nome da receita</param>
        public Receita(string nomeDaNovaReceita)
        {
            ContagemDeReceitas = ContagemDeReceitas + 1;//incrementar a contagem de receitas

            //indicar para usuraio que receita foi instanciada
            Console.WriteLine("iniciando receita com o nome: " + nomeDaNovaReceita+ " agora temos "+ ContagemDeReceitas+" receitas.");
            nomeDaReceita = nomeDaNovaReceita;//inicializar o nome da receita
            tempoDePreparo = -1;//ainda nao sei quanto tempo...
            identidadeDaReceita = ContagemDeReceitas;//incializar a identidade da receita
        }


        /// <summary>
        /// Imprimir a receita e seus conteudos
        /// </summary>
        /// <param name="receitaObj">a instancia da receita desejada a imprimir</param>
        public static void ImprimirReceita(Receita receitaObj)
        {
            int i = 0; //iterador de loop
            int totalIngredientes = receitaObj.quantidateIngredientes.Length;//numeros de items na receita para ser imprimida


            //imprimir o nome da receita
            Console.WriteLine("A receita desejada e: "+ receitaObj.nomeDaReceita+" e contem os items seguintes.");


            //imprimir todos itens da receita
            while(i < totalIngredientes)
            {
                //verificar que tem itens para mostrar... se ano sair do loop
                if(receitaObj.Ingredientes[i] == null)
                {
                    break;//sair do loop se o ingrediente estiver em branco
                }
                //imprimir item 
                Console.WriteLine("Item numero " + i + " " + receitaObj.Ingredientes[i]+ " " + receitaObj.quantidateIngredientes[i]);

                i++;//incrementar o iterador para imprimir o proximo item do array
            }

            //imprimir o tempo que leva para fazer essa receita
            Console.WriteLine("Essa receita leval "+receitaObj.tempoDePreparo+" minutos para fazer.");

            //imprimir total de receitas guardadas...
            Console.WriteLine("Atualmente temos: " + Receita.ContagemDeReceitas + " receitas no cardapio.");
        }//final de imprimirReceita()
        
        
        
       

    }//Final de classe Receita{}
}
