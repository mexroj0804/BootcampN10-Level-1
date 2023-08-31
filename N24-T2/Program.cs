//KPI - Key Performance Indicator - xodim ishini baholosh tizimi, sonlarda 0 dan 100 gacha
//Salary - oylik maosh
//Pagination Pattern - juda ko'p elementli to'plamlarni qismlarga bo'lib uzatish usuli

//- Employee modelidan foydalaning - ( firstname, lastname, salary, kpi )
//-EmployeeService v foydalaning

//unda quyidagi methodlar bo'lsin

//- GetBySalary ( int pageSize, int pageToken ) -barcha xodimlarni oyligi kamayib borish tartibida qaytarsin, pageSize - elementlar soni, pageToken - elementlar pozitsiyasi

//- EmployeeService dan object yarating - konstruktorda employeelarni qo'shin,
//- ekranga xodimlarni chiqaring


using N24_T2;

var dastur = new EmployeeService();

dastur.GetBySalary(10, 0);