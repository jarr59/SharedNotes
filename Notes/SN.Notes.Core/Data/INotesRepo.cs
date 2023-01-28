using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SN.Notes.Core.Data
{
    public interface INotesRepo
    {
        /// <summary>
        /// Add note
        /// </summary>
        /// <param name="note"></param>
        /// <returns></returns>
        Task AddAsync(Note note);

        /// <summary>
        /// Get note by id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<Note> GetByIdAsync(string Id, string UserId);

        /// <summary>
        /// Get all notes by user
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        Task<List<Note>> GetAllAsync(string UserId);

        /// <summary>
        /// Remove a list of notes 
        /// </summary>
        /// <param name="notes"></param>
        void Remove(List<Note> notes);

        /// <summary>
        /// Save memory changes 
        /// </summary>
        /// <returns></returns>
        Task SaveChanges();
    }
}
