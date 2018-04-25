using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using ContratoLocacao.Entidades;
using System.Data.Entity.Infrastructure.Annotations;

namespace ContratoLocacao.Infra.Mapeamento
{
    class FiadorMapeamento : EntityTypeConfiguration<Fiador>
    {
        public FiadorMapeamento()
        {
            HasKey(f => f.IdFiador);
            Property(f => f.IdFiador)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(f => f.IdFiadorContrato)
                .IsRequired();

            Property(f => f.NomeFiador)
                .IsRequired()
                .HasMaxLength(120)
                 .HasColumnAnnotation(IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IDX_NOME_FIADOR") { IsUnique = true }));

            Property(f => f.RgFiador)
                .IsRequired()
                .HasMaxLength(12);

            Property(f => f.CPFfiador)
                .IsRequired()
                .HasMaxLength(14);

            Property(f => f.CNPJFiador)
                .HasMaxLength(18);

            Property(f => f.CelularFiador)
                .IsRequired()
                .HasMaxLength(14);

            Property(f => f.DataCadastro)
                .IsRequired();

            #region Relacionamento
            HasRequired(f => f.FiadorContrato)
                .WithMany(fc => fc.Fiador)
                .HasForeignKey(f => f.IdFiador);
            
            #endregion
        }
    }
}
