using System.ComponentModel.DataAnnotations;

namespace NotesManager.Validation
{
    public class FutureDateAttribute : ValidationAttribute
    {
        public FutureDateAttribute()
        {
            ErrorMessage = "The Date connot be in the past";
        }

        public override bool IsValid(object? value)
        {
            if(value is DateTime dateTime)
            {
                return dateTime >= DateTime.Now;
            }
            return false;
        }
    }
}
