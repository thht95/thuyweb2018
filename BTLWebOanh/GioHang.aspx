<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="GioHang.aspx.cs" Inherits="BTLWebOanh.GioHang" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/gio-hang.css" rel="stylesheet" />
    <script type="text/javascript" src="js/GioHang.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="modal-content">

        <form action="" method="post" id="cartform" style="display: block;">
            <div class="modal-body">
                <table style="width: 100%;" id="cart-table">
                    <tbody>
                        <tr>
                            <th></th>
                            <th>Tên sản phẩm</th>
                            <th>Số lượng</th>
                            <th>Giá tiền</th>
                            <th></th>
                        </tr>
                        <tr class="line-item original">
                            <td class="item-image"></td>
                            <td class="item-title">
                                <a></a>
                            </td>
                            <td class="item-quantity"></td>
                            <td class="item-price"></td>
                            <td class="item-delete"></td>
                        </tr>
                        <%--<tr class="line-item">
                            <td class="item-image">
                                <img src="AnhSanPham/anh1.jpg" /></td>
                            <td class="item-title">
                                Anne Klein Quartz 1018RGWT Women's Watch
                            </td>
                            <td class="item-quantity">
                                <input id="quantity1" name="updates[]" min="1" type="number" value="1" class=""></td>
                            <td class="item-price">1600000</td>
                            <td class="item-delete"><a href="#">Xóa</a></td>
                        </tr>
                        <tr class="line-item">
                            <td class="item-image">
                                <img src="AnhSanPham/anh2.jpg" /></td>
                            <td class="item-title">
                                Anne Klein Quartz 1018BKBK Women's Watch
                            </td>
                            <td class="item-quantity">
                                <input id="quantity2" name="updates[]" min="1" type="number" value="1" class=""></td>
                            <td class="item-price">2300000</td>
                            <td class="item-delete"><a href="#">Xóa</a></td>
                        </tr>--%>
                        <asp:Literal ID="ltrGioHang" runat="server"></asp:Literal>
                    </tbody>
                </table>
            </div>
            <div class="modal-footer">
                <div class="row" style="margin-top: 10px;">
                    <div class="col-lg-6">
                        <div class="comeback">
                            <a href="/Index.aspx">
                                Tiếp tục mua hàng
                            </a>
                        </div>
                    </div>
                    <div class="col-lg-6 text-right">
                        <div class="buttons btn-modal-cart">
                            <button type="submit" class="button-default" id="checkout" name="checkout">
                                Đặt hàng
                            </button>
                        </div>

                        <div class="buttons btn-modal-cart">
                            <button type="submit" class="button-default" id="update-cart-modal" name="">Cập nhật</button>
                        </div>
                    </div>
                </div>

            </div>

        </form>
    </div>
</asp:Content>
