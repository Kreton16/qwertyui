using System.ComponentModel.DataAnnotations;
namespace Shop.Domain.Enum
{
    public enum CategoryGender
    {
        [Display(Name = "Чоловічий")]
        Man = 0,
        [Display(Name = "Жіночий")]
        Women = 1
    }
}
