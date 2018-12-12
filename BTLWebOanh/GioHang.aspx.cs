using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTLWebOanh
{
    public partial class GioHang : System.Web.UI.Page
    {
        DataTable gioHang = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"]!=null) 
                {
                    string id = Request.QueryString["id"];
                    //nếu có sản phẩm được thêm vào  giỏ thì abcxyz
                    if (Session["giohang"]==null)
                    {
                        //giỏ hàng rỗng thì tạo mới
                        DataTable dt = new DataTable();
                        Session["giohang"] = dt;
                    }
                    else
                    {
                        //nếu có rồi thì load cái đã có vào datatable
                        gioHang = Session["giohang"] as DataTable;
                    }
                    using(SqlConnection conn = new SqlConnection(Connect.ConnectionString))
                    {
                        conn.Open();
                        if (conn.State == ConnectionState.Open)
                        {
                            string sql = "select iMaSP,sTenSP,fGia,sAnh from tblSanPham where iMaSP="+id;
                            SqlCommand command = new SqlCommand(sql, conn);
                            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                            DataTable dt = new DataTable();
                            dataAdapter.Fill(dt);
                            gioHang.Merge(dt);
                            Session["giohang"] = gioHang;
                        }
                    }
                }
                //mặc định sẽ load sản phẩm từ giỏ hàng ra ở đây
                gioHang = Session["giohang"] as DataTable;
                if (gioHang!=null)
                {
                    for (int i = 0; i < gioHang.Rows.Count; i++)
                    {
                        ltrGioHang.Text += @"<tr class='line-item'>
                                             <td class='item-image'>
                                             <img src = '"+gioHang.Rows[i]["sAnh"]+ @"' /></td>
                                             <td class='item-title'>
                                              " + gioHang.Rows[i]["sTenSP"] + @"
                                             </td>
                                             <td class='item-quantity'>
                                             <input id = 'quantity1' name='updates[]' min='1' type='number' value='1' class=''></td>
                                             <td class='item-price'>" + gioHang.Rows[i]["fGia"] + @"</td>
                                             <td class='item-delete'><a onclick='return XacNhanXoa(event);' href = '/Xuly/XoaGioHang.aspx?id="+gioHang.Rows[i]["iMaSP"] +@"' > Xóa </ a ></ td >
                                             </tr> ";
                    }
                }
            }
            
            
        }
        
    }
}