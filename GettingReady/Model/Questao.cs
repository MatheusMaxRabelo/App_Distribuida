using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady.Model
{
    public class Questao : Entidade
    {
        [Required(ErrorMessage = "Campo Pergunta é obrigatório!")]
        public string Pergunta { get; set; }
        public Assunto Assunto { get; set; }
        [Required(ErrorMessage = "Alternativa 1 é obrigatório!")]
        public string opcao_0 { get; set; }
        [Required(ErrorMessage = "Alternativa 2 é obrigatório!")]
        public string opcao_1 { get; set; }
        [Required(ErrorMessage = "Alternativa 3 é obrigatório!")]
        public string opcao_2 { get; set; }
        [Required(ErrorMessage = "Alternativa 4 é obrigatório!")]
        public string opcao_3 { get; set; }
        [Required(ErrorMessage = "Campo resposta correta é obrigatório!")]
        public string resposta { get; set; }
        public Professor Professor { get; set; }
        [Required(ErrorMessage = "Selecionar professor é obrigatório!")]
        public int ProfessorId { get; set; }
        [Required(ErrorMessage = "Selecionar Assunto é obrigatório!")]
        public int AssuntoId { get; set; }

        
        
    }
}
