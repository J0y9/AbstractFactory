using AbstractFactory;

IChair chair = FurnitureFactory.CreateChair("modern");
chair.HasLegs();
chair.SitOn();

ISofa sofa = FurnitureFactory.CreateSofa("victorian");
sofa.HasLegs();
sofa.SitOn();