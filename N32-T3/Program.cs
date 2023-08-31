//Product modelidan foydalaning ( id, name, description )
//-bunda id init-only bo'lsin
//- name va description read-only bo'lsin ( private set )
//- name va descriptino getter methodi ichida name va description ni validate
//                  qiling ( regex dan foydalanish ixtiyoriy, is null or white space yetarli )
//-parameterized constructorda name va description bo'lsin
//- copy constructor orqali Product ni copy qiladigan qiling

//- Product modelidan bir nechta object yarating ( valid va invalid )
//-Singleton pattern ishlatilgan ProductService ni yarating
//- unda Add methodi bo'lsin ( name, description ), agar product yaratishda
//                  exception bo'lsa konsolga exception chiqsin
//- unda Clone methodi bo'lsin ( id ) - u product ni topib, copy qilinganini kolleksiyaga qo'shib qo'ysin
//- unda Display methodi hamma productlarni ekranga chiqarsin

//- ProductService dan instance oling, valid invalid modellar qo'shib, Clone methodi orqali
//                  clonelar qilib, ekranga chiqaring

using N32_T3.Services;

var service = ProductService.GetInstance();
service.Add(1, "aa", "bb");
service.Add(2, "aaa", "bbb");
service.Add(1, "aaaa", "bbbb");
service.Display();