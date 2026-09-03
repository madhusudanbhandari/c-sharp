

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

foreach(string student in students)
{
    if(student=="student1"){
    foreach(int score in student1Scores)
        {
            sum1+=score;
        }
    }
    else if(student=="student2"){
    foreach(int score in student2Scores)
        {
            sum2+=score;
        }
    }
    else if(student=="student3"){
    foreach(int score in student3Scores)
        {
            sum3+=score;
        }
    }
    else if(student=="student4"){
    foreach(int score in student4Scores)
        {
            sum4+=score;
        }
    }
    else if(student=="student5"){
    foreach(int score in student5Scores)
        {
            sum5+=score;
        }
    }

    
}



Console.WriteLine($"The sum of Student1 scores is {sum1} ");
Console.WriteLine($"The sum of Student2 scores is {sum2}");
Console.WriteLine($"The sum of Student3 scores is {sum3} ");
Console.WriteLine($"The sum of Student4 scores is {sum4}");
Console.WriteLine($"The sum of Student5 scores is {sum5} ");


decimal avg1=(sum1/5m)+(0.1m*(decimal)extraAssignmentScore1);
Console.WriteLine(avg1);

decimal avg2=(sum2/5m)+(0.1m*(decimal)extraAssignmentScore2);
Console.WriteLine(avg2);

decimal avg3=(sum3/5m)+(0.1m*(decimal)extraAssignmentScore3);
Console.WriteLine(avg3);

decimal avg4=(sum4/5m)+(0.1m*(decimal)extraAssignmentScore4);
Console.WriteLine(avg4);

decimal avg5=(sum5/5m)+(0.1m*(decimal)extraAssignmentScore5);
Console.WriteLine(avg5);