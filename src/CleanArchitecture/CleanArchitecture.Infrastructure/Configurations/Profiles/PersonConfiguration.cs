using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CleanArchitecture.Domain;
using CleanArchitecture.Common;

namespace CleanArchitecture.Persistence
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable(nameof(Person));

            builder.HasKey(e => e.Id);

            builder.Property(e => e.FirstName).HasMaxLength(AppSettings.HAS_MAXLENGHT256);
            builder.Property(e => e.LastName).HasMaxLength(AppSettings.HAS_MAXLENGHT128);
            builder.Property(e => e.PersonType).HasMaxLength(AppSettings.HAS_MAXLENGHT48);

            builder.Property(e => e.ProfilePhoto).HasMaxLength(AppSettings.HAS_MAXLENGHT512);

            builder.Property(e => e.CreatedBy).HasMaxLength(AppSettings.HAS_MAXLENGHT128);
            builder.Property(e => e.UpdatedBy).HasMaxLength(AppSettings.HAS_MAXLENGHT128);
            builder.Property(e => e.DeActivatedBy).HasMaxLength(AppSettings.HAS_MAXLENGHT128);
            builder.Property(e => e.DeletedBy).HasMaxLength(AppSettings.HAS_MAXLENGHT128);
            builder.Property(e => e.Description).HasMaxLength(AppSettings.HAS_MAXLENGHT512);

            builder.Metadata
                .FindNavigation(nameof(Person.EmailAddresses))
                .SetPropertyAccessMode(PropertyAccessMode.Field);

            builder.Metadata
                .FindNavigation(nameof(Person.Phones))
                .SetPropertyAccessMode(PropertyAccessMode.Field);

            builder.Metadata
                .FindNavigation(nameof(Person.Addresses))
                .SetPropertyAccessMode(PropertyAccessMode.Field);

            builder.Property(e => e.PersonType).HasConversion<int>();
        }
    }
}