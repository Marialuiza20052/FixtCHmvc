using System.ComponentModel.DataAnnotations;

namespace FixTechMVC.Models
{
    public class Servico
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome do serviço.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe a descrição.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Informe o preço.")]
        public decimal Preco { get; set; }
    }
}