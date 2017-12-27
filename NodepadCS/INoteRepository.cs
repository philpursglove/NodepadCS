using System.Collections.Generic;
using NodepadCS.Models;

namespace NodepadCS
{
    public interface INoteRepository
    {
        List<Note> GetAll();
        Note Get(string id);
        void Create(Note note);
        void Update(Note note);

    }
}