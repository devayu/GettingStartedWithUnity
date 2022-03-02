using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basics_Programming : MonoBehaviour
{
    //vars
    // public float speed = 5f;
    // double speed2 = 20.0;
    // int health = 100;
    // string playerName = "PLAYER_01";
    // bool isDead = false;
    // char id = 'A';
    /*
    * * functions, conditional statements, loops , switch all have the same syntax as c/cpp

    ! Naming Conventions public vars or functions should use PascelCasing eg- function TestFunc()
    ! Private vars or methods should use camelCasing starting with _ prefix
    */
    public bool isDead = true;


    private void Start()
    {
        StartCoroutine(ExecuteAfterSometime()); // calling an async function
        // ** StartCoroutine("executeAfterSometime"); this is also calling the function but this way can be used to stop the coroutines as well
        // * * StopCoroutine("executeAfterSometime");

        Player player = new Player(100, 90, "Player");
        player.Health = 250;
        Warrior warrior = new Warrior(100, 90, "Warrior");
        warrior.Info();
    }
    // * * Coroutines (async basically)
    IEnumerator ExecuteAfterSometime()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("This executed after 2sec");
        yield return new WaitForSeconds(2f);
        // more code executed after 4secs
        Debug.Log("This executed after 4sec");
        yield return new WaitForSeconds(2f);
        // more code executed after 6 sec
        Debug.Log("This executed after 6sec");
    }

}
