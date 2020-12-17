using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MISIS.NetCore.Presentation
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class MisisControllerBase : ControllerBase
    {
        protected IActionResult ExecuteLogic<T>()
        {
            Console.WriteLine($"We are here {nameof(ExecuteLogic)}");
            try
            {
                return DoTheLogic<T>();
            }
            catch (Exception e)
            {
                Console.Write(e);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        protected abstract IActionResult DoTheLogic<T>();
    }
}


//Template method

public abstract class TempMeth
{
    public void ExecuteTopLevel()
    {
        DoSomethingWhatWeSure();
        DerivedMethod();
        DoAnotherWhatWeShure();
    }

    private void DoAnotherWhatWeShure()
    {
        Console.WriteLine();
    }

    private void DoSomethingWhatWeSure()
    {
        throw new NotImplementedException();
    }

    protected abstract void DerivedMethod();
}

public class DerivedClass : TempMeth
{
    protected override void DerivedMethod()
    {
        throw new NotImplementedException();
    }
}

public class DerivedClass2 : TempMeth
{
    protected override void DerivedMethod()
    {
        throw new NotImplementedException();
    }
}