using DuAnLamQuen.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuAnLamQuen.Controllers
{
    public class MayTinhController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //cách 3: tiếp nhận giá trị tham số thông qua Model
        public IActionResult XuLy(MayTinhModel mt)
        {
            //b1.lấy giá trị các tham số (So1, So2, PhepTinh)
            //b2.tinh toan ket qua
            double ketqua = 0;
            switch (mt.PhepTinh)
            {
                case "+": ketqua = mt.So1 + mt.So2; break;
                case "-": ketqua = mt.So1 - mt.So2; break;
                case "*": ketqua = mt.So1 * mt.So2; break;
                case "/": ketqua = mt.So1 / mt.So2; break;
            }
            //b3.Tra ket qua ve nguoi dung
            ViewBag.KQ = ketqua; //truyền dữ liệu cho view thông qua ViewBag
            return View("Index", mt);
        }
    }
}
