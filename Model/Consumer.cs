using System.ComponentModel.DataAnnotations;

namespace ConsumerMicroservice.Model
{
    public partial class Consumer
    {
        public int ConsumerId { get; set; }
        public string ConsumerName { get; set; }

        //[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = false)]
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PanNumber { get; set; }
        public int AgentId { get; set; }
    }
}
