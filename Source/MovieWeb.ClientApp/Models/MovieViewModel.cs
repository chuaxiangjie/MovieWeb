namespace MovieWeb.ClientApp.Models
{
    public class MovieViewModel
    {
        public MovieViewModel()
        {
            this.Image = new Image();
        }

        public int ItemIndex { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ProgramType { get; set; }

        public Image Image { get; set; }

        public string ReleaseYear { get; set; }
    }

    public class Image
    {
        public Image()
        {
            this.PosterArt = new PosterArt();
        }

        public PosterArt PosterArt { get; set; }
    }

    public class PosterArt
    {
        public string Url { get; set; }
        public int Width { get; set; }

        public int Height { get; set; }
    }
}
