<%@ Page Language="C#" AutoEventWireup="true" CodeFile="YHGL.aspx.cs" Inherits="SYSHY_YHGL" %>


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>用户管理</title>
    <link href="../css/CSS.css" type="text/css" rel="Stylesheet" />
</head>

<body>
    <form id="Form1" method="post" runat="server">
        <div align="center">
            <table width="99%" border="0" cellspacing="0" cellpadding="0" align="center" id="Table1">
                <tr>
                    <td   valign="top">
                        <table width="100%" border="0" align="center" cellpadding="5" cellspacing="0">
                            <tr>
                                <td >
                                    <table  
                                        cellpadding="5" width="100%" 
                                        border="0" cellspacing="0">
                                        <tr>
                                            <td height="25"  class="tdHeader"
                                                align="center">
                                                [用户管理]</td>
                                        </tr>
                                        <tr>
                                            <td height="22" valign="middle">
                                                &nbsp;&nbsp; 快速查询： <asp:DropDownList ID="ddlCXLX" runat="server" 
                                                    CssClass="DropDownList">
                                                    <asp:ListItem Value="全部" Selected="True">全部</asp:ListItem>
                                                    <asp:ListItem Value="YHMC">用户名称</asp:ListItem>                                                    
                                                </asp:DropDownList>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:Label ID="Label1" runat="server">关键字：</asp:Label>
                                                <asp:TextBox ID="txtCXNR" runat="server" Width="170px" BorderStyle="Groove" 
                                                    CssClass="TextBox"></asp:TextBox>
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:ImageButton ID="BtnSearch" runat="server" 
                                                    ImageUrl="~/Images/button_search.GIF" onclick="BtnSearch_Click"
                                                    ></asp:ImageButton>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                &nbsp; 
                                                </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                            <td>
                            	<asp:GridView ID="gvData" runat="server" AllowPaging="True" 
                                    AutoGenerateColumns="False" BorderStyle="None" BorderWidth="1px" 
                                    CellPadding="3" PageSize="50" SkinID="GridViewAuto" 
                                    UseAccessibleHeader="False" Width="100%" onrowcommand="gvData_RowCommand" 
                                    onrowcreated="gvData_RowCreated" onrowdatabound="gvData_RowDataBound" 
                                    BackColor="White" BorderColor="#CCCCCC">
                                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                                    <EmptyDataTemplate>
                                        <div style="text-align:center;vertical-align:middle">
                                            <br />
                                            找不到和您的查询条件相符的信息 
                                        </div>
                                    </EmptyDataTemplate>
                                    <FooterStyle BackColor="White" ForeColor="#000066" />
                                    <RowStyle ForeColor="#000066" />
                                    <Columns>
                                        <asp:ButtonField CommandName="Sel" DataTextField="YHMC" HeaderText="用户名称">
                                            <ItemStyle HorizontalAlign="Center"  />
                                            <HeaderStyle HorizontalAlign="Center" />
                                        </asp:ButtonField>
                                        <asp:BoundField DataField="DLZH" HeaderText="登录账户">
                                            <ItemStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="DLMM" HeaderText="登录密码">
                                            <ItemStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" />
                                        </asp:BoundField>
                                         
                                        <asp:TemplateField HeaderText="操作">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="btn_Delete" runat="server" BackColor="Transparent" 
                                                    BorderStyle="None" CommandName="Del" ForeColor="#3a6ea5" Text="删除"></asp:LinkButton>
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="5%" 
                                                Wrap="false" />
                                            <HeaderStyle HorizontalAlign="Center" Wrap="false" />
                                        </asp:TemplateField>
                                    </Columns>
                                    <PagerSettings Visible="False" />
                                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                                </asp:GridView>
                            
                            </td>
                            </tr>
                            <tr>
                                <td  
                                    align="right">
                                    <asp:Label ID="lblCurrentIndex" runat="server"></asp:Label>
                                    &nbsp;
                                    <asp:Label ID="lblPageCount" runat="server"></asp:Label>
                                    &nbsp;&nbsp;
                                    <asp:Label ID="lblCount" runat="server"></asp:Label>
                                    &nbsp;&nbsp;
                                    <asp:LinkButton ID="btnFirst" runat="server" CommandArgument="0" 
                                        Font-Size="8pt" ForeColor="navy" OnClick="PagerButtonClick">最首页</asp:LinkButton>
                                    &nbsp;
                                    <asp:LinkButton ID="btnPrev" runat="server" CommandArgument="prev" 
                                        Font-Size="8pt" ForeColor="navy" OnClick="PagerButtonClick">前一页</asp:LinkButton>
                                    &nbsp;
                                    <asp:LinkButton ID="btnNext" runat="server" CommandArgument="next" 
                                        Font-Size="8pt" ForeColor="navy" OnClick="PagerButtonClick">后一页</asp:LinkButton>
                                    &nbsp;
                                    <asp:LinkButton ID="btnLast" runat="server" CommandArgument="last" 
                                        Font-Size="8pt" ForeColor="navy" OnClick="PagerButtonClick">最后页</asp:LinkButton>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </div>
       
    </form>
</body>
</html>
