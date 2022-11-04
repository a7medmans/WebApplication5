using System.ComponentModel.DataAnnotations;

namespace WebApplication5.ViewModels
{
    public class RoleFormViewModel
    {
        [Required, StringLength(256)]
        public string Name { get; set; }
    }
}
