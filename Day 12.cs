class Student : Person{
    private int[] testScores;  
  
    /*	
    *   Class Constructor
    *   
    *   Parameters: 
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */
    // Write your constructor here
    public Student(string firstName, string lastName, int id, int[] scores) : base (firstName, lastName, id)
    {
        testScores = scores;
    }
    /*	
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
    // Write your method here
    public char Calculate()
    {
        int score = testScores.Sum() / testScores.Length;
        
        if (score >= 90)
            return 'O';
        
        if (score >= 80)
            return 'E';
        
        if (score >= 70)
            return 'A';
        
        if (score >= 55)
            return 'P';
        
        if (score >= 40)
            return 'D';
        
        return 'T';
    }
}