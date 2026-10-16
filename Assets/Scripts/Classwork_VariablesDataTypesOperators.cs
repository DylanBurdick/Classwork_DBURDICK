using UnityEngine;

// Variables, Data Types & Operators
// Attach this to an empty GameObject and press Play. Work through the TODOs.
public class L5_Variables_Operators_Reps_DBURDICK : MonoBehaviour
{
    void Start()
    {
        // TODO A1. Declare a variable of the RIGHT type (write the full line):
        // TODO   1. arrows: 12
        int arrows = 12;
        // TODO   2. player's name: Kael
        string playerName = "Kael";
        // TODO   3. gate is open: true
        bool gateIsOpen = true;
        // TODO   4. a single grade letter: B
        char grade = 'B';
        // TODO   5. move speed: 4.5
        float moveSpeed = 4.5f;
        // TODO   6. a precise price: 19.99
        float price = 19.99f;

        // TODO A2. Name the TYPE (int / float / double / char / bool / string):
        // TODO   7. number of potions 
        // int
        // TODO   8. character name
        // string
        // TODO   9. is the door locked
        // bool
        // TODO   10. one keyboard key as a letter
        // char

        // TODO A3. Compute the result (write the value as a comment):
        // TODO   11. 8 + 5        13. 20 % 6        15. 2 + 3 * 4
        //            13               2                 14
        // TODO   12. 15 / 4       14. 10 % 2        16. (2 + 3) * 4
        //            3                0                 20

        // TODO A4. Rewrite each with a COMPOUND operator:
        // TODO   17. score = score + 100;
        //            score += 100;
        // TODO   18. health = health - 20;
        //            health -= 20;
        // TODO   19. speed = speed * 2;
        //            speed *= 2;
        // TODO   20. lives = lives - 1;   (also show the -- form)
        //            lives -= 1;
        //            lives--

        // TODO A5. PREDICT the final value (write it as a comment):
        // TODO   21.   int x = 10;
        //              x += 5;
        //              x -= 3;
        //              12
        // TODO   22.   int h = 100;
        //              h -= 30;
        //              h += 2 * 20;
        //              110

        // TODO 23. Declare four stats for a MONSTER (name, health, attack,
        //          alive) with proper types, then print them on one line.
        string monsterName = "Goblin";
        int monsterHP = 10;
        string monsterAttack = "Swing";
        bool monsterIsAlive = true;
        Debug.Log(monsterName + ", " + monsterHP + ", " + monsterAttack + ", " + monsterIsAlive);
        // TODO 24. int health = 100; apply a 25 hit, a 40 heal, a 60 hit with
        //          compound operators, printing health after each. What three
        //          numbers appear?
        int health = 100;
        health -= 25;
        Debug.Log(health);
        health += 40;
        Debug.Log(health);
        health -= 60;
        Debug.Log(health);

        // TODO 25. Fix each broken line, then write the corrected version:
        //            int speed = 5.5;
        //            needs to be a float and have an f at the end of the number.
        float speed = 5.5f;
        //            string name = Aria;
        //            needs quotations around Aria.
        string name = "Aria";
        //            int g = "20";
        //            20 doesn't need quotations around it. g might also just not be a good name
        //            for a variable, probably meant to be gold if i had to guess.
        int gold = 20;


        // TODO 26. SWAP: int a = 3; int b = 8; write code that swaps them so
        //          a becomes 2 and b becomes 1. Try this first with an extra
        //          variable, then do it without any other variables.
        int a = 3;
        int b = 8;
        int c;
        c = a;
        a = b;
        b = c;
        a = 3;
        b = 8;
        // my thought process for this was very similar to the water jug problem we did, so a bit of "using what i already knew" in this.
        a = a + b;
        b = a - b;
        a = a - b;

        // TODO 27. SECONDS TO CLOCK: given int totalSeconds, print hours, 
        //          minutes and seconds: e.g. if totalSeconds is set to:
        //              125, output is "2m 5s"
        //              3600, output is "1h"
        //              10000, output is "2h 46m 40s"
        int totalSeconds = 3665;
        int hours = totalSeconds / 3600;
        int minutes = (3665 % 3600) / 60;
        int seconds = ((3665 % 3600) % 60);
        Debug.Log(hours + "h " + minutes + "m " + seconds + "s ");

        // TODO 28. EVERY THIRD HIT: a sword deals 10 damage, but every 3rd hit
        //          deals double. Using %, print the damage of hits 1 to 6.
        int swordDamage = 10;
        Debug.Log(swordDamage + " " + swordDamage + " " + swordDamage * 2 + " " + swordDamage + " " + swordDamage + " " + swordDamage * 2);
    }
}
