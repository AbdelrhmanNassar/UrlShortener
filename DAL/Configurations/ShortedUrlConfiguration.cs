using DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    internal class ShortedUrlConfiguration : IEntityTypeConfiguration<ShortedUrl>
    {
        public void Configure(EntityTypeBuilder<ShortedUrl> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x=>x.Id)
                //.UseIdentityColumn();
               .ValueGeneratedOnAdd();

            builder.Property(x => x.LongUrl)
                .HasColumnType("nvarchar")
                .HasMaxLength(300);  
            builder.Property(x => x.ShortUrl)
                .HasColumnType("nvarchar")
                .HasMaxLength(30);

            #region Don't forgert difference between them
            //builder.Property(x => x.CreatedAt)
            //  .HasComputedColumnSql("GetUtcDate()");

            builder.Property(x => x.CreatedAt)
               .HasDefaultValueSql("GetUtcDate()");
            #endregion

            builder.Property(x => x.ExpirationDate)
                .HasDefaultValueSql("GetUtcDate()")






        ;
        }
    }
}
