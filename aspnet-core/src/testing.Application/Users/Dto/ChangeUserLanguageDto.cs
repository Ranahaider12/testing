using System.ComponentModel.DataAnnotations;

namespace testing.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}