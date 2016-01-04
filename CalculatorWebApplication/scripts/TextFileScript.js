
function SaveToText() {
    var textToSave = document.getElementById("TextArea1").value;
    CalculatorWebApplication.DemoWebService.SaveText(textToSave, SaveToTextSuccessCallBack)

}
function SaveToTextSuccessCallBack(result) {
    if (result === true)
        document.getElementById("resultWindow").innerHTML = "Data Saved Successfully";
    else
        document.getElementById("resultWindow").innerHTML = "Saving Text Failed";
}
function GetTextDataFromFile()
{
    debugger;
    var textData = "";
   
    textData = CalculatorWebApplication.DemoWebService.GetText(GetTextsSuccessCallBack);
}
function GetTextsSuccessCallBack(result)
{
    if (result !== "")
        document.getElementById("resultWindow2").innerHTML = result;
}