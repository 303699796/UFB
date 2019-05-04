
<%@ Page Title="" Language="C#" MasterPageFile="~/master/feedback.Master" AutoEventWireup="true" CodeBehind="CategorySetting.aspx.cs" Inherits="UFB.Web.setting.CategorySetting" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="content">
            <div class="row">
                <div class="col-md-6">
                    <div class="card">
                        <div class="card-header bg-light" style="width:1200px;height:50px;border:none">
                         <h5>管理员设置</h5> 
                        </div>                      
                    </div>
                </div>
            </div>
        <asp:GridView ID="GridView1" runat="server"
             class="tab-content" style="width: 100%;text-align:center;word-break :break-all;word-wrap:break-word " RowStyle-Height="50px"
                OnRowDeleting="GridView1_RowDeleting"  OnRowDataBound="GridView1_RowDataBound" OnRowEditing="GridView1_RowEditing"
                OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowUpdating="GridView1_RowUpdating" AutoGenerateColumns="False" DataKeyNames="category" EnableModelValidation="True">
                 <Columns>
                       <asp:TemplateField HeaderText ="问题分类">
                        <ItemTemplate>
                            <%--<asp:Label ID="LabelID" runat="server" Text='<%#Bind("category")%>'></asp:Label>--%>
                            <asp:TextBox ID="txbCategory" runat="server" Text='<%#Bind("category")%>'></asp:TextBox>
                          </ItemTemplate>
                    </asp:TemplateField>

                     <asp:TemplateField HeaderText ="修改时间">
                        <ItemTemplate>
                            <asp:Label ID="LabelTime" runat="server" Text='<%#Bind("time")%>'></asp:Label>
                          </ItemTemplate>
                    </asp:TemplateField>

                       <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />

                     </Columns>

<RowStyle Height="50px"></RowStyle>
        </asp:GridView>
            </div>




</asp:Content>
