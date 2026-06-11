namespace hotel_api.Shared.Validation;

public static class CpfValidator
{
    public static bool IsValid(string? cpf)
    {
        if (string.IsNullOrWhiteSpace(cpf))
            return false;

        // remover máscara
        cpf = new string(cpf.Where(char.IsDigit).ToArray());

        // CPF deve possuir 11 dígitos
        if (cpf.Length != 11)
            return false;

        // rejeitar sequências repetidas
        if (cpf.Distinct().Count() == 1)
            return false;

        return ValidateDigits(cpf);
    }

    private static bool ValidateDigits(string cpf)
    {
        // calcula primeiro dígito verificador
        int sum = 0;

        for (int i = 0; i < 9; i++)
        {
            sum += (cpf[i] - '0') * (10 - i);
        }

        int remainder = sum % 11;

        int firstDigit =
            remainder < 2
                ? 0
                : 11 - remainder;

        // calcula segundo dígito verificador
        sum = 0;

        for (int i = 0; i < 10; i++)
        {
            sum += (cpf[i] - '0') * (11 - i);
        }

        remainder = sum % 11;

        int secondDigit =
            remainder < 2
                ? 0
                : 11 - remainder;

        return cpf[9] - '0' == firstDigit
            && cpf[10] - '0' == secondDigit;
    }
}