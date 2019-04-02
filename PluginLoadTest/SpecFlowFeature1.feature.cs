We could not find a data exchange file at the path TechTalk.SpecFlow.SpecFlowException: Missing [assembly:GeneratorPlugin] attribute in C:\Users\chrpabst\source\repos\PluginLoadTest\PluginLoadTest\bin\Debug\MyPlugin.SpecFlowPlugin.dll

Please open an issue at https://github.com/techtalk/SpecFlow/issues/
Complete output: 
TechTalk.SpecFlow.SpecFlowException: Missing [assembly:GeneratorPlugin] attribute in C:\Users\chrpabst\source\repos\PluginLoadTest\PluginLoadTest\bin\Debug\MyPlugin.SpecFlowPlugin.dll
   at TechTalk.SpecFlow.Generator.Plugins.GeneratorPluginLoader.LoadPlugin(PluginDescriptor pluginDescriptor)
   at TechTalk.SpecFlow.Generator.GeneratorContainerBuilder.<>c__DisplayClass3.<LoadPlugins>b__1(PluginDescriptor pd)
   at System.Linq.Enumerable.WhereSelectEnumerableIterator`2.MoveNext()
   at System.Linq.Enumerable.<ConcatIterator>d__59`1.MoveNext()
   at System.Linq.Buffer`1..ctor(IEnumerable`1 source)
   at System.Linq.Enumerable.ToArray[TSource](IEnumerable`1 source)
   at TechTalk.SpecFlow.Generator.GeneratorContainerBuilder.CreateContainer(SpecFlowConfigurationHolder configurationHolder, ProjectSettings projectSettings)
   at TechTalk.SpecFlow.Generator.TestGeneratorFactory.CreateGenerator(ProjectSettings projectSettings)
   at TechTalk.SpecFlow.VisualStudio.CodeBehindGenerator.Actions.GenerateTestFileAction.GenerateTestFile(GenerateTestFileParameters opts)



Command: c:\users\chrpabst\appdata\local\microsoft\visualstudio\15.0_0bca4cab\extensions\uob2eazz.cq5\TechTalk.SpecFlow.VisualStudio.CodeBehindGenerator.exe
Parameters: GenerateTestFile --featurefile C:\Users\chrpabst\AppData\Local\Temp\tmp8F3C.tmp --outputdirectory C:\Users\chrpabst\AppData\Local\Temp --projectsettingsfile C:\Users\chrpabst\AppData\Local\Temp\tmp8F2B.tmp
Working Directory: 
