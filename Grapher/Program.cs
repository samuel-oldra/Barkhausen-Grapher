﻿using System;
using System.Windows.Forms;

namespace Grapher
{
    internal static class Program
    {
        #region Static private

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Grapher(args));
        }

        #endregion
    }
}