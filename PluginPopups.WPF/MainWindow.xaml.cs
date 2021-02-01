using Prism;
using Prism.Ioc;
using Prism.Plugin.Popups;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF;

namespace PluginPopups.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : FormsApplicationPage
    {
        public MainWindow()
        {
            InitializeComponent();

            Forms.Init();


            LoadApplication(new PluginPopups.App(new WpfInitializer()));
        }

    }

    public class WpfInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterPopupNavigationService();
        }
    }
}
