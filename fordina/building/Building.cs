namespace fordina.building
{
    public class Building
    {
        private int _numberBuilding;
        private int _height;
        private int _tegnost;
        private int _numberOfApartment;
        private int _numberOfEntrances;
        private static int _nextNumberBuilding = 0;

        //Методы доступа к данным
        public int GetNumberOfApartment() 
        { 
            return _numberOfApartment; 
        }
        public void SetNumberOfApartment(int value)
        {
            _numberOfApartment = value;
        }

        public int GetHeight() 
        { 
            return _height;
        }
        public void SetHeight(int value)
        {
            _numberOfApartment = value;
        }

        public int GetTegnost() 
        {
            return _tegnost;
        }
        public void SetTegnost(int value)
        {
            _tegnost = value;
        }

        public int GetNumberOfEntrances()
        { 
            return _numberOfEntrances;
        }
        public void SetNumberOfEntrances(int value)
        {
            _numberOfEntrances = value;
        }

        public int GetNumberBuilding()
        {
            return _numberBuilding;
        }

        //Генератор уникального номера здания
        private static int GeneratedNumberBuildind()
        {
            return ++_nextNumberBuilding;
        }
        
        //Пустой конструктор
        public Building()
        {
            _numberBuilding = GeneratedNumberBuildind();
        }

        //Конструктор со всеми полями
        public Building(int height, int tegnost, int numberOfApartment, int numberOfEntrances)
        {
            _numberBuilding = GeneratedNumberBuildind();
            _height = height;
            _tegnost = tegnost;
            _numberOfApartment = numberOfApartment;
            _numberOfEntrances = numberOfEntrances;
        }

        //Метод, считающий высоту этажа
        public float FloorHeight()
        {
            return _height / _tegnost;
        }

        //Метод, считающий количество квартир в подъезде
        public int NumberOfApartmentOnEntranc()
        {
            return _numberOfApartment / _numberOfEntrances;
        }

        //Метод, считающий количество квартир на этаже
        public int NumberOfApartmentOnFloor()
        {
            return _numberOfApartment / _tegnost;
        }

        //Метод, считающий количество квартир в подъезде на одном этаже
        public int NumberOfApartmentOnEntrancOneFloor()
        {
            return NumberOfApartmentOnEntranc() / _tegnost;
        }
    }
}
