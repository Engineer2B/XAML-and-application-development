using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Adv_1_Hands_On_2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.LoadData();
        }

        async void LoadData()
        {
            this.SetValue(LoadingProperties.IsLoadingProperty, true);

            await Task.Delay(5000);

            this.SetValue(LoadingProperties.IsLoadingProperty, false);
        }
    }
}
