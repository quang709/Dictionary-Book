using System;
using System.Collections.Generic;

namespace Dictionary_Book
{
    public class BookManagement
    {
        static void Main(string[] args)
        {
            Dictionary<string, Book> bookList = new Dictionary<string, Book>();
         //   Thêm phần tử vào Dictionary và kiểm tra kết quả với phương thức PrintValue(). Chạy chương trình và xem kết quả.

            bookList.Add("9780321344755", new Book { ISBN = "9780321344755", Name = "Don't Make Me Think (Beta)", Author = "Steve Krug" });
            bookList.Add("1491904909", new Book { ISBN = "1491904909", Name = "User Story Mapping", Author = "Jeff Patton" });
            bookList.Add("9780465050659", new Book { ISBN = "9780465050659", Name = "The Design of Everyday Things", Author = "Don Norman" });

            Console.WriteLine("Add books to Dictionary");
            PrintValue(bookList);
          //      Thay một phần tử với key chỉ định và kiểm tra kết quả với phương thức PrintValue().Chạy chương trình và xem kết quả.

bookList["9780321344755"] = new Book { ISBN = "9780321344755", Name = "Don't Make Me Think", Author = "Steve Krug" };

            Console.WriteLine("Edit book with ISBN");
            PrintValue(bookList);
          //  Tìm kiếm một phần tử trong Dictionary.Chạy chương trình và xem kết quả.

           Console.WriteLine("Search for a specific book with ISBN");
            if (bookList.ContainsKey("9780321344755") == false)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                Book book = bookList["9780321344755"];
                Console.WriteLine("Found this book: " + book.Name);
            }

        }




        public static void PrintValue(Dictionary<string, Book> books)
        {
            foreach (KeyValuePair<string, Book> kvp in books)
            {
                Book book = kvp.Value;

                Console.WriteLine("ISBN: " + book.ISBN + " - " +
                    book.Name + " - " + book.Author);
            }
            Console.WriteLine();
        }
    }
}
