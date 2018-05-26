using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPersonalTutorial.App_Start
{
    public class AutomapperConfig
    {
        public static void Configure()
        {
            var assemblyNames = new[]
            {
                "MyPersonalTutorial",
                "DatabaseLayer"
            };

            Mapper.Initialize(cfg =>
            {
                cfg.AddProfiles(assemblyNames);
            });

        }
    }
}