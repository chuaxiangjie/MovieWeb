using System.Text.Json.Serialization;

namespace MovieWeb.Services.Models
{
    public class MovieModel
    {
        public MovieModel()
        {
            this.Image = new Image();
        }

        public int ItemIndex { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ProgramType { get; set; }

        [JsonPropertyName("Images")]
        public Image Image { get; set; }

        public int ReleaseYear { get; set; }
    }

    public class Image
    {
        public Image()
        {
            this.PosterArt = new PosterArt();
        }

        [JsonPropertyName("Poster Art")]
        public PosterArt PosterArt { get; set; }
    }

    public class PosterArt
    {
        public string Url { get; set; }
        public int Width { get; set; }

        public int Height { get; set; }
    }
}
