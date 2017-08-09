using System.Collections.Generic;

namespace VertoExcercise.POCO
{
    public class WikiImagesContinue
    {
        public string Imcontinue { get; set; }
        public string Continue { get; set; }
    }

    public class WikiImage
    {
        public int Ns { get; set; }
        public string Title { get; set; }
    }

    public class WikiImagesInnerPages
    {
        public int Pageid { get; set; }
        public int Ns { get; set; }
        public string Title { get; set; }
        public List<WikiImage> Images { get; set; }
    }

    public class WikiPages
    {
        public WikiImagesInnerPages WikiImagesInnerPage { get; set; }
    }

    public class WikiImagesQuery
    {
        public WikiPages WikiPages { get; set; }
    }

    public class WikiImagesRoot
    {
        public WikiImagesContinue WikiImagesContinue { get; set; }
        public WikiImagesQuery WikiImagesQuery { get; set; }
    }
}