using CompetitionApp.Model;
using Grpc.Core;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json;
using System.IO;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace CompetitionApp.Controllers
{
    public class CompetitionController : Controller
    {
        private readonly string _jsonPath;

        public CompetitionController(IWebHostEnvironment env)
        {
            _jsonPath = Path.Combine(env.ContentRootPath, "App_Data", "questions.json");
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Topics()
        {
            var topics = GetTopicsFromJson();
            return View(topics);
        }

        public ActionResult Questions(int topicId)
        {
            var topics = GetTopicsFromJson();
            var topic = topics.FirstOrDefault(t => t.Id == topicId);
            return View(topic);
        }

        public ActionResult QuestionDetail(int topicId, int questionId)
        {
            var topics = GetTopicsFromJson();
            var topic = topics.FirstOrDefault(t => t.Id == topicId);
            var question = topic?.Questions.FirstOrDefault(q => q.Id == questionId);
            ViewBag.TopicId = topicId;
            return View(question);
        }

        public List<Topic> GetTopicsFromJson()
        {
            var jsonData = System.IO.File.ReadAllText(_jsonPath);
            return JsonSerializer.Deserialize<List<Topic>>(jsonData);
        }
        public ActionResult RevealAnswer(int topicId, int questionId)
        {
            var topics = GetTopicsFromJson();
            var topic = topics.FirstOrDefault(t => t.Id == topicId);
            if (topic == null)
            {
                return NotFound();
            }
            var question = topic.Questions.FirstOrDefault(q => q.Id == questionId);
            if (question == null)
            {
                return NotFound();
            }
            ViewBag.TopicId = topicId;
            return View(question);
        }

    }
}
