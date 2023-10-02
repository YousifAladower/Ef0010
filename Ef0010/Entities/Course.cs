using System.Collections.Generic;
using static System.Collections.Specialized.BitVector32;

namespace Ef0010.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string? CourseName { get; set; }
        public decimal Price { get; set; }

        public ICollection<Section> Sections { get; set; } = new List<Section>();
    

    }
}
