using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using setours.jarvis.domain.entity.Contacts;
using System;

namespace setours.jarvis.infrastructure.persistence.Configurations.Contacts
{
    public class ContactDataConfiguration : IEntityTypeConfiguration<ContactDataEntity>
    {
        public void Configure(EntityTypeBuilder<ContactDataEntity> builder)
        {
            builder.ToTable("co_contact_data");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasAnnotation("Npgsql:ValueGenerationStrategy",
                    Npgsql.EntityFrameworkCore.PostgreSQL.Metadata.NpgsqlValueGenerationStrategy.SerialColumn)
                .ValueGeneratedOnAdd()
                .HasComment("Llave primaria de la tabla");

            builder.Property(x => x.ContactId)
                .HasColumnName("co_contact_id")
                .IsRequired()
                .HasComment("Llave foranea con la tabla co_contacts");

            builder.Property(x => x.ContactMediaId)
                .HasColumnName("co_media_id")
                .IsRequired()
                .HasComment("Llave foranea con la tabla co_medias");

            builder.Property(x => x.Value)
               .HasColumnName("value")
               .IsRequired()
               .HasComment("valor del datos ingresado");

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

            builder.HasOne(x => x.Contact)
                .WithMany(x => x.ContactDatas)
                .HasForeignKey(x => x.ContactId);

            builder.HasOne(x => x.ContactMedia)
                .WithMany(x => x.ContactDatas)
                .HasForeignKey(x => x.ContactMediaId);
        }
    }
}
