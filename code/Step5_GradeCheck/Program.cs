Console.WriteLine("Определение оценки по баллам");

Console.Write("Введите кол-во баллов от 0 до 100 включительно: ");
int score = Convert.ToInt32(Console.ReadLine());

string grade;
int numericGrade;
if (score >= 91 && score <= 100) {
    grade = "great";
    numericGrade = 5;
}
else if (score >= 71 && score < 90) {
    grade = "good";
    numericGrade = 4;
}
else if (score >= 51 && score < 70) {
    grade = "not good";
    numericGrade = 3;
}
else if (score >= 0 && score < 50) {
    grade = "bad";
    numericGrade = 2;
}
else 
{
    grade = "error";
    numericGrade = 0;
    Console.WriteLine("error. Try again");
    return;
}
Console.WriteLine("result: ");
Console.WriteLine($"score: {score}");
Console.WriteLine($"grade: {grade} ({numericGrade})");
