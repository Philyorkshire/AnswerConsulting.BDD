namespace AnswerConsulting.BDD.Helpers
{
    public static class PageNavigation
    {
        private static readonly string BaseUrl = "http://www.answerconsulting.com/";
        
        public static string Url(Page page)
        {
            switch (page)
            {
                case Page.Home:
                    return BaseUrl;

                case Page.Careers:
                    return BaseUrl + "careers";

                case Page.Contact:
                    return BaseUrl + "contact";

                case Page.GreatClients:
                    return BaseUrl + "clients";

                case Page.HowWeDoIt:
                    return BaseUrl + "how-we-do-it";

                case Page.StunningSolutions:
                    return BaseUrl + "solutions";

                case Page.WhoWeAre:
                    return BaseUrl + "who-we-are";

                case Page.Sitemap:
                    return BaseUrl + "sitemap.xml";

                default:
                    return BaseUrl;
            }
        }

        public static string GetUrlByString(string page)
        {
            switch (page)
            {
                case "Home":
                    return Url(Page.Home);
                case "Careers":
                    return Url(Page.Careers);
                case "Stunning Solutions":
                    return Url(Page.StunningSolutions);
                case "Great Clients":
                    return Url(Page.GreatClients);
                case "How we do it":
                    return Url(Page.HowWeDoIt);
                case "Who we are":
                    return Url(Page.WhoWeAre);
                case "Contact Us":
                    return Url(Page.Contact);
                default:
                    return Url(Page.Home);
            }
        }
    }
}
