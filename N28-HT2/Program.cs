using N28_HT2.Models;

var clonableList = new ClonableList<StorageFile>
{
    new StorageFile("aaa", "aaa dess", 68),
    new StorageFile("bbb", "bbb desc", 56),
    new StorageFile("ccc", "ccc desc", 95),
};

var clonedList = (ClonableList<StorageFile>)clonableList.Clone();

var firstItem = clonableList.First();
firstItem.Description = "other description ";

clonedList.ForEach(Console.WriteLine);