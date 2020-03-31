using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CleanArchitecture.Domain;
using CleanArchitecture.Common;

namespace CleanArchitecture.Persistence
{
    public class EmailAddressConfiguration : IEntityTypeConfiguration<EmailAddress>
    {
        public void Configure(EntityTypeBuilder<EmailAddress> builder)
        {
            builder.ToTable(nameof(EmailAddress));

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Email).IsRequired()
               .HasMaxLength(AppSettings.HAS_MAXLENGHT256).IsUnicode(false);

            builder.Property(e => e.CreatedBy).HasMaxLength(AppSettings.HAS_MAXLENGHT128);
            builder.Property(e => e.UpdatedBy).HasMaxLength(AppSettings.HAS_MAXLENGHT128);
            builder.Property(e => e.DeActivatedBy).HasMaxLength(AppSettings.HAS_MAXLENGHT128);
            builder.Property(e => e.DeletedBy).HasMaxLength(AppSettings.HAS_MAXLENGHT128);
            builder.Property(e => e.Description).HasMaxLength(AppSettings.HAS_MAXLENGHT512);

            builder.HasOne(e => e.Person)
                .WithMany(e => e.EmailAddresses)
                .HasForeignKey(e => e.PersonId);

            builder.Property(e => e.Status).HasConversion<int>();
        }
    }
}