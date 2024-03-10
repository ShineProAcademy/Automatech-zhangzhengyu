using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Automatech
{
    public class Theme : ITheme
    {
        private ThemeResource _themeResource;

        public Theme(ThemeResource themeResource)
        {
            _themeResource = themeResource;
        }

        public string Name => _themeResource?.Name;

        public ThemeResource ThemeResource => _themeResource;

        public void Attach()
        {
            if (_themeResource != null)
            {
                IList<ResourceDictionary> resourceDictionaries = _themeResource.GetResources();
                foreach (var item in resourceDictionaries)
                {
                    if (!Application.Current.Resources.MergedDictionaries.Contains(item))
                    {
                        Application.Current.Resources.MergedDictionaries.Add(item);
                    }
                }
            }
        }

        public void Detach()
        {
            if (_themeResource != null)
            {
                IList<ResourceDictionary> resourceDictionaries = _themeResource.GetResources();
                foreach (var item in resourceDictionaries)
                {
                    if (!Application.Current.Resources.MergedDictionaries.Contains(item))
                    {
                        Application.Current.Resources.MergedDictionaries.Remove(item);
                    }
                }
            }
        }
    }
}
