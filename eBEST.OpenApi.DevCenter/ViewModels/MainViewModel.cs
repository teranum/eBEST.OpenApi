using App.Helpers;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace eBEST.OpenApi.DevCenter.ViewModels
{
    internal partial class MainViewModel : ObservableObject
    {

        [ObservableProperty] string _title = "eBEST OpenApi DevCenter";
        [ObservableProperty] string _statusText = "Ready";
        [ObservableProperty] GridLength _tabTreeWidth;

        [ObservableProperty] GridLength _tabListHeight;

        [ObservableProperty] GridLength _propertyWidth;
        private readonly IAppRegistry _appRegistry;
        private readonly Window _mainWindow;

        public MainViewModel(IAppRegistry appRegistry)
        {
            _appRegistry = appRegistry;
            _mainWindow = Application.Current.MainWindow;

            // 메인 윈도우 설정값 로딩
            string session = _mainWindow.GetType().Name;
            int Left = _appRegistry.GetValue(session, "Left", 0);
            int Top = _appRegistry.GetValue(session, "Top", 0);
            int Width = _appRegistry.GetValue(session, "Width", 1250);
            int Height = _appRegistry.GetValue(session, "Height", 760);

            TabTreeWidth = new(_appRegistry.GetValue(session, nameof(TabTreeWidth), 410));
            TabListHeight = new(_appRegistry.GetValue(session, nameof(TabListHeight), 150));
            PropertyWidth = new(_appRegistry.GetValue(session, nameof(PropertyWidth), 270));

            if (Left != 0) _mainWindow.Left = Left;
            if (Top != 0) _mainWindow.Top = Top;
            if (Width != 0) _mainWindow.Width = Width;
            if (Height != 0) _mainWindow.Height = Height;

            _mainWindow.Closed += (s, e) =>
            {
                _appRegistry.SetValue(session, "Left", (int)_mainWindow!.Left);
                _appRegistry.SetValue(session, "Top", (int)_mainWindow.Top);
                _appRegistry.SetValue(session, "Width", (int)_mainWindow.Width);
                _appRegistry.SetValue(session, "Height", (int)_mainWindow.Height);

                _appRegistry.SetValue(session, nameof(TabTreeWidth), (int)TabTreeWidth.Value);
                _appRegistry.SetValue(session, nameof(TabListHeight), (int)TabListHeight.Value);
                _appRegistry.SetValue(session, nameof(PropertyWidth), (int)PropertyWidth.Value);

                //SaveToolsData();
            };
        }
        // 메뉴
        [RelayCommand] void MenuLogin() { }
        [RelayCommand] void MenuLogout() { }
        [RelayCommand] void MenuExit() => System.Windows.Application.Current.Shutdown();
        [RelayCommand] void MenuCustomize(string customName) { }
    }
}
