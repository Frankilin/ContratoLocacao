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
    class TipoGarantiaMapeamento : EntityTypeConfiguration<TipoGarantia>
    {
        public TipoGarantiaMapeamento()
        {
            HasKey(t => t.IdTipoGarantia);
            Property(t => t.IdTipoGarantia)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(t => t.Descricao)
                .HasMaxLength(30);
        }
    }
}
