

//Occurance of a character
 
string input = "brigadeCollege";
int Occurance = input.Count(c => c == 'i');
Console.WriteLine(Occurance);


//occurance of a word 

string input2 = "In the world of software development, coding is both an art and a science. The process of coding allows developers to create applications, websites, and systems that can solve complex problems. Efficient coding practices lead to cleaner, more maintainable code, which is easier to debug and enhance over time. As the field of software development continues to evolve, the importance of good coding practices cannot be overstated.";

int count2 = input2.Split(new string[] { "coding" }, StringSplitOptions.None).Length - 1;

Console.WriteLine(count2);
