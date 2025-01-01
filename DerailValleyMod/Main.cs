using System;
using UnityModManagerNet;
using UnityEngine;

namespace DerailValleyMod
{
    public class Main
    {
        public static bool Load(UnityModManager.ModEntry modEntry)
        {
            // Logs section (pre-fixed with [MOD_ID] by UMM)
            modEntry.Logger.Log("Mod initialized!");

            // Subscribe to mod's update event
            modEntry.OnUpdate = OnUpdate;

            // Add additional setup here
            return true; // Return true if initialization is successful
        }

        private static void OnUpdate(UnityModManager.ModEntry modEntry, float deltaTime)
        {
            // This method is called every frame
            if (Input.GetKeyDown(KeyCode.F10))
            {
                modEntry.Logger.Log("F10 key pressed!");
            }
            
        }
    }
}
