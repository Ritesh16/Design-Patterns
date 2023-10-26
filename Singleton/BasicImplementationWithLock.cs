namespace Singleton
{
    // Basic Implementation with locking. Lock has perforamnce issues since we are checking it always.
    internal class BasicImplementationWithLock
    {
        private static BasicImplementationWithLock _instance;
        private static object padlock = new object();
        public static BasicImplementationWithLock Instance
        {
            get
            {
                lock(padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new BasicImplementationWithLock();
                    }
                }

                return _instance;
            }
        }

        // Double null check on lock to avoid calling lock.
        // It resolves performanceissues.
        public static BasicImplementationWithLock Instance2
        {
            get
            {
                if(_instance == null)
                {
                    lock (padlock)
                    {
                        if (_instance == null)
                        {
                            _instance = new BasicImplementationWithLock();
                        }
                    }
                }

                return _instance;
            }
        }

        private BasicImplementationWithLock()
        {

        }
    }
}
