class Person {
    public int age;     
    public Person(int initialAge) {
        if(initialAge < 0){ // initial age is invalid
            Console.WriteLine("Age is not valid, setting age to 0.");
            this.age = 0;
        }
        else{ // set age to valid initial age
            this.age = initialAge;
        }
     }
     public void amIOld() {
        Console.WriteLine(
            (age >= 18) 
            ? "You are old." 
            : (
                (age >=13) 
                ? "You are a teenager." 
                : "You are young." 
            )
        );
     }

     public void yearPasses() {
        this.age++;
     }