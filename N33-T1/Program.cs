//FileManagementServiceBase abstract service dan foydalaning
//unda quyidagi methodlar bo'lsin
//- ReadAsync ( filePath ) -berilgan filedagi ma'lumotlarni o'qib return qilsin ( string )
//-WriteAsync(filePath, data) - berilgan faylga yozsin

//JsonFileManagementService sealed serivcedan foydalaning
//-ReadAsync(filePath) - override qiling, fayl extension ".json" bo'lmasa InvalidOperationException
//- WriteAsync ( filePath, data ) - override qiling, fayl extension ".json" bo'lmasa InvalidOperationException
//- ReadAsync<T> ( filePath ) -berilgan fayldan ma'lumotni o'qib berilgan tipga o'girib qaytarsin