using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaLivros
{
    public class Book
    {
        public string? Nome { get; set; }

        public string? Editora { get; set; }
        public string? Autor { get; set; }
        public int? Paginas { get; set; }
    }
}