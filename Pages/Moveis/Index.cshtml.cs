using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Prova2710.Data;
using Prova2710.Pages.Modus;

namespace Prova2710.Pages.Moveis
{
    public class IndexModel : PageModel
    {
        private readonly Prova2710.Data.Prova2710Context _context;

        public IndexModel(Prova2710.Data.Prova2710Context context)
        {
            _context = context;
        }

        public IList<Funcionario> Funcionario { get;set; }

        public async Task OnGetAsync()
        {
            Funcionario = await _context.Funcionario.ToListAsync();
        }
    }
}
