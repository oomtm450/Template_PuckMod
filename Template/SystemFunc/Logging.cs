﻿using oomtm450PuckMod_Template.Configs;
using UnityEngine;

namespace oomtm450PuckMod_Template.SystemFunc {
    internal class Logging {
        /// <summary>
        /// Function that logs information to the debug console.
        /// </summary>
        /// <param name="msg">String, message to log.</param>
        /// <param name="config">IConfig, config to use to check if info must be logged.</param>
        /// <param name="bypassConfig">Bool, true to bypass the logs config. False by default.</param>
        internal static void Log(string msg, IConfig config, bool bypassConfig = false) {
            if (bypassConfig || (ServerFunc.IsDedicatedServer() && config.LogInfo) || (!ServerFunc.IsDedicatedServer() && config.LogInfo))
                Debug.Log($"[{Constants.MOD_NAME}] {msg}");
        }

        /// <summary>
        /// Function that logs errors to the debug console.
        /// </summary>
        /// <param name="msg">String, message to log.</param>
        internal static void LogError(string msg) {
            Debug.LogError($"[{Constants.MOD_NAME}] {msg}");
        }
    }
}
