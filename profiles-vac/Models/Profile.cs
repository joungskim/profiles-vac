using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace profiles_vac.Models
{
    public class Profile
    {
        public int Id { get; set; }
        [DisplayName("Name")]
        public string Name { get; set; }
        public bool CurrentEmployee { get; set; }
        [DisplayName("Position")]
        public string PositionTitle { get; set; }
        [DisplayName("Description")]
        public string Description { get; set; }
        [DisplayName("Image")]
        public string ProfileImageURL { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

    }
}
