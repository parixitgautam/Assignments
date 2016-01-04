<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CalculatorWebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" lang="ja" src="scripts/TextFileScript.js?001">
        
        
    </script>
</head>
<body>
    <form runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>
                <asp:ServiceReference Path="~/DemoWebService.asmx" />
            </Services>
        </asp:ScriptManager>


        <div>
            <table>
                <tr>
                    <td>

                        <textarea id="TextArea1" cols="20" rows="20"></textarea>

                    </td>

                </tr>
                <tr>
                    <td>
                        <input type="button" id="button" onclick="SaveToText()" value="Save Data" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <span id="resultWindow"></span>
                    </td>
                </tr>
            </table>
        </div>

        <div>
            <table>
                <tr>
                    <td>
                        <input type="button" id="button2" onclick="GetTextDataFromFile()" value="Get Data" />

                    </td>
                </tr>
                <tr>
                    <td>
                        <span id="resultWindow2"></span>
                    </td>
                </tr>
            </table>
        </div>

    </form>

</body>
</html>
