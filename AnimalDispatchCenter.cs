using System;
namespace SingletonDesignPattern
{
	public class AnimalDispatchCenter
	{
		private static readonly AnimalDispatchCenter _dispatchCenterInstance = new AnimalDispatchCenter();
		private List<string> animalsForDispatch = new List<string>();
        private int nextAnimaldispatcher = 0;
        private AnimalDispatchCenter()
		{
            animalsForDispatch.Add("wiggly");
            animalsForDispatch.Add("nibbly");
            animalsForDispatch.Add("furry");
            animalsForDispatch.Add("slithery");
            animalsForDispatch.Add("sneaky");
            animalsForDispatch.Add("wimpy");
            animalsForDispatch.Add("jumpy");
        }

        public static AnimalDispatchCenter GetAnimalDispatchCenter()
        {
            return _dispatchCenterInstance;
        }

        public string GetNextAnimalDispatcher()
        {
            string nextDispatcher = animalsForDispatch[nextAnimaldispatcher];
            nextAnimaldispatcher += 1;

            if (nextAnimaldispatcher > animalsForDispatch.Count - 1)
            {
                nextAnimaldispatcher = 0;
            }
            return nextDispatcher;
        }
    }
}

