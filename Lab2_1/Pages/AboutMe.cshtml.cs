using Lab2_1.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Lab2_1.Pages;

public class AboutModel : PageModel
{
    ApplicationContext context;

    public AboutModel(ApplicationContext db)
    {
        context = db;
    }

    public string University { get; set; } = "Ярославский Государственный Технический Институт";
    public string Group { get; set; } = "Зцис - 26";
    public string Direction { get; set; } = "Информационные системы и технологии";


    public string[] FavoriteMusicGenres { get; set; } = new string[]
    {
        "Jungle",
        "Pop",
        "Amen Break",
        "Rap"
    };


    public List<string> Hobbies { get; private set; } = new();
    public List<string> Achievements { get; private set; } = new();

    public void OnGet()
    {
        var profile = context.Profiles.AsNoTracking().FirstOrDefault();

        Hobbies = profile?.Hobbies ?? new List<string>();
        Achievements = profile?.Achievements ?? new List<string>();
    }
}
