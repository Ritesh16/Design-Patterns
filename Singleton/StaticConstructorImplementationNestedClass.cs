namespace Singleton
{
    // Resolves issues with static constructor approach
    internal class StaticConstructorImplementationNestedClass
    {
        public static readonly string greeting = "Hi";

        public static StaticConstructorImplementationNestedClass Instance
        {
            get
            {
                return Nested._instance;
            }
        }
        private class Nested
        {
            static Nested()
            {

            }

            internal static readonly StaticConstructorImplementationNestedClass _instance = new StaticConstructorImplementationNestedClass();
        }

        private StaticConstructorImplementationNestedClass() { }
    }
}
