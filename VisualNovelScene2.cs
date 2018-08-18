using System;
using VisualNovelScene1;

namespace VisualNovelScene2 {
    public class Scene2 {
        
        public char choice4;
        public char[] choicesScene2 = new char[1];
        
        public Scene2() {
            
            choice4 = 'x';
            choicesScene2[0] = choice4;
        }
        
        public char[] ExecuteScene2(char[] choicesScene1) {
        
            char s1c1 = choicesScene1[0];
            char s1c2 = choicesScene1[1];
            char s1c3 = choicesScene1[2];
            
            //Initial Situation
            if((s1c1 == 'G' || s1c1 == 'g') && (s1c2 == 'Y' || s1c2 == 'y')){
                
                Console.WriteLine("************ SCENE 2 ************");
                Console.WriteLine("Hi again! Please make a choice.");
            
                //Ask the user to make a choice.
                Console.WriteLine("Press Y or E.");
                choice4 = Console.ReadKey().KeyChar;

                //Test if the instruction is respected and ask to make the choice
                //again if not respected.
                while (choice4 != 'Y' || choice4 != 'y' || choice4 != 'E' || choice4 != 'e'){

                    //Condition to exit the loop when the instruction is respected.
                    if(choice4 == 'Y' || choice4 == 'y' || choice4 == 'E' || choice4 == 'e') {
                        choicesScene2[0] = choice4;
                        break;
                    }

                    //Tells that the choice wasn't correct and ask to make the
                    //choice again.
                    Console.WriteLine();
                    Console.WriteLine("This is not an option. Please press Y or E.");
                    choice4 = Console.ReadKey().KeyChar;
                }

                //Continues the Y storyline if Y was chosen.
                if(choice4 == 'Y' || choice4 == 'y') {
                    Console.WriteLine();
                    Console.WriteLine("Choice 4 = Y - Thank you for your time. Goodbye!");
                    return choicesScene2;
                }

                    
                //Continues the E storyline if E was chosen.
                else if(choice4 == 'E' || choice4 == 'e'){
                    Console.WriteLine();
                    Console.WriteLine("Choice 4 = E. Thank you for your time. Goodbye!");
                    return choicesScene2;

                }
            }
            
            else if((s1c1 == 'G' || s1c1 == 'g') && (s1c2 == 'N' || s1c2 == 'n')){
                
                Console.WriteLine("************ SCENE 2 ************");
                Console.WriteLine("Hi again! Please make a choice..");
            
                //Ask the user to make a choice.
                Console.WriteLine("Press S or I.");
                choice4 = Console.ReadKey().KeyChar;

                //Test if the instruction is respected and ask to make the choice
                //again if not respected.
                while (choice4 != 'S' || choice4 != 's' || choice4 != 'I' || choice4 != 'i'){

                    //Condition to exit the loop when the instruction is respected.
                    if(choice4 == 'S' || choice4 == 's' || choice4 == 'I' || choice4 == 'i') {
                        choicesScene2[0] = choice4;
                        break;
                    }

                    //Tells that the choice wasn't correct and ask to make the
                    //choice again.
                    Console.WriteLine();
                    Console.WriteLine("This is not an option. Please press S or I.");
                    choice4 = Console.ReadKey().KeyChar;
                }

                //Continues the Y storyline if Y was chosen.
                if(choice4 == 'S' || choice4 == 's') {
                    Console.WriteLine();
                    Console.WriteLine("Choice 4 = S - Thank you for your time. Goodbye!");
                    return choicesScene2;
                }

                    
                //Continues the E storyline if E was chosen.
                else if(choice4 == 'I' || choice4 == 'i'){
                    Console.WriteLine();
                    Console.WriteLine("Choice 4 = I - Thank you for your time. Goodbye!");
                    return choicesScene2;

                }
                
            }
            
            else if((s1c1 == 'N' || s1c1 == 'n') && (s1c2 == 'Y' || s1c2 == 'y')){
                
                Console.WriteLine("************ SCENE 2 ************");
                Console.WriteLine("Hi again! Please make a choice.");
            
                //Ask the user to make a choice.
                Console.WriteLine("Press F or B.");
                choice4 = Console.ReadKey().KeyChar;

                //Test if the instruction is respected and ask to make the choice
                //again if not respected.
                while (choice4 != 'F' || choice4 != 'f' || choice4 != 'B' || choice4 != 'b'){

                    //Condition to exit the loop when the instruction is respected.
                    if(choice4 == 'F' || choice4 == 'f' || choice4 == 'B' || choice4 == 'b') {
                        choicesScene2[0] = choice4;
                        break;
                    }

                    //Tells that the choice wasn't correct and ask to make the
                    //choice again.
                    Console.WriteLine();
                    Console.WriteLine("This is not an option. Please press F or B.");
                    choice4 = Console.ReadKey().KeyChar;
                }

                //Continues the Y storyline if Y was chosen.
                if(choice4 == 'F' || choice4 == 'f') {
                    Console.WriteLine();
                    Console.WriteLine("Choice 4 = F - Thank you for your time. Goodbye!");
                    return choicesScene2;
                }

                    
                //Continues the E storyline if E was chosen.
                else if(choice4 == 'B' || choice4 == 'b'){
                    Console.WriteLine();
                    Console.WriteLine("Choice 4 = B - Thank you for your time. Goodbye!");
                    return choicesScene2;

                }
                
            }
            
            else if((s1c1 == 'N' || s1c1 == 'n') && (s1c2 == 'N' || s1c2 == 'n') && (s1c3 == 'Y' || s1c3 == 'y')){
                
                Console.WriteLine("************ SCENE 2 ************");
                Console.WriteLine("Hi again! Please make a choice.");
            
                //Ask the user to make a choice.
                Console.WriteLine("Press Y or O.");
                choice4 = Console.ReadKey().KeyChar;

                //Test if the instruction is respected and ask to make the choice
                //again if not respected.
                while (choice4 != 'Y' || choice4 != 'y' || choice4 != 'O' || choice4 != 'o'){

                    //Condition to exit the loop when the instruction is respected.
                    if(choice4 == 'Y' || choice4 == 'y' || choice4 == 'O' || choice4 == 'o') {
                        choicesScene2[0] = choice4;
                        break;
                    }

                    //Tells that the choice wasn't correct and ask to make the
                    //choice again.
                    Console.WriteLine();
                    Console.WriteLine("This is not an option. Please press Y or O.");
                    choice4 = Console.ReadKey().KeyChar;
                }

                //Continues the Y storyline if Y was chosen.
                if(choice4 == 'Y' || choice4 == 'y') {
                    Console.WriteLine();
                    Console.WriteLine("Choice 4 = Y - Thank you for your time. Goodbye!");
                    return choicesScene2;
                }

                    
                //Continues the E storyline if E was chosen.
                else if(choice4 == 'O' || choice4 == 'o'){
                    Console.WriteLine();
                    Console.WriteLine("Choice 4 = O - Thank you for your time. Goodbye!");
                    return choicesScene2;

                }
                
            }
            
            else if((s1c1 == 'N' || s1c1 == 'n') && (s1c2 == 'N' || s1c2 == 'n') && (s1c3 == 'N' || s1c3 == 'n')){
                
                Console.WriteLine("************ SCENE 2 ************");
                Console.WriteLine("Hi again! Please make a choice.");
            
                //Ask the user to make a choice.
                Console.WriteLine("Press S or N.");
                choice4 = Console.ReadKey().KeyChar;

                //Test if the instruction is respected and ask to make the choice
                //again if not respected.
                while (choice4 != 'S' || choice4 != 's' || choice4 != 'N' || choice4 != 'n'){

                    //Condition to exit the loop when the instruction is respected.
                    if(choice4 == 'S' || choice4 == 's' || choice4 == 'N' || choice4 == 'n') {
                        choicesScene2[0] = choice4;
                        break;
                    }

                    //Tells that the choice wasn't correct and ask to make the
                    //choice again.
                    Console.WriteLine();
                    Console.WriteLine("This is not an option. Please press S or N.");
                    choice4 = Console.ReadKey().KeyChar;
                }

                //Continues the Y storyline if Y was chosen.
                if(choice4 == 'S' || choice4 == 's') {
                    Console.WriteLine();
                    Console.WriteLine("Choice 4 = S - Thank you for your time. Goodbye!");
                    return choicesScene2;
                }

                    
                //Continues the E storyline if E was chosen.
                else if(choice4 == 'N' || choice4 == 'n'){
                    Console.WriteLine();
                    Console.WriteLine("Choice 4 = N - Thank you for your time. Goodbye!");
                    return choicesScene2;

                }
                
            }
            return choicesScene2;
        }
    }
}