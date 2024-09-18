using System.ComponentModel.DataAnnotations;
using System.Data;

namespace QuelloCook.ViewModels;

    public class RegistroVM
    {
        [Display(Name = "Nome Completo", Prompt = "Informe seu Nome Completo")]
        [Required(ErrorMessage = "Por Favor, informe seu Nome")]
        [StringLength(60, ErrorMessage = "O nome deve possuir no máximo 60 caracteres")]
        public string Nome { get;set;}

        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento", Prompt = "Informe sua Data de Nascimento")]
        [Required(ErrorMessage = "Por favor, informe sua Data de Nascimento")]
        public DateTime? DataNascimento {get; set;} = null;

        [Display(Prompt = "Informe seu Email")]
        [Required(ErrorMessage = "Por Favor, informe seu Email")]
        [EmailAddress(ErrorMessage = "Por Favor, informe seu Email Válido!")]
        [StringLength(100, ErrorMessage = "O Email deve possuir no máximo 100 caracteres")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Senha de Acesso", Prompt = "Informe uma senha para acesso")]
        [Required(ErrorMessage = "Por Favor, informe sua senha de acesso")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = " A senha deve possuir no minimo 6 e no maximo 20 caracteres")]
        public string Senha { get;set;}

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar senha de acesso", Prompt = "Confirme sua senha de acesso")]
        [Compare("Senha", ErrorMessage = "As senhas não Conferem.")]
        public string ConfirmacaoSenha { get; set;}

        public IFormFile Foto { get; set; }
        public bool Termos { get; set; } = false;
        public bool Enviado { get; set; } = false;
    }
