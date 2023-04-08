using System.ComponentModel.DataAnnotations;
namespace Shop.Domain.Enum
{
    public enum CategorySeason
    {
        [Display(Name = "Весна-Осінь")]
        SpringAutumn = 0,
        [Display(Name = "Зима")]
        Winter = 1,
        [Display(Name = "Літо")]
        Summer = 2
    }
}
