using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Metadata;
using Avalonia.Controls.Templates;

namespace Automatech.Avalonia.Controls
{
    /// <summary>
    /// 带图标的按钮
    /// </summary>
    [PseudoClasses(P_LEFT, P_RIGHT, P_TOP, P_BOTTOM, P_EMPTY)]
    public class IconButton : Button
    {
        private const string P_LEFT = ":left";
        private const string P_RIGHT = ":right";
        private const string P_TOP = ":top";
        private const string P_BOTTOM = ":bottom";
        private const string P_EMPTY = ":empty";

        static IconButton()
        {
            IconPlacementProperty.Changed.AddClassHandler<IconButton,Position>((s, e) =>
            {
                s.SetPlacement(e.NewValue.Value, s.Icon);
            });
            IconProperty.Changed.AddClassHandler<IconButton, object>((s, e) =>
            {
                s.SetPlacement(s.IconPlacement, e.NewValue.Value);
            });
        }

        public static readonly StyledProperty<object> IconProperty =
            AvaloniaProperty.Register<IconButton, object>(nameof(Icon));

        public object Icon
        {
            get => GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }
        
        public static readonly StyledProperty<IDataTemplate> IconTemplateProperty = 
            AvaloniaProperty.Register<IconButton, IDataTemplate>(nameof(IconTemplate));
        
        public object IconTemplate
        {
            get => GetValue(IconTemplateProperty);
            set => SetValue(IconTemplateProperty, value);
        }
        
        public static readonly StyledProperty<Position> IconPlacementProperty =
            AvaloniaProperty.Register<IconButton, Position>(nameof(IconPlacement));

        public Position IconPlacement
        {
            get => GetValue(IconPlacementProperty);
            set => SetValue(IconPlacementProperty, value);
        }
        
        private void SetPlacement(Position position, object icon)
        {
            if (icon == null)
            {
                PseudoClasses.Set(P_EMPTY, true);
                PseudoClasses.Set(P_LEFT, false);
                PseudoClasses.Set(P_RIGHT, false);
                PseudoClasses.Set(P_TOP, false);
                PseudoClasses.Set(P_BOTTOM, false);
                return;
            }
            
            PseudoClasses.Set(P_LEFT, position == Position.Left);
            PseudoClasses.Set(P_RIGHT, position == Position.Right);
            PseudoClasses.Set(P_TOP, position == Position.Top);
            PseudoClasses.Set(P_BOTTOM, position == Position.Bottom);
        }
    }
}