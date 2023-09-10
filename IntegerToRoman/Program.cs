namespace IntegerToRoman;
public class Solution
{
    public string IntToRoman(int num)
    {
        var roman = new List<string>()
        { "I", "V", "X", "L", "C", "D", "M" };

        string romanOutput = "";
        var strNum = num.ToString();
        int length = strNum.Length;
        int offset =0;

        for (int i = length-1; i >= 0; i--)
        {
            var currentNum = Convert.ToInt32(strNum[i].ToString());
            if (currentNum < 4)
            {
                romanOutput = String.Concat(Enumerable.Repeat(roman[offset], currentNum)) + romanOutput;
            }
            else if (currentNum == 4)
            {
                romanOutput = roman[offset] + roman[offset + 1] + romanOutput;
            }
            else if (currentNum<9)
            {
                romanOutput = roman[offset + 1] + String.Concat(Enumerable.Repeat(roman[offset], currentNum - 5)) + romanOutput;
            }
            else
            {
                romanOutput = roman[offset ] + roman[offset + 2] + romanOutput;
            }

            offset += 2;
        }
        return romanOutput;

    }
}
