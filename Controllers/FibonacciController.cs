using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("[controller]")]
public class FibonacciController : ControllerBase
{
    public FibonacciController()
    {
    }

    [HttpGet("{n}")]
    public int Get(int n)
    {
        return Fibonacci(n);
    }

    static int Fibonacci(int n)
    {
        int firstnumber = 0;
        int secondnumber = 1; 
        int result = 0;
        if (n == 0) return 0; 
        if (n == 1) return 1; 
        for (int i = 2; i<= n; i++)
        {
            result = firstnumber + secondnumber;
            firstnumber = secondnumber;
            secondnumber = result;
        }
        return result;
    }
}