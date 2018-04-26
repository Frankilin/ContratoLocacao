using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContratoLocacao.Entidades;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContratoLocacao.Infra.Mapeamento
{
    class FiadorContratoMapeamento : EntityTypeConfiguration<FiadorContrato>
    {
        public FiadorContratoMapeamento()
        {

            HasKey(f => f.IdFiadorContrato);
            Property(f => f.IdFiadorContrato)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(f => f.IdFiador)
                .IsRequired();

            Property(f => f.IdContrato)
                .IsRequired();


            #region Relacionamento 
                HasRequired(fc => fc.Contratos)
                    .WithMany(c => c.FiadorContrato)
                    .HasForeignKey(f => f.IdContrato);

            HasRequired(fc => fc.Locatario)
                .WithMany(l => l.FiadorContrato)
                .HasForeignKey(fc => fc.IdLocatario);

            HasRequired(fc => fc.Fiador)
                   .WithMany(f => f.FiadorContrato)
                   .HasForeignKey(f => f.IdFiador);
            #endregion
        }
    }
}
