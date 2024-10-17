using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class CalculatorController : ControllerBase
{
    [HttpGet("add")]
    public IActionResult Add([FromQuery] int num1, [FromQuery] int num2)
    {
        var result = num1 + num2;
        return Ok(result);
    }

    [HttpGet("subtract")]
    public IActionResult Subtract([FromQuery] int num1, [FromQuery] int num2)
    {
        var result = num1 - num2;
        return Ok(result);
    }

    [HttpGet("multiply")]
    public IActionResult Multiply([FromQuery] int num1, [FromQuery] int num2)
    {
        var result = num1 * num2;
        return Ok(result);
    }

    [HttpGet("divide")]
    public IActionResult Divide([FromQuery] int num1, [FromQuery] int num2)
    {
        if (num2 == 0)
        return BadRequest("Bölen 0 olamaz.");
        var result = num1 / num2;
        return Ok(result);
    }

    [HttpGet("power")]
    public IActionResult Power([FromQuery] double num, [FromQuery] double exponent)
    {
        var result = Math.Pow(num, exponent);
        return Ok(result);
    }

    [HttpGet("sqrt")]
    public IActionResult SquareRoot([FromQuery] double num)
    {
        var result = Math.Sqrt(num);
        return Ok(result);
    }

}
