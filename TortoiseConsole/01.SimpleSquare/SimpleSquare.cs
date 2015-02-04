using System;
using SmallBasicFun;
using System.Drawing;

namespace SimpleSquare
{
    public class SimpleSquare
    {
        public static void Main()
        {
            //	Show the tortoise --#1
            Tortoise.Show();
            Tortoise.SetSpeed(4);

            //  Make the tortoise move as fast as possible  --#6

            //  Do the following 4 times --#5.1

            //     Change the color of the line the tortoise draws to blue --#4
            Tortoise.SetPenColor(GetRandomColorName());
            //     Move the tortoise 50 pixels --#2
            Tortoise.Move(150);
            //     Turn the tortoise 90 degrees to the right --#3

            Tortoise.SetSpeed(6);

            for (int i = 0; i < 10; i++)
            {
                // Turn 10%
                Tortoise.Turn(9);
                //  Repeat --#5.2
                Tortoise.SetPenColor(GetRandomColorName());
                Tortoise.Move(10);
            }

            Tortoise.Turn(90);
            Tortoise.SetPenColor(GetRandomColorName());
            Tortoise.Move(260);


            Tortoise.Turn(90);
            Tortoise.SetSpeed(8);
            Tortoise.Move(3);
            Tortoise.Turn(90);
            Tortoise.SetPenColor(GetRandomColorName());
            Tortoise.Move(254);
            Tortoise.Turn(-90);
            Tortoise.SetPenColor(GetRandomColorName());

            for (int i = 0; i < 10; i++)
            {
                // Turn 10%
                Tortoise.Turn(-9);
                //  Repeat --#5.2
                Tortoise.Move(10);
                Tortoise.SetSpeed(10);
                Tortoise.SetPenColor(GetRandomColorName());
            }

            Tortoise.Move(135);
            Tortoise.Turn(90);
            Tortoise.Move(12);
            Tortoise.Turn(180);
            Tortoise.Move(65);
            Tortoise.SetSpeed(12);
            Tortoise.SetPenColor(GetRandomColorName());
            Tortoise.Turn(90);
            Tortoise.Move(52);
            Tortoise.Turn(270);
        }

        private static string GetRandomColorName()
        {
            Guid guid = Guid.NewGuid();
            int hash = (int)guid.GetHashCode();
            Random randomGen = new Random(hash);
            var names = Enum.GetValues(typeof(KnownColor));
            int theNumber = randomGen.Next(names.Length);
            KnownColor randomColorName = (KnownColor)names.GetValue(theNumber);
            Color randomColor = Color.FromKnownColor(randomColorName);
            return randomColor.Name;
        }
    }
}
