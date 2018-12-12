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
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Form["timkiem"] != null)
                {
                    String timKiem = Request.Form["timkiem"];
                    using (SqlConnection connection = new SqlConnection(Connect.ConnectionString))
                    {
                        connection.Open();
                        if (connection.State == ConnectionState.Open)
                        {
                            SqlCommand command = new SqlCommand("select * from tblSanPham where sTenSP like '%"+timKiem+"%'", connection);
                            SqlDataReader dataReader = command.ExecuteReader();
                            if (dataReader.HasRows)
                            {
                                while (dataReader.Read())
                                {
                                    ltrLoadSanPham.Text += @"
                                <div class='item'>
                                <a href='/Detail.aspx?id=" + dataReader["iMaSP"] + @"'><img src='" + dataReader["sAnh"] + @"'/></a>
                                <a class='title-sp' href='/Detail.aspx?id=" + dataReader["iMaSP"] + @"'>" + dataReader["sTenSP"] + @"</a>
                                <div class='desc'>
                                    Giá : " + dataReader["fGia"] + @" vnđ
                                </div>
                                </div>";
                                }
                            }
                            else
                            {
                                ltrLoadSanPham.Text = "Không tìm thấy từ khóa";
                            }
                        }
                    }
                }
                else
                {
                    ltrLoadSanPham.Text = "hihi vui lòng nhập sản phẩm cần tìm vào ô tìm kiếm";
                }
            }
        }
    }
}