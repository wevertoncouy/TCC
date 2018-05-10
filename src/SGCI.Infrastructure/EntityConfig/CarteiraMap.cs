using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGCI.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGCI.Infrastructure.EntityConfig
{
    public class CarteiraMap : IEntityTypeConfiguration<Carteira>
    {
        public void Configure(EntityTypeBuilder<Carteira> builder)
        {

            builder.HasKey(c => c.CarteiraId);
            builder.HasOne(c => c.Conta)
                .WithMany(c => c.Carteiras)
                .HasForeignKey(c => c.ContaId)
                .HasPrincipalKey(c => c.ContaId);
                
            
            builder.Property(c => c.Descricao)
               .HasColumnType("varchar(230)")
                .IsRequired();

        }
    }
}
