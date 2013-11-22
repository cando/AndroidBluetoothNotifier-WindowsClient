using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;
using InTheHand.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndroidBluetoothNotifier
{
    class BluetoothServer : IDisposable
    {
        private BluetoothListener lsnr;
        private Notification notificationForm;
        NotifyIcon notifyIcon;

        public BluetoothServer(Notification notification)
        {
            this.notificationForm = notification;
            InitiNotifyIcon();
            listenAsync();
        }

        public void Dispose()
        {
            notificationForm.Close();
            notifyIcon.Dispose();
            lsnr.Stop();
        }

        private void InitiNotifyIcon()
        {
            MenuItem item = new MenuItem("Exit", new EventHandler(Menu_OnExit));
            ContextMenu contextMenu = new ContextMenu();
            contextMenu.MenuItems.Add(item);

            notifyIcon = new NotifyIcon();
            notifyIcon.Icon = AndroidBluetoothNotifier.Properties.Resources.icon;
            notifyIcon.Text = "Android Bluetooth Notification";
            notifyIcon.ContextMenu = contextMenu;
            notifyIcon.Visible = true;
        }

        private async void listenAsync()
        {
            lsnr = new BluetoothListener(BluetoothService.SerialPort);
            lsnr.Start();

            bool stop = false;
            while (!stop)
            {
                NotificationEntity message = await listen();
                notificationForm.newNotification(message.title, message.body, message.icon);
            }
        }

        private void discoverPhone()
        {
            //var dlg = new SelectBluetoothDeviceDialog();
            //DialogResult result = dlg.ShowDialog(this);
            //if (result != DialogResult.OK)
            //{
            //    return;
            //}
            //BluetoothDeviceInfo device = dlg.SelectedDevice;
            //BluetoothAddress addr = device.DeviceAddress;
        }

        private Task<NotificationEntity> listen()
        {
            return Task.Run<NotificationEntity>(() =>
            {
                // Accept new connections
                try
                {
                    BluetoothClient conn = lsnr.AcceptBluetoothClient();
                    Stream stream = conn.GetStream();
                    StreamReader sr = new StreamReader(stream);
                    String title = sr.ReadLine();
                    String tmp;
                    String _body = "";
                    while (!(tmp = sr.ReadLine()).Equals("com.devcando.stop"))
                    {
                        _body += tmp + "\n";
                    }
                    String body = _body;
                    //Send a message for synchronization with the peer.
                    stream.WriteByte(1);
                    //Read the bitmap
                    byte[] icon_b = Utils.ReadToEnd(stream);
                    sr.Close();

                    NotificationEntity notificationEntity = new NotificationEntity(title, body, icon_b);
                    return notificationEntity;
                }
                catch (Exception e)
                {
                    Debug.WriteLine("Error: " + e.Message);
                    return new NotificationEntity("Error", e.Message, null);
                }

            });
        }

        private void Menu_OnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public class NotificationEntity
        {
            public string title { get; private set; }
            public string body { get; private set; }
            public Image icon { get; private set; }

            public NotificationEntity(string title, string body, byte[] icon)
            {
                this.title = title;
                this.body = body;
                this.icon = IconFromByteArray(icon);
            }

            private Image IconFromByteArray(byte[] icon)
            {
                if (icon == null){
                    return null;
                }
                ImageConverter ic = new ImageConverter();
                Image img = (Image)ic.ConvertFrom(icon);
                return img;
            }
        }
    }
}
