using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System.Drawing;

namespace DAServer.Controllers;
[Route("[controller]")]
[ApiController]
public class ComController : ControllerBase
{
  [HttpGet("img")]
  public string GetImgString()
  {
    byte[] imageArray = System.IO.File.ReadAllBytes(@"C:\Users\Michael\source\repos\DAServer\DAServer\WP_Schizophrenie_überblick-1024x576.jpg");
    return Convert.ToBase64String(imageArray);
  }

  [HttpGet("helloworld")]
  public string GetResponse(string message)
  {
    return $"Dei Nachricht ist: {message}";
  }
}
