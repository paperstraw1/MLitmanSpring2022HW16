using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
    private string name;
    private Room currentRoom;

    public Enemy()
    {
        //this.name = name;
        this.currentRoom = null;
    }

    /*
    public string getName()
    {
        return this.name;
    }
    */

    public void setRoom(Room r)
    {
        this.currentRoom = r;
    }

    /*
    public Room getRoom()
    {
        return this.currentRoom;
    }
    */
}