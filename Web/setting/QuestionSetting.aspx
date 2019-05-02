<%@ Page Title="" Language="C#" MasterPageFile="~/master/feedback.Master" AutoEventWireup="true" CodeBehind="QuestionSetting.aspx.cs" Inherits="UFB.Web.setting.QuestionSetting" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            padding: 32px;
            min-width: 0;
            -webkit-box-flex: 1;
            -ms-flex: 1;
            flex: 1;
            -webkit-transition: .3s;
            transition: .3s;
            width: 1019px;
            height: 270px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <div class="auto-style2">
            <div class="row">
                <div class="col-md-6">
                    <div class="card">
                        <div class="card-header bg-light" style="width:1200px;height:50px;border:none">
                         <h5>管理员申请列表</h5> 
                        </div>
                    </div>
                </div>

            </div>
         <asp:GridView ID="GridView1" runat="server" EnableModelValidation="True">
               <Columns>
             <asp:TemplateField HeaderText ="管理员ID">
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%#Bind("questionID")%>'></asp:Label>
                          </ItemTemplate>
                    </asp:TemplateField>
            <asp:BoundField DataField="category" HeaderText="问题分类" />
            <asp:BoundField DataField="question" HeaderText="问题详情" />
            <asp:BoundField DataField="solution" HeaderText="解决方案" />
            <asp:BoundField DataField="time" HeaderText="添加时间" />

                       <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />

                       </Columns>
         </asp:GridView>
          </div>
</asp:Content>
