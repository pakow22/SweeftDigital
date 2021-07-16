using System;

namespace sweeftDigital
{
    class Exercise
    { /*
         1.     დაწერეთ ფუნქცია, რომელსაც გადაეცემა ტექსტი  და აბრუნებს პალინდრომია თუ არა.
        (პალინდრომი არის ტექსტი რომელიც ერთნაირად იკითხება ორივე მხრიდან). 
          Boolean isPalindrome(String text);
        */
        public static Boolean IsPalindrome(String text)
        {
            string[] compareableString = new string[text.Length];

            int j = text.Length - 1;
            for (int i = 0; i <= compareableString.Length; i++)
            {
                for (; j >= 0;)
                {
                    compareableString[i] = text[j].ToString();
                    j--;
                    break;
                }
            }

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].ToString() == compareableString[i].ToString())
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        /*  2.     გვაქვს 1,5,10,20 და 50 თეთრიანი მონეტები. 
         * დაწერეთ ფუნქცია, რომელსაც გადაეცემა თანხა (თეთრებში)
         * და აბრუნებს მონეტების მინიმალურ რაოდენობას, რომლითაც შეგვიძლია ეს თანხა დავახურდაოთ.
         */
        public static int MinSplit(int amount)
        {
            int count = 0;
            int[] coins = { 50, 20, 10, 5, 1 };
            int i = 0;

            while (amount > 0)
            {
                if (amount >= coins[i])
                {
                    amount -= coins[i];
                    count++;
                    i = 0;
                    continue;
                }
                i++;
            }
            return count;
        }
        /*3. მოცემულია მასივი, რომელიც შედგება მთელი რიცხვებისგან.
         *   დაწერეთ ფუნქცია რომელსაც გადაეცემა ეს მასივი და აბრუნებს მინიმალურ მთელ რიცხვს,
         *    რომელიც 0-ზე მეტია და ამ მასივში არ შედის.
         */
        public static int NotContains(int[] array)
        {
            int minNumber = 1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == minNumber)
                {
                    minNumber++;
                    i = 0;
                }
            }

            return minNumber;
        }
        /*4. მოცემულია String რომელიც შედგება „(„ და „)“ ელემენტებისგან.
        * დაწერეთ ფუნქცია რომელიც აბრუნებს ფრჩხილები არის თუ არა მათემატიკურად სწორად დასმული.
        */
        public static Boolean IsProperly(string sequence)
        {
            char open = '(';
            char close = ')';
            int isProperly = 0;

            for (int i = 0; i < sequence.Length; i++)
            {
                char currentChar = sequence[i];
                if (open == currentChar)
                {
                    isProperly += 1;
                }
                else if (close == currentChar)
                {
                    isProperly -= 1;
                }
                if (isProperly < 0)
                {
                    return false;
                }
            }

            return isProperly == 0;
        }


        /* 5.     გვაქვს n სართულიანი კიბე, ერთ მოქმედებაში შეგვიძლია ავიდეთ 1 ან 2 საფეხურით.
        დაწერეთ ფუნქცია რომელიც დაითვლის n სართულზე ასვლის ვარიანტების რაოდენობას.
        Int countVariants(Int stearsCount);

         */
        public static int CountVariants(int stearsCount)
        {
            int arrSize = CalculateArrSize(stearsCount) + (int)Steps.Double;
            int[] numbers = new int[arrSize];
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0 || i == (int)Steps.Single)
                {
                    numbers[i] = i;
                    continue;
                }
                numbers[i] = numbers[i - (int)Steps.Double] + numbers[i - (int)Steps.Single];
                count = numbers[i];
            }

            return count;
        }

        private static int CalculateArrSize(int size)
        {
            int count = 0, oldVal = 0, prevVal = (int)Steps.Single;

            while (true)
            {
                int nextVal = oldVal + prevVal;
                oldVal = prevVal;
                prevVal = nextVal;

                if (nextVal > size)
                {
                    break;
                }
                count++;
            }
            return count;
        }

        enum Steps
        {
            Single = 1,
            Double = 2
        }

        /* 6.   იხილეთ MyStack და MyEnumerator*/
    }
}
