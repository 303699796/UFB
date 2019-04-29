<%@ Page Title="" Language="C#" MasterPageFile="~/UFB.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="UFB.Web.List.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="col-md-3">
                        <div class="card p-4">
                            <div class="card-body d-flex justify-content-between align-items-center">
                                <div>
                                    <span class="font-weight-light">今日反馈量</span><br /><br />

                                    <span class="h4 d-block font-weight-normal mb-2">900</span>
                                    
                                </div>

                                <div class="h2 text-muted">
                                    <i class="icon icon-cloud-download"></i>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class="col-md-3">
                        <div class="card p-4">
                            <div class="card-body d-flex justify-content-between align-items-center">
                                <div>
                                    <span class="font-weight-light">今日已处理</span><br /><br />
                                    <span class="h4 d-block font-weight-normal mb-2">32s</span>
                                    
                                </div>

                                <div class="h2 text-muted">
                                    <i class="icon icon-clock"></i>
                                </div>
                            </div>
                        </div>
                    </div>
                
</asp:Content>
