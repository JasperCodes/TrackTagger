using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Controls;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TrackTagger
{
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

            string joinedString = string.Join(" ", selectedList);

            Clipboard.SetText(joinedString);
        }
        public MainWindow()
        {
            InitializeComponent();
            MoodTags moodTagsData = new MoodTags();
            tagsListBox.DataContext = moodTagsData;
        }
    }

    class MoodTags {
        public List<string> tags { get; } = new List<string> {
            "Acid","Ambient","Bouncy","Breaky","Bright","Cheesy","Chill","Clean","Dark","Dirty","Disco","Distorted","Downtempo","Dub","Epic","Ethereal","Funky","Glitchy","Groovy","Happy","Hard","Industrial","Jackin'","Jazzy","Latin","Lo-fi","Mainstream","Massive","Melancholic","Mellow","Melodic","Minimalistic","Old-School","Rolling","Sad","Sexy","Soulful","Spacey","Techy","Throaty","Tight","Tribal","Trippy","Underground","Uplifting","Vocal","Wavey","Weird","Dialog Female","Dialog Male","Sample Female","Sample Male","Vocal Female","Vocal Male"
        };
    }
}

