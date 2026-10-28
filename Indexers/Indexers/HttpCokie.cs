using System.Collections.Generic;
using System;
namespace Indexers
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary;     //can also do this : _dictionary = new Dictionary<string, string>();
        public DateTime Expiry { get; set; }
        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>(); 
        }

        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }

    }
}
