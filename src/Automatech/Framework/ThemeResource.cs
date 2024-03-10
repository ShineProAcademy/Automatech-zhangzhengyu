using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Automatech
{
    public class ThemeResource
    {
        private IList<ResourceDictionary> resources;

        public ThemeResource(string name) 
        {
            Name = name;
            resources = new List<ResourceDictionary>();
        }

        public string Name { get; }

        public IList<ResourceDictionary> GetResources()
        {
            return resources;
        }
        
        public void Add(string key, object value)
        {
            if (!resources.Any())
            {
                return;
            }

            foreach (var resource in resources)
            {
                if (resource.Contains(key))
                {
                    resource.Remove(key);
                    resource.Add(key, value);
                }
            }
        }

        public void Add(Uri uri)
        {
            resources.Add(new ResourceDictionary { Source = uri });
        }
    }
}
