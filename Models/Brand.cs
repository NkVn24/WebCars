using System.ComponentModel.DataAnnotations;

namespace WebCars.Models
{
	public class Brand
	{
		[Key]
		public Guid Id { get; set; }

		[Required(ErrorMessage ="Укажите имя.")]
		[MaxLength(100)]
		public string Name { get; set; }

		public virtual ICollection<Car> Cars { get; set; }
	}
}
