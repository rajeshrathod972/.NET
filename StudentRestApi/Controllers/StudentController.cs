using Microsoft.AspNetCore.Mvc;
using StudentRestApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly AppDbContext appDbContext;
        public StudentController(AppDbContext dbContext) { 
            this.appDbContext = dbContext;
        }
       static List<Student> students=new List<Student>();
        // GET: api/<StudentController>
        [HttpGet]
        public IActionResult Get()
        {
            var students = appDbContext.Students.ToList();
            return Ok(students);
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            /* return students.FirstOrDefault(s=>s.StudentId == id);*/
           var students= appDbContext.Students.Find(id);
            if(students is null)
            {
                return NotFound();
            }
            return Ok(students);

        }

        // POST api/<StudentController>
        [HttpPost]
        public void Post([FromBody] AddStudentDto addStudentDto)
        {
            var studentEntity = new Student()
            {
                FirstName = addStudentDto.FirstName,
                LastName = addStudentDto.LastName,
                email = addStudentDto.email,
                DepartmentId = addStudentDto.DepartmentId,
                PhotoPath = addStudentDto.PhotoPath,


            };
            appDbContext.Students.Add(studentEntity);
            appDbContext.SaveChanges();
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] AddStudentDto addStudentDto)
        {
            /*int i=students.FindIndex(s => s.StudentId == id);
            if (i > 0)
            {
                students[i] = value;
            }*/
            var student=appDbContext.Students.Find(id);
            if(student is null)
            {
                return NotFound();
            }
            student.FirstName = addStudentDto.FirstName;
            student.LastName = addStudentDto.LastName;
            student.email = addStudentDto.email;
            student.DepartmentId = addStudentDto.DepartmentId;
            student.PhotoPath = addStudentDto.PhotoPath;

            appDbContext.SaveChanges();
            return Ok(student);


        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
          /*  students.RemoveAll(s => s.StudentId == id);*/
          var student=appDbContext.Students.Find(id);
          if (student is null)
            {
                return NotFound();
            }
          appDbContext.Students.Remove(student);
          appDbContext.SaveChanges();
          return Ok();
        }
    }
}
