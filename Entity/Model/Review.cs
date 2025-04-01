namespace Entity.Model
{
    public class ReviewDTO
    {
        public int IdReview { get; set; }
        public int IdUser { get; set; }
        public int IdService { get; set; }
        public int Qualification { get; set; }
        public string Comment { get; set; }  
        public DateTime DateReview { get; set; }
        public bool Approve { get; set; }
    }
}
