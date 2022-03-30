using Newtonsoft.Json;

namespace BrownFig.Generation
{
    /// <summary>
    /// A utility class for generating configurations.
    /// </summary>
    public static partial class ConfigurationGen
    {
        /// <summary>
        /// Generates a configuration object from the provided parameters.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="prefix"></param>
        /// <param name="testguildid"></param>
        /// <param name="deployTarget"></param>
        /// <returns>A <see cref="Cfg"/> object from the parameters.</returns>
        public static Cfg GenConfig(string token, string? prefix = null,
            ulong? testguildid = null, CommandDeployTarget? deployTarget = null) => new Cfg
            {
                Token = token,
                CommandPrefix = prefix,
                DeployTarget = deployTarget,
                TestGuildId = testguildid
            };

        /// <summary>
        /// Converts a <see cref="Cfg"/> instance into a JSON file.
        /// </summary>
        /// <param name="filename">The file to write to</param>
        /// <param name="config">The configuration object to generate from</param>
        public static void CfgToJSON(string filename, Cfg config)
            => File.WriteAllText(filename,
                JsonConvert.SerializeObject(config));
    }
}