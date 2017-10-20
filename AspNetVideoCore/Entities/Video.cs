using AspNetVideoCore.Models;
using System.ComponentModel.DataAnnotations;

namespace AspNetVideoCore.Entities
{
    public class Video
    {
        public int Id { get; set; }
        [Required, MinLength(3), MaxLength(80)]
        //[DataType(DataType.Password)]
        public string Title { get; set; }
        [Display(Name = "Film Genre")]
        public Genres Genre { get; set; }
    }
}
