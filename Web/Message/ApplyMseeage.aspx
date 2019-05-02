<%@ Page Title="" Language="C#" MasterPageFile="~/master/feedback.Master" AutoEventWireup="true" CodeBehind="ApplyMseeage.aspx.cs" Inherits="UFB.Web.Message.ApplyMseeage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div >
    <ul class="navbar-nav ml-auto">
                <li class="nav-item d-md-down-none">
                    <a href="#">
                        <i class="fa fa-bell"></i>
                        <span class="badge badge-pill badge-danger">5</span>
                    </a>
                </li>

                <li class="nav-item d-md-down-none">
                    <a href="#">
                        <i class="fa fa-envelope-open"></i>
                        <span class="badge badge-pill badge-danger">5</span>
                    </a>
                </li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                <li class="nav-item dropdown" style="left: -32px; top: -10px">
                    <a class="nav-link dropdown-toggle" href="#" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        <img src="../Images/用户头像.jpg" class="avatar avatar-sm" alt="logo">
                        
                        <span class="small ml-1 d-md-down-none">John Smith</span>
                    </a>

                    <div class="dropdown-menu dropdown-menu-right">
                        

                        <div class="dropdown-header">个人中心</div>

                        <a href="#" class="dropdown-item">
                            <i class="fa fa-bell"></i> 申请消息
                        </a>

                        <a href="#" class="dropdown-item">
                            <i class="fa fa-wrench"></i> 用户回复
                        </a>

                        <a href="#" class="dropdown-item">
                            <i class="fa fa-lock"></i> 注销登陆
                        </a>
                    </div>
                          
                </li>
            </ul>
     </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
  <div class="content">
            <div class="row">
                <div class="col-md-6">
                    <div class="card">
                        <div class="card-header bg-light" style="width:1200px;height:50px;border:none">
                         <h5>管理员申请列表</h5> <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
                        </div>
                    </div>
                </div>

            </div>
    <asp:GridView ID="GridView1" runat="server"  class="tab-content" style="width: 100%;text-align:center;word-break :break-all;word-wrap:break-word " RowStyle-Height="50px" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" EnableModelValidation="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="name" HeaderText="申请人" SortExpression="name" />
            <asp:BoundField DataField="department" HeaderText="部门" SortExpression="department" />
            <asp:BoundField DataField="job" HeaderText="岗位" SortExpression="job" />
            <asp:BoundField DataField="permission" HeaderText="所申请权限" SortExpression="permission" />
             <asp:BoundField DataField="applyState" HeaderText="状态" SortExpression="applyState" />
            <asp:TemplateField HeaderText="操作">
    <ItemTemplate>
    <asp:Button ID="btnAgree" runat="server" Text="同意" CssClass="btn btn-primary" CausesValidation="false" CommandName=""  OnClick="btnAgree_Click"/> 
         <asp:Button ID="btnRefuse" runat="server" Text="拒绝" CssClass="btn btn-primary" CausesValidation="false" CommandName=""  OnClick="btnRefuse_Click" /> 
    </ItemTemplate>
</asp:TemplateField> 

        </Columns>
        <HeaderStyle BackColor="#F8F9FA" />

<RowStyle Height="50px" BorderStyle="None"></RowStyle>
    </asp:GridView>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=.;Initial Catalog=UFB;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [name], [department], [job], [permission] ,[applyState]FROM [Apply_Message]"></asp:SqlDataSource>
   </div>
    
</asp:Content>
