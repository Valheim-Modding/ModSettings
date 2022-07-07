// ModSettings
// 
// File:    ModSettings.cs
// Project: ModSettings

using BepInEx;
using HarmonyLib;
using Jotunn.Entities;
using Jotunn.Managers;
using ModSettings.GUI;

namespace ModSettings
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    [BepInDependency(Jotunn.Main.ModGuid)]
    internal class Main : BaseUnityPlugin
    {
        public const string PluginGUID = "com.jotunn.modsettings";
        public const string PluginName = "ModSettings";
        public const string PluginVersion = "0.0.1";
        
        internal static Main Instance;
        internal static Harmony Harmony;
        internal static CustomLocalization Localization = LocalizationManager.Instance.GetLocalization();

        private void Awake()
        {
            Instance = this;
            Harmony = new Harmony(PluginGUID);
            InGameConfig.Init();
        }
    }
}

