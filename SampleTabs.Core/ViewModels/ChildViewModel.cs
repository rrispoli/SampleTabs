using System.Windows.Input;
using MvvmCross.Core.ViewModels;

namespace SampleTabs.Core.ViewModels
{
    public class ChildViewModel : MvxViewModel
    {
        public ChildViewModel(string name = "default")
        {
            Name = name;
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged(() => Name);
            }
        }

        public ICommand GoToChildCommand => new MvxCommand(() => ShowViewModel<ChildViewModel>());
    }
}