﻿using OrganizerTasks1.Model;

namespace OrganizerTask1.UI.ViewModels
{
    public class NoteViewModel : ViewModelBase
    {
        private readonly Note _note;

        public NoteViewModel(Note note)
        {
            _note = note;
        }

        public string Name
        {
            get { return _note.Name; }
            set
            {
                _note.Name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Description
        {
            get { return _note.Description; }
            set
            {
                _note.Description = value;
                OnPropertyChanged("Description");
            }
        }
    }
}