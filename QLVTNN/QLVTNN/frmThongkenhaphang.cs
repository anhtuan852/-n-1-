using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BLL;
using BUS;
using DTO;

namespace QLVTNN
{
    public partial class frmThongkeNhapHang : Form
    {
        private ImportBLL importBLL;

        public frmThongkeNhapHang()
        {
            InitializeComponent();
            IsMdiContainer = false;
            importBLL = new ImportBLL(@"Data Source=DESKTOP-06DA0DB;Initial Catalog=QLCHDN;Integrated Security=True;Encrypt=False");
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            List<ImportStatisticsDTO> statistics = importBLL.GetImportStatistics(startDate, endDate);
            if (statistics == null || statistics.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Xóa các dữ liệu cũ trên biểu đồ (nếu có)
            chart1.Series.Clear();
            chart2.Series.Clear();

            // Tạo một loạt dữ liệu mới cho biểu đồ
            foreach (ImportStatisticsDTO statistic in statistics)
            {
                Series series = new Series(statistic.ProductName);
                series.Points.AddXY("Số lượng nhập", statistic.QuantityImported);
                //series.Points.AddXY("Tổng tiền", statistic.TotalAmount);

                // Thêm dữ liệu vào biểu đồ
                chart1.Series.Add(series);
            }
            foreach (ImportStatisticsDTO statistic in statistics)
            {
                Series series = new Series(statistic.ProductName);
                series.Points.AddXY("Tổng tiền", statistic.TotalAmount);

                // Thêm dữ liệu vào biểu đồ chart2
                chart2.Series.Add(series);
            }
        }
    }
}
