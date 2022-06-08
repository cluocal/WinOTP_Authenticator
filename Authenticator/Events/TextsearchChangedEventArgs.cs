using Domain;
using Domain.Storage;
using System;

namespace Authenticator.Events
{
    public class TextsearchChangedEventArgs : EventArgs
    {
        public String textQuery;

        public TextsearchChangedEventArgs(String textQuery)
        {
            this.textQuery = textQuery;
        }
    }
}
