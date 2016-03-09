﻿#region

using System.Collections.Generic;
using System.IO;
using System.Linq;
using TL;
using TL.Enums;

#endregion

namespace BL
{
    public class PhotoManager : BaseManager
    {
        private readonly PathManager _pathManager;

        public PhotoManager( IPathManager pathManager = null )
        {
            if ( null == pathManager )
            {
                _pathManager = PathManager.Instance;
            }
        }

        public List<PhotoDto> GetPortfolioImages( PhotoEnum.PortfolioImageType imageType )
        {
            List<PhotoDto> photoList = new List<PhotoDto>();

            if ( imageType == PhotoEnum.PortfolioImageType.Standard )
            {
                photoList = GetDtoFromPath(_pathManager.PortfolioStandardPath, PhotoEnum.PortfolioImageType.Standard);
            }

            if ( imageType == PhotoEnum.PortfolioImageType.Creative )
            {
                photoList = GetDtoFromPath(_pathManager.PortfolioCreativePath, PhotoEnum.PortfolioImageType.Creative);
            }

            if ( imageType == PhotoEnum.PortfolioImageType.All )
            {
                photoList.AddRange(GetDtoFromPath(_pathManager.PortfolioStandardPath,
                    PhotoEnum.PortfolioImageType.Standard));
                photoList.AddRange(GetDtoFromPath(_pathManager.PortfolioCreativePath,
                    PhotoEnum.PortfolioImageType.Creative));
            }

            return photoList;
        }

        private List<PhotoDto> GetDtoFromPath( string path, PhotoEnum.PortfolioImageType itemType )
        {
            return
                Directory.GetFiles(path)
                    .Select(
                        filePath => new PhotoDto
                        {
                            Path = filePath,
                            Name = Path.GetFileNameWithoutExtension(filePath),
                            ByteArray = File.ReadAllBytes(filePath),
                            Type = itemType
                        })
                    .ToList();
        }
    }
}