
Console.WriteLine("Student \t\t Exam Scores \t\t Overall Grade  \t\tExtra Credit");


//Array,foreach and if-

int[] student1Scores={56,77,32,65,86};
int[] student2Scores={44,56,23,67,87};
int[] student3Scores={88,83,58,81,29};
int[] student4Scores={64,48,38,93,34};
int[] student5Scores={56,87,25,77,89};

string[] students={"student1","student2","student3","student4","student5"};


int extraAssignmentScore1=45;
int extraAssignmentScore2=55;
int extraAssignmentScore3=65;
int extraAssignmentScore4=75;
int extraAssignmentScore5=85;

int sum1=0;
int sum2=0;
int sum3=0;
int sum4=0;
int sum5=0;

decimal[] examScores=new decimal[5];


foreach(string student in students)
{
    
    if(student=="student1"){
    foreach(int score in student1Scores)
        {
            sum1+=score;
        }
        decimal avg1=(sum1/5m)+((0.1m)*extraAssignmentScore1);
        examScores[0]=avg1;
    }
    
    else if(student=="student2"){
    foreach(int score in student2Scores)
        {
            sum2+=score;
        }
        decimal avg2=(sum2/5)+(0.1m)*extraAssignmentScore2;
        examScores[1]=avg2;
    }
    else if(student=="student3"){
    foreach(int score in student3Scores)
        {
            sum3+=score;
        }
        decimal avg3=(sum3/5)+(0.1m)*extraAssignmentScore3;
        examScores[2]=avg3;

    }
    else if(student=="student4"){
    foreach(int score in student4Scores)
        {
            sum4+=score;
        }
        decimal avg4=(sum4/5)+(0.1m)*extraAssignmentScore4;
        examScores[3]=avg4;

    }
    else if(student=="student5"){
    foreach(int score in student5Scores)
        {
            sum5+=score;
        }
        decimal avg5=(sum5/5)+(0.1m)*extraAssignmentScore5;
        examScores[4]=avg5;

    }

}

string[] currentStudentLetterGrade=new string[5];

for(int i=0; i<5; i++)
{
    decimal currentStudentGrade=examScores[i];

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade[i] = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade[i] = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade[i] = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade[i] = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade[i] = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade[i] = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade[i] = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade[i] = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade[i] = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade[i] = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade[i] = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade[i] = "D-";

    else
        currentStudentLetterGrade[i] = "F";


}

    

for(int i=0; i<5; i++)
{
    string student=students[i];
    decimal score=examScores[i];
    string grade=currentStudentLetterGrade[i];

    Console.WriteLine($"{student} \t\t {score} \t\t\t {grade}");

}