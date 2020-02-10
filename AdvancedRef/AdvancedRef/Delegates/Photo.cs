using System;

namespace AdvancedRef.Delegates
{
    public class Photo
    {

        public static Photo Load(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentException("message", nameof(path));
            }

            return new Photo();
        }
        public void Save()
        {

        }
    }
}
