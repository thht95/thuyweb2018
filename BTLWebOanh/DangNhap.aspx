<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DangNhap.aspx.cs" Inherits="BTLWebOanh.DangNhap" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/dang-nhap.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="title-gioithieu">
        <h1>ĐĂNG NHẬP</h1>
    </div>
    <div id="customer-login">
        <div id="login" class="userbox">
            <form accept-charset="UTF-8" action="/DangNhap.aspx" id="customer_login" method="post">
                <input name="form_type" type="hidden" value="customer_login">
                <input name="utf8" type="hidden" value="✓">



                <div class="clearfix large_form">
                    <label for="customer_email" class="icon-field"><i class="icon-login icon-envelope "></i></label>
                    <input required="" type="email" value="" name="txtEmail" id="txtEmail" placeholder="Email" class="text">
                </div>


                <div class="clearfix large_form">
                    <label for="customer_password" class="icon-field"><i class="icon-login icon-shield"></i></label>
                    <input required="" type="password" value="" name="txtPassword" id="txtPassword" placeholder="Mật khẩu" class="text" size="16">
                </div>


                <div class="action_bottom">
                    <input class="btn btn-signin" type="submit" value="Đăng nhập">
                </div>
                <div class="req_pass">
                    <a href="#">Quên mật khẩu?</a>
                    hoặc <a href="/DangKy.aspx" title="Đăng ký">Đăng ký</a>
                </div>

            </form>
        </div>
    </div>
</asp:Content>
