using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTLWebOanh.Xuly
{
    public partial class XoaGioHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"]!=null && Session["giohang"]!=null)
                {
                    int id = int.Parse(Request.QueryString["id"]);
                    DataTable gioHang = Session["giohang"] as DataTable;
                    for (int i = 0; i < gioHang.Rows.Count; i++)
                    {
                        if (gioHang.Rows[i]["iMaSP"].Equals(id)) // nếu id gửi đến ý == mã sản phẩm thì xóa nó
                        {
                            gioHang.Rows.Remove(gioHang.Rows[i]);
                            gioHang.AcceptChanges();
                            Session["giohang"] = gioHang;
                            break;
                        }
                    }
                }
            }
            Response.Redirect("/GioHang.aspx");
        }
    }
}