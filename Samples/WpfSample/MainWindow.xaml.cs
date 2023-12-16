using eBEST.OpenApi.Events;
using eBEST.OpenApi.Models;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

#pragma warning disable CS0067

namespace WpfSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private eBEST.OpenApi.EBestOpenApi _client;
        public MainWindow()
        {
            InitializeComponent();

            _client = new eBEST.OpenApi.EBestOpenApi();
            _client.OnConnectEvent += _client_OnConnectEvent;


            로그인Command = new RelayCommand(Proc_로그인);
            종목조회Command = new RelayCommand(Proc_종목조회);

            AccKey = string.Empty;
            AccSecretKey = string.Empty;
            종목코드 = "005930";
            _resultText = string.Empty;


            DataContext = this;
        }

        private void _client_OnConnectEvent(object? sender, EBestOnConnectEventArgs e)
        {
            if (e.Ok)
            {
                ResultText += "로그인 성공";
            }
            else
            {
                ResultText += $"로그인 실패 : {e.Msg}";
            }
        }

        public string AccKey { get; set; }
        public string AccSecretKey { get; set; }
        public string 종목코드 { get; set; }

        string _resultText;
        public string ResultText
        {
            get => _resultText;
            set
            {
                _resultText = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ResultText)));
            }
        }

        public ICommand 로그인Command { get; }
        public ICommand 종목조회Command { get; }

        void Proc_로그인()
        {
            if (_client.Connected)
            {
                ResultText += "\r\n이미 로그인 되었습니다.";
                return;
            }

            if (string.IsNullOrEmpty(AccKey) || string.IsNullOrEmpty(AccSecretKey))
            {
                ResultText += "\r\n계좌키와 비밀키를 입력해주세요.";
                return;
            }

            _ = _client.ConnectAsync(AccKey, AccSecretKey);
            ResultText += "\r\n로그인 요청중....";
        }

        void Proc_종목조회()
        {
            if (!_client.Connected)
            {
                ResultText += "\r\n로그인을 먼저 해주세요.";
                return;
            }

            _ = TestRequestAsync(종목코드);

        }

        async Task TestRequestAsync(string code)
        {
            t1102 주식현재가 = new()
            {
                t1102InBlock = new(code),
            };
            await _client.GetTRData(주식현재가).ConfigureAwait(true);
            if (주식현재가.t1102OutBlock != null)
            {
                ResultText += $"\r\n{주식현재가.t1102OutBlock}";
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }

    internal class RelayCommand : ICommand
    {
        private readonly Action _action;

        public RelayCommand(Action action)
        {
            _action = action;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter) => _action.Invoke();
    }
}