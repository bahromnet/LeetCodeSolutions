namespace Medium._12.IntegertoRoman;
public class Solution12
{
    public string IntToRoman(int num)
    {
        string romain = "";
        if (num >= 1000)
        {
            int thousand = num / 1000;
            num %= 1000;
            for (int i = 1; i <= thousand; i++)
                romain += "M";
        }
        if (num >= 900)
        {
            int nine = num / 900;
            num %= 900;
            romain += nine > 0 ? "CM" : "";
        }
        if (num >= 500)
        {
            int five = num / 500;
            num %= 500;
            romain += five > 0 ? "D" : "";
        }
        if (num >= 400)
        {
            int four = num / 400;
            num %= 400;
            romain += four > 0 ? "CD" : "";
        }
        if (num >= 100)
        {
            int hundred = num / 100;
            num %= 100;
            for (int i = 1; i <= hundred; i++)
                romain += "C";
        }
        if (num >= 90)
        {
            int ninetin = num / 90;
            num %= 90;
            romain += ninetin > 0 ? "XC" : "";
        }
        if (num >= 50)
        {
            int fiftin = num / 50;
            num %= 50;
            romain += fiftin > 0 ? "L" : "";
        }
        if (num >= 40)
        {
            int fotin = num / 40;
            num %= 40;
            romain += fotin > 0 ? "XL" : "";
        }
        if (num >= 10)
        {
            int ten = num / 10;
            num %= 10;
            for (int i = 1; i <= ten; i++)
                romain += "X";
        }
        if (num == 9)
        {
            romain += "IX";
            return romain;
        }

        if (num >= 5)
        {
            romain += "V";
            for (int i = 1; i <= num - 5; i++)
                romain += "I";
        }
        if (num == 4)
            romain += "IV";

        if (num < 4)
            for (int i = 1; i <= num; i++)
                romain += "I";

        return romain;
    }
}
