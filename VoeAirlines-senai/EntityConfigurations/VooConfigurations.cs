using VoeAirlinesSenai.Contexts;
using VoeAirlinesSenai.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VoeAirlinesSenai.EntityConfigurations;

public class VooConfiguration : IEntityTypeConfiguration<Voo>
{
    public void Configure(EntityTypeBuilder<Voo> builder)
    {
        //Aqui se encontra o POLIMOFISMO REAL
        builder.ToTable("Voos");

        builder.HasKey(v => v.Id);

        builder.Property(v => v.Origem)
               .IsRequired()
               .HasMaxLength(3);

        builder.Property(v => v.Destino)
               .IsRequired()
               .HasMaxLength(3);

        builder.Property(v => v.DataHoraPartida)
               .IsRequired();

        builder.Property(v => v.DataHoraChegada)
               .IsRequired();

        builder.HasOne(v => v.Piloto)
               .WithMany(p => p.Voo)
               .HasForeignKey(v => v.PilotoId);

        builder.HasOne(v => v.Aeronave)
               .WithMany(a => a.Voo)
               .HasForeignKey(v => v.AeronaveId);

        builder.HasOne(v => v.Cancelamento)
               .WithOne(c => c.Voo)
               .HasForeignKey<Cancelamento>(c => c.VooId);
    }
}