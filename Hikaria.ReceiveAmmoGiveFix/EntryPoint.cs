using BepInEx;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;

namespace Hikaria.ReceiveAmmoGiveFix
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.NAME, PluginInfo.VERSION)]
    public class EntryPoint : BasePlugin
    {
        public override void Load()
        {
            Instance = this;
            harmony = new(PluginInfo.GUID);
            harmony.PatchAll();
            Logs.LogMessage("OK");
        }

        public static EntryPoint Instance { get; private set; }

        private static Harmony harmony;
    }
}
