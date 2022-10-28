using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Введите название")]
        [Display(Name = "Название")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Введите количество")]
        [Display(Name = "Количество страниц")]
        public int PageNum { get; set; }
        [EnumDataType(typeof(Genre))]
        [Display(Name = "Жанр")]
        public Genre Genre { get; set; }
        [JsonIgnore]
        public Author? Author { get; set; }
    }

    public enum Genre
    {
        Драма = 1,
        Ужасы = 2,
        Триллер = 3,
        Биорграфия = 4,
        История = 5
    }
}
