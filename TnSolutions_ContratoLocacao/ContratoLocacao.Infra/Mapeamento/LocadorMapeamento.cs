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
    class LocadorMapeamento : EntityTypeConfiguration<Locador>
    {
        public LocadorMapeamento()
        {
            HasKey(l => l.IdLocador);
            Property(l => l.IdLocador)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(l => l.NomeLocador)
                .IsRequired()
                .HasMaxLength(120)
                .HasColumnAnnotation(IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IDX_NOME_LOCADOR") { IsUnique = true }));

            Property(l => l.EnderecoLocador)
                .IsRequired()
                .HasMaxLength(250);

            Property(l => l.RgLocador)
               .IsRequired()
               .HasMaxLength(12);

            Property(l => l.CPFLocador)
                .IsRequired()
                .HasMaxLength(14);

            Property(l => l.CNPJLocador)
                .HasMaxLength(18);

            Property(l => l.CelularLocador)
                .IsRequired()
                .HasMaxLength(14);
                
            Property(l => l.TelFixoLocador)
                .IsRequired()
                .HasMaxLength(13);

            Property(l => l.Padrao)
                .IsRequired();

            //#region Relacionamento
            //    HasRequired(l => l.ImovelLocador)
            //       .WithMany(il => il.Locador)
            //       .HasForeignKey(i => i.IdLocador);
            //#endregion
        }
    }
}
