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
    public class EntryEntityConfiguration:BaseEntityConfiguration<Api.Models.Entry>
    {
        public override void Configure(EntityTypeBuilder<Api.Models.Entry> builder)
        {
            base.Configure(builder);
            builder.ToTable("entryvote", BlazorSozlukContext.DEFAULT_SCHEMA);
            builder.HasOne(i => i.CreatedBy)
                .WithMany(i => i.Entries)
                .HasForeignKey(i => i.CreatedById);
        }
    }
}
