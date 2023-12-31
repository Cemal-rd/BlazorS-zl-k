﻿using Blazorsozluk.Api.Models;
using Blazorsozluk.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazorsozluk.Infrastructure.Persistence.EntityConfigurations.EntryComment
{
    public class EntryCommentVoteEntityConfiguration:BaseEntityConfiguration<EntryCommentVote>

    {
        public override void Configure(EntityTypeBuilder<EntryCommentVote> builder)
        {
            base.Configure(builder);
            builder.ToTable("entrycommentvote", BlazorSozlukContext.DEFAULT_SCHEMA);
            builder.HasOne(i => i.EntryComment)
                .WithMany(i => i.EntryCommentVote)
                .HasForeignKey(i => i.EntryCommentId);
        }
    }
}
