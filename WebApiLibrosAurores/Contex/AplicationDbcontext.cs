using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiLibrosAurores.Entidades;

namespace WebApiLibrosAurores.Contex
{
    public class AplicationDbcontext : DbContext
    {
        public AplicationDbcontext( DbContextOptions options) : base(options)
        {
        }

        //Se va a crear una tabla a partir de las propiedades [Autor], osea ve a crear una tabla con los campos Id y Nombre 
        public DbSet<Autor> Autores { get; set; } 
    }
}
