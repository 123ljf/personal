<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HYEdit.aspx.cs" Inherits="SJGL_HYEdit" %> 
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>编辑会员信息</title>
    <link href="../css/CSS.css" rel="Stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align:center;">
    

<table cellSpacing="0" cellPadding="0" width="60%"    >
	<tr>
	<td height="25" width="30%" align="center" class="tdHeader" colspan="2">
		[会员信息编辑]</td>
	</tr>
	<tr>
	<td height="25" width="30%" align="right">
		会员名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtHYXM" runat="server" Width="200px"></asp:TextBox><font color=red>*</font>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		会员性别
	：</td>
	<td height="25" width="*" align="left">
		<asp:DropDownList ID="ddlXB" runat="server" CssClass="DropDownList">
            <asp:ListItem Value="1">男</asp:ListItem>
            <asp:ListItem Value="0">女</asp:ListItem>
        </asp:DropDownList>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		专业
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtHYZY" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		班级
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtHYBJ" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		宿舍
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtHYSS" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		手机号码
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMOBILE" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		社团
	：</td>
	<td height="25" width="*" align="left">
		<asp:DropDownList ID="ddlST" runat="server" CssClass="DropDownList">
        </asp:DropDownList>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		职位
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtZW" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		会费
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtHF" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" colspan="2"><div align="center">
		<asp:Button ID="btnAdd" runat="server" Text="提交 " OnClick="btnAdd_Click" ></asp:Button>
	    <asp:Button ID="btBack" runat="server" onclick="btBack_Click" 
              Text="返回" />
	</div></td></tr>
</table>
    </div>
    </form>
</body>
</html>
