namespace WebCars.Models
{
    public class Enty
    {
        public int ID { get; set; }

        public virtual Guid? BrandId { get; set; }

        public virtual Brand? Brand { get; set; }
    }
}
