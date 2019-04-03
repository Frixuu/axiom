﻿/* ----------------------------------------------------------------------
Axiom UI
Copyright (C) 2017-2019 Matt McManis
https://github.com/MattMcManis/Axiom
https://axiomui.github.io
mattmcmanis@outlook.com

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.If not, see <http://www.gnu.org/licenses/>. 
---------------------------------------------------------------------- */

using Axiom.Properties;
using System;
// Disable XML Comment warnings
#pragma warning disable 1591

namespace Axiom
{
    public class Configure
    {
        // --------------------------------------------------------------------------------------------------------
        // Variables
        // --------------------------------------------------------------------------------------------------------
        public static string theme; // Set Theme
        public static string threads; // Set FFmpeg -threads
        public static string maxthreads; // All CPU Threads


        /// <summary>
        ///     Load FFmpeg Path
        /// </summary>
        public static void LoadFFmpegPath(ViewModel vm)
        {
            // --------------------------------------------------
            // Safeguard Against Corrupt Saved Settings
            // --------------------------------------------------
            try
            {
                // --------------------------
                // First time use
                // --------------------------
                if (string.IsNullOrEmpty(Settings.Default.FFmpegPath))
                {
                    // Set ComboBox if Configure Window is Open
                    vm.FFmpegPath_Text = "<auto>";

                    // Save for next launch
                    Settings.Default.FFmpegPath = vm.FFmpegPath_Text;
                    Settings.Default.Save();
                }
                // --------------------------
                // Load Saved Settings Override
                // --------------------------
                else if (!string.IsNullOrEmpty(Settings.Default.FFmpegPath)) // null check
                {
                    // Set ComboBox if Configure Window is Open
                    vm.FFmpegPath_Text = Settings.Default.FFmpegPath;
                }
            }
            catch
            {

            }
        }


        /// <summary>
        ///     Load FFprobe Path
        /// </summary>
        public static void LoadFFprobePath(ViewModel vm)
        {
            // --------------------------------------------------
            // Safeguard Against Corrupt Saved Settings
            // --------------------------------------------------
            try
            {
                // --------------------------
                // First time use
                // --------------------------
                if (string.IsNullOrEmpty(Settings.Default.FFprobePath))
                {
                    // Set ComboBox if Configure Window is Open
                    vm.FFprobePath_Text = "<auto>";

                    // Save for next launch
                    Settings.Default.FFprobePath = vm.FFprobePath_Text;
                    Settings.Default.Save();
                }
                // --------------------------
                // Load Saved Settings Override
                // --------------------------
                else if (!string.IsNullOrEmpty(Settings.Default.FFprobePath)) // null check
                {
                    // Set ComboBox if Configure Window is Open
                    vm.FFprobePath_Text = Settings.Default.FFprobePath;
                }
            }
            catch
            {

            }
        }


        /// <summary>
        ///     Load FFplay Path
        /// </summary>
        public static void LoadFFplayPath(ViewModel vm)
        {
            // --------------------------------------------------
            // Safeguard Against Corrupt Saved Settings
            // --------------------------------------------------
            try
            {
                // --------------------------
                // First time use
                // --------------------------
                if (string.IsNullOrEmpty(Settings.Default.FFplayPath))
                {
                    // Set ComboBox if Configure Window is Open
                    vm.FFplayPath_Text = "<auto>";

                    // Save for next launch
                    Settings.Default.FFplayPath = vm.FFplayPath_Text;
                    Settings.Default.Save();
                }
                // --------------------------
                // Load Saved Settings Override
                // --------------------------
                else if (!string.IsNullOrEmpty(Settings.Default.FFplayPath)) // null check
                {
                    // Set ComboBox if Configure Window is Open
                    vm.FFplayPath_Text = Settings.Default.FFplayPath;
                }
            }
            catch
            {

            }
        }


        /// <summary>
        ///     Load youtubedl Path
        /// </summary>
        public static void LoadyoutubedlPath(ViewModel vm)
        {
            // --------------------------------------------------
            // Safeguard Against Corrupt Saved Settings
            // --------------------------------------------------
            try
            {
                // --------------------------
                // First time use
                // --------------------------
                if (string.IsNullOrEmpty(Settings.Default.youtubedlPath))
                {
                    // Set ComboBox if Configure Window is Open
                    vm.youtubedlPath_Text = "<auto>";

                    // Save for next launch
                    Settings.Default.youtubedlPath = vm.youtubedlPath_Text;
                    Settings.Default.Save();
                }
                // --------------------------
                // Load Saved Settings Override
                // --------------------------
                else if (!string.IsNullOrEmpty(Settings.Default.youtubedlPath)) // null check
                {
                    // Set ComboBox if Configure Window is Open
                    vm.youtubedlPath_Text = Settings.Default.youtubedlPath;
                }
            }
            catch
            {

            }
        }


        /// <summary>
        ///     Load Log Checkbox
        /// </summary>
        public static void LoadLogCheckbox(ViewModel vm)
        {
            // --------------------------------------------------
            // Safeguard Against Corrupt Saved Settings
            // --------------------------------------------------
            try
            {
                // --------------------------
                // First time use
                // --------------------------
                if (string.IsNullOrEmpty(Convert.ToString(Settings.Default.Log_IsChecked)))
                {
                    // Set ComboBox if Configure Window is Open
                    vm.LogCheckBox_IsChecked = false;

                    // Save for next launch
                    Settings.Default.Log_IsChecked = false;
                    Settings.Default.Save();
                }
                // --------------------------
                // Load Saved Settings Override
                // --------------------------
                else if (!string.IsNullOrEmpty(Convert.ToString(Settings.Default.Log_IsChecked)))
                {
                    // Set ComboBox if Configure Window is Open
                    vm.LogCheckBox_IsChecked = Convert.ToBoolean(Settings.Default.Log_IsChecked);
                }
            }
            catch
            {

            }
        }


        /// <summary>
        ///     Load Log Path
        /// </summary>
        public static void LoadLogPath(ViewModel vm)
        {
            // --------------------------------------------------
            // Safeguard Against Corrupt Saved Settings
            // --------------------------------------------------
            try
            {
                // --------------------------
                // First time use
                // --------------------------
                if (string.IsNullOrEmpty(Settings.Default.LogPath))
                {
                    //logPath = string.Empty;

                    // Set ComboBox if Configure Window is Open
                    vm.LogPath_Text = string.Empty;

                    // Save for next launch
                    Settings.Default.LogPath = vm.LogPath_Text;
                    Settings.Default.Save();
                }
                // --------------------------
                // Load Saved Settings Override
                // --------------------------
                if (!string.IsNullOrEmpty(Settings.Default.LogPath)) // null check
                {
                    // Set ComboBox if Configure Window is Open
                    vm.LogPath_Text = Settings.Default.LogPath;
                }
            }
            catch
            {

            }
        }


        /// <summary>
        ///     Load Threads
        /// </summary>
        public static void LoadThreads(ViewModel vm)
        {
            // --------------------------------------------------
            // Safeguard Against Corrupt Saved Settings
            // --------------------------------------------------
            try
            {
                // --------------------------
                // First time use
                // --------------------------
                if (string.IsNullOrEmpty(Settings.Default.Threads))
                {
                    threads = "optimal";

                    // Set ComboBox if Configure Window is Open
                    vm.Threads_SelectedItem = threads;

                    // Save for next launch
                    Settings.Default.Threads = threads;
                    Settings.Default.Save();
                }
                // --------------------------
                // Load Saved Settings Override
                // --------------------------
                else if (!string.IsNullOrEmpty(Settings.Default.Threads)) // null check
                {
                    threads = Settings.Default.Threads;

                    // Set ComboBox if Configure Window is Open
                    vm.Threads_SelectedItem = Settings.Default.Threads;
                }
            }
            catch
            {

            }
        }



        // --------------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------------
        // Control Methods
        // --------------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------------

        // --------------------------------------------------
        // FFmpeg Folder Browser Dialog
        // --------------------------------------------------
        public static void FFmpegFolderBrowser(ViewModel vm) 
        {
            var OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            System.Windows.Forms.DialogResult result = OpenFileDialog.ShowDialog();

            // Popup Folder Browse Window
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                // Display Folder Path in Textbox
                vm.FFmpegPath_Text = OpenFileDialog.FileName;

                // Save 7-zip Path for next launch
                Settings.Default.FFmpegPath = vm.FFmpegPath_Text;
                Settings.Default.Save();
                Settings.Default.Reload();
            }
        }


        // --------------------------------------------------
        // FFprobe Folder Browser Dialog
        // --------------------------------------------------
        public static void FFprobeFolderBrowser(ViewModel vm)
        {
            var OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            System.Windows.Forms.DialogResult result = OpenFileDialog.ShowDialog();

            // Popup Folder Browse Window
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                // Display Folder Path in Textbox
                vm.FFprobePath_Text = OpenFileDialog.FileName;

                // Save WinRAR Path for next launch
                Settings.Default.FFprobePath = vm.FFprobePath_Text;
                Settings.Default.Save();
                Settings.Default.Reload();
            }
        }


        // --------------------------------------------------
        // FFplay Folder Browser Dialog
        // --------------------------------------------------
        public static void FFplayFolderBrowser(ViewModel vm) // Method
        {
            var OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            System.Windows.Forms.DialogResult result = OpenFileDialog.ShowDialog();

            // Popup Folder Browse Window
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                // Display Folder Path in Textbox
                vm.FFplayPath_Text = OpenFileDialog.FileName;

                // Save WinRAR Path for next launch
                Settings.Default.FFplayPath = vm.FFplayPath_Text;
                Settings.Default.Save();
                Settings.Default.Reload();
            }
        }


        // --------------------------------------------------
        // youtube-dl Folder Browser Dialog
        // --------------------------------------------------
        public static void youtubedlFolderBrowser(ViewModel vm)
        {
            var OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            System.Windows.Forms.DialogResult result = OpenFileDialog.ShowDialog();

            // Popup Folder Browse Window
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                // Display Folder Path in Textbox
                vm.youtubedlPath_Text = OpenFileDialog.FileName;

                // Save 7-zip Path for next launch
                Settings.Default.youtubedlPath = vm.youtubedlPath_Text;
                Settings.Default.Save();
                Settings.Default.Reload();
            }
        }


        // --------------------------------------------------
        // Log Folder Browser Dialog 
        // --------------------------------------------------
        public static void LogFolderBrowser(ViewModel vm) // Method
        {
            var folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            System.Windows.Forms.DialogResult result = folderBrowserDialog.ShowDialog();

            // Popup Folder Browse Window
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                // Display Folder Path in Textbox
                vm.LogPath_Text = folderBrowserDialog.SelectedPath;

                // Add backslash if missing
                vm.LogPath_Text = vm.LogPath_Text.TrimEnd('\\') + @"\";

                // Save FFmpeg Path for next launch
                Settings.Default.LogPath = vm.LogPath_Text;
                Settings.Default.Save();
                Settings.Default.Reload();
            }
        }


    }
}