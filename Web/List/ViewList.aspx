<%@ Page Title="" Language="C#" MasterPageFile="~/master/feedback.Master" AutoEventWireup="true" CodeBehind="ViewList.aspx.cs" Inherits="UFB.Web.List.ViewList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
  
        <div class="content">
            
   <div class="row">
           <asp:Button ID="btn_Reply"   class="btn btn-rounded btn-info"  data-toggle="modal" data-target="#modal-1" style="width:80px" runat="server" Text="回复" />&nbsp;&nbsp;
             <asp:Button ID="btn_Distribution"   class="btn btn-rounded btn-info"  data-toggle="modal" data-target="#modal-2"  style="width:80px" runat="server" Text="分配" />&nbsp;&nbsp;
              <asp:Button ID="btn_Dealwith"  class="btn btn-rounded btn-info"  runat="server" Text="标记为已处理"  OnClick="btn_Dealwith_Click"/>&nbsp;&nbsp;
              <asp:Button ID="btn_Invalid" class="btn btn-rounded btn-info"  runat="server" Text="标记为无效" OnClick="btn_Invalid_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

         </div>  
            <br />
            <div class="row">
       <asp:Label ID="LabelCategory" runat="server"   class="btn btn-info"  Text="问题分类查询"></asp:Label>
                     <asp:DropDownList ID="DropDownList_Category" class="form-control"  style="width:150px" runat="server" DataSourceID="SqlDataSource_Category" DataTextField="category" DataValueField="category" ></asp:DropDownList>
           <asp:SqlDataSource ID="SqlDataSource_Category" runat="server" ConnectionString="Data Source=.;Initial Catalog=UFB;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [category] FROM [Category]"></asp:SqlDataSource>
           &nbsp;&nbsp;
       <asp:TextBox ID="txbStar" runat="server" Text="请选择开始日期" ></asp:TextBox>
              


                  <asp:Button ID="btn_Search" runat="server"  class="btn btn-info"   Text="搜索" OnClick="btn_Search_Click"/>
            <asp:TextBox ID="txbSearch" class="form-control"  style="width:200px;float:right"  runat="server"></asp:TextBox>                            
                </div>                 
                         
                <br />
    <asp:GridView ID="GridView1" runat="server" class="tab-content" style="width: 100%;text-align:center;word-break :break-all;word-wrap:break-word " RowStyle-Height="50px"  AllowPaging="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource_FeedbackList" EnableModelValidation="True">
        <Columns>
             <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:CheckBox runat="server"  Width="20px" ID="CheckBoxId">
                                        </asp:CheckBox>
                                    </ItemTemplate>
                                </asp:TemplateField>
            <asp:BoundField DataField="UserID" HeaderText="用户ID" SortExpression="UserID" />
            <asp:BoundField DataField="feedbackTime" HeaderText="反馈时间" SortExpression="feedbackTime" />
            <asp:BoundField DataField="category" HeaderText="问题分类" SortExpression="category" />
            <asp:BoundField DataField="Info" HeaderText="反馈内容" SortExpression="Info" />
            <asp:BoundField DataField="contact" HeaderText="用户联系方式" SortExpression="contact" />
            <asp:BoundField DataField="image" HeaderText="图片" SortExpression="image" />
            <asp:BoundField DataField="isInvalid" HeaderText="是否有效" SortExpression="isInvalid" />
            <asp:BoundField DataField="solutionState" HeaderText="解决状态" SortExpression="solutionState" />
            
        </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource_FeedbackList" runat="server" ConnectionString="Data Source=.;Initial Catalog=UFB;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [UserID], [feedbackTime], [category], [Info], [isInvalid], [solutionState], [contact], [image] FROM [Feedback]"></asp:SqlDataSource>


         
    </div> 


        </asp:Content>
