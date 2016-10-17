using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Entidades;
namespace DAL
{
    public class RegistrosClientesDb : DbContext
    {
        public RegistrosClientesDb() : base("name = ConStr")
        {

        }

        public virtual DbSet<Cliente> cliente { get; set; }
    }
}
