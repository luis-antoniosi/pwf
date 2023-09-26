using Microsoft.EntityFrameworkCore;
using PWFilmes.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWFilmes.API.Context
{
    public class PWFilmesContext: DbContext
    {
        public DbSet<Categoria> CategoriaSet { get; set; }
    }
}
