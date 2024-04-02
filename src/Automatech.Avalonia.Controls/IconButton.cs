using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Metadata;
using Avalonia.Controls.Templates;

namespace Automatech.Avalonia.Controls
{
    /// <summary>
    /// 带图标的按钮
    /// </summary>
    [PseudoClasses(P_LEFT,P_RIGHT,P_TOP,P_BOTTOM)]
    public class IconButton : Button
    {
        private const string P_LEFT = ":left";
        private const string P_RIGHT = ":right";
        private const string P_TOP = ":top";
        private const string P_BOTTOM = ":bottom";

        static IconButton()
        {
            PlacementProperty.Changed.AddClassHandler<IconButton,Position>((s, e) =>
            {
                Console.WriteLine(e.NewValue.Value);
                if (e.NewValue.Value == e.OldValue.Value)
                {
                    return;
                }

                s.SetPlacement(e.NewValue.Value);
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
        
        public static readonly StyledProperty<Position> PlacementProperty =
            AvaloniaProperty.Register<IconButton, Position>(nameof(Placement));

        public Position Placement
        {
            get => GetValue(PlacementProperty);
            set => SetValue(PlacementProperty, value);
        }
        
        private void SetPlacement(Position position)
        {
            PseudoClasses.Set(P_LEFT, position == Position.Left);
            PseudoClasses.Set(P_RIGHT, position == Position.Right);
            PseudoClasses.Set(P_TOP, position == Position.Top);
            PseudoClasses.Set(P_BOTTOM, position == Position.Bottom);
        }
    }
}