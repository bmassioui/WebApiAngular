public class PaymentDetails
{
    [Key]
    public int PaymentDetailId { get; set; }

    [Required] 
    public string CardOwnerName { get; set; }
    [Required]
    public string CardNumber { get; set; }
    public string ExperationDate { get; set; }
    public string SecurityCode { get; set; }
}