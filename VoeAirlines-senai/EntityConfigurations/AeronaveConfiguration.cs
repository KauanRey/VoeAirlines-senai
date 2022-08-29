using VoeAirlinesSenai.Contexts;
using VoeAirlinesSenai.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VoeAirlinesSenai.EntityConfigurations;

public class AeronaveConfiguration : IEntityTypeConfiguration<Aeronave>
{
    //FLUENT INTERFACE
    public void Configure(EntityTypeBuilder<Aeronave> builder)
    {
       //Nome da Tabela
        builder.ToTable("Aeronaves");

       //Chave primária
        builder.HasKey(a => a.Id);

       //Propriedade Fabricante
        builder.Property(a => a.Fabricante)
               .IsRequired()
               .HasMaxLength(50);

       //Propriedade Modelo
        builder.Property(a => a.Modelo)
               .IsRequired()
               .HasMaxLength(50);

       //Propriedade Codigo
        builder.Property(a => a.Codigo)
               .IsRequired()
               .HasMaxLength(10);

       //Propriedade Celebridade 
        builder.Property(a => a.Celebridade)
              .IsRequired()
              .HasMaxLength(80);
              
        //Agora é Sério ---Chegou o Relacionamento      
        /*
        https://brasilescola.uol.com.br/matematica/conjunto.htm
        */
        //Many   One

        //Relacionamentos
        builder.HasMany(a => a.Manutencoes)
               .WithOne(m => m.Aeronave)
               .HasForeignKey(m => m.AeronaveId);
    }
}