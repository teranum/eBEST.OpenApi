using System.Windows;

#if !NETCOREAPP
namespace System.Runtime.CompilerServices { internal class IsExternalInit { } }
#endif

namespace WpfSample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
    }

}
