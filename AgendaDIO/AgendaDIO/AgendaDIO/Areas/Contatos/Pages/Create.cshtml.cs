using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgendaDIO.Areas.Contatos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AgendaDIO.Areas.Contatos.Pages
{
    public class CreateModel : PageModel
    {
        public Contato Contato { get; set; }  
        public void OnGet()
        {
        }
    }
}
