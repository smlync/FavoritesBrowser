using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoritesBrowser.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        string _title = "Main Page";

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        bool _isActive = true;

        public bool IsActive
        {
            get { return _isActive; }
            set { SetProperty(ref _isActive, value); }
        }

        public DelegateCommand NavigateCommand { get; set; }

        public MainPageViewModel()
        {
            NavigateCommand = new DelegateCommand(Navigate).ObservesCanExecute((p) => IsActive);
        }

        private void Navigate()
        {
            throw new NotImplementedException();
        }

    }
}
