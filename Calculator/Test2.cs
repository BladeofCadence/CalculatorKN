using System;


public class Test2 : ISolve
{
    public string mathstring = "";

    double hold1 = 0;
    double hold2 = 0;

    public string[] element = new string[50];
    public string[] pemdas = new string[5] { "%", "*", "/", "+", "-" };


    public int count = 0;
    public void Accumulate(string s)
    {

        //check negatives (- when symbols appear then add a )
        //everytime we accumilate a symbol, we close off the last, add the symbol to a separate place
        if (s == "+" || s == "-" || s == "/" || s == "%" || s == "*")
        {
            //close of the last double and clear the hold
            element[count] = mathstring;
            count++;
            mathstring = "";

            //add the symbol to a new space by itself
            element[count] = s;
            count++;
        }
        else if (s == "(-")
        {
            mathstring += "-";
        }
        else
        {
            //if it's not a symbol, we add it together as a double
            mathstring += s;
        }
    }
    public void Clear()
    {
        //clear all elements 
        mathstring = "";
        for (int i = 0; i < element.Length; i++)
        {
            element[i] = "";
        }
        count = 0;
    }

    public double Solve()
    {
        element[count] = mathstring;
        double result = 0;

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < count; j++)
            {
                if (element[j] == "+" || element[j] == "-" || element[j] == "/" || element[j] == "%" || element[j] == "*")
                {
                    hold1 = Convert.ToDouble(element[j - 1]);
                    hold2 = Convert.ToDouble(element[j + 1]);
                    if (element[j] == "%") { result = hold1 % hold2; }
                    if (element[j] == "*") { result = hold1 * hold2; }
                    if (element[j] == "/") { result = hold1 / hold2; }
                    if (element[j] == "+") { result = hold1 + hold2; }
                    if (element[j] == "-") { result = hold1 - hold2; }
                    element[j - 1] = Convert.ToString(result);

                    for (int k = j; k < element.Length - 2; k++)
                    {
                        element[k] = element[k + 2];
                        element[k + 2] = "";
                    }
                }
            }
        }

        return result;
    }
}
