using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Automatech
{
    public class ThemeManager
    {
        private ITheme _currentTheme = null;

        private IList<ITheme> _themes;

        public ThemeManager()
        {
            _themes = new List<ITheme>();
        }

        public ITheme CurrentTheme => _currentTheme;

        public EventHandler<ThemeChangedEventArgs> ThemeChanged;

        public void AddTheme(ITheme theme)
        {
            if (!_themes.Contains(theme))
            {
                _themes.Add(theme);
            }
        }

        public IList<ITheme> GetAllThemes()
        {
            return _themes;
        }

        public void RemoveTheme(ITheme theme)
        {
            _themes.Remove(theme);
        }

        public void SwitchTo(ITheme theme)
        {
            if (_themes.Contains(theme))
            {
                _currentTheme?.Detach();

                theme.Attach();

                _currentTheme = theme;

                ITheme oldTheme = _currentTheme;
                _currentTheme = theme;
                ThemeChanged?.Invoke(this, new ThemeChangedEventArgs(oldTheme, theme));
            }
        }

        public void SwitchTo(string themeName)
        {
            ITheme theme = _themes.FirstOrDefault(m => m.Name == themeName);
            SwitchTo(theme);
        }
    }

    public class ThemeChangedEventArgs : EventArgs
    {
        public ThemeChangedEventArgs(ITheme oldValue, ITheme newValue)
        {
            OldTheme = oldValue;
            NewTheme = newValue;
        }

        public ITheme OldTheme { get; }

        public ITheme NewTheme { get; }
    }
}
