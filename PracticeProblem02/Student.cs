namespace PracticeProblem02;

class Student
{
    // CLASS FIELD
    public string name;
    public int total_score;
    public int no_of_quiz;
    /*
    * This is the class constructor.
    */
    public Student(string name)
    {
       this.name = name;
       this.total_score = 0;
       this.no_of_quiz = 0; 
    }
    //CONSTRUCTOR END
    
    
    /*
    * This is the getters and setters for Name, QuizScore, and NoOfQuiz.
    */
    public string get_name()
    {
        return name;
    }
    public void add_quiz(int score)
    {
        total_score += score;
        no_of_quiz++;
    }
    public int get_total_score()
    {
        return total_score;
    }
    public double get_average_score()
    {
        if(no_of_quiz == 0) return 0.0;
        return(double)total_score / no_of_quiz;
    }
    // GET SET END

    static void Main(string[] args)
    {
        Student s = new Student("Joel");
        s.add_quiz(50);
        s.add_quiz(80);
        Console.WriteLine("Name: " + s.get_name());
        Console.WriteLine("Total Score: " + s.get_total_score());
        Console.WriteLine("Average Score: " + s.get_average_score());
        
    }
}