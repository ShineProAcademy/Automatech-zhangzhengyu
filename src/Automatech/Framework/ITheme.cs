using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Automatech
{
    public interface ITheme
    {
        string Name { get; }

        ThemeResource ThemeResource { get; }

        void Attach();

        void Detach();
    }
}
