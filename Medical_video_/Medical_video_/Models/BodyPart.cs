using System;

namespace Medical_video_
{
    public class BodyPart
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public Guid AreaId { get; set; }
    }
}