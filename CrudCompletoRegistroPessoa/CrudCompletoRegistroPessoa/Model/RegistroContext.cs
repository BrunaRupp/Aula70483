namespace CrudCompletoRegistroPessoa.Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class RegistroContext : DbContext
    {
        // Your context has been configured to use a 'RegistroContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CrudCompletoRegistroPessoa.Model.RegistroContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'RegistroContext' 
        // connection string in the application configuration file.
        public RegistroContext()
            : base("name=RegistroContext")
        {
        }

      public virtual DbSet<Pessoa> Pessoas { get; set; }

    }

}