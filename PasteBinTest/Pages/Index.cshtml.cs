using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PasteBinTest.Data;
using PasteBinTest.Models;

namespace PasteBinTest.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        [BindProperty]
        public string NewText { get; set; }

        public List<TextModel> TextList { get; set; } = new List<TextModel>();

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            TextList = _context.TextFragmentsDb.ToList();
        }

        public IActionResult OnPost()
        {
            if (!string.IsNullOrWhiteSpace(NewText))
            {
                TextModel newTextModel = new TextModel();
                newTextModel.Text = NewText;
                _context.TextFragmentsDb.Add(newTextModel);
                _context.SaveChanges();
                TextList = _context.TextFragmentsDb.ToList();
                ModelState.Clear();
                NewText = string.Empty;
            }
            return RedirectToPage();
        }
    }
}