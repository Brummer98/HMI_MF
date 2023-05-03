using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.ComponentModel;
using System.Data.SqlClient;

namespace HMI_MF.Controllers
{
    public class TagController : Controller
    {
        private readonly IConfiguration configuration;
        private readonly ILogger<TagController> _logger;
        string constr = @"Data Source=.\sqlexpress;Initial Catalog=TagTableFactory;Integrated Security=True;";

        public TagController(IConfiguration config, ILogger<TagController> logger)
        {
            this.configuration = config;
            _logger = logger;
        }

        // GET: TagController
        public ActionResult Index()
        {
            // Create a list of all database items and show them

            List<Models.TagModel> tagModelList = new();

            string query = "SELECT ID, TagName, TagValue FROM Tags";

            using (SqlConnection con = new(constr))
            {
                using (SqlCommand cmd = new(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            tagModelList.Add(new Models.TagModel(
                                Convert.ToInt32(sdr["ID"]),
                                Convert.ToString(sdr["TagName"]),
                                Convert.ToInt32(sdr["TagValue"])
                            ));
                            
                        }
                    }
                    con.Close();
                }
            }

            if (tagModelList.Count == 0)
            {
                tagModelList.Add(new Models.TagModel(0, "", 0));
            }
            return View(tagModelList);
        }

        // GET: TagController/Details/5
        public ActionResult Details(int id)
        {
            // Create a list of all database items and show them

            List<Models.TagModel> singleTagList = new();

            string query = "SELECT ID, TagName, TagValue FROM Tags WHERE ID = @iD";

            using (SqlConnection con = new(constr))
            {
                using (SqlCommand cmd = new(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    cmd.Parameters.Add(new SqlParameter("iD", id));
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            singleTagList.Add(new Models.TagModel(
                                Convert.ToInt32(sdr["ID"]),
                                Convert.ToString(sdr["TagName"]),
                                Convert.ToInt32(sdr["TagValue"])
                            ));

                        }
                    }
                    con.Close();
                }
            }

            if (singleTagList.Count == 0)
            {
                singleTagList.Add(new Models.TagModel(0, "", 0));
            }

            Models.TagModel newModel = new Models.TagModel();

            foreach (var model in singleTagList)
            {
                newModel.ID = model.ID;
                newModel.TagName = model.TagName;
                newModel.TagValue = model.TagValue;
            }

            return View(newModel);
        }

        // GET: TagController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TagController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.TagModel collection)
        {
            int id = collection.ID;
            string tagname = collection.TagName;
            int tagvalue = collection.TagValue;

            string query = "INSERT INTO Tags (TagName, TagValue) VALUES (@TagName, @TagValue)";
            using (SqlConnection con = new SqlConnection(constr))
            {
                // Create a sqlCommand 
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Connection = con;
                    con.Open();
                    cmd.Parameters.Add(new SqlParameter("TagName", tagname));
                    cmd.Parameters.Add(new SqlParameter("TagValue", tagvalue));
                    // Execute reader 
                    SqlDataReader sdr = cmd.ExecuteReader();
                }
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: TagController/Edit/5
        public ActionResult Edit(int id)
        {
            // Create a list of all database items and show them

            List<Models.TagModel> singleTagList = new();

            string query = "SELECT ID, TagName, TagValue FROM Tags WHERE ID = @iD";

            using (SqlConnection con = new(constr))
            {
                using (SqlCommand cmd = new(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    cmd.Parameters.Add(new SqlParameter("iD", id));
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            singleTagList.Add(new Models.TagModel(
                                Convert.ToInt32(sdr["ID"]),
                                Convert.ToString(sdr["TagName"]),
                                Convert.ToInt32(sdr["TagValue"])
                            ));

                        }
                    }
                    con.Close();
                }
            }

            if (singleTagList.Count == 0)
            {
                singleTagList.Add(new Models.TagModel(0, "", 0));
            }

            Models.TagModel newModel = new Models.TagModel();

            foreach (var model in singleTagList)
            {
                newModel.ID = model.ID;
                newModel.TagName = model.TagName;
                newModel.TagValue = model.TagValue;
            }
            
            return View(newModel);
        }

        // POST: TagController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Models.TagModel collection)
        {
            string tagname = collection.TagName;
            int tagvalue = collection.TagValue;

            string query = "UPDATE Tags SET TagName = @Tagname, TagValue = @Tagvalue WHERE ID = @iD";
           
            using (SqlConnection con = new SqlConnection(constr))
            {
                // Create a sql command
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Connection = con;
                    con.Open();
                    cmd.Parameters.Add(new SqlParameter("Tagname", tagname));
                    cmd.Parameters.Add(new SqlParameter("Tagvalue", tagvalue));
                    cmd.Parameters.Add(new SqlParameter("iD", id));
                    // Execute reader
                    SqlDataReader sdr = cmd.ExecuteReader();
                }
            }

            return RedirectToAction(nameof(Index));
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
