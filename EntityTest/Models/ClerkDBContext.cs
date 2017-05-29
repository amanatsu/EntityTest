namespace EntityTest.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.Common;

    public partial class ClerkDBContext : DbContext
    {
        public ClerkDBContext(DbConnection connection)
            : base(connection, true)
        {
        }

        public virtual DbSet<mClerks> mClerks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<mClerks>()
                .Property(e => e.scClerkCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mClerks>()
                .Property(e => e.sClerkPassword)
                .IsUnicode(false);

            modelBuilder.Entity<mClerks>()
                .Property(e => e.scHtlcod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mClerks>()
                .Property(e => e.sClerkName)
                .IsUnicode(false);

            modelBuilder.Entity<mClerks>()
                .Property(e => e.sDisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<mClerks>()
                .Property(e => e.scClerkMenuType)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
