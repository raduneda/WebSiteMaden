#region

using TL.Enums;

#endregion

namespace TL
{
    public class CarouselDto
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string ReadMore { get; set; }
        public byte[] FrontImage { get; set; }
        public byte[] BackgroundImage { get; set; }
    }
}