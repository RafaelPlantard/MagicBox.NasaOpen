using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;

namespace MagicBox.NasaOpen
{
    /// <summary>
    /// Provides application-specific behavior to supplement the PrismUnityApplication class.
    /// </summary>
    /// <remarks>This application-specific behavior enable the use of Unity and Prism in the project.</remarks>
    public sealed partial class App
    {
        /// <summary>
        /// Initializes the singleton application object.  
        /// This is the first line of authored code executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        /// <remarks>The Application Insights is initilized here too.</remarks>
        public App()
        {
            Microsoft.ApplicationInsights.WindowsAppInitializer.InitializeAsync(
                Microsoft.ApplicationInsights.WindowsCollectors.Metadata |
                Microsoft.ApplicationInsights.WindowsCollectors.Session);

            InitializeComponent();
        }

        /// <summary>
        /// Using the navigation service redirects for the first page.
        /// </summary>
        /// <param name="args">Information of when an app is launched.</param>
        /// <returns>Returns a task based in a null object.</returns>
        protected override Task OnLaunchApplicationAsync(LaunchActivatedEventArgs args)
        {
            NavigationService.Navigate("Main", null);

            return Task.FromResult<object>(null);
        }
    }
}