using System.ComponentModel.DataAnnotations;

namespace FichaClientes.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }

        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Telefone inválido")]
        public string Telefone { get; set; }
    }
}