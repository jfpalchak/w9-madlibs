using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    // Choose your MadLib form!
    [Route("/")]
    public ActionResult Choice() { return View(); }

    // The MadLib Forms
    [Route("/excuse-form")]
    public ActionResult FormOne() { return View(); }

    [Route("/hallpass-form")]
    public ActionResult FormTwo() { return View(); }

    // The MadLib Story
    [Route("/excuse")]
    public ActionResult MadLibsOne(string name, string bodyPart, string typeOfFluid, string aSubstance)
    {
      MadLibsVariable userMadLibsVariable = new MadLibsVariable();
      // set all the properties/fields for the variable here, using form input
      userMadLibsVariable.Name = name;
      userMadLibsVariable.BodyPart = bodyPart;
      userMadLibsVariable.Fluid = typeOfFluid;
      userMadLibsVariable.Substance = aSubstance;
      // throw the object into our MadLibs View file to implement the variables:
      return View(userMadLibsVariable);
    }

    [Route("/hallpass")]
    public ActionResult MadLibsTwo(string name, string place, string noun)
    {
      MadLibsVariable userMadLibsVariable = new MadLibsVariable();

      userMadLibsVariable.Name = name;
      userMadLibsVariable.Place = place;
      userMadLibsVariable.Noun = noun;

      return View(userMadLibsVariable);
    }
  }
}