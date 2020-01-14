using System;
using System.Windows;
using System.Windows.Forms;


namespace EuroDiffusion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        #region Private Methods
        private string _inputFileName;
        private string _outputFolder;
        private readonly ErrorProcessor _errorProcessor;
        #endregion

        #region Constructor
        public MainWindow()
        {
            _inputFileName = String.Empty;
            _outputFolder = String.Empty;
            _errorProcessor=new ErrorProcessor();
            InitializeComponent();
        }
        #endregion


        #region Event handlers

        private void SelectInputFileBtnClick(object sender, RoutedEventArgs e)
        {
            var dlg = new Microsoft.Win32.OpenFileDialog
            {
                DefaultExt = ".txt",
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            };

            var result = dlg.ShowDialog();
            if (result != true) return;
            inputFileTxtBox.Text = dlg.FileName;
            _inputFileName = dlg.FileName;
        }

        private void SelectOutPutFileBtnClick(object sender, RoutedEventArgs e)
        {
            using (var dlg = new FolderBrowserDialog())
            {
                dlg.Description = Properties.Resources.OutPutFolderDesc;
                dlg.ShowNewFolderButton = true;
                dlg.RootFolder = Environment.SpecialFolder.MyComputer;
                dlg.ShowDialog();
                outputFileTxtBox.Text = dlg.SelectedPath;
                _outputFolder = dlg.SelectedPath;
            }
        }

        private void FindSolutionClick(object sender, RoutedEventArgs e)
        {
           //Check the input file
            if (_inputFileName == String.Empty)
            {
                _errorProcessor.Show("The input file name is not selected!", MsgTypes.Error);
                return;  
            }
            FindSolutionBtn.IsEnabled = false;
            MainProgress.Visibility = Visibility.Visible;
            MainProgress.Value = 10;

        }

        #endregion

        
    }
}
