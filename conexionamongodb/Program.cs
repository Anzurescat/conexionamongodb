// See https://aka.ms/new-console-template for more information
using MongoDB.Driver;

MongoClient cliente = new MongoClient("mongodb://localhost");
MongoServer mongo = cliente.GetServer();
var dbs = mongo.GetDatabaseNames();
foreach (var dbsName in dbs)
{
    Console.WriteLine(dbsName);
}

Console.WriteLine("Hello, World!");
