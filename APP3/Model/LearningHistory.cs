using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP3.Model
{
     public class LearningHistory
    {
        [Key]
        public string Id { get; set; }
        public int FromYear { get; set; }
        public int ToYear { get; set; }
        [StringLength(100)]
        public string Address { get; set; }
        public string IdStudent { get; set; }
        [ForeignKey("IdStudent")]
        public Student Student { get; set; }
    }
}
