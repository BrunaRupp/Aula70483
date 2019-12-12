namespace BancoDeDados.Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BancoContext : DbContext
    {
        // Your context has been configured to use a 'BancoContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'BancoDeDados.Model.BancoContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'BancoContext' 
        // connection string in the application configuration file.
        public BancoContext()
            : base("name=BancoContext1")
        {
        }
        public virtual DbSet<Pessoa> Pessoas { get; set; }

    }   
}