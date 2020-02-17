using AutoMapper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DemoLibrary
{
    public class JsonFile
    {
        public DependencyDto ReadJsonFile()
        {
            //Initialising the automapper
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<MyJsonType, DependencyDto>();
            });
            IMapper mapper = new Mapper(config);

            var myJsonString = File.ReadAllText("configureDependency.json");
            var myJsonObject = JsonConvert.DeserializeObject<MyJsonType>(myJsonString);


            //Mappping the json to Tdestination
            var destDto = mapper.Map<MyJsonType, DependencyDto>(myJsonObject);

            Console.WriteLine(myJsonObject.InterfaceNames.First());
            return destDto;

        }
    }
}
