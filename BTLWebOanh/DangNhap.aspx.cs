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
    public partial class DangNhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string email = Request.Form["txtEmail"];
            string matkhau = Request.Form["txtPassword"];
            if (!IsPostBack)
            {
                if (email != null)
                {
                    using (SqlConnection connection = new SqlConnection(Connect.ConnectionString))
                    {
                        connection.Open();
                        if (connection.State == ConnectionState.Open)
                        {
                            string sql = "select * from dbo.tblUsers where sEmail = '" + email + "' and sMatKhau = '" + matkhau + "'";
                            SqlCommand command = new SqlCommand(sql, connection);
                            SqlDataAdapter da = new SqlDataAdapter(command);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            if (dt.Rows.Count > 0)
                            {
                                Session["Login"] = dt.Rows[0]["sHoTen"];
                                Response.Write("<script >alert('Đăng nhập thành công, trang sẽ tự load sau 5s');</script>");
                                Response.AppendHeader("Refresh", "2;url=/Index.aspx");
                            }
                            else
                            {
                                Response.Write("<script >alert('Sai tài khoản hoặc mật khẩu');</script>");
                            }
                        }
                    }
                }
            }
        }
    }
}