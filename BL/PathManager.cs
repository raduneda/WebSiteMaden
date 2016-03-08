using System.IO;

namespace BL
{
    public interface IPathManager
    {
        string ImagesPath { get; }
        string PortfolioPath { get; }
        string PortfolioCreativePath { get; }
        string PortfolioStandardPath { get; }
    }

    public class PathManager : BaseManager, IPathManager
    {
        private static PathManager _instance;

        private PathManager()
        {
            string contentPath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Content");
            ImagesPath = Path.Combine(contentPath, "images");
            PortfolioPath = Path.Combine(ImagesPath, "portfolio");
            PortfolioCreativePath = Path.Combine(PortfolioPath, "creative");
            PortfolioStandardPath = Path.Combine(PortfolioPath, "standard");
        }

        public static PathManager Instance
        {
            get { return _instance ?? (_instance = new PathManager()); }
        }

        public string ImagesPath { get; private set; }
        public string PortfolioPath { get; private set; }
        public string PortfolioCreativePath { get; private set; }
        public string PortfolioStandardPath { get; private set; }
    }
}