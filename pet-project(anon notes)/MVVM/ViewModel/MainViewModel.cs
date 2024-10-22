using System;

using anonotes.Core;

namespace pet_project_anon_notes_.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand FeaturesViewCommand { get; set; }

        public FeaturesViewModel FeaturesVM { get; set; }

        public HomeViewModel HomeVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM=new HomeViewModel();
            FeaturesVM=new FeaturesViewModel();
            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o => { CurrentView = HomeVM; });
            FeaturesViewCommand = new RelayCommand(o => { CurrentView = FeaturesVM; });
        }
    }
}
