using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class ChiTietSach : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Lấy mã loại sách khi người dùng chọn thể loại sách tương ứng
        //MaLoai là tên hiển thị trên thanh địa chỉ của trình duyệt
        //Dùng biến ViewState để khi Refresh lại trang, thì giá trị của biến ViewState không bị khởi tạo lại nó vẫn có giá trị như vậy,
        //nếu dùng biến khác chẳng hạn string MaLoaiLayDuoc, thi khi Refresh lại trang biến MaLoaiLayDuoc sẽ không chứa giá trị hiện có mà trở về không (ban đầu)
        //Dòng ViewState["MaLoaiLayDuoc"] = int.Parse(Request.QueryString.Get("MaLoai")); để lấy giá trị cho biến
        //Khi dùng thì phải khai báo (int)ViewState["MaLoaiLayDuoc"]

        if (!IsPostBack)
        {
            ViewState["MaSachLayDuoc"] = int.Parse(Request.QueryString.Get("MaSach"));
            laybangchogridview();
        }
    }


    public void laybangchogridview()
    {
        ketnoi kn = new ketnoi();
        DataTable dt = new DataTable();
        dt = kn.laybang("select * from Sach where MaSach=" + (int)ViewState["MaSachLayDuoc"]);
        GridView1.DataSource = dt;
        GridView1.DataBind();

        //lblTenSach.Text = dt.Rows[0]["TenSach"].ToString();
       // lblTacGia.Text = dt.Rows[0]["TacGia"].ToString();
        //lblGia.Text = dt.Rows[0]["Gia"].ToString();
        //lblSoLuong.Text = dt.Rows[0]["SoLuong"].ToString();
        //lblMoTa.Text = dt.Rows[0]["MoTa"].ToString();
        //Hiển thị ảnh của sách tương ứng ra điều khiển Image
        //imgSach.ImageUrl = "~/Images/" + dt.Rows[0]["TenFileAnh"].ToString();
    }
}