using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace HMI_MF.Controllers
{
    public class TagController : Controller
    {
        private readonly IConfiguration configuration;
        private readonly ILogger<TagController> _logger;

        public TagController(IConfiguration config, ILogger<TagController> logger)
        {
            this.configuration = config;
            _logger = logger;
        }

        // GET: TagController
        public ActionResult Index()
        {
            string connectionString = configuration.GetConnectionString("HMI_DB");

            SqlConnection conn = new(connectionString);

            conn.Open();

            SqlCommand cmd = new("SELECT * FROM Tags", conn);
            var count = (int)cmd.ExecuteScalar();
            var names = (int)cmd.ExecuteNonQuery();

            ViewData["TotalData"] = names;

            conn.Close();

            return View();
        }

        // GET: TagController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TagController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TagController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TagController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TagController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TagController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TagController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
