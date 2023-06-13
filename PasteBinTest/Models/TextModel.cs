using System.ComponentModel.DataAnnotations;

namespace PasteBinTest.Models
{
    public class TextModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        [MaxLength(10)]
        public string? PreviewText => Text != null ? (Text.Length > 10 ? (Text.Substring(0, 10)  + "...") : Text) : null;
    }
}
