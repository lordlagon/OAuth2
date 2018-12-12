using Newtonsoft.Json;
using OAuth2.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace OAuth2.Services
{
    public class ApiServices
    {
        public async Task<bool> RegisterAsync(string email, string password, string confirmPassword)
        {
            try
            {
                var client = new HttpClient();
                var model = new RegisterBindingModel
                {
                    Email = email,
                    Password = password,
                    ConfirmPassword = confirmPassword
                };

                var json = JsonConvert.SerializeObject(model);
                HttpContent content = new StringContent(json);

                var response = await client.PostAsync("http://localhost:50540/api/Account/Register", content);

                return response.IsSuccessStatusCode;
            }
            catch (Exception e)
            {
                 throw;
            }
            
        }
    }
}
