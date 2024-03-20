using ControleAcessso.API.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleAcesso.Infrastructure.Configurations
{
    public class GroupsReportsConfigurations : IEntityTypeConfiguration<GroupReport>
    {
        public void Configure(EntityTypeBuilder<GroupReport> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .HasOne(x => x.Group)
                .WithMany()
                .HasForeignKey(x => x.IdGroup);

            builder
                .HasOne(x => x.Relatorio)
                .WithMany()
                .HasForeignKey(x => x.IdRelatorio);
        }
    }
}
