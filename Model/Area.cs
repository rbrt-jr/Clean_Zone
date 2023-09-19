using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Zone.Model;

internal class Area
{
    public List<Division> divisions = new();
    public string? Name { get; }

    public Area(string name)
    {
        Name = name;
    }

    public void Create_Division(Division division)
    {
        divisions.Add(division);
        Console.WriteLine("Divisão criada com sucesso!");
        //Thread.Sleep(2000);
        //Console.Clear();
    }

    public void Delete_Division(Division division)
    {
        divisions.Remove(division);
        Console.WriteLine("Divisão deletada com sucesso!");
        //Thread.Sleep(2000);
        //Console.Clear();
    }

    public void ShowAreasDetails()
    {
        Console.WriteLine($"- {Name}");
    }

}
