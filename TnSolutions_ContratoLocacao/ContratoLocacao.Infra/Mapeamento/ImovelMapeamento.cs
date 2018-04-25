﻿using System;
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
    class ImovelMapeamento : EntityTypeConfiguration<Imovel>
    {
        public ImovelMapeamento()
        {
            HasKey(i => i.IdImovel);
            Property(i => i.IdImovel)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(i => i.NomeImovel)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnAnnotation(IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IDX_NOME_IMOVEL") { IsUnique = true }));

            Property(i => i.Endereco)
                .IsRequired()
                .HasMaxLength(200);

            Property(i => i.Complemento)
                .IsRequired()
                .HasMaxLength(70);

            Property(i => i.Numero)
                .IsRequired()
                .HasMaxLength(5);

            Property(i => i.Bairro)
                .IsRequired()
                .HasMaxLength(20);

            Property(i => i.Estado)
                .IsRequired()
                .HasMaxLength(30);

            Property(i => i.Cidade)
                .IsRequired()
                .HasMaxLength(18);

            Property(i => i.Cep)
                .IsRequired()
                .HasMaxLength(10);

            Property(i => i.Ativo)
                .IsRequired();



        }
    }
}
