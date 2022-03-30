using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using BrownFig;
using BrownFig.Generation;
using BrownFig.JSON;
using System.IO;

namespace BrownFig.Tests
{
    [TestClass]
    public class GenerationTests
    {
        public Cfg conf = new Cfg
        {
            Token = "test",
            CommandPrefix = "!",
            TestGuildId = 0,
            DeployTarget = CommandDeployTarget.Global
        };

        [TestMethod]
        public void GenerateConfigFromParams()
        {
            Assert.AreEqual<Cfg>(conf, ConfigurationGen.GenConfig("test", "!", 0, CommandDeployTarget.Global));
        }

        [TestMethod]
        public void GenerateConfigIntoJSON()
        {
            ConfigurationGen.CfgToJSON("conf.json", conf);
            Assert.AreEqual(conf, ConfigReaderJSON.GetCfgFromJSONFile("conf.json"));
        }
    }
}