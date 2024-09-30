using Microsoft.AspNetCore.Mvc;

namespace Cp04.Controller;

public interface IExchangeController
{
   JsonResult GetExchangeRate();
}