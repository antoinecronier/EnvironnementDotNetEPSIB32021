using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1.Entities;
using TP1.Entities.Contracts;

namespace TP1.Data
{
    public class Tp1DbContext : DbContext
    {
        public DbSet<Buy> Buys { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookShop> BookShops { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Editor> Editors { get; set; }

        public Tp1DbContext()
        {
            if (this.Database.CreateIfNotExists())
            {
                Author author1 = new Author() { Firstname = "joh", Lastname = "clark" };
                Author author2 = new Author() { Firstname = "ziggy", Lastname = "metal" };
                this.Authors.Add(author1);
                this.Authors.Add(author2);

                Editor editor1 = new Editor() { Name = "Best editor ever" };
                this.Editors.Add(editor1);

                Customer customer1 = new Customer() { Firstname = "Jean", Lastname = "Dupont" };
                Customer customer2 = new Customer() { Firstname = "Ygor", Lastname = "Ramons" };
                this.Customers.Add(customer1);
                this.Customers.Add(customer2);

                BookShop bookShop1 = new BookShop() { Name = "L'entrepot" };
                BookShop bookShop2 = new BookShop() { Name = "Librairie de la rue" };
                this.BookShops.Add(bookShop1);
                this.BookShops.Add(bookShop2);

                this.SaveChanges();

                Book book1 = new Book();
                book1.Authors.Add(author1);
                book1.BookShops.Add(bookShop1);
                book1.Editor = editor1;
                book1.Name = "livre 1";
                book1.NbPage = 10;

                //author1.Books.Add(book1);
                //bookShop1.Books.Add(book1);
                //editor1.Books.Add(book1);

                Book book2 = new Book();
                book2.Authors.Add(author1);
                book2.BookShops.Add(bookShop1);
                book2.BookShops.Add(bookShop2);
                book2.Editor = editor1;
                book2.Name = "Livre rafiné";
                book2.NbPage = 420;

                //author1.Books.Add(book2);
                //bookShop1.Books.Add(book2);
                //bookShop2.Books.Add(book2);
                //editor1.Books.Add(book2);

                Book book3 = new Book();
                book3.Authors.Add(author1);
                book3.BookShops.Add(bookShop1);
                book3.BookShops.Add(bookShop2);
                book3.Editor = editor1;
                book3.Name = "Mémoire";
                book3.NbPage = 30;

                //author1.Books.Add(book3);
                //bookShop1.Books.Add(book3);
                //bookShop2.Books.Add(book3);
                //editor1.Books.Add(book3);

                Book book4 = new Book();
                book4.Authors.Add(author2);
                book4.BookShops.Add(bookShop2);
                book4.Editor = editor1;
                book4.Name = "Navigation à la voile";
                book4.NbPage = 65;

                //author2.Books.Add(book4);
                //bookShop2.Books.Add(book4);
                //editor1.Books.Add(book4);

                Book book5 = new Book();
                book5.Authors.Add(author2);
                book5.BookShops.Add(bookShop2);
                book5.Editor = editor1;
                book5.Name = "Circuit";
                book5.NbPage = 360;

                //author2.Books.Add(book5);
                //bookShop2.Books.Add(book5);
                //editor1.Books.Add(book5);

                Book book6 = new Book();
                book6.Authors.Add(author1);
                book6.BookShops.Add(bookShop2);
                book6.Editor = editor1;
                book6.Name = "Les croisades";
                book6.NbPage = 30600;

                //author1.Books.Add(book6);
                //bookShop2.Books.Add(book6);
                //editor1.Books.Add(book6);

                Book book7 = new Book();
                book7.Authors.Add(author1);
                book7.BookShops.Add(bookShop1);
                book7.Editor = editor1;
                book7.Name = "Fruits";
                book7.NbPage = 89;

                //author1.Books.Add(book7);
                //bookShop1.Books.Add(book7);
                //editor1.Books.Add(book7);

                Book book8 = new Book();
                book8.Authors.Add(author2);
                book8.BookShops.Add(bookShop1);
                book8.Editor = editor1;
                book8.Name = "Les tests";
                book8.NbPage = 1;

                //author2.Books.Add(book8);
                //bookShop1.Books.Add(book8);
                //editor1.Books.Add(book8);

                Book book9 = new Book();
                book9.Authors.Add(author2);
                book9.BookShops.Add(bookShop1);
                book9.Editor = editor1;
                book9.Name = "Essaie 1";
                book9.NbPage = 120;

                //author2.Books.Add(book9);
                //bookShop1.Books.Add(book9);
                //editor1.Books.Add(book9);

                Book book10 = new Book();
                book10.Authors.Add(author1);
                book10.Authors.Add(author2);
                book10.BookShops.Add(bookShop1);
                book10.BookShops.Add(bookShop2);
                book10.Editor = editor1;
                book10.Name = "200 page à voir";
                book10.NbPage = 200;

                //author1.Books.Add(book10);
                //author2.Books.Add(book10);
                //bookShop1.Books.Add(book10);
                //bookShop2.Books.Add(book10);
                //editor1.Books.Add(book10);

                this.Books.Add(book1);
                this.Books.Add(book2);
                this.Books.Add(book3);
                this.Books.Add(book4);
                this.Books.Add(book5);
                this.Books.Add(book6);
                this.Books.Add(book7);
                this.Books.Add(book8);
                this.Books.Add(book9);
                this.Books.Add(book10);

                this.SaveChanges();

                Buy buy1 = new Buy() { Book = book1, BookShop = bookShop1, Customer = customer1, Price = 20.36M };

                customer1.Books.Add(book1);

                Buy buy2 = new Buy() { Book = book1, BookShop = bookShop1, Customer = customer2, Price = 30 };
                Buy buy3 = new Buy() { Book = book2, BookShop = bookShop1, Customer = customer1, Price = 20.36M };
                Buy buy4 = new Buy() { Book = book3, BookShop = bookShop1, Customer = customer1, Price = 12.99M };
                Buy buy5 = new Buy() { Book = book3, BookShop = bookShop2, Customer = customer1, Price = 3.50M };

                this.Buys.Add(buy1);
                this.Buys.Add(buy2);
                this.Buys.Add(buy3);
                this.Buys.Add(buy4);
                this.Buys.Add(buy5);

                this.SaveChanges();
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasMany(x => x.Authors).WithMany(x => x.Books)
                .Map(x => 
                {
                    x.MapLeftKey(WriteContract.FK_COL_BOOK);
                    x.MapRightKey(WriteContract.FK_COL_AUTHOR);
                    x.ToTable(WriteContract.TABLE_NAME);
                });
            modelBuilder.Entity<Book>().HasMany(x => x.BookShops).WithMany(x => x.Books)
                .Map(x =>
                {
                    x.MapLeftKey(HaveContract.FK_COL_BOOK);
                    x.MapRightKey(HaveContract.FK_COL_BOOKSHOP);
                    x.ToTable(HaveContract.TABLE_NAME);
                });
            modelBuilder.Entity<Book>().HasRequired(x => x.Editor).WithMany(x => x.Books)
                .Map( x =>
                {
                    x.MapKey(BookContract.FK_COL_EDITOR);
                });

            modelBuilder.Entity<Buy>().HasRequired(x => x.Book).WithMany()
                .Map( x =>
                {
                    x.MapKey(BuyContract.FK_COL_BOOK);
                });
            modelBuilder.Entity<Buy>().HasRequired(x => x.BookShop).WithMany()
                .Map(x =>
                {
                    x.MapKey(BuyContract.FK_COL_BOOKSHOP);
                });
            modelBuilder.Entity<Buy>().HasRequired(x => x.Customer).WithMany()
                .Map(x =>
                {
                    x.MapKey(BuyContract.FK_COL_CUSTOMER);
                });
        }
    }
}
