using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace blazorPostsList.Models
{
    public class post
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string type { get; set; }
        public bool published { get; set; } = false;
        public string cover_image { get; set; }
        public string cover_video { get; set; }
        public DateTime date { get; set; } = DateTime.Now;
    }

    public enum type
    {
        объявление,
        новость,
        статья,
        видео
    }
}
