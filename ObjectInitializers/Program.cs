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

Point fourtyPoint = new Point(10, 16) {X=34, Y=78 };
fourtyPoint.DisplayStats();

Point fiftyPoint = new Point(PointColor.Gold) { X = 90, Y = 90 };
fiftyPoint.DisplayStats();