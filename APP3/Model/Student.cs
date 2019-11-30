using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP3.Model
{
    public class Student
    {
        [Key]
        public string Id { get; set; }
        [StringLength(20)]
        public string FirstName { get; set; }
        [StringLength(20)]
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public GENDER Gender { get; set; }
        [StringLength(200)]
        public string PlaceOfBirth { get; set; }

        public List<LearningHistory> ListLearningHistory { get; set; }
    }

    public enum GENDER { Female,Male,Other}

}
