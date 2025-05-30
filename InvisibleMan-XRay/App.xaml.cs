﻿using System;
using System.Windows;
using Microsoft.Win32;

namespace InvisibleManXRay
{
    using Managers;
    using Handlers;
    using Factories;

    public partial class App : Application
    {
        private AppManager appManager;
        private WindowFactory windowFactory;

        protected override void OnStartup(StartupEventArgs e)
        {
            InitializeAppManager();
            InitializeNotifyIcon();
            InitializeWindowFactory();
            InitializeMainWindow();
            HandlePipes();
            HandleExitingEvents();

            void InitializeAppManager()
            {
                appManager = new AppManager(e.Args);
                appManager.Initialize();
            }

            void InitializeNotifyIcon()
            {
                appManager.HandlersManager.GetHandler<NotifyHandler>().InitializeNotifyIcon();
            }

            void InitializeWindowFactory()
            {
                windowFactory = appManager.WindowFactory;
            }

            void InitializeMainWindow()
            {
                MainWindow mainWindow = windowFactory.CreateMainWindow();
                mainWindow.Show();
            }

            void HandlePipes()
            {
                if (IsThereAnyArg())
                    PipeManager.SignalThisApp(e.Args);
                
                PipeManager.ListenForPipes();
            }

            void HandleExitingEvents()
            {
                AppDomain.CurrentDomain.ProcessExit += (sender, e) => CleanupBeforeExit();
                SystemEvents.SessionEnded += (sender, e) => CleanupBeforeExit();
            }

            bool IsThereAnyArg() => e.Args.Length != 0;
        }

        protected override void OnExit(ExitEventArgs e)
        {
            AppDomain.CurrentDomain.ProcessExit -= (sender, e) => CleanupBeforeExit();
            SystemEvents.SessionEnded -= (sender, e) => CleanupBeforeExit();

            base.OnExit(e);
        }

        void CleanupBeforeExit()
        {
            appManager.Core.DisableMode();
        }
    }
}
