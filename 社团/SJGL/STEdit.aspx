<%@ Page Language="C#" AutoEventWireup="true" CodeFile="STEdit.aspx.cs" Inherits="SJGL_STEdit" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>社团设置</title>
    <link href="../css/CSS.css" rel="Stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align:center;">
    

<table cellSpacing="0" cellPadding="0" width="60%"    >
	<tr>
	<td height="25" width="30%" align="center" class="tdHeader" colspan="2">
		[社团信息添加]</td>
	</tr>
	<tr>
	<td height="25" width="30%" align="right">
		名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSTBMC" runat="server" Width="200px"></asp:TextBox><font color="red">*</font>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		部长
	：</td>
	<td height="25" width="*" align="left">
		<asp:DropDownList ID="ddlBZ" runat="server" CssClass="DropDownList">
        </asp:DropDownList><font color="red">*</font>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		社团人数
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCYRS" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		手机
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMOBILE" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		社团职责
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSTZN" runat="server" Width="457px" Height="137px" 
            TextMode="MultiLine"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		备注
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBZ" runat="server" Width="457px" Height="140px" 
            TextMode="MultiLine"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		会费
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSTF" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" colspan="2"><div align="center">
		<asp:Button ID="btnAdd" runat="server" Text="保存" OnClick="btnAdd_Click" ></asp:Button>
	    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
	    <asp:Button ID="Button1" runat="server" Text="返回列表" onclick="Button1_Click" />
	</div></td></tr>
</table>
    </div>
    </form>
</body>
</html>
