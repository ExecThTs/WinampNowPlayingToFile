﻿using System;

namespace WinampNowPlayingToFile.Settings
{
    public interface ISettings
    {
        string NowPlayingFilename { get; set; }
        string NowPlayingTemplate { get; set; }

        event EventHandler SettingsUpdated;

        void Load();
        ISettings LoadDefaults();
        void Save();
    }
}