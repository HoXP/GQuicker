﻿using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GQuicker
{
    public delegate void HotkeyEventHandler(int HotKeyID);
    public class Hotkey : IMessageFilter
    {
        Hashtable keyIDs = new Hashtable();
        IntPtr hWnd;
        static public int HKShowHideMain;
        static public int HKHideMain;
        public event HotkeyEventHandler OnHotkey;
        public enum KeyFlags
        {
            MOD_ALT = 0x1,
            MOD_CONTROL = 0x2,
            MOD_SHIFT = 0x4,
            MOD_WIN = 0x8
        }
        [DllImport("user32.dll")]
        public static extern uint RegisterHotKey(IntPtr hWnd, uint id, uint fsModifiers, uint vk);
        [DllImport("user32.dll")]
        public static extern uint UnregisterHotKey(IntPtr hWnd, uint id);
        [DllImport("kernel32.dll")]
        public static extern uint GlobalAddAtom(string lpString);
        [DllImport("kernel32.dll")]
        public static extern uint GlobalDeleteAtom(uint nAtom);
        public Hotkey(IntPtr hWnd)
        {
            this.hWnd = hWnd;
            Application.AddMessageFilter(this);
        }
        public int RegisterHotkey(Keys Key, KeyFlags keyflags)
        {
            uint hotkeyid = GlobalAddAtom(Guid.NewGuid().ToString());
            RegisterHotKey(hWnd, hotkeyid, (uint)keyflags, (uint)Key);
            keyIDs.Add(hotkeyid, hotkeyid);
            return (int)hotkeyid;
        }
        public void UnRegisterHotkey(int hotkeyid)
        {
            uint key = (uint)hotkeyid;
            UnregisterHotKey(hWnd, key);
            GlobalDeleteAtom(key);
            keyIDs.Remove(key);
        }
        public void UnregisterHotkeys()
        {
            Application.RemoveMessageFilter(this);
            foreach (uint key in keyIDs.Values)
            {
                UnregisterHotKey(hWnd, key);
                GlobalDeleteAtom(key);
            }
        }
        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == 0x312)
            {
                if (OnHotkey != null)
                {
                    foreach (uint key in keyIDs.Values)
                    {
                        if ((uint)m.WParam == key)
                        {
                            OnHotkey((int)m.WParam);
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}