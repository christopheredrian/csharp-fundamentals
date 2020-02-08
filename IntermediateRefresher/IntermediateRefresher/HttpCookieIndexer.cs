namespace IntermediateRefresher
{
    using System;
    using System.Collections.Generic;

    class HttpCookieIndexer
    {
        private readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>();
        public DateTime Expiry { get; set; }
        public string this[string key]
        {
            get
            {
                return _dictionary[key];
            }
            set
            {
                _dictionary[key] = value;
            }
        }

        public static void Run()
        {
            var cookie = new HttpCookieIndexer();
            cookie["name"] = "Muffin";

            System.Console.WriteLine(cookie["name"]);

        }
    }
}