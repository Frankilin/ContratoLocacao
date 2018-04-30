using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContratoLocacao.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.Infrastructure.Annotations;

namespace ContratoLocacao.Infra.Mapeamento
{
    class ImovelLocadorMapeamento : EntityTypeConfiguration<ImovelLocador>
    {
        public ImovelLocadorMapeamento()
        {
            HasKey(il => il.IdImovelLocador);

            Property(il => il.IdImovelLocador)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(il => il.IdLocador)
                .IsRequired();

            Property(il => il.IdImovel)
                .IsRequired();

            #region Relacionamento
                HasRequired(il => il.Locador)
                   .WithMany(l => l.ImovelLocador)
                   .HasForeignKey(i => i.IdLocador);

                HasRequired(il => il.Imovel)
                       .WithMany(i => i.ImovelLocador)
                       .HasForeignKey(i => i.IdImovel);
            #endregion
        }

    }
}
