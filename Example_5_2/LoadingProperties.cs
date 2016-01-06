using Windows.UI.Xaml;

namespace Example_5_2
{
    public class LoadingProperties : DependencyObject
    {
        public static readonly DependencyProperty IsLoadingProperty = DependencyProperty.RegisterAttached(
            "IsLoading", typeof(bool), typeof(LoadingProperties), new PropertyMetadata(true)
            );

        public static void SetIsLoading(UIElement element, bool value)
        {
            element.SetValue(IsLoadingProperty, value);
        }
        public static bool GetIsLoading(UIElement element)
        {
            return (bool)element.GetValue(IsLoadingProperty);
        }
    }


}