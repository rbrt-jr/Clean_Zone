
using Clean_Zone;
using Clean_Zone.Model;




Residence r4 = new();
Area a4 = new("Garagem");
Division d4 = new("Passagem secreta", 59, 4, 11);
r4.Create_Area(a4);
a4.Create_Division(d4);
r4.ShowDetails();

Residence r5 = new();
Area a5 = new("Piso 1");
Division d5 = new("Quarto", 60, 5, 13);
r5.Create_Area(a5);
a5.Create_Division(d5);
r5.ShowDetails();


