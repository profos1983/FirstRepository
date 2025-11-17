Pen pen1 = new();
Pen pen2 = new("Синий", 56.0);
Pen pen3 = new Pen {color = "Зеленый",cost = 43.0 }; // через инициализацию

pen1.ShowPenInfo();
pen2.ShowPenInfo();
pen3.ShowPenInfo();

Rectangle rec1 = new Rectangle();
Rectangle rec2 = new Rectangle(6);
Rectangle rec3 = new Rectangle(10,6);

rec1.ShowRectangleInfo();
rec2.ShowRectangleInfo();
rec3.ShowRectangleInfo();

