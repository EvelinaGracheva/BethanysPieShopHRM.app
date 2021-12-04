using BethanysPieShopHRM.Shared;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.app.Services
{
    public class EmployeeDataService : IEmployeeDataService
    {
        private readonly HttpClient _httpClient;

        public EmployeeDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<Employee> AddEmployee(Employee employee)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteEmployee(int employeeId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Employee>>
                (await _httpClient.GetStreamAsync($"api/employee"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<Employee> GetEmployeeDetails(int employeeId)
        {
            return await JsonSerializer.DeserializeAsync<Employee>
                (await _httpClient.GetStreamAsync($"api/employee/{employeeId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public Task UpdateEmployee(Employee employee)
        {
            throw new System.NotImplementedException();
        }
    }
}
