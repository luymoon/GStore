using System.ComponentModel.DataAnnotations;

namespace GStore.ViewModels;

public class RegistroVM
{
    [Display(Name = "Nome Completo", Prompt = "Informe seu Nome Completo")]
    [Required(ErrorMessage = "Por Favor, informe seu Nome")]
    [StringLength(60, ErrorMessage = "O nome deve possuir no máximo 60 caracteres")]
    public string Nome { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "Data de Nascimento", Prompt = "Informe sua Data de nascimento")]
    [Required(ErrorMessage = "Por favor, informe sua Data de nascimento")]
    public DateTime? DataNascimento { get; set; } = null;

    [Display(Prompt = "Informe sey email")]
    [Required(ErrorMessage = " Por favor, informe seu email")]
    [EmailAddress(ErrorMessage = "Por favor, informe um email Válido")]
    [StringLength(100, ErrorMessage = "O email deve possuir no máximo 100 caracteres")]
    public string Email { get; set;} 

    [DataType(DataType.Password)]
    [Display(Name = "Senha de acesso", Prompt = "Informe uma Senha para acesso")]
    [StringLength(20, MinimumLength = 6, ErrorMessage = "A senha deve possuir no minímo 6 e no máximo 20 caracteres")]
    public string Senha {get; set;}

    [DataType(DataType.Password)]
    [Display(Name = "Confirmar senha de acesso", Prompt = "Confirme sua Senha de acesso")]
    [Compare("Senha", ErrorMessage = "As Senhas não conferem.")]
    public string ConfirmacaoSenha {get; set;}

    public IFormFile Foto { get; set;}
}