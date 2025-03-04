using Microsoft.AspNetCore.Mvc;

namespace WebApplication1;

[ApiController, Route("api/[controller]")]
public class ToDoController : ControllerBase
{
    public ToDoController()
    {
        
    }


    [HttpGet, Route("all")]
    public ActionResult<List<ToDo>> getToDos()
    {

        return Ok(new List<ToDo>());
    }
}


public class ToDo
{
    public int Id { get; set; }
    public string Title { get; set; }
}