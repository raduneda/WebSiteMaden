#region

using System.Collections.Generic;
using System.Linq;
using DL;
using TL;
using TL.Enums;

#endregion

namespace BL
{
    public class PhotoManager : BaseManager
    {
        //private readonly PathManager _pathManager;

        //public PhotoManager()
        //{
        //    //_pathManager = PathManager.Instance;
        //}

        public List<PhotoDto> GetRecentImages( int numberOfImages = 8 )
        {
            List<PhotoDto> photoList = GetPortfolioImages(PhotoEnum.PortfolioImageType.All);

            return photoList.Take(numberOfImages).ToList();
        }

        public List<PhotoDto> GetPortfolioImages( PhotoEnum.PortfolioImageType imageType )
        {
            List<PhotoDto> photoList = new List<PhotoDto>();

            if ( imageType == PhotoEnum.PortfolioImageType.Standard )
            {
                photoList.AddRange(
                    new DatabaseManager().GetPhotoDtoList()
                        .Where(item => item.Type == PhotoEnum.PortfolioImageType.Standard));

                //foreach (PhotoDto dto in photoList)
                //{
                //    dto.Path = _pathManager.TrimPathUntilContentDirectory(dto.Path);
                //    DatabaseManager dbManager = new DatabaseManager();
                //    dbManager.InsertPhotoDto(dto);
                //}
            }

            if ( imageType == PhotoEnum.PortfolioImageType.Creative )
            {
                //photoList = GetDtoFromPath(_pathManager.PortfolioCreativePath, PhotoEnum.PortfolioImageType.Creative);
                photoList.AddRange(
                    new DatabaseManager().GetPhotoDtoList()
                        .Where(item => item.Type == PhotoEnum.PortfolioImageType.Creative));

                //foreach (PhotoDto dto in photoList)
                //{

                //    dto.Path = _pathManager.TrimPathUntilContentDirectory(dto.Path);
                //    DatabaseManager dbManager = new DatabaseManager();
                //    dbManager.InsertPhotoDto(dto);
                //}
            }

            if ( imageType == PhotoEnum.PortfolioImageType.All )
            {
                //photoList.AddRange(GetDtoFromPath(_pathManager.PortfolioStandardPath,
                //    PhotoEnum.PortfolioImageType.Standard));
                //photoList.AddRange(GetDtoFromPath(_pathManager.PortfolioCreativePath,
                //    PhotoEnum.PortfolioImageType.Creative));

                //foreach (PhotoDto dto in photoList)
                //{
                //    DatabaseManager dbManager = new DatabaseManager();
                //    dbManager.InsertPhotoDto(dto);
                //}
                photoList.AddRange(new DatabaseManager().GetPhotoDtoList());
            }

            return photoList;
        }
    }
}