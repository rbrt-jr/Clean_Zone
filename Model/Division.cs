using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Zone;

internal class Division
{
    public string? Name { get; }

    public int CleanTime { get; }

    public int CleanInterval { get; }

    public int Id { get; }


    public Division(string name, int cleanTime, int cleanInternal, int id)
    {
        if (name.Length <= 10)
        {
            Name = name;
            CleanTime = cleanTime;
            CleanInterval = cleanInternal;
            Id = id;
        }
        else
        {
            Console.WriteLine("A quantidade total de caracteres para o nome deverá ser igual ou inferior a 10.\nVoltando ao menur Principal...\n");
            Thread.Sleep(2000);
            Console.Clear();
           // Console.ReadKey();

        }
        
    }

    //public void Status_Clear_Division(string nameDivision)
    //{
    //    if(nameDivision == null || Name != nameDivision) 
    //    {
    //        Console.WriteLine("Divisão não encontrada.");
    //        Thread.Sleep(2000);
    //        Console.Clear();
    //        // Console.ReadKey();
    //    }
    //    else
    //    {
    //        Console.WriteLine($"A divisão {Name} está a ser limpa...");
    //        Thread.Sleep(3000);
    //        Console.WriteLine("Limpeza concluída");
    //        isCleaned = true;
    //        //Console.Clear();
    //        // Console.ReadKey();
    //    }
    //}

    public void Status_Clear_Division()
    {
       if(CleanInterval < CleanInterval-1)
        {
            
        }
    }

   

    
}

