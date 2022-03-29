using System.ComponentModel.DataAnnotations;

namespace ThisisPaymentAPI.Model
{
    public class CustomerDetail
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string DOB { get; set; }
    }
}
