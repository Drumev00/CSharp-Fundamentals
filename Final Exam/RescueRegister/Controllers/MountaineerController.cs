using RescueRegister.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace RescueRegister.Controllers
{
	public class MountaineerController : Controller
	{
		private readonly RescueRegisterDbContext context;

		public MountaineerController(RescueRegisterDbContext context)
		{
			this.context = context;
		}

		public IActionResult Index()
		{
			// TODO: Implement me
			using (var db = new RescueRegisterDbContext())
			{
				var alltabs = db.Mountaineers.ToList();
				return this.View(alltabs);
			}

		}

		[HttpGet]
		public IActionResult Create()
		{
			// TODO: Implement me

			return this.View();
		}

		[HttpPost]
		public IActionResult Create(Mountaineer mountaineer)
		{
			// TODO: Implement me
			using (var db = new RescueRegisterDbContext())
			{
				db.Mountaineers.Add(mountaineer);
				db.SaveChanges();

			}
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult Edit(int id)
		{
			// TODO: Implement me
			Mountaineer mountaineer = new Mountaineer();
			mountaineer.Id = id;
			using (var db = new RescueRegisterDbContext())
			{
				var listToEdit = db.Mountaineers.Find(id);
				return this.View(listToEdit);
			}
				
		}

		[HttpPost]
		public IActionResult Edit(Mountaineer mountaineer)
		{
			using (var db = new RescueRegisterDbContext())
			{
				var listToEdit = db.Mountaineers.Find(mountaineer.Id);
				listToEdit.Name = mountaineer.Name;
				listToEdit.Age = mountaineer.Age;
				listToEdit.Gender = mountaineer.Gender;
				listToEdit.LastSeenDate = mountaineer.LastSeenDate;
				db.SaveChanges();
				return RedirectToAction("Index");
			}
				
		}

		[HttpGet]
		public IActionResult Delete(int id)
		{
			using (var db = new RescueRegisterDbContext())
			{
				var listToDelete = db.Mountaineers.Find(id);
				return this.View(listToDelete);
			}
				
		}

		[HttpPost]
		public IActionResult Delete(Mountaineer mountaineer)
		{
			using (var db = new RescueRegisterDbContext())
			{
				var listToDelete = db.Mountaineers.Find(mountaineer.Id);
				db.Remove(listToDelete);
				db.SaveChanges();
				return RedirectToAction("Index");
			}
				
		}
	}
}