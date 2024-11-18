using Microsoft.AspNetCore.Mvc.Rendering;

namespace NetCoreMVCLab03.Models
{
    public class Book
    {
        
            private readonly List<Book> books;

            public int Id { get; set; }
            public string Title { get; set; }
            public int AuthorId { get; set; }
            public int GenreID { get; set; }
            public String Image { get; set; }
            public float Price { get; set; }
            public int TotalPage { get; set; }
            public string Sumary { get; set; }
            // danh sách các cuốn sách (nhớ using System.collections.Generic)
            public List<Book> GetBookList()
            {
                new Book()
                {
                    Id = 1,
                    Title = "chí phèo",
                    AuthorId = 1,
                    GenreID = 1,
                    Image = "/images/Products/1.jpg",
                    Price = 500000,
                    Sumary = "",
                    TotalPage = 250


                };
                new Book()
                {
                    Id = 2,
                    Title = "chí phèo",
                    AuthorId = 1,
                    GenreID = 1,
                    Image = "/images/Products/2.jpg",
                    Price = 500000,
                    Sumary = "",
                    TotalPage = 250


                };
                new Book()
                {
                    Id = 3,
                    Title = "chí phèo",
                    AuthorId = 1,
                    GenreID = 1,
                    Image = "/images/Products/3.jpg",
                    Price = 500000,
                    Sumary = "",
                    TotalPage = 250


                };
                new Book()
                {
                    Id = 4,
                    Title = "chí phèo",
                    AuthorId = 1,
                    GenreID = 1,
                    Image = "/images/Products/4.jpg",
                    Price = 500000,
                    Sumary = "",
                    TotalPage = 250


                };

                return books;
            }
            //chi tiết một cuốn sách theo id (nhớ using System.linq)
            public Book GetBookById(int id)
            {
                Book book = this.GetBookList().FirstOrDefault(b => b.Id == id);
                return book;
            }
            public List<SelectListItem> Athors { get; } = new List<SelectListItem>
        {
            new SelectListItem{Value="1",Text="nam cao"},
            new SelectListItem{Value="2",Text="Ngô Tất Tố"},
            new SelectListItem{Value="3",Text="Adamkhom"},
            new SelectListItem{Value="4",Text="Thiền sư Thích Nhất Hạnh "}

        };
            public List<SelectListItem> Genders { get; } = new List<SelectListItem>
        {

            new SelectListItem{Value="1",Text="Truyện tranh "},
            new SelectListItem{Value="2",Text="Văn học đương đại"},
            new SelectListItem{Value="3",Text="Phật học phổ thông "},
            new SelectListItem{Value="4",Text="Truyện cười  "}
        };


     }
}

