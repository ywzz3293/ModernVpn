using ModernVpn.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ModernVpn.MVVM.ViewModel
{
    internal class MainViewModel:ObservableObject 
    {
        /*Command*/
        public RelayCommand MoveWindowsCommand { get; set; }
        public RelayCommand ShutDownWindowsCommand { get; set; }
        public RelayCommand MaximizeWindowsCommand { get; set; }
        public RelayCommand MinimizeWindowsCommand { get; set; }

        public RelayCommand ShowProtetionView {  get; set; }
        public RelayCommand ShowSettingsView {  get; set; }

        private object _currentView;
        public object CurrentView 
        {
            get { return _currentView; }
            set { _currentView = value;
                OnPropetychanged();
            }
        }

        public ProtectionViewModel ProtectionVM { get; set; }
        public SettingsViewModel SettingsVM { get; set; }

        public MainViewModel()
        {
            ProtectionVM = new ProtectionViewModel();
            SettingsVM = new SettingsViewModel();
            CurrentView = ProtectionVM;

            Application.Current.MainWindow.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
            MoveWindowsCommand = new RelayCommand(o => { Application.Current.MainWindow.DragMove(); });
            ShutDownWindowsCommand = new RelayCommand(o => { Application.Current.Shutdown(); });
            MaximizeWindowsCommand = new RelayCommand(o => 
            {
                if(Application.Current.MainWindow.WindowState == WindowState.Maximized)
                {
                    Application.Current.MainWindow.WindowState = WindowState.Normal;
                }
                else
                {
                    Application.Current.MainWindow.WindowState = WindowState.Maximized;
                }
                
            });

            MinimizeWindowsCommand = new RelayCommand(o => { Application.Current.MainWindow.WindowState = WindowState.Minimized ; });
        
            ShowProtetionView = new RelayCommand(o => { CurrentView = ProtectionVM; });
            ShowSettingsView = new RelayCommand(o => { CurrentView = SettingsVM; });
        }
    }
}
