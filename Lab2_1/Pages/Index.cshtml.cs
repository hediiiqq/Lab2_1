using Microsoft.AspNetCore.Mvc.RazorPages;


namespace Lab2_1.Pages;

public class IndexModel : PageModel
{
    public string FullName { get; set; } = "Гусев Никита Сергеевич";
    public string FutureJob { get; set; } = "Разработчик ПО";
    public string University { get; set; } = "Ярославский Государственный Технический Институт";
    public string Group { get; set; } = "Зцис - 26";
    public string ShortDescription { get; set; } = "Я учусь в университете, изучаю основы программирования, алгоритмы и веб-разработку. В будущем хочу стать специалистом в сфере IT.";



    public void OnGet()
    {
    }
}