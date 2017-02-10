using MvvmCross.Core.ViewModels;

namespace SampleTabs.Core.ViewModels
{
    public class ChildViewModel : MvxViewModel
    {
        public ChildViewModel(string name)
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
    }
}