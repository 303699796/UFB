<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminSetting.aspx.cs" Inherits="UFB.Web.setting.AdminSetting" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="UTF-8"/>
    <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0"/>
    <meta http-equiv="X-UA-Compatible" content="ie=edge"/>
    <title>管理员设置</title>
     <link rel="stylesheet" href="../bootstrap/vendor/simple-line-icons/css/simple-line-icons.css"/>
    <link rel="stylesheet" href="../bootstrap/vendor/font-awesome/css/fontawesome-all.min.css"/>
     <link rel="stylesheet" href="../bootstrap/css/styles.css"/>
</head>
<body class="sidebar-fixed header-fixed">
    <form id="form2" runat="server">
<div class="page-wrapper">
    <div class="page-header">
        <nav class="navbar page-header">
            <a href="#" class="btn btn-link sidebar-mobile-toggle d-md-none mr-auto">
                <i class="fa fa-bars"></i>
            </a>

            <a class="navbar-brand" href="#">
                <img src="./imgs/logo.png" alt="logo">
            </a>

            <a href="#" class="btn btn-link sidebar-toggle d-md-down-none">
                <i class="fa fa-bars"></i>
            </a>

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
                </li>

                <li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle" href="#" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        <img src="./imgs/avatar-1.png" class="avatar avatar-sm" alt="logo">
                        <span class="small ml-1 d-md-down-none">John Smith</span>
                    </a>

                    <div class="dropdown-menu dropdown-menu-right">
                        <div class="dropdown-header">Account</div>

                        <a href="#" class="dropdown-item">
                            <i class="fa fa-user"></i> Profile
                        </a>

                        <a href="#" class="dropdown-item">
                            <i class="fa fa-envelope"></i> Messages
                        </a>

                        <div class="dropdown-header">Settings</div>

                        <a href="#" class="dropdown-item">
                            <i class="fa fa-bell"></i> Notifications
                        </a>

                        <a href="#" class="dropdown-item">
                            <i class="fa fa-wrench"></i> Settings
                        </a>

                        <a href="#" class="dropdown-item">
                            <i class="fa fa-lock"></i> Logout
                        </a>
                    </div>
                </li>
            </ul>
        </nav>
    </div>

    <div class="main-container">
         <div class="sidebar">
            <nav class="sidebar-nav">
                <ul class="nav">
                    <li class="nav-title">Navigation</li>

                    <li class="nav-item">
                        <a href="index.html" class="nav-link active">
                            <i class="icon icon-speedometer"></i> 首页
                        </a>
                    </li>
                       <li class="nav-item">
                        <a href="forms.html" class="nav-link">
                            <i class="icon icon-puzzle"></i> 反馈列表
                        </a>
                    </li>
                    <li class="nav-item nav-dropdown">
                        <a href="#" class="nav-link nav-dropdown-toggle">
                            <i class="icon icon-target"></i> 反馈分析 <i class="fa fa-caret-left"></i>
                        </a>

                        <ul class="nav-dropdown-items">
                            <li class="nav-item">
                                <a href="layouts-normal.html" class="nav-link">
                                    <i class="icon icon-target"></i> 反馈数量
                                </a>
                            </li>

                            <li class="nav-item">
                                <a href="layouts-fixed-sidebar.html" class="nav-link">
                                    <i class="icon icon-target"></i> 反馈分类
                                </a>
                            </li>

                            <li class="nav-item">
                                <a href="layouts-fixed-header.html" class="nav-link">
                                    <i class="icon icon-target"></i> 热门关键词
                                </a>
                            </li>

                            <li class="nav-item">
                                <a href="layouts-hidden-sidebar.html" class="nav-link">
                                    <i class="icon icon-target"></i> 用户画像
                                </a>
                            </li>
                        </ul>
                    </li>

                    <li class="nav-item nav-dropdown">
                        <a href="#" class="nav-link nav-dropdown-toggle">
                            <i class="icon icon-energy"></i> 设置 <i class="fa fa-caret-left"></i>
                        </a>

                        <ul class="nav-dropdown-items">
                            <li class="nav-item">
                                <a href="alerts.html" class="nav-link">
                                    <i class="icon icon-energy"></i> 常见问题
                                </a>
                            </li>

                            <li class="nav-item">
                                <a href="buttons.html" class="nav-link">
                                    <i class="icon icon-energy"></i> 问题分类
                                </a>
                            </li>

                            <li class="nav-item">
                                <a href="cards.html" class="nav-link">
                                    <i class="icon icon-energy"></i> 管理员设置
                                </a>
                            </li>                         
                        </ul>
                    </li>                 
                        </ul>
                
            </nav>
        </div>

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


            <asp:GridView ID="GridView1" runat="server" class="tab-content" style="width: 100%;text-align:center;word-break :break-all;word-wrap:break-word " RowStyle-Height="50px"
                OnRowDeleting="GridView1_RowDeleting"  OnRowDataBound="GridView1_RowDataBound" OnRowEditing="GridView1_RowEditing"
                OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowUpdating="GridView1_RowUpdating" AutoGenerateColumns="False" DataKeyNames="ID" EnableModelValidation="True">
                 <Columns>
                       <asp:TemplateField HeaderText ="ID">
                        <ItemTemplate>
                            <asp:Label ID="LabelID" runat="server" Text='<%#Bind("ID")%>'></asp:Label>
                          </ItemTemplate>
                    </asp:TemplateField>


                    <asp:BoundField DataField="adminName" HeaderText="管理员" ReadOnly="True" />
                    <asp:BoundField DataField="department" HeaderText="部门" ReadOnly="True" />
                    <asp:BoundField DataField="job" HeaderText="职位" ReadOnly="True" />
                      <asp:TemplateField HeaderText ="权限">
                     <ItemTemplate>
                            <asp:TextBox ID="txbpermission" runat="server" BorderStyle="None" style="text-align:center"  Text='<%#Bind("permission")%>'></asp:TextBox>                         
                          </ItemTemplate>
                    </asp:TemplateField>
                <%--   <asp:BoundField DataField="permission" HeaderText="权限" />--%>

                       <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" EditText="编辑权限" />

                      </Columns>

<RowStyle Height="50px"></RowStyle>

            </asp:GridView>
              </div>
    </div>
</div>


          
   </form>  

 <script src="../bootstrap/vendor/jquery/jquery.min.js"></script>
<script src="../bootstrap/vendor/popper.js/popper.min.js"></script>
<script src="../bootstrap/vendor/bootstrap/js/bootstrap.min.js"></script>
<script src="../bootstrap/vendor/chart.js/chart.min.js"></script>
<script src="../bootstrap/js/carbon.js"></script>
<script src="../bootstrap/js/demo.js"></script>
</body>
</html>
