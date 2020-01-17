using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using setours.jarvis.domain.entity.Contacts;
using System;

namespace setours.jarvis.infrastructure.persistence.Configurations.Contacts
{
    public class ContactDetailConfiguration : IEntityTypeConfiguration<ContactDetailEntity>
    {
        public void Configure(EntityTypeBuilder<ContactDetailEntity> builder)
        {
            builder.ToTable("co_contact_details");

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
                .HasMaxLength(150)
                .HasComment("Llave foranea con co_contacts");

            builder.Property(x => x.SegmentationId)
                .HasColumnName("name")
                .IsRequired()
                .HasMaxLength(150)
                .HasComment("Llave foranea con ge_segmentations");

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
        }
    }
}
