using System.ComponentModel.DataAnnotations;

namespace hotel_api.Shared.Validation;

public class CpfAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(
        object? value,
        ValidationContext validationContext)
    {
        var cpf = value?.ToString();

        if (CpfValidator.IsValid(cpf))
        {
            return ValidationResult.Success;
        }

        return new ValidationResult(
            ErrorMessage ?? "CPF inválido."
        );
    }
}