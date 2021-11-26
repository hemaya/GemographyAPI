namespace Gemography.Crosscut.Routers
{
    public static class Router
    {
        private const string Root = "apis/gemography/";
        private const string Version = "v1/";
        private const string Route = Root + Version;
        
        public static class Repos
        {
            private const string Prefix = Route + "repositories/";
            public const string GetLanguages = Prefix + "get-languages";
        }


    }
}