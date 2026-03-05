using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Abc.Data;

public class Currency
{
    public int Id { get; set; }

    [Required]
    [StringLength(3, MinimumLength = 3)]
    [RegularExpression(@"^[A-Z]{3}$")]
    public string Code { get; set; }

    [Required]
    [StringLength(40, MinimumLength = 3)]
    [RegularExpression(@"^[A-Z]+[a-zA-Z\s-]*$")]
    public string Name { get; set; }

    [Required]
    [StringLength(5)]
    public string Symbol { get; set; }

    [Range(0.0, 10000.0)]
    [Column(TypeName = "decimal(18, 4)")]
    public decimal ExchangeRateToUSD { get; set; }
}
