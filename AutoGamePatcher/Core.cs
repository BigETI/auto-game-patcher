using MetroFramework;
using MetroFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AutoGamePatcher
{
    public static class Core
    {

        public static IEnumerable<Control> GetSelfAndChildrenRecursive(Control parent)
        {
            List<Control> controls = new List<Control>();
            foreach (Control child in parent.Controls)
                controls.AddRange(GetSelfAndChildrenRecursive(child));
            controls.Add(parent);
            return controls;
        }

        private static void SetTheme(Control parent, MetroThemeStyle theme, MetroColorStyle style)
        {
            if (parent is IMetroControl)
            {
                ((IMetroControl)parent).Theme = theme;
                ((IMetroControl)parent).Style = style;
                parent.Refresh();
            }
            else if (parent is IMetroComponent)
            {
                ((IMetroComponent)parent).Theme = theme;
                ((IMetroComponent)parent).Style = style;
                parent.Refresh();
            }
            else if (parent is IMetroForm)
            {
                ((IMetroForm)parent).Theme = theme;
                ((IMetroForm)parent).Style = style;
                parent.Refresh();
            }
        }

        public static void LoadThemeAndStyle(Control parent)
        {
            MetroThemeStyle theme = Properties.Settings.Default.UseTheme;
            MetroColorStyle style = Properties.Settings.Default.UseStyle;
            IEnumerable<Control> controls = GetSelfAndChildrenRecursive(parent);
            foreach (Control c in controls)
                SetTheme(c, theme, style);
        }

        public static void LoadReversedTheme(Control parent)
        {
            MetroThemeStyle theme = (Properties.Settings.Default.UseTheme == MetroThemeStyle.Dark) ? MetroThemeStyle.Light : MetroThemeStyle.Dark;
            MetroColorStyle style = Properties.Settings.Default.UseStyle;
            IEnumerable<Control> controls = GetSelfAndChildrenRecursive(parent);
            foreach (Control c in controls)
                SetTheme(c, theme, style);
        }

        /*public static string RelativePath(string rootPath, string relatePath)
        {
            string[] absDirs = rootPath.Split('\\');
            string[] relDirs = relatePath.Split('\\');
            int len = absDirs.Length < relDirs.Length ? absDirs.Length : relDirs.Length;
            int lastCommonRoot = -1; int index;
            for (index = 0; index < len; index++)
            {
                if (absDirs[index] == relDirs[index])
                    lastCommonRoot = index;
                else
                    break;
            }
            if (lastCommonRoot == -1)
                throw new ArgumentException("Paths do not have a common base");
            StringBuilder relativePath = new StringBuilder();
            for (index = lastCommonRoot + 1; index < absDirs.Length; index++)
            {
                if (absDirs[index].Length > 0)
                    relativePath.Append("..\\");
            }
            for (index = lastCommonRoot + 1; index < relDirs.Length - 1; index++)
                relativePath.Append(relDirs[index] + "\\");
            relativePath.Append(relDirs[relDirs.Length - 1]);
            return relativePath.ToString();
        }*/

        public static string ReplacePath(string sourcePath, string rootPath, string replaceWith)
        {
            string ret = sourcePath;
            rootPath = AddLastChar(rootPath, '\\');
            if (ret.StartsWith(rootPath))
                ret = AddLastChar(replaceWith, '\\') + ret.Substring(rootPath.Length);
            return ret;
        }

        public static string AddLastChar(string str, char c)
        {
            string ret = str;
            if (ret.Length > 0)
            {
                if (ret[ret.Length - 1] != c)
                    ret += c;
            }
            return ret;
        }

        public static void EnumToComboBox<T>(ComboBox comboBox, T[] exclusions = null)
        {
            comboBox.Items.Clear();
            Array arr = Enum.GetValues(typeof(T));
            foreach (var e in arr)
            {
                bool s = true;
                if (exclusions != null)
                {
                    foreach (var ex in exclusions)
                    {
                        if (ex.Equals(e))
                        {
                            s = false;
                            break;
                        }
                    }
                }
                if (s)
                    comboBox.Items.Add(e);
            }
        }

        public static void ArrayToComboBox<T>(ComboBox comboBox, T[] arr)
        {
            comboBox.Items.Clear();
            foreach (var e in arr)
                comboBox.Items.Add(e);
        }
    }
}
