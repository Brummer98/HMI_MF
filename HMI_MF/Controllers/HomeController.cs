using HMI_MF.Models;
using libplctag.NativeImport;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System;
using System.Net;
using System.Threading;
using libplctag;
using libplctag.DataTypes;
using Microsoft.Extensions.Configuration;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace HMI_MF.Controllers
{
    public class HomeController : Controller
    {

        private readonly IConfiguration configuration;
        private readonly ILogger<HomeController> _logger;

        public HomeController(IConfiguration config, ILogger<HomeController> logger)
        {
            this.configuration = config;
            _logger = logger;
        }

        public IActionResult Index()
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}