static void Main(string[] args)
{
    while (true)
    {

        Console.WriteLine("Input Odd number(0 to exit)");
        var num = Console.ReadLine();

        var nums = int.Parse(num);

        if (nums <= 0)
        {
            break;
        }

        if ((nums % 2) == 0)
        {
            continue;
        }

        var enternum = nums;
        var minusOperation = true;

        for (int i = 1; i <= nums; i++)
        {
            var ss = "  ";

            var spacesLR = Math.Abs(Math.Abs(enternum) / 2);
            ss += string.Concat(Enumerable.Repeat(" ", spacesLR));
            ss += string.Concat(Enumerable.Repeat("*", nums - (spacesLR + spacesLR)));
            ss += string.Concat(Enumerable.Repeat(" ", spacesLR));

            Console.WriteLine(ss);

            if (minusOperation)
            {
                enternum -= 2;
            }
            else
            {
                enternum += 2;
            }

            if (enternum <= 0)
            {
                enternum = 3;
                minusOperation = false;
            }


        }

    }
