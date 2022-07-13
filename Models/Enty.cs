using System.ComponentModel.DataAnnotations;

namespace WebCars.Models
{
    public class Enty
    {
        public int ID { get; set; }

        [Display(Name = "Бренд")]
        public virtual Guid? BrandId { get; set; }

        [Display(Name = "Бренд")]
        public virtual Brand? Brand { get; set; }

        [Display(Name = "Тип тормозов")]
        public Brake Brake { get; set; }

		[UIHint("RightRule")]        
        [Display(Name = "Праворульная")]
        public bool RightRule { get; set; }
    }

    public enum Brake
	{
		[Display(Name = "Без тормозов")]
        None,
        [Display(Name = "Барабанные")]
        Drum,
        [Display(Name = "Колодочные")]
        Pad,
	}
}
