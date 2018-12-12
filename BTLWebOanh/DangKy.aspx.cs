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
    public partial class DangKy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string email = Request.Form["txtEmail"];
                string name = Request.Form["txtName"];
                string password = Request.Form["txtPassword"];
                if (Request.Form["txtEmail"] !=null)
                {
                    using (SqlConnection connection = new SqlConnection(Connect.ConnectionString))
                    {
                        connection.Open();
                        if (connection.State == ConnectionState.Open)
                        {
                            try
                            {
                                string sql = "insert into dbo.tblUsers ( sEmail, sMatKhau, sHoTen ) values ('" + email + "','" + password + "',N'" + name + "')";
                                SqlCommand command = new SqlCommand(sql, connection);
                                int kq = command.ExecuteNonQuery();
                                if (kq > 0)
                                {
                                    //thành công
                                    Response.Write("<script >alert('Thêm thành công, trang sẽ tự load sau 5s');</script>");
                                    Response.AppendHeader("Refresh", "2;url=/DangNhap.aspx");
                                }
                                else
                                {
                                    //hihi lỗi rồi
                                    Response.Write("<script >alert('Thêm thất bại, chắc là trùng email hihi');</script>");

                                }
                            }catch(Exception ex)
                            {
                                Response.Write("<script >alert('Thêm thất bại, chắc là trùng email hihi');</script>");
                            }
                        }
                    }
                }
            }
        }
    }
}