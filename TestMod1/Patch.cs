using HarmonyLib;

namespace InfiniteStamina;

public class InfiniteStaminaPatch
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(WildSkies.Player.LocalPlayer), "Awake")]
    static bool InfiniteStamina(WildSkies.Player.LocalPlayer __instance)
    {
        __instance._staminaController._infiniteStaminaEnabled = true;
        return true;
    }
}