using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GaleriApp.Models
{
    public class Araba
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]        
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} boş geçilemez")]
        [StringLength(50, ErrorMessage = "{0} en fazla {1} olabilir")]
        [MinLength(3, ErrorMessage = "{0} {1}'den fazla olmalıdır ")]
        [DisplayName("Marka")]
        public string Marka { get; set; }

        [Required(ErrorMessage = "{0} boş geçilemez")]
        [StringLength(50, ErrorMessage = "{0} en fazla {1} olabilir")]
        [MinLength(3, ErrorMessage = "{0} {1}'den fazla olmalıdır ")]
        [DisplayName("Model")]
        public string Model { get; set;}
        public decimal Price { get; set; }
        public AracTuru AracTuru { get; set; }
        public bool Aktif { get; set; }
        public string AktifString => Aktif ? "Stokta" : "Stokta Değil"; 
    }
}
