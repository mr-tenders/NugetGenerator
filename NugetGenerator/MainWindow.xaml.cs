using System.IO;
using System.Windows;
using System.Windows.Forms;

using NugetGenerator.Core;

namespace NugetGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window 
    {
        private readonly IStringValidator _validator;
        public MainWindow(IStringValidator validator)
        {
            _validator = validator;
            InitializeComponent();

            // An extra default intialization
            PackageSaveLocationTextBox.Text = System.Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
        }

        private void CreateNugetPackageButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PackageSaveLocationButton_Click(object sender, RoutedEventArgs e)
        {
            var folderDialog = new FolderBrowserDialog();
            var result = folderDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }

            var folder = folderDialog.SelectedPath;
            _validator.Instance = folder;
            if (!_validator.IsValid())
            {
                System.Windows.MessageBox.Show("No folder was selected!", "Folder", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            PackageSaveLocationTextBox.Text = Path.GetFullPath(folder);
        }
    }
}
