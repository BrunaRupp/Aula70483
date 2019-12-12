namespace AplicacaoTelefone.Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CadastroContext : DbContext
    {
        // Your context has been configured to use a 'CadastroContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'AplicacaoTelefone.Model.CadastroContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CadastroContext' 
        // connection string in the application configuration file.
        public CadastroContext()
            : base("name=CadastroContext")
        {
        }

        public virtual DbSet<Telefone> Telefones { get; set; }
    }  
}