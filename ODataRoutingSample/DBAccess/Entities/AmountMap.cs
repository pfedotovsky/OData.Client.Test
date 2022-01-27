
namespace ODataRoutingSample.DBAccess.Entities
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal sealed class AmountMap : IEntityTypeConfiguration<Amount>
    {
        public void Configure(EntityTypeBuilder<Amount> builder)
        {
            builder
                .ToTable("TransactionAmounts", "dbo");

            builder
                .HasKey(e => e.AmountId);

            builder
                .Property(e => e.AmountId)
                .HasColumnName("AmountId")
                .ValueGeneratedOnAdd();

            builder
                .Property(e => e.OrderId)
                .HasColumnName("OrderId")
                .IsRequired();

            builder
                .Property(e => e.AccountId)
                .IsRequired();

            builder
                .Property(e => e.TotalAmount)
                .HasColumnName("Amount")
                .HasPrecision(18, 8)
                .IsRequired();

            builder
                .Property(e => e.TaxAmount)
                .HasPrecision(18, 8)
                .IsRequired();
        }
    }
}
