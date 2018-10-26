

using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

[ApiController]
public class NotesController {
    private readonly NoteContext _context;

    public NotesController(NoteContext context)
    {
        _context = context;
    }
    public IEnumerable<Note> Get() => _context.Notes;

}