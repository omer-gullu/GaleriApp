using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GaleriApp.Models
{
    public class AracTuru
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage ="{0} boş geçilemez")]
        [StringLength(50, ErrorMessage ="{0} en fazla {1} olabilir")]
        [MinLength(3,ErrorMessage ="{0} {1}'den fazla olmalıdır ")]
        [DisplayName("Kasa Tipi")]
        public string KasaTipi { get; set; }
    }
}
