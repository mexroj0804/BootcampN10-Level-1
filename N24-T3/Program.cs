//-Movie modelidan foydalaning(name, author, rating )
//-MovieService servisidan foydalaning 

//unda quyidagi methodlar bo'lsin
//- Search ( searchKeyword ) -kinolarni avtori va nomi bo'yicha filter qilib qaytarsin
//- Add ( name, author, rating ) -kinoni xuddi shu nomda va avtorda yo'q ekanligini tekshirib qo'shsin
//- GetByRating - kinolarni rating bo'yicha saralab qaytarsin

//- MovieService dan object yarating - unga kinolarni qo'shing
//- kinolarni rating bo'yicha ekranga chiqaring


using N24_T3;

var dastur = new MovieService();

dastur.Search("Eternal Echoes");