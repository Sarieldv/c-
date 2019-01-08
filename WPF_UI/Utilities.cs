﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_UI
{
    public static class Utilities
    {
        public static bool IsLetter(char a)
        {
            if (((int)a > 64 && (int)a < 91) || ((int)a > 96 && (int)a < 123) || (int)a == 32)
            {
                return true;
            }
            return false;
        }
        public static bool IsWords(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (!IsLetter(str[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsNumber(char c)
        {
            if ((int)c > 47 && (int)c < 58)
            {
                return true;
            }
            return false;
        }
        public static bool IsStringNumbers(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (!IsNumber(str[i]))
                    return false;
            }
            return true;
        }
        public static string ToProper(string str)
        {
            string s = str[0].ToString().ToUpper();
            for (int i = 1; i < str.Length; i++)
            {
                s += str[i].ToString().ToLower();
            }
            return s;
        }
        public static void ErrorBox(string str)
        {
            MessageBox.Show(str, "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }
        public static void InformationBox(string str)
        {
            MessageBox.Show(str, "", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
