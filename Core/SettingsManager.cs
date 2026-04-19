using System;
using System.IO;
using Newtonsoft.Json;
using AshX.Core;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace AshX
{
    public static class SettingsManager
    {
        private static readonly string FilePath = "settings.json";

        public static void Save()
        {
            var data = new
            {
                Enabled = MirrorEngineStatic.Enabled,
                DelayEnabled = MirrorEngineStatic.DelayEnabled,
                DelayMs = MirrorEngineStatic.DelayMs,
                BlockChat = MirrorEngineStatic.BlockChat,
                MainHandle = WindowManagerStatic.MainHandle.ToInt64(),
                SecondHandle = WindowManagerStatic.SecondHandle.ToInt64(),
                BlockedKeys = BlockedKeyService.UserBlocked
            };

            string json = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }


        public static void Load()
        {
            if (!File.Exists(FilePath))
                return;

            string json = File.ReadAllText(FilePath);
            dynamic data = JsonConvert.DeserializeObject(json);

            MirrorEngineStatic.Enabled = data.Enabled;
            MirrorEngineStatic.DelayEnabled = data.DelayEnabled;
            MirrorEngineStatic.DelayMs = data.DelayMs;
            MirrorEngineStatic.BlockChat = data.BlockChat;

            WindowManagerStatic.MainHandle = new IntPtr((long)data.MainHandle);
            WindowManagerStatic.SecondHandle = new IntPtr((long)data.SecondHandle);

            BlockedKeyService.UserBlocked.Clear();
            foreach (var item in data.BlockedKeys)
                BlockedKeyService.UserBlocked.Add((Keys)item);
        }
    }
}
