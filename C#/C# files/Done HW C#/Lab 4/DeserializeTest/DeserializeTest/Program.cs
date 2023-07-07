using System.Net;
using DeserializeTest;
using Newtonsoft.Json;

List<Iserializable> people = new()
{
    new Person()
    {
        Name = "Aykhan",
        Surname = "Zeynalov",
        Age = 18
    },
    new Person()
    {
        Name = "Omar",
        Surname = "Haciyev",
        Age = 20
    }
};

SerializationService.Serialize(people);




using var fs = new FileStream("data.json", FileMode.OpenOrCreate);
using var sr = new StreamReader(fs);

var a = SerializationService.Deserialize(sr.ReadToEnd()) ;

