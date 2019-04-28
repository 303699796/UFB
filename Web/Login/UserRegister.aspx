<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserRegister.aspx.cs" Inherits="UFB.Web.Login.UserRegister" EnableEventValidation="false"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="UTF-8"/>
    <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0"/>
    <meta http-equiv="X-UA-Compatible" content="ie=edge"/>
    <title>用户注册</title>

      <link rel="stylesheet" href="../bootstrap/vendor/simple-line-icons/css/simple-line-icons.css"/>
    <link rel="stylesheet" href="../bootstrap/vendor/font-awesome/css/fontawesome-all.min.css"/>
     <link rel="stylesheet" href="../bootstrap/css/styles.css"/>

<%--  <script type="text/javascript">
      window.onload = function () {
          var selects = document.getElementsByTagName("select");//通过标签名获取select对象
          var date = new Date();
          var nowYear = date.getFullYear();//获取当前的年
          for (var i = nowYear; i >= nowYear - 60; i--) {
              var optionYear = document.createElement("option");
              optionYear.innerHTML = i;
              optionYear.value = i;
              selects[0].appendChild(optionYear);
          }
          for (var i = 1; i <= 12; i++) {
              var optionMonth = document.createElement("option");
              optionMonth.innerHTML = i;
              optionMonth.value = i;
              selects[1].appendChild(optionMonth);
          }
          getDays(selects[1].value, selects[0].value, selects);
      }
      // 获取某年某月存在多少天
      function getDaysInMonth(month, year) {
          var days;
          if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) {
              days = 31;
          } else if (month == 4 || month == 6 || month == 9 || month == 11) {
              days = 30;
          } else {
              if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)) {     // 判断是否为润二月
                  days = 29;
              } else {
                  days = 28;
              }
          }
          return days;
      }
      function setDays() {
          var selects = document.getElementsByTagName("select");
          var year = selects[0].options[selects[0].selectedIndex].value;
          var month = selects[1].options[selects[1].selectedIndex].value;
          getDays(month, year, selects);
      }
      function getDays(month, year, selects) {
          var days = getDaysInMonth(month, year);
          selects[2].options.length = 0;
          for (var i = 1; i <= days; i++) {
              var optionDay = document.createElement("option");
              optionDay.innerHTML = i;
              optionDay.value = i;
              selects[2].appendChild(optionDay);
          }
      }
</script>--%>
</head>

<body>
<form id="form1" runat="server">

<div class="page-wrapper flex-row align-items-center">
    <div class="container">
        <div class="row justify-content-center">
            <div class="col-md-5">
                <div class="card p-4">
                    <div class="card-header text-center text-uppercase h4 font-weight-light">
                       用户注册
                    </div>
                    <div class="card-body py-5">
                        <div class="form-group">
                            <label class="form-control-label">用户名&nbsp;:</label>                   
                           &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
                          <%--  <asp:RequiredFieldValidator ID="rfvUserName" runat="server" ControlToValidate="txbUserName" Display="Dynamic" ErrorMessage="请输入用户名"></asp:RequiredFieldValidator>                    --%>
                            <asp:TextBox ID="txbUserName" runat="server" class="form-control"></asp:TextBox>                          
                        </div>
                      
                            <div class="form-group">
                                <label class="form-control-label">出生日期&nbsp;: &nbsp;&nbsp; &nbsp; </label> 
                              
                                <asp:DropDownList ID="DropDownListYear" runat="server" ></asp:DropDownList>
                                <span>&nbsp;年 &nbsp; </span>
                            
                                    <asp:DropDownList ID="DropDownListMonth" runat="server" ></asp:DropDownList>
                               
                                <span>&nbsp;月 &nbsp; </span>
                                
                                <asp:DropDownList ID="DropDownListDay" runat="server"></asp:DropDownList>
                                <span>&nbsp;日 &nbsp;</span>
                             <%-- onchange="setDays()"--%>

                            </div>

                          <div class="form-group">
                            <label class="form-control-label"  style="float:left">性别&nbsp;: &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp;</label> 
                            <asp:DropDownList ID="DropDownList1" runat="server">
                                <asp:ListItem>男</asp:ListItem>
                                <asp:ListItem>女</asp:ListItem>
                            </asp:DropDownList>
                         </div>

                        <div class="form-group">
                            <label class="form-control-label" >密码&nbsp;:</label>  
                              &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
                           <%-- <asp:RequiredFieldValidator ID="rfvtxbPassword1" runat="server" ControlToValidate="txbPassword1" Display="Dynamic" ErrorMessage="请输入密码"></asp:RequiredFieldValidator>  --%>
                             <asp:TextBox runat="server" ID="txbPassword1" CssClass="form-control" TextMode="Password"></asp:TextBox>
                        </div>       
                        <div class="form-group">
                            <label class="form-control-label">确认密码&nbsp;:</label>  
                              &nbsp; &nbsp; &nbsp; 
                            <asp:RequiredFieldValidator ID="rfvtxbPassword2" runat="server" ControlToValidate="txbPassword2" Display="Dynamic" ErrorMessage="请再次输入密码"></asp:RequiredFieldValidator>  
                          <%--   <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txbPassword1" ControlToValidate="txbPassword2" Display="Dynamic" ErrorMessage="两次密码不一致"></asp:CompareValidator>--%>
                             <asp:TextBox runat="server" ID="txbPassword2" CssClass="form-control" TextMode="Password"></asp:TextBox>
                           
                        </div>   
                    </div>

                    <div class="card-footer">
                       <div class="row">
                          
                            <div class="col-6">
                                <a href="Login.aspx" class="btn btn-link">已有密码？登陆 ></a>
                            </div>
                             <div class="col-6">
                                 <asp:Button ID="Btn_submit" runat="server" Text="注册" CssClass="btn btn-primary px-5" OnClick="Btn_submit_Click"/>
                               </div>
                            </div>
                        </div>
                    </div>
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
