//-masala logikasini alohida class library projectga(N14 - HT2 - CL)
//- ishlash jarayonini esa console projectga yozing
//- class libraryni asosiy dasturga ulang ( Project -> Add Project Reference -> N14-HT2-CL )

//-davomat uchun ClassroomAttendance service dan foydalaning - service internal bo 'lsin
//- unda davmoatni ekranga chiqaruvchi public Display methodi bo'lsin
//- o'quvchilar protected bo'lgan dictionary da saqlansin
//- o'quvchilarni belgilash uchun Mark methodi bo'lsin - fullname va true/false qiymatli isPresent parameterlari bo'lsin
//- true/false qiymatni true -> present, false -> absent string qiymatga o'giring
//- internal protected bo 'lgan GetStats methodi bo'lsin - unda darsda nechta o'quvchi qatnashganligi foizda hisoblansin 

//- UltimateClassroomAttendance servisdan foydalaning
//- unda Mark methodiga overload bo'lsin - fullname, isPresent, cause paramterlari bo'lsin, cause - optional parameter
//- bunda dictionaryga fullname, isPresent ( absent / present qiymatda + cause ) qilib qo'shilsin
//- Display methodini override qiling va unda parentdagi Display methodini chaqiring va GetStats dan foydalanib, ekranga qatnashganlik foizini chiqaring

//- console projectda UltimateClassroomAttendance dan object olib, 5 ta o'quvchi keldi/kelmadi va sababi bilan qo'shing
//- display methodi orqali ekraga chiqaring

ClassroomAttendance dastur = new ClassroomAttendance();
internal class ClassroomAttendance
{
}