<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AutoExtendControl.aspx.cs" Inherits="AutoExtendControl" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 92px;
        }
        .auto-style3 {
            width: 92px;
            height: 26px;
        }
        .auto-style4 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
    
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">Name</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtStudentName" runat="server"></asp:TextBox>
                    <asp:AutoCompleteExtender ID="txtStudentName_AutoCompleteExtender" runat="server" CompletionSetCount="1" DelimiterCharacters="" Enabled="True" TargetControlID="txtStudentName" ServiceMethod="GetNamesList" CompletionInterval="10" MinimumPrefixLength="1">
                    </asp:AutoCompleteExtender>
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="btnCheck" runat="server" OnClick="btnCheck_Click" Text="Check" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
