﻿

using System.Data;

internal class Game
{
    public Game()
    {
    }

    internal void Run()
    {
        Inizialize();
    }

    private void Inizialize()
    {
        var map = new Map(width: 10, height: 10);
    }
}