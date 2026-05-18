using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace Lab2_1.Pages;

public class Contact : PageModel
{
    public string Email { get; set; } = "mgus7900@gmail.com";
    public string Phone { get; set; } = "+7 962 212 33 63";
    public string TelegramLink { get; set; } = "https://t.me/Gazalini";
    [BindProperty]
    public string PostName { get; set; } = string.Empty;
    [BindProperty]
    public string PostPhone { get; set; } = string.Empty;
    [BindProperty]
    public string PostMessage { get; set; } = string.Empty;
    public string Message { get; private set; } = "";
    public void OnPost()
    {
        if (!string.IsNullOrEmpty(PostName))
            Message = $"Спасибо за сообщение {PostName}";
    }
    public void OnGet()
    {}
}