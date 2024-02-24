using System.ComponentModel.DataAnnotations;

namespace StuWebApp.Data
{
    public class TableOne
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Position { get; set; }
    }
}
