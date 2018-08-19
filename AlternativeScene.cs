using System;

namespace AlternativeScene
{
    //Enumeration representing next action to execute
    enum Command { Comment, AskPlayerChoice, EndScene, Undefined };

    //Represents a generic scene and its proprieties
    public class GenericScene
    {
        public String result { get; set; } = "UNDEFINED";
        public int currentBranch { get; set; }
        private ArrayList lines;

        public GenericScene(String fileName)
        {
            lines = new ArrayList(System.IO.File.ReadAllLines(fileName));
        }
        public String getNextLine()
        {
            String toReturn = (String)lines[0];
            lines.RemoveAt(0);
            return (toReturn);
        }

    }

    public class StateOfGame
    {
        //TODO
        //Should be created by the AltSceneManager instance, and its methods should be called in order to load appropriate
        //scene at the correct point in time, as well as world stats (ex: relationship level with each character)
        //Should also be called by the AltSceneManager to save state before quitting the game
    }

    //Manages all scenes by loading them and dealing with user input
    public class AltSceneManager
    {
        private GenericScene currentScene;
        private SceneParser parser;
        private bool running;

        public AltSceneManager()
        {
            currentScene = new GenericScene("ExampleScene.txt");
            parser = new SceneParser();
        }
        public void startScene()
        {
            //TODO: Should load appropriate SceneOfGame

            run();
        }
        public void run()
        {
            while(running)
            {
                String nextLine = currentScene.getNextLine();
                Command nextCommand = parser.evaluateNextAction(nextLine);
                switch (nextCommand)
                {
                    case Command.Comment:
                        //Simply ignores comments
                        break;
                    case Command.AskPlayerChoice:
                        nextChoice(nextLine);
                        break;
                    case Command.EndScene:
                        endScene(nextLine);
                        running = false;
                        break;
                    case Command.Undefined:
                        Console.WriteLine("\nSyntax of scene file invalid");
                        running = false;
                        break;
                }
            }
        }
        public void nextChoice(String line)
        {
            Console.WriteLine("\nMake a choice:");
            //TODO: Implement next choice reading by continuing the
            //reading of the file, adding to the process queue in parser
            //and using SceneParser's getChoices to modify the scene as needed
        }
        public void endScene(String line)
        {
            //TODO: Ends and updates scene as needed
        }
    }

    public class SceneParser
    {
        private ArrayList linesToProcess = new ArrayList();

        public Command evaluateNextAction(String line)
        {
            if(line.StartsWith("#"))
            {
                return Command.Comment;
            }
            else if(line.StartsWith("-"))
            {
                return Command.AskPlayerChoice;
            }
            else if(line.StartsWith("+"))
            {
                return Command.EndScene;
            }
            else
            {
                return Command.Undefined;
            }
        }
        public void addToProcessQueue(String line)
        {
            linesToProcess.Add(line);
        }
        public ArrayList getChoices()
        {
            //TODO: Parses and returns the choices to display
        }
    }
}