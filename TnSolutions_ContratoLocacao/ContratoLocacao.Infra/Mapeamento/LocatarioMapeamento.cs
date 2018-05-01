using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using ContratoLocacao.Entidades;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContratoLocacao.Infra.Mapeamento
{
    class LocatarioMapeamento : EntityTypeConfiguration<Locatario>
    {
        public LocatarioMapeamento()
        {

            HasKey(l => l.IdLocatario);
            Property(l => l.IdLocatario)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(l => l.EnderecoLocatario)
                .IsRequired()
                .HasMaxLength(250);

            Property(l => l.RgLocatario)
               .IsRequired()
               .HasMaxLength(12);

            Property(l => l.CPFLocatario)
                .IsRequired()
                .HasMaxLength(14);

            Property(l => l.CNPJLocatario)
                .HasMaxLength(18)
                .IsOptional();

            Property(l => l.CelularLocatario)
                .IsRequired()
                .HasMaxLength(14);
            
            Property(l => l.Ativo)
                .IsRequired();

            Property(l => l.EmailLocatario)
                .IsOptional()
                .HasMaxLength(50);

            Property(l => l.DataInclusao)
                .IsRequired();

            Property(l => l.DataAlteracao)
                .IsOptional();

        }

    }
}
