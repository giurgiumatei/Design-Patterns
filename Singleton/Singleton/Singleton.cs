namespace Singleton
{
    public sealed class Singleton
    {
        private static Singleton _instance;
        private static readonly object _lockObject = new object();

        private Singleton()
        {
            
        }

        public static Singleton Instance
        {
            get
            {
                lock (_lockObject)
                {
                    
                
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }

                    return _instance;
                }
            }
            
        }
        
     // rest of the methods   

    }
}