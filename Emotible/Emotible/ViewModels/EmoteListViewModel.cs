﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emotible.Commands;

namespace Emotible.ViewModels
{
    public class EmoteListViewModel
    {
        private ObservableCollection<EmoteViewModel> emotesList;// = new ObservableCollection<object>();
        public ObservableCollection<EmoteViewModel> EmotesList {
            get { return emotesList; }
        }

        public EmoteListViewModel()
        {
            emotesList = new ObservableCollection<EmoteViewModel>();
            emotesList.Add(new EmoteViewModel() { Content = "Hello", OnClick = new CopyTextCommand() });
            emotesList.Add(new EmoteViewModel() { Content = "World", OnClick = new CopyTextCommand() });
        }
    }
}
