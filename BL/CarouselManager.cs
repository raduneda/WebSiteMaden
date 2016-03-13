#region

using System.Collections.Generic;
using System.IO;
using System.Linq;
using TL;
using TL.Enums;

#endregion

namespace BL
{
    public class CarouselManager : BaseManager
    {
        private readonly PathManager _pathManager;
        private const string BG_PREFIX = "bg";
        private const string FG_PREFIX = "img";
        private const string JPG_EXT = ".jpg";
        private const string PNG_EXT = ".png";
        private const string READ_MORE = "Mai Mult";

        public CarouselManager()
        {
            _pathManager = PathManager.Instance;
        }

        /// <summary>
        ///     Gets the required number of items for the carousel
        /// </summary>
        /// <returns></returns>
        public List<CarouselDto> GetCarouselItems(int numberOfItems = 3)
        {
            List<CarouselDto> carouselList = new List<CarouselDto>();

            for (int i = 1; i <= numberOfItems; i++)
            {
                CarouselDto carouselDto = new CarouselDto
                {
                    BackgroundImage =
                        File.ReadAllBytes(Path.Combine(_pathManager.SliderBackgroundPath,string.Concat( BG_PREFIX, i.ToString(),
                            JPG_EXT))),
                    FrontImage =
                        File.ReadAllBytes(Path.Combine(_pathManager.SliderForegroundPath,string.Concat( FG_PREFIX, i.ToString(),
                            PNG_EXT))),
                    ReadMore = READ_MORE,
                    Title = "Titlu Mare",
                    Subtitle = "Subtitlu mic"
                };

                carouselList.Add(carouselDto);
            }

            return carouselList;
        }
    }
}