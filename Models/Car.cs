using System.ComponentModel.DataAnnotations;

namespace WebCars.Models
{
    public class Car : Enty                                                     
    {
        [Required(ErrorMessage ="Укажи название, дурачок!")]
        public string Title { get; set; } = string.Empty;

        [Display(Name = "Дата выпуска")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public string Genre { get; set; } = string.Empty;

		[DataType(DataType.Currency)]        
        public decimal Price { get; set; }
    }
}
