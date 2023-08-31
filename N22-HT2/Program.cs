//review - biror service / narsa uchun berilgan fikr
//star - review dagi yulduzlar bilan baholash usuli ( 1 dan 5 gacha ) 
//message - review ga yozilgan xabar, tushuntirish

//- IReview interfeysdan foydalaning ( id, star, message )
//-Review modelidan foydalaning(id, star, message ) -IReview ni implement qilsin
//- CrashReport modelidan foydalaning ( id, star, message, screenshot ) -IReview ni implement qilsin

//IReviewList<TReview> interfeysidan foydalaning, TReview ga IReview bilan constraint qo'ying

//unda quyidagi methodlar bo'lsin

//- Add ( review ) -reviewni reviewlar kolleksiyasiga qo'shsin
//- Update ( id, star, message ) -review ni update qilsin
//- Remove ( id ) -review ni kolleksiyadan o'chirsin
//- Remove ( review ) -kolleksiyadan berilgan review ni id bo'yicha qidirib, topilsa o'chirsin
//- GetReview ( id ) -reviewni id bo'yicha topib qaytarsin, bo'lmasa null qaytarsin
//- GetReview ( message ) -review ni message bo'yicha topib qaytarsin, bo'lmasa null qaytarsin
//- GetOverallReview - review lar bo'yicha umumiy xulosa ni string da chiqarsin

//ReviewList<TReview> modelidan foydalaning, unda IReviewList<TReview> ni impleemnt qiling
//bunda GetOverallReview bunday ishlashi kerak : 

//agar
//- reviewlar soni 0 bo'lsa - "Be the first to leave a review for this product"
//- reviewlar barchasi 5 star bo'lsa - "Great news! All reviews for this product are 5-star ratings."
//- agar reviewlar orasida 1 star bo'lsa - o'sha reviewdagi message chiqsin

//- dasturda ReviewList<TReview> dan object yarating
//- GetOverallReview dan foydalanib ko'ring
//- bir nechta Review va CrashReport dan object yaratib qo'shing
//- ekranga id bo'yicha va message bo'yicha qidiirib ko'rib chiqaring
//- bitta review ni update qiling
//- yana GetOverallReview dan foydalanib ko'ring

//PS : CrashReport da screenshot image fayl ga bo'lgan yo'l ( path ) ni saqlashligi kerak, bo'sh string qilib ketilsa ham bo'ladi

using N22_HT2.Models;

var dastur = new ReviewList<Review>();

Console.WriteLine(dastur.GetOverallReview());

var dastur2 = new CrashReport(1, 5, "aaa", "a");
var dastur3 = new Review(2, 3, "sdvb");

dastur.Add(dastur3);
dastur.Add(new Review(3, 3, "dfg"));
dastur.Add(new Review(4, 5, "sdfg"));
dastur.Add(new Review(5, 1, "ertyu"));


Console.WriteLine(dastur.GetReview(3).Massage);

dastur.Update(2, 5, "awerstdfjgkhf");

Console.WriteLine(dastur.GetOverallReview());






