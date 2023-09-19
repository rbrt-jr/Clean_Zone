using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace Clean_Zone.Model;

internal class Residence
{
    public List<User> users = new();

    public List<Area> areas = new();

    public List<Division> divisions = new();

    public Residence() { }

    public Residence(Area generalArea)
    {
        areas.Add(generalArea);
    }

    public void Create_Area(Area generalArea)
    {
        areas.Add(generalArea);
        Console.WriteLine("Área criada com sucesso!");
        //Thread.Sleep(2000);
        //Console.Clear();
    }

    public void Delete_Area(Area generalArea)
    {
        areas.Remove(generalArea);
        Console.WriteLine("Área deletada com sucesso!");
        //Thread.Sleep(2000);
        //Console.Clear();
    }

    //public  void Edit_Area(GeneralArea current_name, [Optional] GeneralArea new_name)
    //{
    //    if(Find_Area(current_name))
    //    {
    //        Console.Write($"{current_name} encontrado(a). Poderá fazer a sua edição");
    //        generalAreas.Remove(current_name);
    //        Console.Write("Digite o novo nome pretnedido: ");
    //        generalAreas.Add(new_name);
    //    }
    //    else
    //    {
    //        Console.WriteLine($"{current_name} não foi encontrado.");
    //    }

    //}

    //private bool Find_Area(GeneralArea area_name)
    //{
    //    if (generalAreas.Contains(area_name))
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;   
    //    }
    //}

    public void ShowDetails(DateTime anyDate)
    {
        DateTime now = DateTime.Now;
        string dateTodayComplete = now.ToString("(dd/MM/yyyy)");
        Console.WriteLine($"Home {dateTodayComplete}");
        

        foreach (var item1 in areas)
        {
            Console.WriteLine($"\t- {item1.Name}");     
           

            foreach (var item2 in item1.divisions)
            {
                TimeSpan difenrence = TimeSpan.FromDays(item2.CleanInterval);
                DateTime status = anyDate - difenrence;
                if (status <)
                {

                }
                Console.WriteLine($"\t\t- {item2.Id}  {item2.Name} {}");
            }
        }

    }
}
