<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SYSAbout.aspx.cs" Inherits="SYSAbout" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>系统关于</title>
    <link href="css/CSS.css" rel="Stylesheet" />
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table align="center" class="style1" width="80%">
            <tr>
                <td>
                    系统关于：</td>
            </tr>
            <tr>
                <td align="center">
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/images/Snap2.bmp" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
