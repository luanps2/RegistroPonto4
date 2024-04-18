using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroPonto4
{
    internal class Usuario
    {
        public int Id { get; set; } 
        public string Nome { get; set; }
        

        //construtor
        public Usuario(int Id, string Nome)
        {
            this.Id = Id;
            this.Nome = Nome;
        }
    }
}
