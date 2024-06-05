using System.Collections.ObjectModel;

namespace sportsball
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }
    
    public class SportsBallModel
    {
        public string Name { get; set; }

        public double Size { get; set; }
        
        public double Weight { get; set; }
    }

    public class SportsBallViewModel
    {
        public List<SportsBallModel> SportsBallData { get; set; }

        public ObservableCollection<Brush> PaletteBrushes { get; set; }
        
        public SportsBallViewModel()
        {
            PaletteBrushes = new ObservableCollection<Brush>()
            {
                new SolidColorBrush(Color.FromArgb("#FF5733")), // Vibrant Red
                new SolidColorBrush(Color.FromArgb("#33FF57")), // Bright Green
                new SolidColorBrush(Color.FromArgb("#3357FF")), // Bright Blue
                new SolidColorBrush(Color.FromArgb("#FF33A6")), // Hot Pink
                new SolidColorBrush(Color.FromArgb("#33FFA5")), // Aquamarine
                new SolidColorBrush(Color.FromArgb("#FFA533")), // Golden Orange
                new SolidColorBrush(Color.FromArgb("#A533FF")), // Vivid Purple
                new SolidColorBrush(Color.FromArgb("#FF5733")), // Vibrant Red
                new SolidColorBrush(Color.FromArgb("#FFC300")), // Bright Yellow
                new SolidColorBrush(Color.FromArgb("#DAF7A6")), // Light Green
                new SolidColorBrush(Color.FromArgb("#FF6F61")), // Coral
                new SolidColorBrush(Color.FromArgb("#6B5B95")), // Royal Purple
                new SolidColorBrush(Color.FromArgb("#88B04B")), // Olive Green
                new SolidColorBrush(Color.FromArgb("#FFB447")), // Orange
                new SolidColorBrush(Color.FromArgb("#009688")), // Teal
                new SolidColorBrush(Color.FromArgb("#F7CAC9")), // Rose Quartz
                new SolidColorBrush(Color.FromArgb("#92A8D1")), // Serenity Blue
                new SolidColorBrush(Color.FromArgb("#955251")), // Marsala
                new SolidColorBrush(Color.FromArgb("#B565A7")), // Orchid
                new SolidColorBrush(Color.FromArgb("#009DAE")), // Caribbean Blue
                new SolidColorBrush(Color.FromArgb("#F0A07E")), // Peach
                new SolidColorBrush(Color.FromArgb("#FF6F61")), // Coral
                new SolidColorBrush(Color.FromArgb("#5B5EA6")), // Royal Blue
                new SolidColorBrush(Color.FromArgb("#45B8AC")), // Turquoise
                new SolidColorBrush(Color.FromArgb("#E15D44")), // Deep Orange
                new SolidColorBrush(Color.FromArgb("#C39BD3")), // Lilac
            };

            SportsBallData = new List<SportsBallModel>();
            SportsBallData.Add(new SportsBallModel { Weight = 23, Size = 3.96, Name = "Squash" });
            SportsBallData.Add(new SportsBallModel { Weight = 2.7, Size = 3.99, Name = "Table Tennis" });
            SportsBallData.Add(new SportsBallModel { Weight = 45.93, Size = 4.27, Name = "Golf" });
            SportsBallData.Add(new SportsBallModel { Weight = 125, Size = 5.59, Name = "Jai Alai" });
            SportsBallData.Add(new SportsBallModel { Weight = 40, Size = 5.72, Name = "Racquetball" });
            SportsBallData.Add(new SportsBallModel { Weight = 156, Size = 5.72, Name = "Pool" });
            SportsBallData.Add(new SportsBallModel { Weight = 142, Size = 6.35, Name = "Lacrosse" });
            SportsBallData.Add(new SportsBallModel { Weight = 56.0, Size = 6.54, Name = "Tennis" });
            SportsBallData.Add(new SportsBallModel { Weight = 680, Size = 7.94, Name = "Pétanque" });
            SportsBallData.Add(new SportsBallModel { Weight = 155.9, Size = 7.11, Name = "Cricket" });
            SportsBallData.Add(new SportsBallModel { Weight = 156, Size = 7.11, Name = "Field Hockey" });
            SportsBallData.Add(new SportsBallModel { Weight = 142, Size = 7.30, Name = "Baseball" });
            SportsBallData.Add(new SportsBallModel { Weight = 22.1, Size = 7.29, Name = "Pickleball" });
            SportsBallData.Add(new SportsBallModel { Weight = 99, Size = 7.62, Name = "Polo" });
            SportsBallData.Add(new SportsBallModel { Weight = 166.6, Size = 8.89, Name = "Softball (slowpitch)" });
            SportsBallData.Add(new SportsBallModel { Weight = 453.6, Size = 9.21, Name = "Croquet" });
            SportsBallData.Add(new SportsBallModel { Weight = 178, Size = 9.70, Name = "Softball (fastpitch)" });
            SportsBallData.Add(new SportsBallModel { Weight = 920, Size = 10.67, Name = "Bocce" });
            SportsBallData.Add(new SportsBallModel { Weight = 400, Size = 18.03, Name = "Rhythmic gymnastics ball" });
            SportsBallData.Add(new SportsBallModel { Weight = 425, Size = 18.54, Name = "Team Handball" });
            SportsBallData.Add(new SportsBallModel { Weight = 260, Size = 20.70, Name = "Volleyball" });
            SportsBallData.Add(new SportsBallModel { Weight = 420, Size = 21.59, Name = "Football (Soccer)" });
            SportsBallData.Add(new SportsBallModel { Weight = 445, Size = 21.59, Name = "Korfball" });
            SportsBallData.Add(new SportsBallModel { Weight = 400, Size = 21.59, Name = "Water polo" });
            SportsBallData.Add(new SportsBallModel { Weight = 397, Size = 22.61, Name = "Netball" });
            SportsBallData.Add(new SportsBallModel { Weight = 623.7, Size = 23.88, Name = "Basketball" });
        }
    }
}
