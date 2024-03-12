using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetTrainingBatch2.MvcApp.Models
{
    [Table("Tbl_User")]
    public class UserDataModel
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string? GeneratedToken { get; set; }
    }
}
