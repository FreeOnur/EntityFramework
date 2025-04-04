using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreAnima
{
    public class Animal
    {
        public int Id { get; set; }

        [Column(TypeName = "TEXT")]
        public string Name { get; set; }

        public int Age { get; set; }

        [Column(TypeName = "TEXT")]
        public string Colour { get; set; }
    }

}
