using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msite.DTO
{
    public class DepartmentDTO
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public List<PersonDTO> Members { get; set; }
    }
}
