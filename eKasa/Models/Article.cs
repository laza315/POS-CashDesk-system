using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;


namespace eKasa.Models
{
    public class Article
    {
        [Key]
        public int ArticleId { get; set; }

        public string Title { get; set; }

        public int Purchase_price { get; set; }

        public int Retail_price { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
