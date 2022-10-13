//From https://github.com/hartez/CustomLayoutExamples#single-column-layout 
using Microsoft.Maui.Layouts;

namespace MauiAttached;

public class ColumnLayout : VerticalStackLayout
{
    public static readonly BindableProperty FillProperty = BindableProperty.CreateAttached("Fill", typeof(bool),
        typeof(ColumnLayout), false);

    public ColumnLayout()
    {
    }

    protected override ILayoutManager CreateLayoutManager()
    {
        return new ColumnLayoutManager(this);
    }

    // Support methods for the attached property
    public static bool GetFill(BindableObject bindableObject)
    {
        return (bool)bindableObject.GetValue(FillProperty);
    }
    
    public static void SetFill(BindableObject bindableObject, bool fill)
    {
        bindableObject.SetValue(FillProperty, fill);
    }

    // Convenience method for use from the layout manager
    internal static bool GetFillForView(IView view)
    {
        if (view is BindableObject bindableObject)
        {
            return GetFill(bindableObject);
        }

        return false;
    }
}
