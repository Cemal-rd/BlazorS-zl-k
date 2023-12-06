using Blazorsozluk.Api.Models;
using Blazorsozluk.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazorsozluk.Infrastructure.Persistence.EntityConfigurations.Entry
{
    public class EntryFavoriteEntityConfiguration: BaseEntityConfiguration<EntryFavorite>
    {
        public override void Configure(EntityTypeBuilder<EntryFavorite> builder)
        {
            base.Configure(builder);
            builder.ToTable("entryfavorite", BlazorSozlukContext.DEFAULT_SCHEMA);
            builder.HasOne(i => i.Entry)
                .WithMany(i => i.EntryFavorite)
                .HasForeignKey(i => i.EntryId);
            builder.HasOne(i => i.CreatedUser)
                .WithMany(i => i.EntryFavorites)
                .HasForeignKey(i => i.CreatedById)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
