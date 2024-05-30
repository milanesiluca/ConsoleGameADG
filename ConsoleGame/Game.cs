

using System.Data;

internal class Game
{
    private Map map = null!;
    private Player player = null!;
    public Game()
    {
    }

    internal void Run()
    {
        Inizialize();
        Play();
    }

    private void Play()
    {
        bool gameInProgress = true;

        do {

            //DrowMap

            //Get Command 

            //Act

            //Drawmap

            //Enemy Action

            //Drow map again

        } while (gameInProgress);
       
    }

    private void Inizialize()
    {
        //ToDo: config file to check
        map = new Map(width: 10, height: 10);
        player = new Player();
    }
}