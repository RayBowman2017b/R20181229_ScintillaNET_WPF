using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace SCide.WPF
{
    class Z32_Scintilla_Panel_01
    {
    }

public class ScintillaPanel : Panel
{
    protected override Size MeasureOverride(Size availableSize)
    {
        var children = InternalChildren.OfType<UIElement>();
        var firstChild = children.FirstOrDefault();
        if (firstChild != null)
            firstChild.Measure(new Size(0, 0));
        return new Size(0, 0);
    }

    protected override Size ArrangeOverride(Size finalSize)
    {
        var children = InternalChildren.OfType<UIElement>();
        var firstChild = children.FirstOrDefault();
        if (firstChild != null)
            firstChild.Arrange(new Rect(0, 0, finalSize.Width, finalSize.Height));
        return finalSize;
    }
}

}
