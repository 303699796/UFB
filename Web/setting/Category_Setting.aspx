﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Category_Setting.aspx.cs" Inherits="UFB.Web.setting.Category_Setting" %>

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
    <form id="form2" runat="server" onsubmit="return false">
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
            
                   
                       
                          <asp:Button ID="Button1" runat="server" Text="新增问题分类"  class="btn btn-primary px-5"   data-toggle="modal" data-target="#modal-1" style="float:left" />
                   <br />
              <br />
             <br />
         

        <asp:GridView ID="GridView1" runat="server"  class="tab-content" style="width: 100%;text-align:center;word-break :break-all;word-wrap:break-word " RowStyle-Height="50px"
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
            </asp:GridView>
                </div> 

        <div class="modal fade" id="modal-1" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
    <div class="modal-dialog" role="document">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title">添加问题分类</h5>
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <span aria-hidden="true">&times;</span>
                </button>
            </div>

            <div class="modal-body">
                 <asp:Label ID="Label1" runat="server" Text="请输入新增问题分类"></asp:Label>
                &nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txbAdd" runat="server" Width="300px" Height="30px"></asp:TextBox>
            </div>

            <div class="modal-footer" >
                <button type="button" class="btn btn-link"  data-dismiss="modal">取消</button>
               <%-- <button  type="button" class="btn btn-primary" onclick=""  >保存</button>--%>
                <asp:Button ID="BntSave" type="button" runat="server"  class="btn btn-primary" OnClick="BntSave_Click"  Text="保存" />
            </div>
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