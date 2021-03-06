// ModSettings
// 
// File:    ModSettings.cs
// Project: ModSettings

using BepInEx;
using HarmonyLib;
using ModSettings.GUI;

namespace ModSettings
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    [BepInDependency(Jotunn.Main.ModGuid, "2.7.2")]
    internal class Main : BaseUnityPlugin
    {
        public const string PluginGUID = "com.jotunn.modsettings";
        public const string PluginName = "ModSettings";
        public const string PluginVersion = "0.0.1";
        
        internal static Main Instance;
        internal static Harmony Harmony;

        private void Awake()
        {
            Instance = this;
            Harmony = new Harmony(PluginGUID);
            InGameConfig.Init();
        }
    }
}