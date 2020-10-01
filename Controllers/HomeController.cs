using PagedList;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        Entities1 en = new Entities1();
        public ActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult Index(UserDetail D)
        //{
        //   // string FileName = Path.GetFileNameWithoutExtension(d.ProfilePic.FileName);

        //    //To Get File Extension  
        //    //string FileExtension = Path.GetExtension(d.ProfilePic.FileName);

        //   // Add Current Date To Attached File Name  
        //    //FileName = DateTime.Now.ToString("yyyyMMdd") + "-" + FileName.Trim() + FileExtension;

        //    ////Get Upload path from Web.Config file AppSettings.  
        //    //string UploadPath = ConfigurationManager.AppSettings["UserImagePath"].ToString();

        //    ////Its Create complete path to store in server.  
        //    //d.ProfilePic = UploadPath + FileName;

        //    ////To copy and save file into server.  
        //    //d.ImageFile.SaveAs(d.ProfilePic);



        //    ////To save Club Member Contact Form Detail to database table.  
           


        //    return View();
        //}

        //public ActionResult About()
        // {
        //     var student = en.UserDetails.Find(1);

        //     return View();
        // }
        public ActionResult About()
        {

            /*var data = us.UserDetails.SqlQuery("select * from userdetails").ToList();
            PagedList<UserDetail> model = new PagedList<UserDetail>(data, page, pageSize);
            return View(model);*/
            using (Entities1 us = new Entities1())
            {
                List<UserDetail> userDetails = us.UserDetails.ToList();
                List<CarDetail> carDetails = us.CarDetails.ToList();

                List<UserViewModel> userViewModels = new List<UserViewModel>();

                //var userRecord = from e in userDetails
                //                 join d in carDetails on e.UserId equals d.UserId into table1
                //                 from d in table1.ToList()
                //                 select new UserViewModel
                //                 {
                //                     userDetail = e,
                //                     carDetail = d

                //                 };

                foreach (var user in userDetails)
                {
                    var data = new UserViewModel
                    {
                        UserId = user.UserId,
                        FullName = user.FullName,
                        UserEmail = user.UserEmail,
                        CivilIdNumber = user.CivilIdNumber,


                    };

                    var cardetails = string.Join(",", carDetails.Where(x => x.UserId == user.UserId).Select(y => y.CarLicense).ToList());

                    data.CarLicense = cardetails;


                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                userViewModels.Add(data);

                }

                //PagedList<UserViewModel> model = new PagedList<UserViewModel>(userViewModels, page, pageSize);
                return View(userViewModels);
            }
        }

        public ActionResult Details(int id)
        {
            List<UserDetail> USER = en.UserDetails.ToList();
            var data = from u in USER
                       where u.UserId == id
                       select u;
           // USER.Add(data);
           
           
            return View(data);
        }

       

                //Customer c = (from x in dataBase.Customers
                //              where x.Name == "Test"
                //              select x).First();
                //        c.Name = "New Name";
                //dataBase.SaveChanges();
        public ActionResult Edit(int id)
        {
            List<UserDetail> USER = en.UserDetails.ToList();
            var data = (from u in USER
                        where u.UserId == id
                        select u).First();
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(UserDetail obj)
        {
        //    List<UserDetail> userDetails = en.UserDetails.ToList();
        //    List<CarDetail> carDetails = en.CarDetails.ToList();
        //    var dtls = from u in userDetails
        //               where x => x.UserId == obj.UserId
        //    var dtls1 = en.CarDetails.Where(x => x.UserId == obj.UserId).FirstOrDefault();

            //var std = context.Students.First<Student>(); 
            //List<object> lst = new List<object>();
            //lst.Add(obj.FullName);
            //lst.Add(obj.UserEmail);
            //lst.Add(obj.PasswordHash);
            //lst.Add(obj.CivilIdNumber);
            //lst.Add(obj.DOB);
            //lst.Add(obj.MobileNo);
            //lst.Add(obj.Address);
            //lst.Add(obj.RoleId);
            //lst.Add(obj.ProfilePic);
            //lst.Add(obj.CreatedDate);
            //lst.Add(obj.ModifiedDate);
            //lst.Add(obj.IsNotificationActive);
            //lst.Add(obj.IsActive);
            //lst.Add(obj.DeviceId);
            //lst.Add(obj.DeviceType);
            //lst.Add(obj.FcmToken);
            //lst.Add(obj.verify);
            //lst.Add(obj.VerifiedBy);
            //lst.Add(obj.Area);
            //lst.Add(obj.Block);
            //lst.Add(obj.Street);
            //lst.Add(obj.Housing);
            //lst.Add(obj.Floor);
            //lst.Add(obj.NewPass);
            //lst.Add(obj.ConPass);
            //lst.Add(obj.Jadda);
            //lst.Add(obj.Reason);
            //lst.Add(obj.ActivatedBy);
            //lst.Add(obj.VerifiedDate);
            //lst.Add(obj.ActivatedDate);
            //object[] allitem = lst.ToArray();
            en.SaveChanges();
            int output = en.SaveChanges();
            if (output > 0)
            {
                ViewBag.msg = "Updated Added Successfully";
            }

            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(UserViewModel collection)
        {
            //List<object> lst = new List<object>();
            //lst.Add(collection.FullName);
            //lst.Add(collection.UserEmail);
            //lst.Add(collection.PasswordHash);
            //lst.Add(collection.CivilIdNumber);
            //lst.Add(collection.DOB);
            //lst.Add(collection.MobileNo);
            //lst.Add(collection.Address);
            //lst.Add(collection.RoleId);
            //lst.Add(collection.ProfilePic);
            //lst.Add(collection.CreatedDate);
            //lst.Add(collection.ModifiedDate);
            //lst.Add(collection.IsNotificationActive);
            //lst.Add(collection.IsActive);
            //lst.Add(collection.DeviceId);
            //lst.Add(collection.DeviceType);
            //lst.Add(collection.FcmToken);
            //lst.Add(collection.verify);
            //lst.Add(collection.VerifiedBy);
            //lst.Add(collection.Area);
            //lst.Add(collection.Block);
            //lst.Add(collection.Street);
            //lst.Add(collection.Housing);
            //lst.Add(collection.Floor);
            //lst.Add(collection.NewPass);
            //lst.Add(collection.ConPass);
            //lst.Add(collection.Jadda);
            //lst.Add(collection.Reason);
            //lst.Add(collection.ActivatedBy);
            //lst.Add(collection.VerifiedDate);
            //lst.Add(collection.ActivatedDate);
            //object[] allitems = lst.ToArray();
            //int output = en.Database.ExecuteSqlCommand("insert into userdetails(FullName,UserEmail,PasswordHash,CivilIdNumber,DOB,MobileNo,Address,RoleId,ProfilePic,CreatedDate,ModifiedDate,IsNotificationActive,IsActive,DeviceId,DeviceType,FcmToken,verify,VerifiedBy,Area,Block,Street,Housing,Floor,NewPass,ConPass,Jadda,Reason,ActivatedBy,VerifiedDate,ActivatedDate) values(@p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17,@p18,@p19,@p20,@p21,@p22,@p23,@p24,@p25,@p26,@p27,@p28,@p29)", allitems);
            //if (output > 0)
            //{
            //    ViewBag.msg = "User Added Successfully";
            //}


                        var user = new UserDetail()
                        {
                            FullName = collection.FullName,
                            UserEmail = collection.UserEmail,
                            PasswordHash = collection.PasswordHash,
                            CivilIdNumber = collection.CivilIdNumber,

                            DOB = collection.DOB,
                            MobileNo = collection.MobileNo,
                            Address = collection.Address,
                            RoleId = collection.RoleId,
                            ProfilePic = collection.ProfilePic,


                            CreatedDate = collection.CreatedDate,
                            ModifiedDate = collection.ModifiedDate,
                            IsNotificationActive = collection.IsNotificationActive,
                            IsActive = collection.IsActive,
                            DeviceId = collection.DeviceId,
                            DeviceType = collection.DeviceType,
                            FcmToken = collection.FcmToken,
                            verify = collection.verify,
                            VerifiedBy = collection.VerifiedBy,
                            Area = collection.Area,
                            Block = collection.Block,
                            Street = collection.Street,
                            Housing = collection.Housing,
                            Floor = collection.Floor,
                            NewPass = collection.NewPass,
                            ConPass = collection.ConPass,
                            Jadda = collection.Jadda,
                            Reason = collection.Reason,
                            ActivatedBy = collection.ActivatedBy,
                            ActivatedDate = collection.ActivatedDate


                        };

                    var car = new CarDetail()
                    {
                        CarLicense = collection.CarLicense

                    };
            en.UserDetails.Add(user);
            en.CarDetails.Add(car);
            en.SaveChanges();
        
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }

        public ActionResult Contact()
        {
            List<UserDetail> USER = en.UserDetails.ToList();
            var data = from u in USER
                       select u;
            return View(data);
        }
    }
}