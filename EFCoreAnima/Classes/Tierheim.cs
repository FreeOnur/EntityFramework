using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAnima.Classes
{
    public class Tierheim
    {
        public int Id { get; set; }

        [Column(TypeName = "TEXT")]
        public string TierheimName { get; set; }
        public List<Animal> AnimalsList { get; set; }
    }
}

