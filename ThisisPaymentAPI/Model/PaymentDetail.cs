using System.ComponentModel.DataAnnotations;

namespace ThisisPaymentAPI.Model
{
    public class PaymentDetail
    {  
        [Key]
        public int PaymentDetailId { get; set; }
        public string PaymentDetailName { get; set; }
        public string CardNumber { get; set; }  
        public string SecurityCode { get; set; }
        public string ExpirationDate { get; set; }
    }
}
