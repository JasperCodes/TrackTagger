using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Documents;

namespace TrackTagger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        private void CopyTagsButtonClick(object sender, RoutedEventArgs e)
        {
            List<string> selectedList = new();
            foreach (var item in tagsListBox.SelectedItems)
            {

                string combinedString = "#" + item.ToString();

                selectedList.Add(combinedString);
            }

            if (selectedList.Count == 0) { return; }

            string joinedString = string.Join(", ", selectedList);

            MessageBox.Show(joinedString);
        }
        public MainWindow()
        {
            InitializeComponent();

        }
        
    }
}
