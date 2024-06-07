using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BLL;
using DAO;
using DTO;

namespace QLVTNN
{
    public partial class frmThongkebanhang : Form
    {

        private SaleBLL saleBLL;

        public frmThongkebanhang()
        {
            InitializeComponent();
            IsMdiContainer = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            saleBLL = new SaleBLL(@"Data Source=DESKTOP-06DA0DB;Initial Catalog=QLCHDN;Integrated Security=True;Encrypt=False");
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            // Lấy dữ liệu thống kê từ BLL
            List<SaleStatisticsDTO> statistics = saleBLL.GetSalesStatistics(startDate, endDate);
            if (statistics == null || statistics.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Xóa các dữ liệu cũ trên biểu đồ (nếu có)
            chart1.Series.Clear();
            chart2.Series.Clear();

            // Tạo một loạt dữ liệu mới cho biểu đồ
            foreach (SaleStatisticsDTO statistic in statistics)
            {
                // Tạo một loạt dữ liệu mới cho biểu đồ
                Series series = new Series(statistic.ProductName);
                series.ChartType = SeriesChartType.Column; // Loại biểu đồ là cột

                // Thêm dữ liệu số lượng bán vào biểu đồ
                series.Points.AddXY("Số lượng bán", statistic.QuantitySold);



                // Thêm dữ liệu vào biểu đồ
                chart1.Series.Add(series);
            }
            foreach (SaleStatisticsDTO statistic in statistics)
            {
                // Tạo một loạt dữ liệu mới cho biểu đồ
                Series series = new Series(statistic.ProductName);
                series.ChartType = SeriesChartType.Column; // Loại biểu đồ là cột

                // Thêm dữ liệu doanh thu vào biểu đồ chart2
                series.Points.AddXY("Doanh thu", statistic.TotalRevenue);

                // Thêm dữ liệu vào biểu đồ chart2
                chart2.Series.Add(series);
            }
        }
    }
}
