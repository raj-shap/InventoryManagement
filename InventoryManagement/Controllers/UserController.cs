using InventoryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace InventoryManagement.Controllers
{
	public class UserController : Controller
	{
		private string _Baseurl = "https://localhost:7129/api/User";
		private HttpClient client = new HttpClient();
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public IActionResult Login()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Login(Login login)
		{
			string url = $"{_Baseurl}/Login";
			string data = JsonConvert.SerializeObject(login);
			StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
			HttpResponseMessage response = client.PostAsync(url, content).Result;
			if(response.IsSuccessStatusCode)
			{
				TempData["Login_Message"] = "Login Successfully...";
				return RedirectToAction("Index", "Home");
			}
			return View();
		}
	}
}
