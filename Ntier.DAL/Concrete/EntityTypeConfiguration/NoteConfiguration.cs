using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ntier.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ntier.DAL.Concrete.EntityTypeConfiguration
{
    class NoteConfiguration : IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> builder)
        {
            builder.ToTable("Note");
            builder.HasKey(a => a.ID);
            builder.Property(a => a.ID).ValueGeneratedOnAdd();
            builder.Property(a => a.Description).HasMaxLength(250);
            builder.Property(a => a.WorkSubject).HasMaxLength(50).IsRequired();
        }
    }
}
