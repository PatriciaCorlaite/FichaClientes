using System.ComponentModel.DataAnnotations;

namespace FichaClientes.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome � obrigat�rio")]
        public string Nome { get; set; }

        [EmailAddress(ErrorMessage = "E-mail inv�lido")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Telefone inv�lido")]
        public string Telefone { get; set; }
    }
}