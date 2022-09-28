using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio;
using Microsoft.AspNetCore.Authorization;

namespace ProyectoCiclo3.App.Frontend.Pages
{   
    [Authorize]
    public class ListClientesModel : PageModel
    {
       
    private readonly RepositorioAeropuertos repositorioAeropuertos;
    public IEnumerable<Cliente> Aeropuertos {get;set;}
    [BindProperty]
    public Aeropuertos Aeropuerto {get;set;}

    public ListClientesModel(RepositorioAeropuertos repositorioAeropuertos)
    {
        this.repositorioAeropuertos=repositorioAeropuertos;
     }
 
    public void OnGet()
    {
       // Aeropuertos=repositorioAeropuertos.GetAll();
    }

    public IActionResult OnPost()
    {
        if(Aeropuerto.id>0)
        {
            repositorioAeropuertos.Delete(Aeropuerto.id);
        }
        return RedirectToPage("./List");
    }

    }
}
