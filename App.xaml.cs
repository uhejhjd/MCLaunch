using System.Configuration;
using System.Data;
using System.Windows;
using Flurl;
using Flurl.Http;
using MinecraftLaunch;
using MinecraftLaunch.Base.Enums;
using MinecraftLaunch.Base.Models;
using MinecraftLaunch.Base.Models.Game;
using MinecraftLaunch.Base.Models.Network;
using MinecraftLaunch.Components.Authenticator;
using MinecraftLaunch.Components.Downloader;
using MinecraftLaunch.Components.Installer;
using MinecraftLaunch.Components.Logging;
using MinecraftLaunch.Components.Parser;
using MinecraftLaunch.Extensions;
using MinecraftLaunch.Launch;
using MinecraftLaunch.Utilities;
using System;
using System.Diagnostics;
using System.Threading;
using Panuon.WPF.UI;
InitializeHelper.Initialize(settings =>
{
    settings.MaxThread = 256;
    settings.MaxFragment = 128;
    settings.MaxRetryCount = 4;
    settings.IsEnableMirror = false;
    settings.IsEnableFragment = false;
    //settings.CurseForgeApiKey = "Your Curseforge API";
    settings.UserAgent = "MLTest/1.0";
});
namespace MCLaunch
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
    }

}
