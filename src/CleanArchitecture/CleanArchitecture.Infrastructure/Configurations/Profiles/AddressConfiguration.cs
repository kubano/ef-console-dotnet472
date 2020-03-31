using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CleanArchitecture.Domain;
using CleanArchitecture.Common;

namespace CleanArchitecture.Persistence
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable(nameof(Address));

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Address1).IsRequired().HasMaxLength(AppSettings.HAS_MAXLENGHT512);
            builder.Property(e => e.Address2).HasMaxLength(AppSettings.HAS_MAXLENGHT128);
            builder.Property(e => e.City).IsRequired().HasMaxLength(AppSettings.HAS_MAXLENGHT128);
            builder.Property(e => e.Coordinates).HasMaxLength(AppSettings.HAS_MAXLENGHT256);
            builder.Property(e => e.ZipCode4).HasMaxLength(AppSettings.HAS_MAXLENGHT5);
            builder.Property(e => e.ZipCode5).IsRequired().HasMaxLength(AppSettings.HAS_MAXLENGHT5);

            builder.Property(e => e.CreatedBy).HasMaxLength(AppSettings.HAS_MAXLENGHT128);
            builder.Property(e => e.UpdatedBy).HasMaxLength(AppSettings.HAS_MAXLENGHT128);
            builder.Property(e => e.DeActivatedBy).HasMaxLength(AppSettings.HAS_MAXLENGHT128);
            builder.Property(e => e.DeletedBy).HasMaxLength(AppSettings.HAS_MAXLENGHT128);
            builder.Property(e => e.Description).HasMaxLength(AppSettings.HAS_MAXLENGHT512);

            builder.HasOne(e => e.Person)
                .WithMany(e => e.Addresses)
                .HasForeignKey(e => e.PersonId);

            builder.Property(e => e.Status).HasConversion<int>();
            builder.Property(e => e.AddressType).HasConversion<int>();
        }
    }
}