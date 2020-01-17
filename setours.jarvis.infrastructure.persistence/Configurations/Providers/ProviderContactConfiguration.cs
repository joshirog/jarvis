using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using setours.jarvis.domain.entity.Providers;
using System;

namespace setours.jarvis.infrastructure.persistence.Configurations.Providers
{
    public class ProviderContactConfiguration : IEntityTypeConfiguration<ProviderContactEntity>
    {
        public void Configure(EntityTypeBuilder<ProviderContactEntity> builder)
        {
            builder.ToTable("pr_provider_contacts");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", Npgsql.EntityFrameworkCore.PostgreSQL.Metadata.NpgsqlValueGenerationStrategy.SerialColumn)
                .ValueGeneratedOnAdd()
                .HasComment("Llave primaria de la tabla");

            builder.Property(x => x.ProviderId)
                .HasColumnName("pr_provider_id")
                .IsRequired()
                .HasComment("Llave foranea con tabla pr_providers");

            builder.Property(x => x.ContactId)
                .HasColumnName("co_contact_id")
                .IsRequired()
                .HasComment("Llave foranea con tabla co_contacts");

            builder.Property(x => x.CreatedBy)
                .HasColumnName("created_by")
                .IsRequired()
                .HasMaxLength(50)
                .HasComment("Usuario que genero el registro");

            builder.Property(x => x.CreatedAt)
                .HasColumnName("created_at")
                .IsRequired()
                .HasDefaultValue(DateTime.Now)
                .HasComment("Fecha de generacion el registro");

            builder.Property(x => x.UpdatedBy)
                .HasColumnName("updated_by")
                .IsRequired(false)
                .HasMaxLength(50)
                .HasComment("Ultimo usuario que actualizo el registro");

            builder.Property(x => x.UpdatedAt)
                .HasColumnName("updated_at")
                .IsRequired(false)
                .HasComment("ultima fecha de actualizacion el registro");


            builder.HasOne(x => x.Provider)
                .WithMany(x => x.ProviderContacts)
                .HasForeignKey(x => x.ProviderId);

            builder.HasOne(x => x.Contanct)
                .WithMany(x => x.ProviderContacts)
                .HasForeignKey(x => x.ContactId);
        }
    }
}
