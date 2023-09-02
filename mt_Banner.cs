using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server
{
    public class mt_Banner
    {
        [Key] // Marks the property as the primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Specifies it's auto-generated
        public int ID { get; set; }

        public string Guid { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
    }
}
