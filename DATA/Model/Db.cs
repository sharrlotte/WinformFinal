using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DATA.Model
{
    public partial class Db : DbContext
    {
        public Db()
            : base("name=Db")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookDetail> BookDetails { get; set; }
        public virtual DbSet<BookState> BookStates { get; set; }
        public virtual DbSet<BorrowTicket> BorrowTickets { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<ReturnTicket> ReturnTickets { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Storage> Storages { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.AccountId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Username)
                .IsFixedLength();

            modelBuilder.Entity<Account>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<Account>()
                .Property(e => e.RoleId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.BorrowTickets)
                .WithRequired(e => e.Account)
                .HasForeignKey(e => e.EmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.BorrowTickets1)
                .WithRequired(e => e.Account1)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.Logs)
                .WithRequired(e => e.Account)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.AuthorId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .HasMany(e => e.Books)
                .WithRequired(e => e.Author)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.BookId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Book>()
                .Property(e => e.Cover)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.CategoryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.AuthorId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.LanguageId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.BookDetails)
                .WithRequired(e => e.Book)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.BorrowTickets)
                .WithRequired(e => e.Book)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BookDetail>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BookDetail>()
                .Property(e => e.BookId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BookDetail>()
                .Property(e => e.StorageId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BookDetail>()
                .Property(e => e.StateId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BookState>()
                .Property(e => e.StateId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BookState>()
                .HasMany(e => e.BookDetails)
                .WithRequired(e => e.BookState)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BookState>()
                .HasMany(e => e.BorrowTickets)
                .WithRequired(e => e.BookState)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BookState>()
                .HasMany(e => e.ReturnTickets)
                .WithRequired(e => e.BookState)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BorrowTicket>()
                .Property(e => e.TicketId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BorrowTicket>()
                .Property(e => e.UserId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BorrowTicket>()
                .Property(e => e.EmployeeId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BorrowTicket>()
                .Property(e => e.BookId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BorrowTicket>()
                .Property(e => e.StateId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BorrowTicket>()
                .HasMany(e => e.ReturnTickets)
                .WithRequired(e => e.BorrowTicket)
                .HasForeignKey(e => e.BorrowTicketId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.CategoryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Books)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Language>()
                .Property(e => e.LanguageId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Language>()
                .HasMany(e => e.Books)
                .WithRequired(e => e.Language)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Log>()
                .Property(e => e.LogId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Log>()
                .Property(e => e.UserId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ReturnTicket>()
                .Property(e => e.TicketId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ReturnTicket>()
                .Property(e => e.BorrowTicketId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ReturnTicket>()
                .Property(e => e.StateId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ReturnTicket>()
                .Property(e => e.EmployeeId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.RoleId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Accounts)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Storage>()
                .Property(e => e.StorageId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Storage>()
                .HasMany(e => e.BookDetails)
                .WithRequired(e => e.Storage)
                .WillCascadeOnDelete(false);
        }
    }
}
