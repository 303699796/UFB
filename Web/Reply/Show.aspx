<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="UFB.Web.Reply.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		replyID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblreplyID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		feedbackID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblfeedbackID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		replier
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblreplier" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		replyText
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblreplyText" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		replyTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblreplyTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		number
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnumber" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		isRead
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblisRead" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




