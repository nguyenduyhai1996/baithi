using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class SachTheoTheLoai : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ViewState["MaLoaiLayDuoc"] = int.Parse(Request.QueryString.Get("MaLoai"));
            laybangchogridview();
            DemSoMauTinTuongUngVoiTheLoaiSachDuocChon();
        }
    }


    public void laybangchogridview()
    {
        ketnoi kn = new ketnoi();
        DataTable dt = new DataTable();
        dt = kn.laybang("select * from Sach where MaLoai=" + (int)ViewState["MaLoaiLayDuoc"]);
        DataList1.DataSource = dt;
        DataList1.DataBind();
    }


    public void DemSoMauTinTuongUngVoiTheLoaiSachDuocChon()
    {
        // Tạo đối tượng Connection và mở kết nối đến CSDL SQL Server
        string chuoiketnoi = @"Data Source=ADMIN\MSSQLSERVER02;Initial Catalog=SachOnline;Integrated Security=True";
        SqlConnection Conn = new SqlConnection(chuoiketnoi);
        Conn.Open();


        // Tạo đối tượng Command và select toàn bộ bảng Sach
        SqlCommand Cmd;
        Cmd = new SqlCommand();
        Cmd.CommandText = "Select Count(*) from Sach where MaLoai=" + (int)ViewState["MaLoaiLayDuoc"];
        Cmd.Connection = Conn;

        // Hiển thị kết quả trên Label
        int SL = (int)Cmd.ExecuteScalar();
        lblTongSoSanPham.Text = "Tìm được [" + SL.ToString() + "] sản phẩm";

        // Giải phóng kết nối. 
        Cmd.Dispose();
        Conn.Close();

    }
}