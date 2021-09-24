using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge1.Entities
{
    public class Comment
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        //cambio el nombre solo porque no me deja usar el mismo que el de la clase
        public string Comentario { get; set; }

        public User User { get; set; }

    }
}
