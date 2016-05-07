using System;
using System.IO;
using System.Linq;

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
            //string directoryOfImage = HttpContext.Current.Server.MapPath("~/Images/");
            string contentPath = Path.Combine( AppDomain.CurrentDomain.BaseDirectory, "Content");
            ImagesPath = Path.Combine(contentPath, "images");
            PortfolioPath = Path.Combine(ImagesPath, "portfolio");
            PortfolioCreativePath = Path.Combine(PortfolioPath, "creative");
            PortfolioStandardPath = Path.Combine(PortfolioPath, "standard");

            SliderPath = Path.Combine(ImagesPath, "slider");
            SliderBackgroundPath = Path.Combine(SliderPath, "background");
            SliderForegroundPath = Path.Combine(SliderPath, "foreground");
        }

        public static PathManager Instance
        {
            get { return _instance ?? (_instance = new PathManager()); }
        }

        public string TrimPathUntilContentDirectory( string path )
        {
            return path.Remove(path.IndexOf(ImagesPath, StringComparison.InvariantCultureIgnoreCase));

            //string[] pathParts = path.Split(new []{"\\"},StringSplitOptions.RemoveEmptyEntries);

            //for ( int i = 0;i<pathParts.Length;i++)
            //{
            //    if ( string.Equals(pathParts[i].ToLowerInvariant(), "content") )
            //    {
            //        //Reached ContentDirectory
            //        return Path.Combine(pathParts.Skip(i).ToArray());
            //    }
            //}

            //throw new Exception("Unable to find content directory from given path");
        }


        public string ImagesPath { get; private set; }
        public string PortfolioPath { get; private set; }
        public string PortfolioCreativePath { get; private set; }
        public string PortfolioStandardPath { get; private set; }

        public string SliderPath { get; private set; }
        public string SliderBackgroundPath { get; private set; }
        public string SliderForegroundPath { get; private set; }
    }
}