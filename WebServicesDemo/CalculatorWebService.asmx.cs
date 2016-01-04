using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesDemo
{
    /// <summary>
    /// Summary description for CalculatorWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class CalculatorWebService : System.Web.Services.WebService
    {

        [WebMethod(EnableSession = true)]
        public int Add(int firstNumber, int secondNumber)
        {
            List<string> calculations;
            if (Session["CALCULATIONS"] == null)
            {
                calculations = new List<string>();
            }
            else
            {
                calculations = (List<string>)Session["CALCULATIONS"];
            }
            string recentCalculation = firstNumber.ToString() + "+" + secondNumber.ToString() +
                "=" + (firstNumber + secondNumber).ToString();
            calculations.Add(recentCalculation);
            Session["CALCULATIONS"] = calculations;
            return firstNumber + secondNumber;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [WebMethod(EnableSession = true)]
        public List<string> GetCalculations()
        {
            if (Session["CALCULATIONS"] == null)
            {
                List<string> calculations = new List<string>();
                calculations.Add("You have not peformed any calculations");
                return calculations;
            }
            else
            {
                return (List<string>)Session["CALCULATIONS"];
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// 
        [WebMethod(EnableSession = true)]
        public bool SaveText(System.Text.StringBuilder text)
        {
            bool isSuccess = false;
            try
            {
                System.IO.File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "\\TextFile.txt"), text.ToString());
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
        textFromFile=System.IO.File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "\\TextFile.txt"));
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
