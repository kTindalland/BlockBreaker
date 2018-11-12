using System;
using System.Collections.Generic;

namespace BlockBreakerMk2.Resources.Structures
{
    public struct Options
    {
        private Dictionary<string, object> _options;

        public void AddOption(string name, object caller)
        {
            _options.Add(name, caller);
        }

        public string[] ReturnOptionNames()
        {
            var names = _options.Keys;
            var length = names.Count;
            var stringNames = new string[length];

            for (int i = 0; )
        }
    }
}
