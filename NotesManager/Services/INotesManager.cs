using NotesManager.Models;

namespace NotesManager.Services
{
    public interface INotesManager
    {
        public Task<List<Note>> GetNotes();
        public Task<Note> GetNote(int Id);
        public Task<Note> DeleteNote(int Id);
        public Task<Note> AddNote(Note note);
        public Task<Note> UpdateNote(Note note);
    }
}
