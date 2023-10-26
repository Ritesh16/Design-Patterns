namespace Singleton
{
    // Static constructor is thread safe, if there is a static property field and on calling it
    // instance will get created. So it's not lazy loading. Instance can be created accidently.
    internal class StaticConstructorImplementation
    {
        private static readonly StaticConstructorImplementation _instance = new StaticConstructorImplementation();

        public static StaticConstructorImplementation Instance 
        {
            get
            {
                return _instance;
            } 
        }
        static StaticConstructorImplementation()
        {

        }
    }
}
