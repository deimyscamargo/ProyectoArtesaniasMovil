using Newtonsoft.Json;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BasesDeDatosLocales
{


    internal class ApiService<E>
    {

        private HttpClient _httpClient;
        private string URL;

        public ApiService(string URL)
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://192.168.101.73:3000"); // URL base de la API

            this.URL = URL;
        }
        public async Task<List<E>> Get()
        {
            try
            {
                var response = await _httpClient.GetAsync(URL);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<E>>(content);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exepcion> " + ex.Message);
            }

            return null;

        }

        public async Task<E> GetByID(string id)
        {

            try
            {
                var response = await _httpClient.GetAsync("/" + URL + "/" + id);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<E>(content);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exepcion> " + ex.Message);
            }

            return default(E);

        }

        public async Task<bool> Post(E model)
        {

            try
            {
                var json = JsonConvert.SerializeObject(model);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync(URL, content);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exepcion> " + ex.Message);
                return false;
            }

        }

        public async Task<String> PostResponse(E model)
        {

            try
            {
                var json = JsonConvert.SerializeObject(model);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync(URL, content);
                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exepcion> " + ex.Message);
                return null;
            }

        }

        public async Task<bool> Put(string id, E model)
        {

            try
            {
                var json = JsonConvert.SerializeObject(model);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await _httpClient.PutAsync($"{URL}/{id}", content);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exepcion> " + ex.Message);
                return false;
            }

        }

        public async Task<bool> Delete(string id)
        {

            try
            {
                var response = await _httpClient.DeleteAsync($"{URL}/{id}");
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exepcion> " + ex.Message);
                return false;

            }

        }


    }
}

/*
git add BasesDeDatosLocales/BasesDeDatosLocales/paginaFotoP.xaml
git add BasesDeDatosLocales/BasesDeDatosLocales/paginaFotoP.xaml.cs
*/
