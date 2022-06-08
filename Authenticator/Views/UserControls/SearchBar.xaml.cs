using Domain.Utilities;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Authenticator.Events;

namespace Authenticator.Views.UserControls
{
    public sealed partial class SearchBar : UserControl
    {
        public SearchBar()
        {
            InitializeComponent();
        }

        public event EventHandler<TextsearchChangedEventArgs> SearchQuery;

        private void searchBox_QuerySubmitted(SearchBox sender, SearchBoxQuerySubmittedEventArgs args)
        {
            SearchQuery.Invoke(this, new TextsearchChangedEventArgs(sender.QueryText));
        }
    }
}
