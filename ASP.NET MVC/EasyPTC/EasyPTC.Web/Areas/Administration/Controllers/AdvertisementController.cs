namespace EasyPTC.Web.Areas.Administration.Controllers
{
    using System.Web.Mvc;

    using AutoMapper;

    using EasyPTC.Data;
    using EasyPTC.Web.Areas.Administration.Controllers.Base;
    using EasyPTC.Web.Areas.Administration.ViewModels.Advertisements;
    
    using Kendo.Mvc.Extensions;
    using Kendo.Mvc.UI;
    using EasyPTC.Models;
    
    public class AdvertisementController : KendoGridAdministrationController
    {
        public AdvertisementController(IEasyPtcData data)
            : base(data)
        { 
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Read([DataSourceRequest]DataSourceRequest request)
        {
            var ads = this.Data
                .Advertisements
                .All()
                .ToDataSourceResult(request);
            
            return this.Json(ads);
        }

        public ActionResult Create([DataSourceRequest]DataSourceRequest request, AdvertisementViewModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                var dbModel = Mapper.Map<Advertisement>(model);
                this.Data.Advertisements.Add(dbModel);
                this.Data.SaveChanges();
                model.Id = dbModel.Id;
            }

            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult Update([DataSourceRequest]DataSourceRequest request, AdvertisementViewModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                var ad = this.Data.Advertisements.GetById(model.Id.Value);
                Mapper.Map(model, ad);
                this.Data.SaveChanges();
            }

            return Json(new[] {model}.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult Destroy([DataSourceRequest]DataSourceRequest request, AdvertisementViewModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                this.Data.Advertisements.Delete(model.Id.Value);
                this.Data.SaveChanges();
            }

            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        } 
    }
}