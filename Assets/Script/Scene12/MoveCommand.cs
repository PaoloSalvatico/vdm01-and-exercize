using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : MonoBehaviour, ICommand
{
    public void MoveNorth()
    {
        Debug.Log("N");
    }
    public void MoveSouth()
    {
        Debug.Log("S");
    }
    public void MoveEast()
    {
        Debug.Log("E");
    }
    public void MoveWest()
    {
        Debug.Log("W");
    }

    public void Execute(Direction dir)
    {
        switch(dir)
        {
            case Direction.N:
                MoveNorth();
                break;
            case Direction.S:
                MoveSouth();
                break;
            case Direction.W:
            case Direction.E:
                MoveWest();
                MoveEast();
                break;

        }
    }
}

public enum Direction
{
    N,
    S,
    W,
    E
}
