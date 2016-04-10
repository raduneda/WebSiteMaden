#region

using System;
using System.IO;
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
        public string Extension { get; set; }
        public DateTime CreationDate { get; set; }
        public string NameWithExtension {
            get { return string.Concat( Name, Extension ); }
            set
            {
                Name = System.IO.Path.GetFileNameWithoutExtension(value);
                Extension = System.IO.Path.GetExtension(value);
            } 
        } 
    }
}