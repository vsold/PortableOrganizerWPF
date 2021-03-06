﻿using OrganizerTask1.UI.Misc;
using OrganizerTask1.UI.ViewModels.Interfaces;
using OrganizerTasks1.DAL;
using OrganizerTasks1.Model;

namespace OrganizerTask1.UI.ViewModels
{
    public class NotesViewModel : CollectionViewModel<NoteViewModel, Note>, INotesViewModel
    {
        public NotesViewModel(IDataProvider dataProvider, INotificationCenter notificationCenter)
            : base(dataProvider, notificationCenter)
        {
        }

        protected override NoteViewModel CreateViewModelEntity(Note data)
        {
            return new NoteViewModel(data);
        }
    }
}
