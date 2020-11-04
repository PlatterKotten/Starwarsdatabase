using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace Swapi
{
    public class RestService
    {
        HttpClient _client;
        public string url { get; set; }
        public RestService()
        {

            url = Constants.swApiURL;
            _client = new HttpClient();



        }
        public async Task<Movie> GetMovie(string url)
        {

            Movie item = new Movie();
            try
            {

                HttpResponseMessage response = await _client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    var items = JsonConvert.DeserializeObject<Movie>(content);
                    item = items;
                }

            }
            catch (Exception ex) { }
            return item;
        }
        public async Task<List<Movie>> GetMovies(string url)
        {

           List<Movie> items = new List<Movie>();
            try
            {

                HttpResponseMessage response = await _client.GetAsync(url + "films");
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    var movies = JsonConvert.DeserializeObject<Movies>(content);
                    items = movies.results;

                }

            }
            catch (Exception ex) { }
            return items;
        }
       
        public async Task<People>GetCharacter(string url) 
        {


            People character = new People();
             try
            {
                HttpResponseMessage response = await _client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    var people = JsonConvert.DeserializeObject<People>(content);
                    character = people;

                }
            }
            catch (Exception ex) 
            {

                throw;
            }
            return character;
        }
       
        public async Task<Planet> GetPlanets(string url)
        {


            Planet planet = new Planet();
            try
            {
                HttpResponseMessage response = await _client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    var planets = JsonConvert.DeserializeObject<Planet>(content);
                    planet = planets;

                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return planet;
        }
        public async Task<Starships> GetStarships(string url)
        {


            Starships starship = new Starships();
            try
            {
                HttpResponseMessage response = await _client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    var starships = JsonConvert.DeserializeObject<Starships>(content);
                    starship = starships;

                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return starship;
        }
        public async Task<Vehicles> GetVehicles(string url)
        {


            Vehicles vehicle = new Vehicles();
            try
            {
                HttpResponseMessage response = await _client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    var vehicles = JsonConvert.DeserializeObject<Vehicles>(content);
                    vehicle = vehicles;

                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return vehicle;
        }
        public async Task<Species> GetSpecies(string url)
        {


            Species species = new Species();
            try
            {
                HttpResponseMessage response = await _client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    var Species = JsonConvert.DeserializeObject<Species>(content);
                    species = Species;

                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return species;
        }
       
    }
}
