using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Shop.Models.Configuration
{
    public class HotelCommentConfiguration : IEntityTypeConfiguration<HotelComment>
    {
        public void Configure(EntityTypeBuilder<HotelComment> builder)
        {
            builder.HasOne(x => x.Hotels)
                .WithMany(m => m.HotelComments)
                .HasForeignKey(x => x.HotelsId);

            builder.HasOne(x => x.Comment)
                .WithMany(m => m.HotelComments)
                .HasForeignKey(x => x.CommentId);
        }
    }
}
