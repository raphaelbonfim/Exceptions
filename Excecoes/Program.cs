﻿namespace Excecoes;

class Program
{
    static void Main(string[] args)
    {
        var array = new int[3];

        //TRY & CATCH

        /* 
         - Pode se adicionar mais de 1 catch para um Try.
         - Pode se especificar o catch para excecao desejada.
         - Listar os catchs do mais específico para o mais genérico em casacata.
        */

        try
        {
            for (int i = 0; i < 10; i++)
            {
                // System.IndexOutOfRangeException = Tipo de Exceção
                Console.WriteLine(array[i]);
            }
        }
        //Passando o "ex", obtemos mais infos sobre as ex
        catch (IndexOutOfRangeException ex)
        {           
            Console.WriteLine (ex.Message);
            Console.WriteLine("Não encontrei o index na lista");
        }

        catch (Exception ex)
        {            
            Console.WriteLine(ex.Message);
            Console.WriteLine("Ops, algo deu errado :/ ...");
        }



    }
}