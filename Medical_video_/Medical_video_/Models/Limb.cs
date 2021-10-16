using System;

namespace Medical_video_
{
    public class Limb
    {
        public  Guid Id { get; set; }
        public string Name { get; set; }
        public Guid BodyPartId { get; set; }
    }
}