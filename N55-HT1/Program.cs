﻿using N55_HT1.Services;

var fileService = new FileService();

Console.WriteLine($"Fayllar soni : {fileService.GetFilesCount(Directory.GetCurrentDirectory())}");

Console.WriteLine($"Folderlar soni : {fileService.GetDirectoriesCount(Directory.GetCurrentDirectory())}");

Console.WriteLine("Umumiy fayllar hajmi : " + fileService.GetTotalSize(Directory.GetCurrentDirectory()));

Console.WriteLine($"Eng katta fayl hajmi : {fileService.GetBiggestFile(Directory.GetCurrentDirectory())}");