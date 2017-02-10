namespace SampleTabs.Droid
{
    using Android.App;
    using Android.Views;
    using Android.Widget;
    using System.Collections.Specialized;
    using System.Windows.Input;

    /// <summary>
    /// Defines the LinkerPleaseInclude type.
    /// This class is never actually executed, but when Xamarin linking is enabled it does how to 
    /// ensure types and properties are preserved in the deployed app. 
    /// </summary>
    public class LinkerPleaseInclude
    {
        public void Include(Button button)
        {
            button.Click += (s, e) => button.Text = button.Text + "";
        }

        public void Include(CheckBox checkBox)
        {
            checkBox.CheckedChange += (sender, args) => checkBox.Checked = !checkBox.Checked;
        }

        public void Include(View view)
        {
            view.Click += (s, e) => view.ContentDescription = view.ContentDescription + "";
            view.Visibility = view.Visibility - 1;
        }

        public void Include(TextView text)
        {
            text.TextChanged += (sender, args) => text.Text = string.Empty + text.Text;
            text.AfterTextChanged += (sender, args) => text.Text = "" + text.Text;
            text.Hint = "" + text.Hint;
            text.Click += (s, e) => text.Text = text.Text + "";
        }

        public void Include(CheckedTextView text)
        {
            text.TextChanged += (sender, args) => text.Text = "" + text.Text;
            text.Hint = "" + text.Hint;
        }

        public void Include(CompoundButton cb)
        {
            cb.CheckedChange += (sender, args) => cb.Checked = !cb.Checked;
        }

        public void Include(SeekBar sb)
        {
            sb.ProgressChanged += (sender, args) => sb.Progress = sb.Progress + 1;
        }

        public void Include(RatingBar rb)
        {
            rb.Visibility = rb.Visibility - 1;
            rb.Rating = rb.Rating + 1;
            rb.RatingBarChange += (sender, args) => rb.Rating = rb.Rating + 1;
        }

        public void Include(Activity act)
        {
            act.Title = act.Title + "";
        }

        public void Include(INotifyCollectionChanged changed)
        {
            changed.CollectionChanged += (s, e) => {
                var test = $"{e.Action}{e.NewItems}{e.NewStartingIndex}{e.OldItems}{e.OldStartingIndex}";
            };
        }

        public void Include(ICommand command)
        {
            command.CanExecuteChanged += (s, e) => { if (command.CanExecute(null)) command.Execute(null); };
        }

        public void Include(MvvmCross.Platform.IoC.MvxPropertyInjector injector)
        {
            injector = new MvvmCross.Platform.IoC.MvxPropertyInjector();
        }

        public void Include(System.ComponentModel.INotifyPropertyChanged changed)
        {
            changed.PropertyChanged += (sender, e) =>
            {
                var test = e.PropertyName;
            };
        }
    }
}