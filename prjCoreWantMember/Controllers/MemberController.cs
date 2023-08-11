﻿using Microsoft.AspNetCore.Mvc;
using prjCoreWantMember.Models;

namespace prjCoreWantMember.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MemberAccount(int? idforreal)
        {
            int id = 33; //還沒做登入先寫死
            NewIspanProjectContext db = new NewIspanProjectContext();
            MemberAccount datas = db.MemberAccounts.FirstOrDefault(p => (int)p.AccountId == (int)id);
            return View(datas);
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult ForgetPassword()
        {
            return View();
        }
    }
}
