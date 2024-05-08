﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ModernVpn.Core;
using ModernVpn.MVVM.Model;

namespace ModernVpn.MVVM.ViewModel
{
    internal class ProtectionViewModel:ObservableObject
    {
        public ObservableCollection<ServerModel> Servers { get; set; }

        private string _connectionStatus;

        public string ConnectionStatus {
            get { return _connectionStatus; }
            set { _connectionStatus = value;
                  OnPropetyChanged(); } 
        }

        public RelayCommand ConnectCommand { get; set; }
        public ProtectionViewModel()
        {
            Servers = new ObservableCollection<ServerModel>();
            for (int i = 0; i < 10; i++)
            {
                Servers.Add(new ServerModel
                {
                    Country = "USA"
                }) ;
            }

            ConnectCommand = new RelayCommand(o => 
            { 
                ConnectionStatus = "Connecting..";
                var process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.WorkingDirectory = Environment.CurrentDirectory;
                process.StartInfo.ArgumentList.Add(@"/c rasdial MyServer vpnbook z93cvfv /phonebook:us1.vpnbook.com");
                process.Start();
                process.WaitForExit();

                switch (process.ExitCode)
                {
                    case 0:
                        Debug.WriteLine("Success!");
                        break;
                    case 691:
                        Debug.WriteLine("Wrong credentials");
                        break;
                    default:
                        Console.WriteLine("?");
                        break;


                }
            });

        }

        private void ServerBuilder()
        {
            var address = "us1.vpnbook.com";
            var FolderPath = $"{Directory.GetCurrentDirectory()}/VPN";
            var PbkPath = $"{FolderPath}/{address}.pbk";

            if(!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }

            if(File.Exists(PbkPath))
            {
                MessageBox.Show("Connection already exists!");
                return;
            }

            var sb = new StringBuilder();
            sb.AppendLine("[MyServer]");
            sb.AppendLine("MEDIA=raptapi");
            sb.AppendLine("Port=VPN2-0");
            sb.AppendLine("Device = WAN Miniport (IKEv2)");
            sb.AppendLine("DEVICE=vpn");
            sb.AppendLine($"PhoneNumber={address}");
            File.WriteAllText(PbkPath, sb.ToString());
        }
    }
}
