using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ImportBLL
    {
        private ImportDAL importDAL;

        public ImportBLL(string connectionString)
        {
            this.importDAL = new ImportDAL(connectionString);
        }

        public List<ImportStatisticsDTO> GetImportStatistics(DateTime startDate, DateTime endDate)
        {
            return importDAL.GetImportStatistics(startDate, endDate);
        }

    }
}