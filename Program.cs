//variables
decimal participation1, assignment1, composition1, quiz1, oralExam1, p1, p2, finalExam;
decimal participation2, assignment2, composition2, quiz2, oralExam2;

string student = string.Empty;
Console.WriteLine("Enter student name:");
student = Console.ReadLine() ?? string.Empty;


Console.WriteLine($"Welcome {student}");


// PERIOD 1

Console.WriteLine("To know your accumulated grade for Period 1, add the following: ");

Console.WriteLine("Participation: ");
decimal.TryParse(Console.ReadLine(), out participation1);

Console.WriteLine("Assignment: ");
decimal.TryParse(Console.ReadLine(), out assignment1);

Console.WriteLine("Composition: ");
decimal.TryParse(Console.ReadLine(), out composition1);

Console.WriteLine("Quiz: ");
decimal.TryParse(Console.ReadLine(), out quiz1);

Console.WriteLine("Oral Exam");
decimal.TryParse(Console.ReadLine(), out oralExam1);

// Total period 1 - 30
p1 = (participation1 + assignment1 + composition1 + quiz1 + oralExam1) / 5 * 0.30m;
Console.WriteLine($"*** The total accumulation of period 1 is: {p1:N2}. ***");

// PERIOD 2

Console.WriteLine("\nTo know your accumulated grade for Period 2, add the following: ");

Console.WriteLine("Participation: ");
decimal.TryParse(Console.ReadLine(), out participation2);

Console.WriteLine("Assignment: ");
decimal.TryParse(Console.ReadLine(), out assignment2);

Console.WriteLine("Composition: ");
decimal.TryParse(Console.ReadLine(), out composition2);

Console.WriteLine("Quiz: ");
decimal.TryParse(Console.ReadLine(), out quiz2);

Console.WriteLine("Oral Exam: ");
decimal.TryParse(Console.ReadLine(), out oralExam2);

// Total period 2 - 30
p2 = (participation2 + assignment2 + composition2 + quiz2 + oralExam2) / 5 * 0.30m;
Console.WriteLine($"*** The total accumulation of period 2 is: {p2:N2}. ***");

// add total grades of p1 plus p2 
decimal periodsTotal = p1 + p2;


// add the calculation of the final oral exam and final grammar exam.

// show the total of these last two

// show the letter based on the calification.

// show message based on the final calification.

