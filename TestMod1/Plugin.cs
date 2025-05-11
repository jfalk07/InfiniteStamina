using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;

namespace InfiniteStamina;

[BepInPlugin("org.minemuffin.plugins.InfiniteStamina", "Infinite Stamina", "0.0.3")]
public class InfiniteStaminaPlugin : BasePlugin
{
    internal static new ManualLogSource Log;

    public override void Load()
    {
        Harmony harmony = new Harmony("minemuffin.InfiniteStamina");
        harmony.PatchAll(typeof(InfiniteStaminaPatch));
        
        Log = base.Log;
        Log.LogInfo($"Plugin org.minemuffin.plugins.InfiniteStamina is loaded!");
    }
}