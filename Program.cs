// See https://aka.ms/new-console-template for more information

using EFDemo;
using System.Text.Json;
using AppDbContext dbContext = new AppDbContext();
Console.WriteLine("添加**************************************");
dbContext.DbTables.Add(new EFDemo.DbModels.DbTable { Id = 1, Name = "test", Value = "TestValue" });
dbContext.SaveChanges();

var dbdatas = dbContext.DbTables.ToList();
foreach (var item in dbdatas)
{
    Console.WriteLine(JsonSerializer.Serialize(item));
}
Console.WriteLine("修改**************************************");
var dbdata = dbContext.DbTables.FirstOrDefault(t => t.Id == 1);
dbdata.Name = "UpdateTest";
dbdata.Value = "UpdateValue";
dbContext.SaveChanges();

dbdatas = dbContext.DbTables.ToList();
foreach (var item in dbdatas)
{
    Console.WriteLine(JsonSerializer.Serialize(item));
}

Console.WriteLine("删除**************************************");
dbContext.DbTables.Remove(dbdata);
if (dbContext.SaveChanges()>0)
{
    Console.WriteLine("删除成功");
}

