namespace Library
{
    public interface Singleton<T> where T: new ()
    {
        static T instance;
        static T Instance{
            get
            {
                if (instance == null)
                {
                    instance = new T();
                }

                return instance;
            }
        }        void SayHiToTheWorld();
    }
}