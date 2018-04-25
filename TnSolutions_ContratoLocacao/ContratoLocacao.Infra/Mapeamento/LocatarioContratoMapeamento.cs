using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContratoLocacao.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;


namespace ContratoLocacao.Infra.Mapeamento
{
    class LocatarioContratoMapeamento : EntityTypeConfiguration<LocatarioContrato>
    {
        public LocatarioContratoMapeamento()
        {
            HasKey(l => l.IdLocatarioContrato);

            Property(l => l.IdLocatarioContrato)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //Locatario
            Property(l => l.IdLocatario)
                .IsRequired();

            //Contrato
            Property(l => l.IdContrato)
                .IsRequired();

            #region Relacionamento
                HasRequired(l => l.Contratos)
                    .WithMany(c => c.LocatarioContrato)
                    .HasForeignKey(l => l.IdContrato);
            
            #endregion


        }
    }
}
