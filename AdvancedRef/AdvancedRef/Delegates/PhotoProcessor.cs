using System;

namespace AdvancedRef.Delegates
{

    public class PhotoProcessor
    {
        //public delegate void PhotoFilterHandler(Photo photo);

        public void Process(string path, Action<Photo> filterHandler)
        {
            // Do you need delegate without a returning value?
            //System.Action
            
            // Do you need a delegate with a returning value?
            // System.Func
            var photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();
        }

    }
}
