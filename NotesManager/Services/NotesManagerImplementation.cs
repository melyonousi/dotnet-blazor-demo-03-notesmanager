
using Microsoft.EntityFrameworkCore;
using NotesManager.Models;

namespace NotesManager.Services
{
    public class NotesManagerImplementation : INotesManager
    {
        private readonly DataContext _dataContext;
        public NotesManagerImplementation(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<Note> AddNote(Note _note)
        {
            if (_note == null)
            {
                return null!;
            }
            _note.CreatedAt = DateTime.UtcNow;
            await _dataContext.AddAsync(_note);
            await _dataContext.SaveChangesAsync();
            return _note;
        }

        public async Task<Note> DeleteNote(int _Id)
        {
            var _note = await _dataContext.Notes.FindAsync(_Id);
            if (_note == null)
            {
                return null!;
            }

            _dataContext.Remove(_note);
            await _dataContext.SaveChangesAsync();

            return _note;
        }

        public async Task<Note> GetNote(int _Id)
        {
            var _note = await _dataContext.Notes.FindAsync(_Id);

            if (_note == null)
            {
                return null!;
            }

            return _note;
        }

        public async Task<List<Note>> GetNotes()
        {
            return await _dataContext.Notes.ToListAsync();
        }

        public async Task<Note> UpdateNote(Note _note)
        {
            var note = await _dataContext.Notes.FindAsync(_note.Id);

            if (note == null)
            {
                return null!;
            }

            note.Title = _note.Title;
            note.Description = _note.Description;
            await _dataContext.SaveChangesAsync();

            return note;
        }
    }
}
