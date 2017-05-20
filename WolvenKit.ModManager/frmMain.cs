﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WolvenKit.ModManager
{
    public partial class frmMain : Form
    {
        public static string GamePath;

        public string ModFolder => Path.Combine(GamePath, "..\\..\\..\\Mods");
        public string DlcFolder => Path.Combine(GamePath, "..\\..\\..\\DLC");

        public frmMain()
        {
            InitializeComponent();
            try
            {
                if (File.Exists("config.ini"))
                {
                    GamePath = File.ReadAllLines("config.ini")[0];
                    if (!File.Exists(GamePath) || Path.GetExtension(GamePath) != ".exe")
                    {
                        GamePath = "";
                    }
                }
                else
                {
                    using (var of = new OpenFileDialog())
                    {
                        of.Filter = @"Witcher 3 Executable | witcher3.exe";
                        if (of.ShowDialog() == DialogResult.OK)
                        {
                            File.WriteAllLines("config.ini",new string[] {of.FileName});
                            GamePath = of.FileName;
                        }
                        else
                        {
                            throw new Exception("Invalid file!");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                if(File.Exists("config.ini"))
                    File.Delete("config.ini");
                MessageBox.Show($"Sorry there was an error launching the application. Please restart.\n{e.StackTrace}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Environment.Exit(0x01);    
            }
            UpdateModAndDlcList();

        }

        public void UpdateModAndDlcList()
        {
            ModList.Items.AddRange(Directory.GetDirectories(ModFolder).Select(x => new ListViewItem(Path.GetFileName(x))).ToArray());
            DLCList.Items.AddRange(Directory.GetDirectories(DlcFolder).Select(x => new ListViewItem(Path.GetFileName(x))).ToArray());
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Game: " + GamePath +
                            "\nDLC folder: " + DlcFolder +
                            "\nMod folder: " + ModFolder,"Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void addModToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: load w3modpackage
        }

        private void addDLCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: load w3modpackage
        }
    }
}
