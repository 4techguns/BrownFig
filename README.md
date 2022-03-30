# BrownFig
An opinionated and simple Discord bot configuration framework, designed for my Discord bots<br />
***NOTE: This is not really intended for actual use by consumers. It has a fixed configuration class and is mainly only designed for managing configuration of my Discord bots. But, if you want to contribute, feel free to do so!***

# Getting started
To get started with this framework, it's as easy as installing a NuGet package.

You can either use `dotnet package add`, or manage packages via Visual Studio's NuGet Package Manager.

## Installing the package via Visual Studio
First, right-click on the Dependencies node in your project, and then click `Manage NuGet Packages`.
<br />![image](https://user-images.githubusercontent.com/42378704/160911879-b3a5c321-28ad-4c34-9955-a3d00508d6bb.png)<br />
Then, go to the Browse tab, then type BrownFig into the search box.
<br />![image](https://user-images.githubusercontent.com/42378704/160912247-a4d2270c-6420-4d36-b920-57ac98bf27ad.png)<br />
Finally, install the package!
<br />![image](https://user-images.githubusercontent.com/42378704/160912341-6bed0a28-cc08-433b-a8a3-4884f9ceb411.png)<br />

## Using the framework
It's surprisingly simple!
For example, if you wanted a configuration generated for your Discord bot, you would do something like this:
```cs
using BrownFig;
using BrownFig.Generation;
using BrownFig.JSON.Generation;

namespace MyAwesomeBot.ConfigurationGenerator;

public class Program
{
  public static void Main(string[] args)
  {
    // Hard-coding your token in a config generator is impractical 
    // if you're open-sourcing your bot, and it may be a good idea 
    // to pass the token as a command line argument instead
    
    // If you're planning on using slash commands, it may be a good
    // idea to also pass the test guild ID as an argument as well
    Cfg conf = new() { 
      Token = "PlaceTokenHere", 
      // The below arguments are optional, and you may not need some of them depending on how you're implementing commands in your Discord bot.
      CommandPrefix = "!",
      TestGuildId = 0,
      DeployTarget = CommandDeployTarget.Global
    }
    
    ConfigurationGen.CfgToJSON("BotConfiguration.json", conf);
  }
}

```

Then, to fetch this configuration from somewhere else in your app, call `ConfigReaderJSON.GetCfgFromJSONFile("BotConfiguration.json");`.
