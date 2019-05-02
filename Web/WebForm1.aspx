<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="UFB.Web.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" EnableModelValidation="True"  ForeColor="#333333" GridLines="None"
                OnRowDeleting="GridView1_RowDeleting" OnRowDataBound="GridView1_RowDataBound" OnRowEditing="GridView1_RowEditing" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowUpdating="GridView1_RowUpdating" AutoGenerateColumns="False" DataKeyNames="ID">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <%--<asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />--%>
               <%--     <Item TemplateFied HeaderText="管理员ID">

                    </Item>--%>
                    <asp:TemplateField HeaderText ="管理员ID">
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%#Bind("ID")%>'></asp:Label>
                          </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText ="用户名">
                        <ItemTemplate>
                            <asp:TextBox ID="TextBox1" BorderWidth="0px" runat="server" Text='<%#Bind("adminName")%>'></asp:TextBox>
                          </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText ="部门" ShowHeader ="false">
                        <ItemTemplate>
                            <asp:TextBox ID="TextBox2" BorderWidth="0px" runat="server" Text='<%#Bind("department")%>'></asp:TextBox>
                          </ItemTemplate>
                    </asp:TemplateField>

                     <asp:TemplateField HeaderText ="操作" >
                         <EditItemTemplate>                        
                         <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="true" CommandName="Update" Text="更新"></asp:LinkButton>
                              <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="false" CommandName="Cancer" Text="取消"></asp:LinkButton>
                     </EditItemTemplate>
                          <EditItemTemplate>                        
                         <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="false" CommandName="Edit" Text="编辑"></asp:LinkButton>                            
                     </EditItemTemplate>
                             </asp:TemplateField>
                   <%-- <asp:BoundField DataField="adminName" HeaderText="adminName" SortExpression="adminName" />--%>
                  
                    <%-- <asp:BoundField DataField="adminPassword" HeaderText="adminPassword" SortExpression="adminPassword" />
                    <asp:BoundField DataField="department" HeaderText="department" SortExpression="department" />
                    <asp:BoundField DataField="job" HeaderText="job" SortExpression="job" />
                    <asp:BoundField DataField="permission" HeaderText="permission" SortExpression="permission" />
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />--%>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
