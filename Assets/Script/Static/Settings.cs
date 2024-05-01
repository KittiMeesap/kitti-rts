using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Settings
{
    public static string currentScene;

    public static Nation mySide;
    public static Nation EnemySide;

    public static void SelectSide(int side)
    {
        switch (side)
        {
            case 0:
                mySide = Nation.Britain;
                EnemySide = Nation.France;
                EnemySide = Nation.Portugal;
                EnemySide = Nation.Spain;
                break;
            case 1:
                mySide = Nation.France;
                EnemySide = Nation.Britain;
                EnemySide = Nation.Portugal;
                EnemySide = Nation.Spain;
                break;
            case 2:
                mySide = Nation.Portugal;
                EnemySide = Nation.Britain;
                EnemySide = Nation.France;
                EnemySide = Nation.Spain;
                break;
            case 3:
                mySide = Nation.Spain;
                EnemySide = Nation.Britain;
                EnemySide = Nation.France;
                EnemySide = Nation.Portugal;
                break;
        }
    }
}