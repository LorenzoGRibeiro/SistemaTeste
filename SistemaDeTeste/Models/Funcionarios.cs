using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeTeste.Models
{

    [Table("Funcionario Cadastrados")]
    public class Funcionarios
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [DataType(DataType.Date)]
        [Column("DataDeNascimento")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataDeNascimento { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "numeric(18,2)")]
        [Display(Name = "Salario")]
        public decimal Salario { get; set; }

        [Column("Atividade")]
        [Display(Name = "Atividade")]

        public string Atividade { get; set; }

    }
}
