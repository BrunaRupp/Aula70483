namespace IniciandoBancoDeDados.Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class IniciandoContext : DbContext
    {
        // Your context has been configured to use a 'IniciandoContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'IniciandoBancoDeDados.Model.IniciandoContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'IniciandoContext' 
        // connection string in the application configuration file.
        public IniciandoContext()
            : base("name=IniciandoContext")
        {
        }

        public virtual DbSet<Bebida> Bebidas { get; set; }

    }
}