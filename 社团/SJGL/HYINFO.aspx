<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HYINFO.aspx.cs" Inherits="SJGL_HYINFO" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>会员信息查看</title>
    <link href="../css/CSS.css" rel="Stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align:center;">
    

<table cellSpacing="0" cellPadding="0" width="60%"    >
	<tr>
	<td height="25" width="30%" align="center" class="tdHeader" colspan="2">
		[会员信息查看]</td>
	</tr> 
	<tr>
	<td height="25" width="30%" align="right">
		会员名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHYXM" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		会员性别
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label ID="lab_sex" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		专业
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHYZY" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		班级
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHYBJ" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		宿舍
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHYSS" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		手机号码
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMOBILE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		社团
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSTBID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		职位
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblZW" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		会费
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHF" runat="server"></asp:Label>
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
