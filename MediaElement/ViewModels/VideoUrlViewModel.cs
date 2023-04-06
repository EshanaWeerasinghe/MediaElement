using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MediaElement.ViewModels
{
    public class VideoUrlViewModel : INotifyPropertyChanged
    {

        private HtmlWebViewSource _webViewSource;

        public HtmlWebViewSource WebViewSource
        {
            //get
            //{
            //    return new HtmlWebViewSource { Html = Flag.Description };
            //}
            get => _webViewSource;
            set
            {
                if (_webViewSource != value) { }
                _webViewSource = value;
                OnPropertyChanged();
            }
        }

        public VideoUrlViewModel()
        {
            _webViewSource = new HtmlWebViewSource();

           // string vidUrl = "https://www.youtube.com/embed/qu0HN9rYtIw";

            string htmlContent = @"<![CDATA[
                <HTML>
                <BODY>
               <iframe width=""956"" height=""538"" src=""https://www.youtube.com/embed/qu0HN9rYtIw"" 
                title="""" frameborder=""0"" 
                allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share"" 
                allowfullscreen></iframe>
                </BODY>
                </HTML>
                ]]>";

            WebViewSource.Html = htmlContent;
        }

        protected bool SetProperty<T>(ref T backingStore, T value,
          [CallerMemberName] string propertyName = "",
          Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}