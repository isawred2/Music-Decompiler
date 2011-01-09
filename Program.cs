﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

using OpenTK.Audio;
using OpenTK.Audio.OpenAL;
using Mp3Sharp;

using MD.GUI;

namespace MD
{
    /// <summary>
    /// Main program interface.
    /// </summary>
    public static class Program
    {

        /// <summary>
        /// Program main entry point.
        /// </summary>
        [STAThread]
        public static void Main(string[] Args)
        {
            Application.EnableVisualStyles();

            MainForm mf = new MainForm();
            for (int t = 0; t < 20; t++ )
            {
                mf.Workspace.AddItem(new WorkItem());
            }
            Application.Run(mf);
        }
    }
}