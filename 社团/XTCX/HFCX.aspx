﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HFCX.aspx.cs" Inherits="XTCX_HFCX" %>


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>会费查询</title>
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
                                                [会费查询]</td>
                                        </tr>
                                        <tr>
                                            <td height="22" valign="middle">
                                                &nbsp;社团名称：&nbsp;&nbsp;
                                                <asp:TextBox ID="txtCXNR" runat="server" Width="170px" BorderStyle="Groove" 
                                                    CssClass="TextBox"></asp:TextBox>
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;会费在：&nbsp;<asp:TextBox ID="txtDY" runat="server" 
                                                    CssClass="TextBox"></asp:TextBox>
&nbsp; 至 
                                                <asp:TextBox ID="txtXY" runat="server" CssClass="TextBox"></asp:TextBox>
                                                &nbsp;&nbsp; &nbsp;&nbsp;之间&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                &nbsp; 
                                                </td>
                                        </tr>
                                        <tr>
                                            <td height="22" valign="middle">
                                                <asp:ImageButton ID="BtnSearch" runat="server" 
                                                    ImageUrl="~/Images/button_search.GIF" onclick="BtnSearch_Click"
                                                    ></asp:ImageButton> 
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
                                         <asp:BoundField DataField="STBMC" HeaderText="社团名称">
                                            <ItemStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" />
                                        </asp:BoundField> 
                                        <asp:BoundField DataField="STF" HeaderText="社团费">
                                            <ItemStyle HorizontalAlign="Center" />
                                            <HeaderStyle HorizontalAlign="Center" />
                                        </asp:BoundField>  
                                        <asp:TemplateField HeaderText="操作" Visible="false">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="btn_Delete" runat="server" BackColor="Transparent" 
                                                    BorderStyle="None" CommandName="Sel" ForeColor="#3a6ea5" Text="修改"></asp:LinkButton>
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