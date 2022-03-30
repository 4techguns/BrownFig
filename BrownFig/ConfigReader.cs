using Newtonsoft.Json;

namespace BrownFig.JSON
{
    /// <summary>
    /// A class for reading JSON configurations.
    /// </summary>
    public static class ConfigReaderJSON
    {
        /// <summary>
        /// Gets a configuration object from a JSON file.
        /// </summary>
        /// <param name="filename">The name of the file.</param>
        /// <returns>A configuration object</returns>
        public static Cfg GetCfgFromJSONFile(string filename)
            => JsonConvert.DeserializeObject<Cfg>(File.ReadAllText(filename));

        /// <summary>
        /// Gets a configuration object from a JSON string.
        /// </summary>
        /// <param name="json">The JSON string.</param>
        /// <returns>A configuration object</returns>
        public static Cfg GetCfgFromJSON(string json)
            => JsonConvert.DeserializeObject<Cfg>(json);
    }
}
