using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoAPIv8.Context;
using ToDoAPIv8.Models;

namespace ToDoAPIv8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
      private readonly ApplicationDbContext _context;
    public CategoryController(ApplicationDbContext context) // DbContext تعريف  يتم تمريره إلى الكنترولر باستخدام Dependency Injection
    {
        _context = context;  //نخزنه في متغير خاص _context علشان نستخدمه داخل الدوال (الـ actions
    }

    //IActiopnResultb

    [HttpGet(Name = "GetCategories")]
    [ProducesResponseType(StatusCodes.Status200OK)]

    public ActionResult GetCategories()
    {
        var cats = _context.categories.ToList(); // يجلب كل الفئات من قاعدة البيانات
        if (cats.Count == 0)
        {

            return Ok("Empyu Result"); // يرجع رسالة إذا ما فيه بيانات
                                       // return äwait k(cats); // retuen category 
        }

        return Ok(cats); // sucessed 200 with data  // يرجع البيانات مع كود 200

    }

    [HttpGet("id")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]

    public ActionResult GetCategory(int id)
    {
        var cat = _context.categories.FirstOrDefault(c => c.Id == id);
        if (cat == null)
        {
            return NotFound(); // إذا ما لقى الفئة يرجع 404
        }

        return Ok(cat);  // إذا لقاها يرجعها مع كود 200
    }




    //إضافة فئة جديدة (Category)

    [HttpPost]
    public ActionResult CreateCategories(Category obj)
    {

        Category cat = new Category()
        {
            Name = obj.Name
        };

        _context.categories.Add(cat);
        _context.SaveChanges();
        return Ok(cat);
    }

    [HttpPost("id")]
    public ActionResult UpdateCategory(int id, Category category)
    {
        var cat = _context.categories.FirstOrDefault(c => c.Id == id);
        if (cat == null)
        {
            return NotFound();
        }

        // تحديث البيانات
        cat.Name = category.Name;

        _context.categories.Update(cat);
        _context.SaveChanges();
        return Ok(cat);

    }
        // حذف فئة (Category) حسب الـ ID
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult DeleteCategory(int id)
        {
            var cat = _context.categories.FirstOrDefault(c => c.Id == id);
            if (cat == null)
            {
                return NotFound();
            }

            _context.categories.Remove(cat);
            _context.SaveChanges();
            return NoContent();

        }



    }

}


