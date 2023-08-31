//-Blog modelidan foydalaning(id, title, body )
//-BlogService servisidan foydalaning

//unda CRUD methodlari quyidagi validationlar bilan bo'lsin
//- Create ( model ) -agar argumentdagi modelda xatolik bo'lsa - ValidationException
//- Get ( id ) -agar id bo'yicha topilmasa - ArgumentOutOfRangeException
//- Update ( model ) -agar argumentdagi model invalid bo'lsa - ValidationException, agar topilgan model invalid bo'lsa - InvalidOperationException
//- Delete ( id ) -agar model topilmasa - ArgumentOutOfRangeException

//PS : bunda ValidateOnCreate va ValidateOnUpdate private methodlaridan foydalanish mumkin

//- BlogService dagi collectionga konstruktorda bir necta modellar qo'shing
//- exceptionlarni asosiy main methodda barchasini try catch orqali ushlab, ekranga chiqaring



