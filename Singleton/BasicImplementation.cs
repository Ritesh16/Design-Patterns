namespace Singleton
{
    // Basic Implementation. It will not work with multi-threading
    internal class BasicImplementation
    {
        private static BasicImplementation _instance;
        public static BasicImplementation Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BasicImplementation();
                }

                return _instance;
            }
        }

        private BasicImplementation()
        {

        }
    }
}
