﻿using Cosmos.System.Graphics;
using SphereOS.Gui.Apps;
using SphereOS.Logging;
using System.Collections.Generic;
using System.Drawing;

namespace SphereOS.Gui
{
    internal static class AppManager
    {
        internal static List<App> Apps { get; private set; } = new List<App>();

        private static bool appsLoaded = false;

        internal static Bitmap DefaultAppIcon
        {
            get
            {
                return Icons.Icon_Default;
            }
        }

        private static class Icons
        {
            [IL2CPU.API.Attribs.ManifestResourceStream(ResourceName = "SphereOS.Gui.Resources.AppIcons.Default.bmp")]
            private static byte[] _iconBytes_Default;
            internal static Bitmap Icon_Default = new Bitmap(_iconBytes_Default);

            [IL2CPU.API.Attribs.ManifestResourceStream(ResourceName = "SphereOS.Gui.Resources.AppIcons.Info.bmp")]
            private static byte[] _iconBytes_Info;
            internal static Bitmap Icon_Info = new Bitmap(_iconBytes_Info);

            [IL2CPU.API.Attribs.ManifestResourceStream(ResourceName = "SphereOS.Gui.Resources.AppIcons.Settings.bmp")]
            private static byte[] _iconBytes_Settings;
            internal static Bitmap Icon_Settings = new Bitmap(_iconBytes_Settings);

            [IL2CPU.API.Attribs.ManifestResourceStream(ResourceName = "SphereOS.Gui.Resources.AppIcons.Clock.bmp")]
            private static byte[] _iconBytes_Clock;
            internal static Bitmap Icon_Clock = new Bitmap(_iconBytes_Clock);

            [IL2CPU.API.Attribs.ManifestResourceStream(ResourceName = "SphereOS.Gui.Resources.AppIcons.Tasks.bmp")]
            private static byte[] _iconBytes_Tasks;
            internal static Bitmap Icon_Tasks = new Bitmap(_iconBytes_Tasks);

            [IL2CPU.API.Attribs.ManifestResourceStream(ResourceName = "SphereOS.Gui.Resources.AppIcons.Calculator.bmp")]
            private static byte[] _iconBytes_Calculator;
            internal static Bitmap Icon_Calculator = new Bitmap(_iconBytes_Calculator);

            [IL2CPU.API.Attribs.ManifestResourceStream(ResourceName = "SphereOS.Gui.Resources.AppIcons.CodeStudio.bmp")]
            private static byte[] _iconBytes_CodeStudio;
            internal static Bitmap Icon_CodeStudio = new Bitmap(_iconBytes_CodeStudio);

            [IL2CPU.API.Attribs.ManifestResourceStream(ResourceName = "SphereOS.Gui.Resources.AppIcons.Notepad.bmp")]
            private static byte[] _iconBytes_Notepad;
            internal static Bitmap Icon_Notepad = new Bitmap(_iconBytes_Notepad);

            [IL2CPU.API.Attribs.ManifestResourceStream(ResourceName = "SphereOS.Gui.Resources.AppIcons.Calendar.bmp")]
            private static byte[] _iconBytes_Calendar;
            internal static Bitmap Icon_Calendar = new Bitmap(_iconBytes_Calendar);

            [IL2CPU.API.Attribs.ManifestResourceStream(ResourceName = "SphereOS.Gui.Resources.AppIcons.Files.bmp")]
            private static byte[] _iconBytes_Files;
            internal static Bitmap Icon_Files = new Bitmap(_iconBytes_Files);

            [IL2CPU.API.Attribs.ManifestResourceStream(ResourceName = "SphereOS.Gui.Resources.AppIcons.Logs.bmp")]
            private static byte[] _iconBytes_Logs;
            internal static Bitmap Icon_Logs = new Bitmap(_iconBytes_Logs);

            [IL2CPU.API.Attribs.ManifestResourceStream(ResourceName = "SphereOS.Gui.Resources.AppIcons.DemoLauncher.bmp")]
            private static byte[] _iconBytes_DemoLauncher;
            internal static Bitmap Icon_DemoLauncher = new Bitmap(_iconBytes_DemoLauncher);
        }

        internal static void RegisterApp(App app)
        {
            Apps.Add(app);
        }

        internal static void LoadAllApps()
        {
            if (appsLoaded)
            {
                return;
            }

            RegisterApp(new App("Files", () => { return new Files(); }, Icons.Icon_Files, Color.FromArgb(25, 84, 97)));
            RegisterApp(new App("Clock", () => { return new Clock(); }, Icons.Icon_Clock, Color.FromArgb(168, 55, 47)));
            RegisterApp(new App("Notepad", () => { return new Notepad(); }, Icons.Icon_Notepad, Color.FromArgb(14, 59, 76)));
            RegisterApp(new App("Settings", () => { return new Settings(); }, Icons.Icon_Settings, Color.FromArgb(0, 115, 186)));
            RegisterApp(new App("Tasks", () => { return new Tasks(); }, Icons.Icon_Tasks, Color.FromArgb(204, 241, 255)));
            RegisterApp(new App("Calculator", () => { return new Calculator(); }, Icons.Icon_Calculator, Color.FromArgb(0, 115, 186)));
            RegisterApp(new App("CodeStudio", () => { return new Apps.CodeStudio.CodeStudio(); }, Icons.Icon_CodeStudio, Color.FromArgb(127, 0, 255)));
            RegisterApp(new App("Calendar", () => { return new Calendar(); }, Icons.Icon_Calendar, Color.FromArgb(168, 55, 47)));
            RegisterApp(new App("Event Log", () => { return new Logs(); }, Icons.Icon_Logs, Color.FromArgb(14, 59, 76)));
            RegisterApp(new App("Demos", () => { return new DemoLauncher(); }, Icons.Icon_DemoLauncher, Color.FromArgb(14, 59, 76)));

            Log.Info("AppManager", $"{Apps.Count} apps were registered.");

            appsLoaded = true;
        }
    }
}
