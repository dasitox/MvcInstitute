using System.ComponentModel.DataAnnotations;

namespace MvcInstitute.ViewModels
{
    public class ViewModel_Login
    {
        [Required]
        public int Dni { get; set; }
        [Required]
        public int Docket { get; set; }
    }
}