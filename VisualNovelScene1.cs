using System;

namespace VisualNovelScene1 {
    public class Scene1 {
        
        public char choice1, choice2, choice3;
        public char[] choicesScene1 = new char[3];
        
        public Scene1() {
            
            choice1 = 'x'; 
            choice2 = 'x';
            choice3 = 'x';
            choicesScene1[0] = choice1;
            choicesScene1[1] = choice2;
            choicesScene1[2] = choice3;
        }
        
        public char[] ExecuteScene1() {
            
            //Initial Situation
            Console.WriteLine("Hi! Please make a choice.");
            
            //Ask the user to make a choice.
            Console.WriteLine("Press G or N.");
            choice1 = Console.ReadKey().KeyChar;
            
            //Test if the instruction is respected and ask to make the choice
            //again if not respected.
            while (choice1 != 'G' || choice1 != 'g' || choice1 != 'N' || choice1 != 'n'){
                
                //Condition to exit the loop when the instruction is respected.
                if(choice1 == 'G' || choice1 == 'g' || choice1 == 'N' || choice1 == 'n') {
                    choicesScene1[0] = choice1;
                    break;
                }
                
                //Tells that the choice wasn't correct and ask to make the
                //choice again.
                Console.WriteLine();
                Console.WriteLine("This is not an option. Please press G or N.");
                choice1 = Console.ReadKey().KeyChar;
            }
            
            //Continues the G storyline if G was chosen.
            if(choice1 == 'G' || choice1 == 'g') {
                Console.WriteLine();
                Console.WriteLine("Choice 1 = G - Please make another choice.");
                
                //Ask the user to make a choice.
                Console.WriteLine("Press Y or N.");
                choice2 = Console.ReadKey().KeyChar;
                
                //Test if the instruction is respected and ask to make the choice
                //again if not respected.
                while (choice2 != 'Y' || choice2 != 'y' || choice2 != 'N' || choice2 != 'n'){
                
                    //Condition to exit the loop when the instruction is respected.
                    if(choice2 == 'Y' || choice2 == 'y' || choice2 == 'N' || choice2 == 'n') {
                        choicesScene1[1] = choice2;
                        break;
                    }
                
                    //Tells that the choice wasn't correct and ask to make the
                    //choice again.
                    Console.WriteLine();
                    Console.WriteLine("This is not an option. Please press Y or N.");
                    choice2 = Console.ReadKey().KeyChar;
                }
                    
                //Continues the Y storyline if Y was chosen.
                if(choice2 == 'Y' || choice2 == 'y'){
                    Console.WriteLine();
                    Console.WriteLine("Choice 1 = G and Choice 2 = Y - Thank you! Now entering Scene 2.");
                    
                    return choicesScene1;
                }
                
                //Continues the N storyline if N was chosen.
                else if(choice2 != 'N' || choice2 != 'n'){
                    Console.WriteLine();
                    Console.WriteLine("Choice 1 = G and Choice 2 = N - Thank you! Now entering Scene 2.");
                    
                    return choicesScene1;
                }
            }
            
            //Continues the N storyline if N was chosen.
            else if(choice1 == 'N' || choice1 == 'n'){
                Console.WriteLine();
                Console.WriteLine("Choice 1 = N - Please make another choice.");
                
                //Ask the user to make a choice.
                Console.WriteLine("Press Y or N.");
                choice2 = Console.ReadKey().KeyChar;
                
                //Test if the instruction is respected and ask to make the choice
                //again if not respected.
                while (choice2 != 'Y' || choice2 != 'y' || choice2 != 'N' || choice2 != 'n'){
                
                    //Condition to exit the loop when the instruction is respected.
                    if(choice2 == 'Y' || choice2 == 'y' || choice2 == 'N' || choice2 == 'n') {
                        choicesScene1[1] = choice2;
                        break;
                    }
                
                    //Tells that the choice wasn't correct and ask to make the
                    //choice again.
                    Console.WriteLine();
                    Console.WriteLine("This is not an option. Please press Y or N.");
                    choice2 = Console.ReadKey().KeyChar;
                }
                
                //Continues the Y storyline if Y was chosen.
                if(choice2 == 'Y' || choice2 == 'y'){
                    Console.WriteLine();
                    Console.WriteLine("Choice 1 = N and Choice 2 = Y - Thank you! Now entering Scene 2.");
                    
                    return choicesScene1;
                }
                
                //Continues the N storyline if N was chosen.
                else if(choice2 == 'N' || choice2 == 'n') {
                    Console.WriteLine();
                    Console.WriteLine("Choice 1 = N and Choice 2 = N - Please make another choice.");
                
                    //Ask the user to make a choice.
                    Console.WriteLine("Press Y or N.");
                    choice3 = Console.ReadKey().KeyChar;
                
                    //Test if the instruction is respected and ask to make the choice
                    //again if not respected.
                    while (choice3 != 'Y' || choice3 != 'y' || choice3 != 'N' || choice3 != 'n'){
                
                        //Condition to exit the loop when the instruction is respected.
                        if(choice3 == 'Y' || choice3 == 'y' || choice3 == 'N' || choice3 == 'n') {
                            choicesScene1[2] = choice3;
                            break;
                        }
                
                        //Tells that the choice wasn't correct and ask to make the
                        //choice again.
                        Console.WriteLine();
                        Console.WriteLine("This is not an option. Please press Y or N.");
                        choice3 = Console.ReadKey().KeyChar;
                    }
                    
                    //Continues the Y storyline if Y was chosen.
                    if(choice3 == 'Y' || choice3 == 'y'){
                        Console.WriteLine();
                        Console.WriteLine("Choice 1 = N, Choice 2 = N and Choice 3 = Y - Thank you! Now entering Scene 2.");
                        
                        return choicesScene1;
                    }
                
                    //Continues the N storyline if N was chosen.
                    else if(choice3 != 'N' || choice3 != 'n'){
                        Console.WriteLine();
                        Console.WriteLine("Choice 1 = N, Choice 2 = N and Choice 3 = N - Thank you! Now entering Scene 2.");
                        
                        return choicesScene1;
                    }
                }
            }
            return choicesScene1;
        }
    }
}