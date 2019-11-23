using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP3.Model
{
     public class LearningHistory
    {
        public string Id { get; set; }
        public int FromYear { get; set; }
        public int ToYear { get; set; }
        public string Address { get; set; }
        public string IdStudent { get; set; }
        public Student Student { get; set; }
    }
}
