<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %> 

<HTML>
	<HEAD>
			<LINK href="css/CSS.css"type="text/css" rel="stylesheet">
	         
	        </HEAD>
	<body   >
		<form id="Form1" method="post" runat="server">
			 <div align="center">
							<TABLE id="Table2" cellSpacing="0" cellPadding="0" border="0" 
                                
                                style="border: thin outset #FFFFFF;   height: 113px; width: 247px;" 
                                 >
								<TR>
									<TD align="center" colspan="2" bgcolor="#0099CC" 
                                        style="color: #FFFFFF; font-size: large; font-weight: bold; text-decoration: underline; font-family: 隶书;"   >
                                        大学社团管理系统</TD>
								</TR>
								<TR>
									<TD align="right"   >
                                        帐号：</TD>
									<TD   >
										<asp:textbox id="txtUser" runat="server"   Width="140px" 
                                            CssClass="TextBox"></asp:textbox></TD>
								</TR>
								<TR>
									<TD align="right"   >
                                        密码：</TD>
									<TD  >
										<asp:textbox id="txtPwd" runat="server"   Width="140px" 
                                            TextMode="Password" CssClass="TextBox"></asp:textbox></TD>
								</TR>
								<TR>
									<TD align="right"   >
                                        类型：</TD>
									<TD  >
										<asp:DropDownList ID="dlType" runat="server" CssClass="DropDownList" 
                                            Width="140px">
                                            <asp:ListItem Value="管理">超级管理员</asp:ListItem>
                                            <asp:ListItem Value="用户">一般用户</asp:ListItem>
                                        </asp:DropDownList>
                                    </TD>
								</TR>
								<TR>
									<TD style="WIDTH: 350px; HEIGHT: 38px" align="center" colSpan="2">
                                        <asp:ImageButton ID="IbtDL" runat="server" 
                                            ImageUrl="~/Images/button-login.gif" onclick="IbtDL_Click" />
                                    </TD>
								</TR>
							</TABLE>
							</div>
			 
		</form>
	</body>
</HTML>
