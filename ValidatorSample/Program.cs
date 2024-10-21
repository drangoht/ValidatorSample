// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;

var user = new User("Greg","ZeGreg",20);

var validationResult = UserValidatorWithValidationResult.Validate(user);
if (validationResult == ValidationResult.Success)
{
    Console.WriteLine("OK!");
}
else
{
    Console.WriteLine(validationResult.ErrorMessage);
}

var userValidator = new UserValidator();
var userValidatorResult = userValidator.Validate(user);
if (userValidatorResult.IsValid)
{
    Console.WriteLine("OK!");
}
else
{
    Console.WriteLine(string.Join(", ",userValidatorResult.Errors));
}
Console.ReadLine();
