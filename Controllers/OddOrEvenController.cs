// Daniel Decoito
// 10-26-22
// Mini Challenge: Odd or Even
// Use api to recreate the odd or even function
// Reviewd by Jacob Dekok - The code is simple, organized, and easy to read
// The program runs great


using Microsoft.AspNetCore.Mvc;

namespace DecoitoDMiniChallenge_OddOrEven.Controllers;

[ApiController]
[Route("[controller]")]
public class OddOrEvenController : ControllerBase
{
  
    [HttpGet]
    [Route("Game/{number}")]
    public string Game(string number)
    {
       int num = int.Parse(number);
       return number = num % 2 == 0 ? "Your number is even" : "Your number is Odd";
        
    }


}
