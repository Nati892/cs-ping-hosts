using Host_tester.Code;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;


namespace Host_tester
{

    public partial class MainWindow : Window
    {
        List<Host_Data> MainDataGridsource = new List<Host_Data>();
        Timer timer = new Timer();

        public MainWindow()
        {
            InitializeComponent();
            InitializeDataGrid();

            timer.TimedFunction = PingHostList;//set intervaled function
            _ = timer.StartAsync();
        }


        private void InitializeDataGrid()
        {
            MainDataGridsource = XmlFileHandler.LoadFromXml();
            MainDataGrid.ItemsSource = MainDataGridsource;
        }

        private int PingHostList()
        {
            foreach (Host_Data host in MainDataGridsource)
            {
                if (host.Enabled)
                    _ = pingSingleHostAsync(host);
                else { 
                if (host.Status==Host_Data.HostConnectionStatus.Pinging)
                        host.Status = Host_Data.HostConnectionStatus.Disconnected;
                }
            }
            return 0;
        }

        private async Task pingSingleHostAsync(Host_Data host)
        {
            PingHost pinger = new PingHost() { hostAddress = host.Address };
            host.Status = Host_Data.HostConnectionStatus.Pinging;
            MainDataGrid.Items.Refresh();

            host.Status = await Task.Run(() => pinger.StartPing());
            MainDataGrid.Items.Refresh();
        }

        //this function controls the Timer's Text box input
        private void TimerTB_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (!int.TryParse(TimerTB.Text.ToString(), out int result))//make sure its numeric
            {
                TimerTB.Text = timer.Interval.ToString();
            }
            else
            {
                if (result <= PingHost.TIMEOUT)//Don't allow to interval faster then ping timeout
                    TimerTB.Text = PingHost.TIMEOUT.ToString();
            }
            timer.Interval = int.Parse(TimerTB.Text);
        }

        private void BtnAddNewHost_Click(object sender, RoutedEventArgs e)
        {
            Host_Data newHost = new Host_Data(TBNewHostName.Text, TBNewHostIp.Text, true, Host_Data.HostConnectionStatus.Disconnected);
            MainDataGridsource.Add(newHost);
            MainDataGrid.Items.Refresh();

        }
        private void BtnStopPing_click(object sender, RoutedEventArgs e)
        {
            timer.stopTimer();
        }

        private void BtnStartPing_click(object sender, RoutedEventArgs e)
        {
            if (!timer.isTimerRunning)
                _ = timer.StartAsync();
        }

        private void BtnSaveToXml_click(object sender, RoutedEventArgs e)
        {
            XmlFileHandler.SaveToXml(MainDataGridsource);
        }

    }
}


