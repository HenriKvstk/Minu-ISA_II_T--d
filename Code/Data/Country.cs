using System.ComponentModel.DataAnnotations;

namespace Abc.Data;

public class Country
{
    public int Id { get; set; }

    [Required]
    [StringLength(60, MinimumLength = 3)]
    [RegularExpression(@"^[A-Z]+[a-zA-Z\s-]*$")]
    public string Name { get; set; }

    [Required]
    [StringLength(60, MinimumLength = 3)]
    [RegularExpression(@"^[A-Z]+[a-zA-Z\s-]*$")]
    public string Capital { get; set; }

    [Range(1, long.MaxValue)]
    public long Population { get; set; }

    [Required]
    [StringLength(20)]
    [RegularExpression(@"^[A-Z]+[a-zA-Z\s-]*$")]
    public string Continent { get; set; }

    [Required]
    public int CurrencyId { get; set; }

    public Currency Currency { get; set; }
}
