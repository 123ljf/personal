<%@ Page Language="C#" AutoEventWireup="true" CodeFile="STINFO.aspx.cs" Inherits="SJGL_STINFO" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>社团信息</title>
    <link href="../css/CSS.css" rel="Stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align:center;">
    

<table cellSpacing="0" cellPadding="0" width="60%"    >
	<tr>
	<td height="25" width="30%" align="center" class="tdHeader" colspan="2">
		[社团信息]</td>
	</tr>
	<tr>
	<td height="25" width="30%" align="right">
		社团部编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSTBID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSTBMC" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		部长
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBZID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		社团人数
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCYRS" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		手机
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMOBILE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		社团职责
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSTZN" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		备注
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBZ" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		会费
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSTF" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		&nbsp;</td>
	<td height="25" width="*" align="left">
		<asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">【返回上一页】</asp:LinkButton>
	</td></tr>
</table>
    </div>
    </form>
</body>
</html>
