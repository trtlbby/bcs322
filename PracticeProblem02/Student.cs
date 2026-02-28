namespace BasicOOP;

class Student
{
    // CLASS FIELD
    public string name;
    public int quiz_score;
    public int no_of_quiz;
    /*
    * This is the class constructor.
    */
    public Student(string name, int quiz_score, int no_of_quiz)
    {
       Name = name;
       NoOfQuiz = no_of_quiz;
       QuizScore = quiz_score; 
    }
    //CONSTRUCTOR END
    
    
    /*
    * This is the getters and setters for Name, QuizScore, and NoOfQuiz.
    */
    public string Name 
    { 
        get {return name;} 
        set { Name = name; } 
    }
    public int QuizScore 
    { 
        get { return quiz_score; } 
        set { QuizScore = quiz_score; } 
    }
    public int NoOfQuiz
    {
        get { return no_of_quiz; }
        set { NoOfQuiz = no_of_quiz; }
    }
    // GET SET END


    /*
    * These are the functions to compute the total number of quiz and the average score
    * for each student.
    */
    public int add_quiz(int quiz_score)
    {
        return 0;
    }
    public void get_total_score(int quiz_score)
    {
        Console.WriteLine("Total score");
    }
    public double get_average_score(double total_score, int no_of_quiz)
    {   
        // total_score = get_total_score();
        double avg_score = total_score / no_of_quiz;
        return avg_score;
    }
    // FUNCTION END

    static void Main(string[] args)
    {
    // static Student(string name, int quiz_score, int no_of_quiz)
        Student joel = new Student("Joel", 50, 1);
        Console.WriteLine(joel.name + " " + joel.quiz_score + " " + joel.no_of_quiz);
    }
}