using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Generator.Plugins;
using TechTalk.SpecFlow.Infrastructure;
using TechTalk.SpecFlow.UnitTestProvider;

namespace MyPlugin.SpecflowPlugin
{

    public class MyGeneratorPlugin : IGeneratorPlugin
    {
        public void Initialize(GeneratorPluginEvents generatorPluginEvents, GeneratorPluginParameters generatorPluginParameters, UnitTestProviderConfiguration unitTestProviderConfiguration)
        {
            Console.WriteLine("Dummy Plugin Initialized!");
        }
    }
}
