using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTLWebOanh
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["Login"] == null)
            {
                ltrDangNhap.Text = @"<ul>
                    <li class='dangnhap1'>/<a href='/DangKy.aspx'>Đăng ký</a></li>
                    <li class='dangnhap2'><a href = '/DangNhap.aspx' > Đăng nhập</a></li>
                </ul>";
            }
            else
            {
                ltrDangNhap.Text = @"<ul>
                    <li class='dangnhap1'>/<a href='/Xuly/DangXuat.aspx'>Đăng xuất</a></li>
                    <li class='dangnhap2'>Xin chào " + Session["Login"] + @"</li>
                </ul>";
            }
        }
    }
}