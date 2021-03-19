using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoMVC.Models;

namespace CursoMVC.Models
{
    public class Context : DbContext
    {
            public virtual DbSet<Categoria> Categorias { get; set; }
            public DbSet<Produto> Produtos { get; set; }
            public Context() { }

            public Context(DbContextOptions<Context> options) : base(options)
            { }

            public virtual void SetModified(object entity)
            {
                Entry(entity).State = EntityState.Modified;
            }
        }
    }
