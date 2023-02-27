using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RequisiteService.Domain;

namespace RequisiteService.persistance
{
    public class Config : IEntityTypeConfiguration<Requisite>
    {
        public void Configure(EntityTypeBuilder<Requisite> builder)
        {
            builder.HasIndex(w => w.id).IsUnique();
            builder.HasKey(w => w.id);

        }
    }
}
