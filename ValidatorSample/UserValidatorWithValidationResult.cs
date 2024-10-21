using System.ComponentModel.DataAnnotations;

public class UserValidatorWithValidationResult
{
    public static ValidationResult Validate(User user)
    {
        List<string> errors = new();
        if(string.IsNullOrWhiteSpace(user.FirstName) || string.IsNullOrWhiteSpace(user.LastName))
        {
            errors.Add("FirstName or LastName cannot be empty");
        }
        if(user.Age<21)
        {
            errors.Add("User must have 21 years or older");
        }
        return errors.Count==0 ? ValidationResult.Success! : new ValidationResult(String.Join(",",errors));
    }
}
