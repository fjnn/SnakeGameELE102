﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SnakeGame
{
    class Input
    {
        //Load the list of available Keyboart buttons
        private static Hashtable keyTable = new Hashtable();

        // Perform a check to see if a particulat button is pressed.
        public static bool KeyPressed(Keys key)
        {
            if(keyTable[key] == null)
            {
                return false;
            }

            return (bool)keyTable[key];
        }

        // Detect if a keyboard button is pressed
        public static void ChangeState(Keys key, bool state)
        {
            keyTable[key] = state;
        }

    }
}
