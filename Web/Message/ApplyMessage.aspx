<%@ Page Title="" Language="C#" MasterPageFile="~/feedback.Master" AutoEventWireup="true" CodeBehind="ApplyMessage.aspx.cs" Inherits="UFB.Web.Message.ApplyMessage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>
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
           </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
