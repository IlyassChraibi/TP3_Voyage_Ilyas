namespace tp3_valise.Models
{
    public class VoyageUser
    {
        public int VoyageId { get; set; }
        public Voyage Voyage { get; set; }

        public int UserId { get; set; }
        public ApplicationUser User { get; set; }

    }
}
