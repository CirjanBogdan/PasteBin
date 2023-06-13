using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PasteBinTest.Data;
using PasteBinTest.Models;

namespace PasteBinTest.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public TextModel TextFragment { get; set; }

        public DetailsModel(ApplicationDbContext context)
        {
            _context = context;   
        }
        public void OnGet(int id)
        {
            TextFragment = _context.TextFragmentsDb.FirstOrDefault(TextFragment => TextFragment.Id == id);

        }
    }
}
