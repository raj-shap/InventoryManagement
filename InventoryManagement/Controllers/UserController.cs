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
		[HttpGet]
		public IActionResult Registration()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Registration(Registration registration)
		{
			string url = $"{_Baseurl}/Registration";
            registration.dto_UserID = "string";
			//registration.dto_CreatedOn = DateTime.Now;
			//registration.dto_ModifiedOn = DateTime.Now;
			registration.dto_Role = "User";
			//registration.dto_CreatedBy = "User";
			registration.dto_CreatedBy = registration.dto_Name;
			registration.dto_ModifiedBy = "User";

			string data = JsonConvert.SerializeObject(registration);
			StringContent content = new StringContent(data, Encoding.UTF8, "application/json");

			HttpResponseMessage response = client.PostAsync(url, content).Result;

            if (response.IsSuccessStatusCode)
			{
				TempData["Registration_Message"] = "Registration Successfully...";
				return RedirectToAction("Index", "Home");
			}
			else
			{
                var errorMessage = await response.Content.ReadAsStringAsync();
				//string errorMessage = response.Content.ReadAsStringAsync().Result;
				//string errorMessage = response.Content.ReadAsStringAsync().Result;

				try
				{
					var error = JsonConvert.DeserializeObject<Dictionary<string, string>>(errorMessage);
					TempData["Registration_Error"] = string.Join(", ", error.Values);
					//dynamic errorDetails = JsonConvert.DeserializeObject<Registration>(errorMessage);

					//TempData["Registration_Error"] = errorDetails?.detail ?? "An error occured during registration.";
					//TempData["Registration_Error"] = errorMessage?? "An error occured during registration.";
					//TempData["Registration_Error"] = errorMessage;
				}
				catch
				{
					TempData["Registration_Error"] = "An error occured during registration.";
				}
				return View();
			}
		}
	}
}
