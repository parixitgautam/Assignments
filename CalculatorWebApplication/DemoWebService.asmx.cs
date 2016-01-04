using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CalculatorWebApplication
{
    /// <summary>
    /// Summary description for DemoWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
     [System.Web.Script.Services.ScriptService]
    public class DemoWebService : System.Web.Services.WebService
    {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="text"></param>
    /// 
    [WebMethod(EnableSession = true)]
    public bool SaveText(string text)
    {
      bool isSuccess = false;
      try
      {
        System.IO.File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TextFile.txt"), text.ToString());
        isSuccess = true;
      }
      catch (Exception ex)
      {
        isSuccess = false;
      }
      return isSuccess;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="text"></param>
    /// 
    [WebMethod(EnableSession = true)]
    public string GetText()
    {
      bool isSuccess = false;
      string textFromFile = string.Empty;
      try
      {
        textFromFile = System.IO.File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TextFile.txt"));
        isSuccess = true;
      }
      catch (Exception ex)
      {
        isSuccess = false;
      }
      return textFromFile;
    }
  }
}
