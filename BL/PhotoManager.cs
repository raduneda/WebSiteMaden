#region

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TL;

#endregion

namespace BL
{
    public class PhotoManager : BaseManager
    {
        public enum PortfolioImageType
        {
            Creative,
            Standard,
            All
        }

        private readonly PathManager _pathManager;

        public PhotoManager( IPathManager pathManager = null )
        {
            if ( null == pathManager )
            {
                _pathManager = PathManager.Instance;
            }
        }

        public List<PhotoDto> GetPortfolioImages( PortfolioImageType imageType )
        {
            List<PhotoDto> photoList = new List<PhotoDto>();

            if ( imageType == PortfolioImageType.Standard )
            {
                photoList = GetDtoFromPath(_pathManager.PortfolioStandardPath);
            }

            if ( imageType == PortfolioImageType.Creative )
            {
                photoList = GetDtoFromPath(_pathManager.PortfolioCreativePath);
            }

            if ( imageType == PortfolioImageType.All )
            {
                photoList.AddRange(GetDtoFromPath(_pathManager.PortfolioStandardPath));
                photoList.AddRange(GetDtoFromPath(_pathManager.PortfolioCreativePath));
            }

            return photoList;
        }

        private List<PhotoDto> GetDtoFromPath( string path )
        {
            return
                Directory.GetFiles(path)
                    .Select(
                        filePath => new PhotoDto { Path = filePath, Name = Path.GetFileNameWithoutExtension(filePath), ByteArray = File.ReadAllBytes(filePath) })
                    .ToList();
        }
    }
}