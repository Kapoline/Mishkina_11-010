using System;

namespace Medical_video_.Controllers
{
    public class Disease
    {
        public  Guid Id { get; set; }
        public  string Name { get; set; }
        public int Grade { get; set; }
        public string INS { get; set; }
    }
}