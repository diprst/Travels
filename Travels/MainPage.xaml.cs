using System.Collections.ObjectModel;

namespace Travels
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<TravelModel> Travels { get; set; }
        public ObservableCollection<TravelModel> FilteredTravels { get; set; }
        public MainPage()
        {
            InitializeComponent();
            Travels = new ObservableCollection<TravelModel>
            {
                new TravelModel { Name = "Австралия", Description = "Уникальные пейзажи, коала и кенгуру, серфинг и дайвинг", Image = "avstralia.png", Date = "13.02.2025", Sum = "20000" },
                new TravelModel { Name = "Франция",Description = "Париж, Прованс, шампанское и замки. Бонусная экскурсия по Лувру при бронировании до конца недели!", Image = "france.png" , Date = "25.02.2025", Sum = "35000"},
                new TravelModel { Name = "Италия", Description = "Рим, Венеция, Тоскана и пицца", Image = "italy.png", Date = "31.09.2025", Sum = "15000" },
                new TravelModel {Name = "Япония", Description = "Исследуйте Токио с его небоскребами и традиционными храмами, окунитесь в историю Киото, наслаждайтесь цветением сакуры и попробуйте аутентичные суши", Image = "japan.png", Date = "31.02.2024", Sum = "1000000"},
                new TravelModel {Name = "Канада", Description = "Насладитесь величием Ниагарского водопада, исследуйте дикие просторы национальных парков", Image = "kanada.png", Date = "22.12.2022", Sum = "32000"},
                new TravelModel {Name = "Мексика", Description = "Погрузитесь в атмосферу древних цивилизаций майя и ацтеков, насладитесь золотыми пляжами Канкуна и закатами в Тихуане", Image = "mexico.png", Date = "18.07.2024", Sum = "80000"},
                new TravelModel {Name = "Испания", Description = "Испытайте магию Барселоны с её архитектурой Гауди, танцуйте фламенко в Севилье и позагорайте на пляжах Коста-Брава", Image = "spain.png", Date = "19.04.2024", Sum = "75000"},
                new TravelModel {Name = "США", Description = "Откройте для себя Нью-Йорк с его небоскрёбами и Бродвеем, исследуйте Гранд-Каньон и Йеллоустонский парк", Image = "usa.png", Date = "19.03.2021", Sum = "98000"},
                new TravelModel {Name = "Великобритания", Description = "Погрузитесь в атмосферу Лондона с его историческими дворцами и музеями, исследуйте загадочные камни Стоунхенджа", Image = "velikobritania.png", Date = "23.10.2025", Sum = "26000"},
                new TravelModel {Name = "Новая Зеландия", Description = "Исследуйте потрясающие пейзажи, вдохновившие Властелина колец: горы, ледники и фьорды.", Image = "zelandia.png", Date = "06.11.2025", Sum = "39999"}
            };

            FilteredTravels = new ObservableCollection<TravelModel>(Travels);
            BindingContext = this;

        }   
    }
    public class TravelModel
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string Sum {  get; set; }
    }

}
