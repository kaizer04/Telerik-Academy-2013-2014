using EasyPTC.Data;
namespace EasyPTC.Web.Areas.Administration.Controllers.Base
{
    public abstract class KendoGridAdministrationController : AdminController
    {
        public KendoGridAdministrationController(IEasyPtcData data)
            : base(data)
        { 
        
        }
    }
}