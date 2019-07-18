using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class ChartData
    {
        public int DeviceID { get; set; }
        public DateTime ReadingDateTime { get; set; }
        public float? RawTac { get; set; }
        public float? RawIrDistance { get; set; }
        public float? RawTemperature { get; set; }
        public decimal Tac { get; set; }
        public decimal IrDistance { get; set; }
        public decimal IrDistanceDisplayValue { get; set; }
        public decimal Temperature { get; set; }

    }
    public class ChartReadings
    {
        public List<ChartData> ChartDatas { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate{ get; set; }
        public DateTime SituationStartDate { get; set; }
        public DateTime SituationsEndDate { get; set; }

    }

    public class TestModel
    {
        public int SituationId { get; set; }
    }

}
