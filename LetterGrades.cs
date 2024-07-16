int examAssigments = 5;

int[] sophiaScores = new int[] { 90, 36, 87, 91, 100, 44, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 34, 98, 68, 69, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 62, 91, 9, 91, 92, 52, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 60, 100, 20, 90, 100, 70, 90 };
int[] gregorScores = new int[] { 71, 92, 51, 54, 11, 46, 57 }; 

string[] studentNames = new string[] { "Sophia","Andrew","Emma","Logan","Becky","Chris","Eric","Gregor"};

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

Console.WriteLine("Student\t\tGrade\tLetter Grade\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
       studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
       studentScores = andrewScores;
    
    else if (currentStudent == "Emma")
       studentScores = emmaScores;

    else if (currentStudent == "Logan")
       studentScores = loganScores;

    else if (currentStudent == "Becky")
       studentScores = beckyScores;

    else if (currentStudent == "Chris")
       studentScores = chrisScores;

    else if (currentStudent == "Eric")
       studentScores = ericScores;

    else if (currentStudent == "Gregor")
       studentScores = gregorScores;

    else
       continue;


    int sumAssigmentScores = 0;
    decimal currentStudentGrade = 0;
    int gradedAssigments = 0;

    foreach (int score in studentScores)
    {
        gradedAssigments +=1;

        if (gradedAssigments <= examAssigments)
           sumAssigmentScores += score;
           // add the exam score to the sum

        else
           sumAssigmentScores += score/10;
           //add the extra credit points to the sum, bonus points equal to %10 of an exam score
    }

    currentStudentGrade = (decimal)(sumAssigmentScores) / examAssigments;

    if (currentStudentGrade >= 97)
       currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
       currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
       currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
       currentStudentLetterGrade = "B+";
    
    else if (currentStudentGrade >= 83)
       currentStudentLetterGrade = "B";

    else if (currentStudentGrade >=80)
       currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
       currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
       currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
       currentStudentLetterGrade = "C-";
    
    else if (currentStudentGrade >= 67)
       currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
       currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
       currentStudentLetterGrade = "D-";

    else
       currentStudentLetterGrade = "F";


    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}

Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine(); 