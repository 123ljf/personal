<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ADDYH.aspx.cs" Inherits="SYSHY_ADDYH" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>编辑用户信息</title>
    <link href="../css/CSS.css" rel="Stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align:center;">
    

<table cellSpacing="0" cellPadding="0" width="60%"    >
	<tr>
	<td height="25" width="30%" align="center" class="tdHeader" colspan="2">
		[编辑用户信息]</td>
	</tr>
	<tr>
	<td height="25" width="30%" align="right">
		登录账户
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDLZH" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		用户名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtYHMC" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		 登录密码
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDLMM" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" colspan="2"><div align="center">
		<asp:Button ID="btnAdd" runat="server" Text="· 提交 ·" OnClick="btnAdd_Click" ></asp:Button>
	</div></td></tr>
</table>
    </div>
    </form>
</body>
</html>

