using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CleanArchitecture.Domain;
using CleanArchitecture.Common;

namespace CleanArchitecture.Persistence
{
    public class PhoneConfiguration : IEntityTypeConfiguration<Phone>
    {
        public void Configure(EntityTypeBuilder<Phone> builder)
        {
            builder.ToTable(nameof(Phone));

            builder.HasKey(e => e.Id);

            builder.Property(e => e.PhoneNumber).IsRequired().HasMaxLength(AppSettings.HAS_MAXLENGHT128);
            builder.Property(e => e.PhoneExtension).HasMaxLength(AppSettings.HAS_MAXLENGHT12);

            builder.Property(e => e.CreatedBy).HasMaxLength(AppSettings.HAS_MAXLENGHT128);
            builder.Property(e => e.UpdatedBy).HasMaxLength(AppSettings.HAS_MAXLENGHT128);
            builder.Property(e => e.DeActivatedBy).HasMaxLength(AppSettings.HAS_MAXLENGHT128);
            builder.Property(e => e.DeletedBy).HasMaxLength(AppSettings.HAS_MAXLENGHT128);
            builder.Property(e => e.Description).HasMaxLength(AppSettings.HAS_MAXLENGHT512);

            builder.HasOne(e => e.Person)
                .WithMany(e => e.Phones)
                .HasForeignKey(e => e.PersonId);

            builder.Property(e => e.Status).HasConversion<int>();
            builder.Property(e => e.PhoneType).HasConversion<int>();
        }
    }
}