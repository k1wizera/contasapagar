using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Cnpj { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
    }
}
