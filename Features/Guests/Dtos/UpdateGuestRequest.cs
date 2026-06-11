using System.ComponentModel.DataAnnotations;

namespace hotel_api.Features.Guests.Dtos;

/// <summary>
/// Dados necessários para atualizar um hóspede.
/// </summary>
public class UpdateGuestRequest
{
    /// <summary>
    /// Nome completo do hóspede.
    /// </summary>
    /// <example>João Silva</example>
    [Required(ErrorMessage = "O nome é obrigatório")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// E-mail do hóspede.
    /// </summary>
    /// <example>joao.silva@email.com</example>
    [Required(ErrorMessage = "O e-mail é obrigatório")]
    [EmailAddress(ErrorMessage = "O e-mail informado é inválido")]
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// Telefone de contato do hóspede.
    /// </summary>
    /// <example>11999998888</example>
    [Required(ErrorMessage = "O telefone é obrigatório")]
    public string Phone { get; set; } = string.Empty;

    /// <summary>
    /// Data de nascimento do hóspede.
    /// </summary>
    /// <example>1990-05-15</example>
    [Required(ErrorMessage = "A data de nascimento é obrigatória")]
    public DateOnly BirthDate { get; set; }

    /// <summary>
    /// Nacionalidade do hóspede.
    /// </summary>
    /// <example>Brasileira</example>
    [Required(ErrorMessage = "A nacionalidade é obrigatória")]
    public string Nationality { get; set; } = string.Empty;

    /// <summary>
    /// País de nascimento do hóspede.
    /// </summary>
    /// <example>Brasil</example>
    [Required(ErrorMessage = "O país de nascimento é obrigatório")]
    public string BirthCountry { get; set; } = string.Empty;

    /// <summary>
    /// Cidade de nascimento do hóspede.
    /// </summary>
    /// <example>São Paulo</example>
    [Required(ErrorMessage = "A cidade de nascimento é obrigatória")]
    public string BirthCity { get; set; } = string.Empty;

    /// <summary>
    /// Estado de nascimento do hóspede.
    /// </summary>
    /// <example>SP</example>
    [Required(ErrorMessage = "O estado de nascimento é obrigatório")]
    public string BirthState { get; set; } = string.Empty;

    /// <summary>
    /// Logradouro do endereço do hóspede.
    /// </summary>
    /// <example>Rua das Flores</example>
    [Required(ErrorMessage = "A rua é obrigatória")]
    public string Street { get; set; } = string.Empty;

    /// <summary>
    /// Número do endereço do hóspede.
    /// </summary>
    /// <example>123</example>
    [Required(ErrorMessage = "O número é obrigatório")]
    public string Number { get; set; } = string.Empty;

    /// <summary>
    /// Bairro do endereço do hóspede.
    /// </summary>
    /// <example>Centro</example>
    [Required(ErrorMessage = "O bairro é obrigatório")]
    public string Neighborhood { get; set; } = string.Empty;

    /// <summary>
    /// CEP do endereço do hóspede.
    /// </summary>
    /// <example>01310100</example>
    [Required(ErrorMessage = "O CEP é obrigatório")]
    public string ZipCode { get; set; } = string.Empty;

    /// <summary>
    /// Cidade do endereço do hóspede.
    /// </summary>
    /// <example>São Paulo</example>
    [Required(ErrorMessage = "A cidade é obrigatória")]
    public string City { get; set; } = string.Empty;

    /// <summary>
    /// Estado do endereço do hóspede.
    /// </summary>
    /// <example>SP</example>
    [Required(ErrorMessage = "O estado é obrigatório")]
    public string State { get; set; } = string.Empty;

    /// <summary>
    /// País do endereço do hóspede.
    /// </summary>
    /// <example>Brasil</example>
    [Required(ErrorMessage = "O país é obrigatório")]
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
    [Required(ErrorMessage = "O tipo de documento é obrigatório")]
    public string DocumentType { get; set; } = string.Empty;

    /// <summary>
    /// Número do documento do hóspede.
    /// </summary>
    /// <example>12345678909</example>
    [Required(ErrorMessage = "O número do documento é obrigatório")]
    public string DocumentNumber { get; set; } = string.Empty;
}
