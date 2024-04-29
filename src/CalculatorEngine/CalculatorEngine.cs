using System;
using System.Runtime.CompilerServices;

namespace CalculatorEngine;

public class CalculatorEngine
{

    public static CalculatorResults Add(double inputA, double inputB)
    {
        // preq-ENGINE-3
        var sum = new CalculatorResults();

        sum.Result = inputA + inputB;
        sum.IsSuccess = true;
        sum.Operation = $"{inputA} + {inputB}";
        sum.Error += null;

        return sum;
    }

    public static CalculatorResults Subtraction(double inputA, double inputB)
    {
        // preq-ENGINE-4
        var difference = new CalculatorResults();

        difference.Result = inputA - inputB;
        difference.IsSuccess = true;
        difference.Operation = $"{inputA} - {inputB}";
        difference.Error += null;

        return difference;
    }

    public static CalculatorResults Multiplication(double inputA, double inputB)
    {
        // preq-ENGINE-5
        var product = new CalculatorResults();

        product.Result = inputA * inputB;
        product.IsSuccess = true;
        product.Operation = $"{inputA} * {inputB}";
        product.Error += null;

        return product;
    }


    public static CalculatorResults Division(double inputA, double inputB)
    {
        // preq-ENGINE-7
        var quotient = new CalculatorResults();

        quotient.Operation = $"{inputA} / {inputB}";

        if (inputB == 0)
        {
            quotient.Error = "Not a Number.";
            quotient.IsSuccess = false;
            return quotient;
        }

        quotient.Result = inputA / inputB;
        quotient.IsSuccess = true;
        quotient.Error += null;

        return quotient;
    }

    public static CalculatorResults Equals(double inputA, double inputB)
    {
        // preq-ENGINE-8
        var equal = new CalculatorResults();
        var range = Math.Pow(10, -8);
        var difference = Math.Abs(Math.Abs(inputA) - Math.Abs(inputB));

        equal.IsSuccess = true;
        equal.Operation = $"{inputA} == {inputB}";
        equal.Error += null;

        if (difference <= range)
        {
            equal.Result = 1;
            return equal;
        }

        equal.Result = 0;
        return equal;
    }

    public static CalculatorResults RaisetoPower(double inputA, double inputB)
    {
        // preq-ENGINE-9
        var power = new CalculatorResults();

        power.Result = Math.Pow(inputA, inputB);
        power.IsSuccess = true;
        power.Operation = $"{inputA} ^ {inputB}";
        power.Error += null;

        return power;
    }

    public static CalculatorResults Logarithmofnumber(double inputA, double inputB)
    {
        // preq-ENGINE-10
        var log = new CalculatorResults();

        log.Operation = $"{inputA} log {inputB}";

        if (inputA <= 0)
        {
            log.IsSuccess = false;
            log.Error = "Not a number.";
            return log;
        }

        if (inputB == 0)
        {
            log.IsSuccess = false;
            log.Error = "Not a number.";
            return log;
        }

        log.Result = Math.Log(inputA, inputB);
        log.IsSuccess = true;
        log.Error += null;

        return log;
    }

    public static CalculatorResults Rootofnumber(double inputA, double inputB)
    {
        // preq-ENGINE-11
        var root = new CalculatorResults();

        root.Operation = $"{inputA} root {inputB}";

        if (inputB == 0)
        {
            root.IsSuccess = false;
            root.Error = "Not a number.";
            return root;
        }

        root.Result = Math.Pow(inputA, 1 / inputB);
        root.IsSuccess = true;
        root.Error += null;

        return root;
    }

    public static CalculatorResults Factorialofnumber(double inputA)
    {
        // preq-ENGINE-12
        var factorial = new CalculatorResults();

        factorial.Operation = $"{inputA}!";

        if ((inputA < 0) || (inputA % 1 != 0))
        {
            factorial.Error = "Not a number.";
            factorial.IsSuccess = false;
            return factorial;
        }

        factorial.Result = 1;
        while (inputA != 0)
        {
            factorial.Result *= inputA;
            inputA--;
        }
        factorial.IsSuccess = true;
        factorial.Error += null;

        return factorial;
    }

    public static CalculatorResults SineofA(double inputA)
    {
        // preq-ENGINE-13
        var sin = new CalculatorResults();

        sin.Result = Math.Sin(inputA);
        sin.IsSuccess = true;
        sin.Operation = $"sin({inputA})";
        sin.Error += null;

        return sin;
    }

    public static CalculatorResults CosineofA(double inputA)
    {
        // preq-ENGINE-13
        var cosine = new CalculatorResults();

        cosine.Result = Math.Cos(inputA);
        cosine.IsSuccess = true;
        cosine.Operation = $"cos({inputA})";
        cosine.Error += null;

        return cosine;
    }

    public static CalculatorResults TangentofA(double inputA)
    {
        // preq-ENGINE-15
        var tan = new CalculatorResults();

        tan.Result = Math.Tan(inputA);
        tan.IsSuccess = true;
        tan.Operation = $"tan({inputA})";
        tan.Error += null;

        return tan;
    }

    public static CalculatorResults ReciprocalofA(double inputA)
    {
        // preq-ENGINE-16
        var reciprocal = new CalculatorResults();

        reciprocal.Operation = $"1 / {inputA}";

        if (inputA == 0)
        {
            reciprocal.IsSuccess = false;
            reciprocal.Error = "Not a number.";
            return reciprocal;
        }

        reciprocal.Result = 1 / inputA;
        reciprocal.IsSuccess = true;
        reciprocal.Error += null;

        return reciprocal;
    }
}