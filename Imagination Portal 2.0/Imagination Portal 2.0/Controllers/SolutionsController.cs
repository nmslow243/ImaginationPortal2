using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Omu.ValueInjecter;

namespace Imagination_Portal_2._0.Models
{
    public class SolutionsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Solutions
        public ActionResult Index()
        {
            return View(db.Solutions.ToList());
        }

        // GET: Solutions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Solution solution = db.Solutions.Find(id);
            if (solution == null)
            {
                return HttpNotFound();
            }
            return View(solution);
        }

        //// GET: Solutions/Create
        //public ActionResult Create(int? id)
        //{
        //    if (id == null)
        //    {
        //        ViewBag.IssueId = 0;
        //    }
        //    else
        //    {
        //        ViewBag.IssueId = id;
        //    }
        //    return View();
        //}
        // GET: Solutions/Create
        public ActionResult Create(int? id)
        {
            if (id == null)
            {
                return View();
            }
            else
            {
                Solution solution = db.Solutions.Find(id);
                if (solution == null)
                {
                    return HttpNotFound();
                }
                CreateFinal Final = new CreateFinal();
                Final.InjectFrom(solution);
                return View(Final);
            }
        }

        // POST: Solutions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Description,Tags,IssueId")] CreateFinal Final)
        {
            
            if (ModelState.IsValid)
            {

                Solution solution = new Solution();
                if (Final.Id <= 0)
                {
                    solution.InjectFrom(Final);
                    db.Solutions.Add(solution);
                }
                else
                {
                    solution = db.Solutions.Find(Final.Id);
                    solution.InjectFrom(Final);
                    db.Entry(solution).State = EntityState.Modified;
                }
                db.SaveChanges();
                return RedirectToAction("Details", "Solutions", new { id = solution.Id });
                //return RedirectToAction("Details", "Issues", new { id = solution.IssueId });
            }

            return View(Final);
        }

        // GET: Solutions/Create
        public ActionResult CreateStep1(int? id)
        {
            if (id == null)
            {
                return View();
            }
            else
            {
                Solution solution = db.Solutions.Find(id);
                if (solution == null)
                {
                    return HttpNotFound();
                }
                CreateStep1 Step1 = new CreateStep1();
                Step1.InjectFrom(solution);
                return View(Step1);
            }
        }

        // POST: Solutions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateStep1([Bind(Include = "Id,Feelings,Achieve,RootCauses,Elements,Analogy")] CreateStep1 Step1)
        {
            if (ModelState.IsValid)
            {
                
                Solution solution = new Solution();
                if (Step1.Id <= 0)
                {
                    solution.InjectFrom(Step1);
                    db.Solutions.Add(solution);
                }
                else
                {
                    solution = db.Solutions.Find(Step1.Id);
                    solution.InjectFrom(Step1);
                    db.Entry(solution).State = EntityState.Modified;
                }
                db.SaveChanges();
                return RedirectToAction("CreateStep2", "Solutions", new { id = solution.Id });
            }

            return View(Step1);
        }
        // GET: Solutions/Create
        public ActionResult CreateStep2(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Solution solution = db.Solutions.Find(id);
            if (solution == null)
            {
                return HttpNotFound();
            }
            CreateStep2 Step2 = new CreateStep2();
            Step2.InjectFrom(solution);
            return View(Step2);
        }

        // POST: Solutions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateStep2([Bind(Include = "Id,Combine,Substitution,MagnifyMinimize,Adapt,OtherUse,Eliminate,Rearrange,Reverse,Opposite")] CreateStep2 Step2)
        {
            if (ModelState.IsValid)
            {

                Solution solution = db.Solutions.Find(Step2.Id);
                solution.InjectFrom(Step2);
                db.Entry(solution).State = EntityState.Modified;
                
                db.SaveChanges();
                return RedirectToAction("CreateStep3", "Solutions", new { id = solution.Id });
            }

            return View(Step2);
        }
        // GET: Solutions/Create
        public ActionResult CreateStep3(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Solution solution = db.Solutions.Find(id);
            if (solution == null)
            {
                return HttpNotFound();
            }
            CreateStep3 Step3 = new CreateStep3();
            Step3.InjectFrom(solution);
            return View(Step3);
        }

        // POST: Solutions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateStep3([Bind(Include = "Id,VisualizeNevers,EvaluateIdeas,Vital,Fatal")] CreateStep3 Step3)
        {
            if (ModelState.IsValid)
            {

                Solution solution = db.Solutions.Find(Step3.Id);
                solution.InjectFrom(Step3);
                db.Entry(solution).State = EntityState.Modified;

                db.SaveChanges();
                return RedirectToAction("Create", "Solutions", new { id = solution.Id });
            }

            return View(Step3);
        }

        // GET: Solutions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Solution solution = db.Solutions.Find(id);
            if (solution == null)
            {
                return HttpNotFound();
            }
            CreateFinal Final = new CreateFinal();
            Final.InjectFrom(solution);
            return View(Final);
        }

        // POST: Solutions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Description,Tags")] CreateFinal Final)
        {
            if (ModelState.IsValid)
            {

                Solution solution = new Solution();
               
                solution = db.Solutions.Find(Final.Id);
                solution.InjectFrom(Final);
                db.Entry(solution).State = EntityState.Modified;
                
                db.SaveChanges();
                return RedirectToAction("Details", "Solutions", new { id = solution.Id });
                //return RedirectToAction("Details", "Issues", new { id = solution.IssueId });
            }

            return View(Final);
        }

        // GET: Solutions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Solution solution = db.Solutions.Find(id);
            if (solution == null)
            {
                return HttpNotFound();
            }
            return View(solution);
        }

        // POST: Solutions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Solution solution = db.Solutions.Find(id);
            db.Solutions.Remove(solution);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult TutorialStep1()
        {
            return View();
        }

        public ActionResult TutorialStep2()
        {
            return View();
        }

        public ActionResult TutorialStep3()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }


    }
}
