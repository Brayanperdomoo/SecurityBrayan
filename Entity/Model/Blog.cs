using System;

namespace Entity.Model
{
    public class BlogDTO
    {
        public int IdBlog { get; set; }
        public int IdUser { get; set; }
        public string Qualification { get; set; }
        public string Content { get; set; }
        public DateTime PublicationDate { get; set; }
        public string FeaturedImage { get; set; }
        public bool Asset { get; set; }
        public int Visits { get; set; }



   }
}
