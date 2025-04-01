namespace Entity.Model
{
    public class Resena
    {
        public int Idresena { get; set; }
        public int Idususer { get; set; }
        public int IdService { get; set; }
        public int qualification { get; set; }
        public string comment { get; set; }  
        public DateTime datereview { get; set; }
        public bool approve { get; set; }
    }
}
