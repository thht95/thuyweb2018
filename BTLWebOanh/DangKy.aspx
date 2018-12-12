<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DangKy.aspx.cs" Inherits="BTLWebOanh.DangKy" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/dang-ky.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="title-gioithieu">
        <h1>TẠO TÀI KHOẢN</h1>
    </div>
    <div class="userbox">

        <form accept-charset="UTF-8" action="/DangKy.aspx" id="create_customer" method="post">
            <input name="form_type" type="hidden" value="create_customer">
            <input name="utf8" type="hidden" value="✓">

            <div id="last_name" class="clearfix">
                <div class="label-lname"></div>
                <input type="text" name="txtName" placeholder="Họ và Tên" id="txtName" class="text" size="30">
            </div>

            <div id="email" class="clearfix">
                <div class="label-email"></div>
                <input type="email" placeholder="Email" name="txtEmail" id="txtEmail" class="text" size="30">
            </div>

            <div id="password" class="clearfix">
                <div class="label-pass"></div>
                <input type="password" placeholder="Mật khẩu" name="txtPassword" id="txtPassword" class="password text" size="30">
            </div>

            <div class="action_bottom">
                <input class="btn" type="submit" value="Đăng ký">
            </div>
            
                <a class="come-back" href="/account/login">Quay về</a>
            

        </form>
    </div>
</asp:Content>
