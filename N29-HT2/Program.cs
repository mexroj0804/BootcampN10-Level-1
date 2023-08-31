using N29_HT2.Models;
using N29_HT2.Services;

var employee= new Employee("Mexroj", "Xaybullayev", "mexrojhaybullayev0804@gmail.com");
var service = new EmployeeService();
await service.HireAsync(employee);