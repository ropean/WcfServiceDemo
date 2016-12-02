using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplicationWcfDemo.ServiceReference1;
using MvcApplicationWcfDemo.ServiceReference2;
using Newtonsoft.Json;
//using WcfModelMemo;

namespace MvcApplicationWcfDemo.Controllers
{
  public class HomeController : Controller
  {
    //
    // GET: /Home/

    public string Index()
    {
      Service1Client client = new Service1Client();

      var serviceResult = client.GetData(100);

      // Use the 'client' variable to call operations on the service.

      // Always close the client.
      client.Close();

      return serviceResult;
    }

    public string GetModel()
    {

      using (Service1Client client = new Service1Client())
      {
        var data = client.GetModel();

        return JsonConvert.SerializeObject(data);
      }

    }

    public string GetData()
    {

      using (Service1Client client = new Service1Client())
      {

        var composite = new ServiceReference1.CompositeType();

        composite.StringValue = "Wcf Demo";

        composite.BoolValue = true;

        var data = client.GetDataUsingDataContract(null);

        return JsonConvert.SerializeObject(data);

      }

    }

    public string GetModel2()
    {

      using (Service2Client client = new Service2Client())
      {
        var data = client.GetModel();

        return JsonConvert.SerializeObject(data);
      }

    }

    public string GetData2()
    {

      using (Service2Client client = new Service2Client())
      {

        var composite = new ServiceReference2.CompositeType();

        var data = client.GetDataUsingDataContract(composite);

        return JsonConvert.SerializeObject(data);

      }

    }

  }
}
