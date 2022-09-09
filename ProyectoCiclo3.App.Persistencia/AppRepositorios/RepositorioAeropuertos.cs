using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioAeropuertos
    {
        List<Aeropuertos> aeropuertos;
 
    public RepositorioAeropuertos()
        {
            aeropuertos= new List<Aeropuertos>()
            {
                new Aeropuertos{id=1,nombre="El Dorado",ciudad= "Bogota",pais= "Colombia",coord_x= "4.457878",coord_y= "14.457878"},
                new Aeropuertos{id=2,nombre="La Nubia",ciudad= "Maniales",pais= "Colombia",coord_x= "16.487878",coord_y= "75.124554"},
                new Aeropuertos{id=3,nombre="JFK",ciudad= "New York",pais= "USA",coord_x= "24.45478",coord_y= "-85.25656"},
                new Aeropuertos{id=4,nombre="Leonardo Davinci",ciudad= "Roma",pais= "Italia",coord_x= "29.45478",coord_y= "-15.25656"}
            };
        }
 
        public IEnumerable<Aeropuertos> GetAll()
        {
            return aeropuertos;
        }
 
        public Aeropuertos GetWithId(int id){
            return aeropuertos.SingleOrDefault(a => a.id == id);
        }

        public Aeropuertos Update(Aeropuertos newAeropuerto){
            var aeropuerto = aeropuertos.SingleOrDefault(a => a.id == newAeropuerto.id);
            if(aeropuerto != null){
                aeropuerto.nombre = newAeropuerto.nombre;
                aeropuerto.ciudad = newAeropuerto.ciudad;
                aeropuerto.pais = newAeropuerto.pais;
                aeropuerto.coord_x = newAeropuerto.coord_x;
                aeropuerto.coord_y = newAeropuerto.coord_y;
            }
            return aeropuerto;
        }

    }
}
