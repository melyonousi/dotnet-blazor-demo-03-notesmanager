using NotesManager.Validation;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace NotesManager.Models
{
    public class Note
{
    [Required]
    public int Id { get; set; }

    [Required, Range(1,100), NotNull]
    public string Title { get; set; } = string.Empty;

    [Range(1, 555)]
    public string Description { get; set; } = string.Empty;

    [FutureDate]
    public DateTime CreatedAt { get; set; }
}
}

