namespace hotel_api.Features.Guests.Dtos;

/// <summary>
/// Representação de um hóspede retornada pela API.
/// </summary>
public class GuestResponse
{
    /// <summary>
    /// Identificador único do hóspede.
    /// </summary>
    /// <example>1</example>
    public int Id { get; set; }

    /// <summary>
    /// Nome completo do hóspede.
    /// </summary>
    /// <example>João Silva</example>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// E-mail do hóspede.
    /// </summary>
    /// <example>joao.silva@email.com</example>
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// Telefone de contato do hóspede.
    /// </summary>
    /// <example>11999998888</example>
    public string Phone { get; set; } = string.Empty;

    /// <summary>
    /// Data de nascimento do hóspede.
    /// </summary>
    /// <example>1990-05-15</example>
    public DateOnly BirthDate { get; set; }

    /// <summary>
    /// Nacionalidade do hóspede.
    /// </summary>
    /// <example>Brasileira</example>
    public string Nationality { get; set; } = string.Empty;

    /// <summary>
    /// País de nascimento do hóspede.
    /// </summary>
    /// <example>Brasil</example>
    public string BirthCountry { get; set; } = string.Empty;

    /// <summary>
    /// Cidade de nascimento do hóspede.
    /// </summary>
    /// <example>São Paulo</example>
    public string BirthCity { get; set; } = string.Empty;

    /// <summary>
    /// Estado de nascimento do hóspede.
    /// </summary>
    /// <example>SP</example>
    public string BirthState { get; set; } = string.Empty;

    /// <summary>
    /// Logradouro do endereço do hóspede.
    /// </summary>
    /// <example>Rua das Flores</example>
    public string Street { get; set; } = string.Empty;

    /// <summary>
    /// Número do endereço do hóspede.
    /// </summary>
    /// <example>123</example>
    public string Number { get; set; } = string.Empty;

    /// <summary>
    /// Bairro do endereço do hóspede.
    /// </summary>
    /// <example>Centro</example>
    public string Neighborhood { get; set; } = string.Empty;

    /// <summary>
    /// CEP do endereço do hóspede.
    /// </summary>
    /// <example>01310100</example>
    public string ZipCode { get; set; } = string.Empty;

    /// <summary>
    /// Cidade do endereço do hóspede.
    /// </summary>
    /// <example>São Paulo</example>
    public string City { get; set; } = string.Empty;

    /// <summary>
    /// Estado do endereço do hóspede.
    /// </summary>
    /// <example>SP</example>
    public string State { get; set; } = string.Empty;

    /// <summary>
    /// País do endereço do hóspede.
    /// </summary>
    /// <example>Brasil</example>
    public string Country { get; set; } = string.Empty;

    /// <summary>
    /// Complemento do endereço do hóspede.
    /// </summary>
    /// <example>Apto 42</example>
    public string Complement { get; set; } = string.Empty;

    /// <summary>
    /// Ponto de referência do endereço do hóspede.
    /// </summary>
    /// <example>Próximo ao metrô</example>
    public string Reference { get; set; } = string.Empty;

    /// <summary>
    /// Tipo de documento do hóspede.
    /// </summary>
    /// <example>CPF</example>
    public string DocumentType { get; set; } = string.Empty;

    /// <summary>
    /// Número do documento do hóspede.
    /// </summary>
    /// <example>12345678909</example>
    public string DocumentNumber { get; set; } = string.Empty;

    /// <summary>
    /// Data de criação do registro.
    /// </summary>
    /// <example>2026-06-09T20:30:35Z</example>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Data da última atualização do registro.
    /// </summary>
    /// <example>2026-06-09T20:30:35Z</example>
    public DateTime UpdatedAt { get; set; }
}
