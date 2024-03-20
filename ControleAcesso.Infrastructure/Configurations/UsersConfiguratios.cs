using ControleAcessso.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleAcesso.Infrastructure.Configurations
{
    public class UsersConfiguratios : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .HasKey(x => x.Id);

            // Define a relação de chave estrangeira com a entidade Group
            builder.HasOne(x => x.Group)
               .WithMany()
               .HasForeignKey(x => x.IdGroup)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
