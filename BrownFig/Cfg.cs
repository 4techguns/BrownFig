namespace BrownFig
{
    /// <summary>
    /// An enum that can control whether interaction commands get 
    /// deployed to the test guild dictated in the config, or globally.
    /// </summary>
    public enum CommandDeployTarget
    {
        Guild,
        Global
    }

    /// <summary>
    /// The base structure for the configuration file.
    /// </summary>
    public struct Cfg
    {
        /// <summary>
        /// The bot's token, which is required to log into Discord.
        /// </summary>
        public string Token { get; set; }
        /// <summary>
        /// The command prefix for traditional commands. If using slash commands, this is not needed.
        /// </summary>
        public string? CommandPrefix { get; set; }
        /// <summary>
        /// The test guild to deploy commands to if <see cref="DeployTarget"/> is set to <see cref="CommandDeployTarget.Guild"/>.
        /// </summary>
        public ulong? TestGuildId { get; set; }
        public CommandDeployTarget? DeployTarget { get; set; }
    }
}
