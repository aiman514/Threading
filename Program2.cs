using System;
using System.Threading;
class RainSimulation
{
    static void Main()
    {
        //three rain frames
        string[] frames = new string[]
        {
            // Frame 1
    @" . .  . . . . ..
.  . . . .   . .
. ..  . . . .  
. .. . .. . . .

        ______
 __/__|__\__|
|  _     _  `|
'-(_)---(_)--'",

    // Frame 2
    @" . . . . . .. .
.. .   . . .  .
. . .. . . .    
 . . . . .. . .

      ______
 __/__|__\__|
|  _     _  `|
'-(_)---(_)--'",

    // Frame 3
    @"  . . . .   . ..
. . .   ..  . .
 . . . . .. .  
.. . . .. . . .

    ______
 __/__|__\__|
|  _     _  `|
'-(_)---(_)--'",

    // Frame 4
    @" .   . .  . .. .
 . . .  . . . .  
..  . . . .. .  
. . .. . . . . .

  ______
 __/__|__\__|
|  _     _  `|
'-(_)---(_)--'"
        };
        Console.CursorVisible = false;
        for (int i = 0; i < 50; i++)
        {
            foreach (string frame in frames)
            {
                //move cursor to top-left instead of clearing
                Console.SetCursorPosition(0, 0);
                Console.Write(frame);

                Thread.Sleep(50);

            }

        }
        Console.CursorVisible = true;
    }
}