PersonasContext db = new();

//db.Personas.ToList().ForEach(Console.WriteLine);

var todas1 = from p in db.Personas select p;
todas1.ToList().ForEach(Console.WriteLine);

var todas2 = from p in db.Personas select new { p.Nombre, p.Apellido} ;
todas2.ToList().ForEach(x => Console.WriteLine($"{x.Nombre} {x.Apellido}"));

var nombresCompletos = from p 
                        in db.Personas 
                        where p.Edad > 18 
                        select p.NombreCompleto;
                        
nombresCompletos.ToList().ForEach(Console.WriteLine);



