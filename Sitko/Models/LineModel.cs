using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace Sitko.Models
{
    public class LineModel 
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateDue { get; set; }
        public bool State { get; set; }

    }
}
