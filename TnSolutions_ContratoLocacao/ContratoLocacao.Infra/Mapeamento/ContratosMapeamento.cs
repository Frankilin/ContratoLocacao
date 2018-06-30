using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContratoLocacao.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace ContratoLocacao.Infra.Mapeamento
{
    class ContratosMapeamento : EntityTypeConfiguration<Contrato>
    {
        public ContratosMapeamento()
        {
            HasKey(c => c.IdContrato);

            Property(c => c.IdContrato)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.ValorLocacao)
                .IsRequired();

            Property(c => c.DataCadastro)
                .IsRequired();

            Property(c => c.DataLimitePagamento)
                .IsRequired()
                .HasMaxLength(2);

            Property(c => c.PrazoLocacao)
                .IsRequired()
                .HasMaxLength(4);

            Property(c => c.DataInicio)
                .IsRequired();

            Property(c => c.DataFim)
                .IsRequired();

            Property(c => c.ReajusteACada)
                .IsRequired()
                .HasMaxLength(2);

            Property(c => c.IdLocador)
                .IsRequired();

            Property(c => c.IdImovel)
                .IsRequired();


            Property(c => c.IdTipoGarantia)
                .IsRequired();

            #region Relacionamentos
                //Locador
                HasRequired(c => c.Locador)
                    .WithMany(l => l.Contratos)
                    .HasForeignKey(c => c.IdLocador);

                //Imovel
                HasRequired(c => c.Imovel)
                    .WithMany(i => i.Contrato)
                    .HasForeignKey(i => i.IdImovel);
            
                //Tipo Garantia
                HasRequired(c => c.TipoGarantia)
                    .WithMany(tg => tg.Contrato)
                    .HasForeignKey(c => c.IdTipoGarantia);
            #endregion

        }
    }
}
