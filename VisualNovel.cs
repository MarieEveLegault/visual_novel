using System;
using VisualNovelScene1;
using VisualNovelScene2;

namespace VisualNovel {
    class ExecuteVisualNovel {
        
        static void Main(string[] args) {
            
            //Scene1
            Scene1 scene1 = new Scene1();
            char[] choicesScene1;
            choicesScene1 = scene1.ExecuteScene1();
            
            //Scene2
            Scene2 scene2 = new Scene2();
            char[] choicesScene2;
            choicesScene2 = scene2.ExecuteScene2(choicesScene1);
            
            Console.WriteLine("************ RESULTS ************");
            Console.WriteLine("SCENE 1: Choice 1 = " + choicesScene1[0] + " Choice 2 = " + choicesScene1[1] + " Choice 3 = " + choicesScene1[2]);
            Console.WriteLine("SCENE 2: Choice 4 = " + choicesScene2[0]);
        }
    }
}