using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        public DataController()
        {
        }
        [HttpGet]
        public IActionResult GetAllNames()
        {
            List<string> names = new List<string>();
            names.Add("Jaweed");
            names.Add("Tariel");
            names.Add("BATMAN");
            return Ok(names);
        }

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            return Ok(StudentDB.GetStudents());
        }
        
        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
           
            Student student = StudentDB.GetStudentById(id);
            if(student == null) return NotFound();
            else return Ok(student);    
        }

        [HttpPost]
        public IActionResult CreateStudent([FromBody] Student student)
        {

            StudentDB.CreateStudent(student);
            return NoContent();
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Student student)
        {
            Student studentFromDb = StudentDB.GetStudentById(id);
            if(studentFromDb == null) return NotFound();
            studentFromDb.Age = student.Age;
            studentFromDb.Name = student.Name;
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            Student studentFromDb = StudentDB.GetStudentById(id);
            if (studentFromDb == null) return NotFound();
            StudentDB.Remove(studentFromDb);
            return NoContent();
        }
        
    }
}
