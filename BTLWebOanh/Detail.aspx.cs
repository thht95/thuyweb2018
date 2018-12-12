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
    public partial class Detail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = string.Empty;
            if (!IsPostBack)
            {
                if (Request.QueryString["id"]!=null)
                {
                    id = Request.QueryString["id"];
                }
                using (SqlConnection connection = new SqlConnection(Connect.ConnectionString))
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        SqlCommand command = new SqlCommand("select * from tblSanPham where iMaSp="+id, connection);
                        SqlDataReader dataReader = command.ExecuteReader();
                        if (dataReader.HasRows)
                        {
                            dataReader.Read();
                            ltrAnhSP.Text = @"<img alt='Ảnh sản phẩm' class='imgsp' src='/"+dataReader["sAnh"]+@"' />";
                            ltrTenSP.Text = dataReader["sTenSP"]+"";
                            ltrGiaSP.Text = dataReader["fGia"] + "";
                            ltrMoTa.Text = dataReader["sMoTa"] + "";
                        }
                    }
                }
                ltrButton.Text = "<button id='add-to-cart' class='btn-detail btn-color-add' name='add'><a href='/GioHang.aspx?id="+id+"'>Thêm vào giỏ</a> </button>";
            }
        }
    }
}