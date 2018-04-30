using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using ContratoLocacao.Infra.Mapeamento;
using ContratoLocacao.Entidades;
using System.Configuration;

namespace ContratoLocacao.Infra.DataSource
{
    class Conexao : DbContext
    {
        public Conexao()
            : base(ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString)
        {
            this.Configuration.LazyLoadingEnabled = false;
            //Resolve o problema de formatação de caracters para o WEB API.    
            this.Configuration.ProxyCreationEnabled = false;
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new ContratosMapeamento());
            modelBuilder.Configurations.Add(new FiadorContratoMapeamento());
            modelBuilder.Configurations.Add(new FiadorMapeamento());
            modelBuilder.Configurations.Add(new ImovelMapeamento());
            modelBuilder.Configurations.Add(new LocadorMapeamento());
            modelBuilder.Configurations.Add(new LocatarioContratoMapeamento());
            modelBuilder.Configurations.Add(new LocatarioMapeamento());
            modelBuilder.Configurations.Add(new ImovelLocadorMapeamento());
        }

        public DbSet<Contratos> Contratos { get; set; }
        public DbSet<Fiador> Fiador { get; set; }
        public DbSet<FiadorContrato> FiadorContrato { get; set; }
        public DbSet<Imovel> Imovel { get; set; }
        public DbSet<Locador> Locador { get; set; }
        public DbSet<Locatario> Locatario { get; set; }
        public DbSet<LocatarioContrato> LocatarioContrato { get; set; }
        public DbSet<ImovelLocador> ImovelLocador { get; set; }
    }
}
