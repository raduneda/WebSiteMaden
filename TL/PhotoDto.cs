#region

using TL.Enums;

#endregion

namespace TL
{
    public class PhotoDto
    {
        public string Path { get; set; }
        public string Name { get; set; }
        public byte[] ByteArray { get; set; }
        public PhotoEnum.PortfolioImageType Type { get; set; }
        public string NameWithExtension { get; set;} 
    }
}