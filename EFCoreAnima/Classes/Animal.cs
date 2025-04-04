using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreAnima.Classes
{
    public class Animal
    {
        public int Id { get; set; }

        [Column(TypeName = "TEXT")]
        public string Name { get; set; }

        public int Age { get; set; }

        [Column(TypeName = "TEXT")]
        public string Colour { get; set; }
        public int TierheimId { get; set; }
        public Tierheim Tierheim { get; set; }
    }

}
