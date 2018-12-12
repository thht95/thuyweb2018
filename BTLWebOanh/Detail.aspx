<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Detail.aspx.cs" Inherits="BTLWebOanh.Detail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/detail.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="chitietsp">
        <div class="baosp">
            <asp:Literal ID="ltrAnhSP" runat="server"></asp:Literal>
            
        </div>
        <div class="baochitiet">
            <div class="product-title">
                <h1><asp:Literal ID="ltrTenSP" runat="server"></asp:Literal></h1>

            </div>
            <div class="product-price">
                <span><asp:Literal ID="ltrGiaSP" runat="server"></asp:Literal> vn₫</span>
            </div>
            <div class="thongtin">
                
                <asp:Literal ID="ltrMoTa" runat="server"></asp:Literal>
            </div>
            <div class="row">
                <div class="giohangsp">
                    <asp:Literal ID="ltrButton" runat="server"></asp:Literal>
                </div>
                <div class="muangay">
                    <button id="buy-now" class="btn-detail btn-color-buy">Mua ngay</button>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
