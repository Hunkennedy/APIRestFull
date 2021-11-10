using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialMedia.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Infrastucture.Data.Configurations
{
    class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.UserId);

            builder.ToTable("Usuario");

            builder.Property(e => e.UserId)
                .HasColumnName("IdUsuario")
                .ValueGeneratedNever();

            builder.Property(e => e.Name)
                .HasColumnName("Nombres")
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.LastName)
                .HasColumnName("Apellidos")
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(e => e.BornDate)
                .HasColumnName("FechaNacimiento")
                .HasColumnType("date");


            builder.Property(e => e.Telephone)
                .HasColumnName("Telefono")
                .HasMaxLength(10)
                .IsUnicode(false);

            builder.Property(e => e.Active)
                .HasColumnName("Activo");
        }
    }
}
