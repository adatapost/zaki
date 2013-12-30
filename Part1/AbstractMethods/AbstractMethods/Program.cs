using System;
abstract public class Question
{
    public string Text { get; set; }
    public string Answer1 { get; set; }
    public string Answer2 { get; set; }
    public string Answer3 { get; set; }

    abstract public void Print();
    public abstract bool IsCorrect { get; }
}


public class SCQ : Question
{
    public int UserChoice { get; set; }
    public int CorrectAnswer { get; set; }
    public override void Print()
    {
        Console.WriteLine("Single Choice Question");
        Console.WriteLine(Text);
        Console.WriteLine("1. " + Answer1);
        Console.WriteLine("2. " + Answer2);
        Console.WriteLine("3. " + Answer3);
        Console.WriteLine("Select your choice : ");
        UserChoice = int.Parse(Console.ReadLine());
    }
    public override bool IsCorrect
    {
        get { return UserChoice == CorrectAnswer; }
    }
}

public class MCQ : Question
{
    public int []UserChoice { get; set; }
    public int []CorrectAnswer { get; set; }

    public MCQ() {
        UserChoice = new int[3];
    }
    public override void Print()
    {
        Console.WriteLine("Multi Choice Question");
        Console.WriteLine(Text);
        Console.WriteLine("1. " + Answer1);
        Console.WriteLine("2. " + Answer2);
        Console.WriteLine("3. " + Answer3);
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Enter choice " + i + " :");
            UserChoice[i] = int.Parse(Console.ReadLine());
        }
    }
    public override bool IsCorrect
    {
        get {
            return UserChoice[0] == CorrectAnswer[0] && UserChoice[1] == CorrectAnswer[1] && UserChoice[2] == CorrectAnswer[2];
        }
    }
}

class Test
{
    static void Main()
    {
        Question[] ques = new Question[3];
        ques[0] = new SCQ() { Text="Q1",Answer1="A",Answer2="B",Answer3="C", CorrectAnswer=1 };
        ques[1] = new MCQ() { Text="M1",Answer1="P",Answer2="Q",Answer3="R", CorrectAnswer=new int[]{1,0,1} };
        ques[2] = new MCQ() { Text = "M2", Answer1 = "P1", Answer2 = "Q1", Answer3 = "R1", CorrectAnswer = new int[] { 1, 1, 1 } };

        foreach (var q in ques)
            q.Print();


        Console.WriteLine("Result");
        int correct = 0;
        foreach (var q in ques)
        {
            Console.WriteLine(q.IsCorrect);
            if (q.IsCorrect) correct++;
        }
        Console.WriteLine("Total correct : " + correct);
    }
}