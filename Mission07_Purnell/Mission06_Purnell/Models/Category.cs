using System.ComponentModel.DataAnnotations;

namespace Mission07_Purnell.Models
{
    public class Category
    {
        [Key]
        public int CategoryId {  get; set; }
        public string CategoryName {  get; set; }
    }
}
