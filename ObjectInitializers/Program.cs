using ObjectInitializers;

Console.WriteLine("***** Fun With Object Init Syntax\n");

Point firstPoint = new Point();
firstPoint.X = 10;
firstPoint.Y = 10;
firstPoint.DisplayStats();

Point secondPoint = new Point(20, 20);
secondPoint.DisplayStats();

Point thirdPoint = new Point() { X=30, Y=30};
thirdPoint.DisplayStats();