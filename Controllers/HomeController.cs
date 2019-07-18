using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AlcoholCurve()
        {
            TestModel testModel = new TestModel();
            testModel.SituationId = 1366;
            return View(testModel);
        }

        [HttpPost]
        public IActionResult AlcoholCurve(int situationId)
        {
            ChartReadings chartReadings = new ChartReadings();
            chartReadings.SituationStartDate = DateTime.Parse("9/18/2018 11:49:28 PM");
            chartReadings.SituationsEndDate = DateTime.Parse("9/19/2018 9:19:00 AM");
            chartReadings.EndDate = DateTime.Parse("9/19/2018 4:34:14 PM");
            chartReadings.StartDate = DateTime.Parse("9/18/2018 4:34:14 PM");
            chartReadings.ChartDatas = new List<ChartData>();
            #region DataAddition
            ChartData chartData = new ChartData();
            chartData.DeviceID = 778;
            chartData.IrDistance = 61.58148m;
            chartData.IrDistanceDisplayValue = 0.993m;
            chartData.RawIrDistance = 61.5814819f;
            chartData.RawTac = 0;
            chartData.RawTemperature = null;
            chartData.ReadingDateTime = DateTime.Parse("9/18/2018 4:49:28 PM");
            chartData.Tac = 0;
            chartData.Temperature = 0;

            chartReadings.ChartDatas.Add(chartData);

            chartData = new ChartData();
            chartData.DeviceID = 778;
            chartData.IrDistance = 61.58148m;
            chartData.IrDistanceDisplayValue = 0.993m;
            chartData.RawIrDistance = 61.5814819f;
            chartData.RawTac = 0;
            chartData.RawTemperature = null;
            chartData.ReadingDateTime = DateTime.Parse("9/18/2018 5:19:28 PM");
            chartData.Tac = 0;
            chartData.Temperature = 0;

            chartReadings.ChartDatas.Add(chartData);

            chartData = new ChartData();
            chartData.DeviceID = 778;
            chartData.IrDistance = 61.58148m;
            chartData.IrDistanceDisplayValue = 0.993m;
            chartData.RawIrDistance = 61.5814819f;
            chartData.RawTac = 0;
            chartData.RawTemperature = null;
            chartData.ReadingDateTime = DateTime.Parse("9/18/2018 5:49:28 PM");
            chartData.Tac = 0;
            chartData.Temperature = 0;

            chartReadings.ChartDatas.Add(chartData);


            chartData = new ChartData();
            chartData.DeviceID = 778;
            chartData.IrDistance = 61.58148m;
            chartData.IrDistanceDisplayValue = 0.993m;
            chartData.RawIrDistance = 61.5814819f;
            chartData.RawTac = 0;
            chartData.RawTemperature = null;
            chartData.ReadingDateTime = DateTime.Parse("9/18/2018 6:49:28 PM");
            chartData.Tac = 0;
            chartData.Temperature = 0;

            chartReadings.ChartDatas.Add(chartData);

            chartData = new ChartData();
            chartData.DeviceID = 778;
            chartData.IrDistance = 61.58148m;
            chartData.IrDistanceDisplayValue = 0.993m;
            chartData.RawIrDistance = 61.5814819f;
            chartData.RawTac = 0;
            chartData.RawTemperature = null;
            chartData.ReadingDateTime = DateTime.Parse("9/18/2018 7:19:28 PM");
            chartData.Tac = 0;
            chartData.Temperature = 0;
            chartReadings.ChartDatas.Add(chartData);

            chartData = new ChartData();
            chartData.DeviceID = 778;
            chartData.IrDistance = 61.58148m;
            chartData.IrDistanceDisplayValue = 0.993m;
            chartData.RawIrDistance = 61.5814819f;
            chartData.RawTac = 0;
            chartData.RawTemperature = null;
            chartData.ReadingDateTime = DateTime.Parse("9/18/2018 7:49:28 PM");
            chartData.Tac = 0;
            chartData.Temperature = 0;

            chartReadings.ChartDatas.Add(chartData);

            chartData = new ChartData();
            chartData.DeviceID = 778;
            chartData.IrDistance = 61.58148m;
            chartData.IrDistanceDisplayValue = 0.993m;
            chartData.RawIrDistance = 61.5814819f;
            chartData.RawTac = 0;
            chartData.RawTemperature = null;
            chartData.ReadingDateTime = DateTime.Parse("9/18/2018 8:19:28 PM");
            chartData.Tac = 0;
            chartData.Temperature = 0;
            chartReadings.ChartDatas.Add(chartData);

            chartData = new ChartData();
            chartData.DeviceID = 778;
            chartData.IrDistance = 61.58148m;
            chartData.IrDistanceDisplayValue = 0.993m;
            chartData.RawIrDistance = 61.5814819f;
            chartData.RawTac = 0;
            chartData.RawTemperature = null;
            chartData.ReadingDateTime = DateTime.Parse("9/18/2018 8:49:28 PM");
            chartData.Tac = 0;
            chartData.Temperature = 0;
            chartReadings.ChartDatas.Add(chartData);

            chartData = new ChartData();
            chartData.DeviceID = 778;
            chartData.IrDistance = 61.58148m;
            chartData.IrDistanceDisplayValue = 0.993m;
            chartData.RawIrDistance = 61.5814819f;
            chartData.RawTac = 0;
            chartData.RawTemperature = null;
            chartData.ReadingDateTime = DateTime.Parse("9/18/2018 9:19:28 PM");
            chartData.Tac = 0;
            chartData.Temperature = 0;
            chartReadings.ChartDatas.Add(chartData);

            chartData = new ChartData();
            chartData.DeviceID = 778;
            chartData.IrDistance = 61.58148m;
            chartData.IrDistanceDisplayValue = 0.993m;
            chartData.RawIrDistance = 61.5814819f;
            chartData.RawTac = 0;
            chartData.RawTemperature = null;
            chartData.ReadingDateTime = DateTime.Parse("9/18/2018 9:49:28 PM");
            chartData.Tac = 0;
            chartData.Temperature = 0;
            chartReadings.ChartDatas.Add(chartData);

            chartData = new ChartData();
            chartData.DeviceID = 778;
            chartData.IrDistance = 61.58148m;
            chartData.IrDistanceDisplayValue = 0.993m;
            chartData.RawIrDistance = 61.5814819f;
            chartData.RawTac = 0;
            chartData.RawTemperature = null;
            chartData.ReadingDateTime = DateTime.Parse("9/18/2018 10:19:28 PM");
            chartData.Tac = 0;
            chartData.Temperature = 0;
            chartReadings.ChartDatas.Add(chartData);

            chartData = new ChartData();
            chartData.DeviceID = 778;
            chartData.IrDistance = 61.58148m;
            chartData.IrDistanceDisplayValue = 0.993m;
            chartData.RawIrDistance = 61.5814819f;
            chartData.RawTac = 0;
            chartData.RawTemperature = null;
            chartData.ReadingDateTime = DateTime.Parse("9/18/2018 10:49:28 PM");
            chartData.Tac = 0;
            chartData.Temperature = 0;
            chartReadings.ChartDatas.Add(chartData);

            chartData = new ChartData();
            chartData.DeviceID = 778;
            chartData.IrDistance = 61.58148m;
            chartData.IrDistanceDisplayValue = 0.993m;
            chartData.RawIrDistance = 61.5814819f;
            chartData.RawTac = 0;
            chartData.RawTemperature = null;
            chartData.ReadingDateTime = DateTime.Parse("9/18/2018 11:19:28 PM");
            chartData.Tac = 0;
            chartData.Temperature = 0;
            chartReadings.ChartDatas.Add(chartData);

            chartData = new ChartData();
            chartData.DeviceID = 778;
            chartData.IrDistance = 61.58148m;
            chartData.IrDistanceDisplayValue = 0.993m;
            chartData.RawIrDistance = 61.5814819f;
            chartData.RawTac = 0;
            chartData.RawTemperature = null;
            chartData.ReadingDateTime = DateTime.Parse("9/18/2018 11:49:28 PM");
            chartData.Tac = 0;
            chartData.Temperature = 0;
            chartReadings.ChartDatas.Add(chartData);

            chartData = new ChartData();
            chartData.DeviceID = 778;
            chartData.IrDistance = 61.58148m;
            chartData.IrDistanceDisplayValue = 0.993m;
            chartData.RawIrDistance = 61.5814819f;
            chartData.RawTac = 0.005f;
            chartData.RawTemperature = null;
            chartData.ReadingDateTime = DateTime.Parse("9/18/2018 12:19:28 AM");
            chartData.Tac = 0.005m;
            chartData.Temperature = 0;
            chartReadings.ChartDatas.Add(chartData);

            chartData = new ChartData();
            chartData.DeviceID = 778;
            chartData.IrDistance = 61.58148m;
            chartData.IrDistanceDisplayValue = 0.993m;
            chartData.RawIrDistance = 61.5814819f;
            chartData.RawTac = 0.01815f;
            chartData.RawTemperature = null;
            chartData.ReadingDateTime = DateTime.Parse("9/18/2018 12:49:28 AM");
            chartData.Tac = 0.01815m;
            chartData.Temperature = 0;
            chartReadings.ChartDatas.Add(chartData);

            chartData = new ChartData();
            chartData.DeviceID = 778;
            chartData.IrDistance = 61.58148m;
            chartData.IrDistanceDisplayValue = 0.993m;
            chartData.RawIrDistance = 61.5814819f;
            chartData.RawTac = 0.01643f;
            chartData.RawTemperature = null;
            chartData.ReadingDateTime = DateTime.Parse("9/18/2018 1:19:28 AM");
            chartData.Tac = 0.01643m;
            chartData.Temperature = 0;
            chartReadings.ChartDatas.Add(chartData);

            chartData = new ChartData();
            chartData.DeviceID = 778;
            chartData.IrDistance = 61.58148m;
            chartData.IrDistanceDisplayValue = 0.993m;
            chartData.RawIrDistance = 61.5814819f;
            chartData.RawTac = 0.02253f;
            chartData.RawTemperature = null;
            chartData.ReadingDateTime = DateTime.Parse("9/18/2018 1:49:28 AM");
            chartData.Tac = 0.02253m;
            chartData.Temperature = 0;
            chartReadings.ChartDatas.Add(chartData);

            chartData = new ChartData();
            chartData.DeviceID = 778;
            chartData.IrDistance = 61.58148m;
            chartData.IrDistanceDisplayValue = 0.993m;
            chartData.RawIrDistance = 61.5814819f;
            chartData.RawTac = 0.05503f;
            chartData.RawTemperature = null;
            chartData.ReadingDateTime = DateTime.Parse("9/18/2018 2:19:28 AM");
            chartData.Tac = 0.05503m;
            chartData.Temperature = 0;
            chartReadings.ChartDatas.Add(chartData);

            chartData = new ChartData();
            chartData.DeviceID = 778;
            chartData.IrDistance = 61.58148m;
            chartData.IrDistanceDisplayValue = 0.993m;
            chartData.RawIrDistance = 61.5814819f;
            chartData.RawTac = 0.06f;
            chartData.RawTemperature = null;
            chartData.ReadingDateTime = DateTime.Parse("9/18/2018 2:49:28 AM");
            chartData.Tac = 0.06m;
            chartData.Temperature = 0;
            chartReadings.ChartDatas.Add(chartData);

            chartData = new ChartData();
            chartData.DeviceID = 778;
            chartData.IrDistance = 61.58148m;
            chartData.IrDistanceDisplayValue = 0.993m;
            chartData.RawIrDistance = 61.5814819f;
            chartData.RawTac = 0.05849f;
            chartData.RawTemperature = null;
            chartData.ReadingDateTime = DateTime.Parse("9/18/2018 3:19:28 AM");
            chartData.Tac = 0.05849m;
            chartData.Temperature = 0;
            chartReadings.ChartDatas.Add(chartData);

            chartData = new ChartData();
            chartData.DeviceID = 778;
            chartData.IrDistance = 61.58148m;
            chartData.IrDistanceDisplayValue = 0.993m;
            chartData.RawIrDistance = 61.5814819f;
            chartData.RawTac = 0.05757f;
            chartData.RawTemperature = null;
            chartData.ReadingDateTime = DateTime.Parse("9/18/2018 3:49:28 AM");
            chartData.Tac = 0.05757m;
            chartData.Temperature = 0;
            chartReadings.ChartDatas.Add(chartData);

            chartData = new ChartData();
            chartData.DeviceID = 778;
            chartData.IrDistance = 61.58148m;
            chartData.IrDistanceDisplayValue = 0.993m;
            chartData.RawIrDistance = 61.5814819f;
            chartData.RawTac = 0.05685f;
            chartData.RawTemperature = null;
            chartData.ReadingDateTime = DateTime.Parse("9/18/2018 4:19:28 AM");
            chartData.Tac = 0.05685m;
            chartData.Temperature = 0;
            chartReadings.ChartDatas.Add(chartData);

            chartData = new ChartData();
            chartData.DeviceID = 778;
            chartData.IrDistance = 61.58148m;
            chartData.IrDistanceDisplayValue = 0.993m;
            chartData.RawIrDistance = 61.5814819f;
            chartData.RawTac = 0.05407f;
            chartData.RawTemperature = null;
            chartData.ReadingDateTime = DateTime.Parse("9/18/2018 4:49:28 AM");
            chartData.Tac = 0.05407m;
            chartData.Temperature = 0;
            chartReadings.ChartDatas.Add(chartData);

            chartData = new ChartData();
            chartData.DeviceID = 778;
            chartData.IrDistance = 61.58148m;
            chartData.IrDistanceDisplayValue = 0.993m;
            chartData.RawIrDistance = 61.5814819f;
            chartData.RawTac = 0.05355f;
            chartData.RawTemperature = null;
            chartData.ReadingDateTime = DateTime.Parse("9/18/2018 5:19:28 AM");
            chartData.Tac = 0.05355m;
            chartData.Temperature = 0;
            chartReadings.ChartDatas.Add(chartData);

            chartData = new ChartData();
            chartData.DeviceID = 778;
            chartData.IrDistance = 61.58148m;
            chartData.IrDistanceDisplayValue = 0.993m;
            chartData.RawIrDistance = 61.5814819f;
            chartData.RawTac = 0.03923f;
            chartData.RawTemperature = null;
            chartData.ReadingDateTime = DateTime.Parse("9/18/2018 5:49:28 AM");
            chartData.Tac = 0.03923m;
            chartData.Temperature = 0;
            chartReadings.ChartDatas.Add(chartData);

            chartData = new ChartData();
            chartData.DeviceID = 778;
            chartData.IrDistance = 61.58148m;
            chartData.IrDistanceDisplayValue = 0.993m;
            chartData.RawIrDistance = 61.5814819f;
            chartData.RawTac = 0.03677f;
            chartData.RawTemperature = null;
            chartData.ReadingDateTime = DateTime.Parse("9/18/2018 6:19:28 AM");
            chartData.Tac = 0.03677m;
            chartData.Temperature = 0;
            chartReadings.ChartDatas.Add(chartData);

            chartData = new ChartData();
            chartData.DeviceID = 778;
            chartData.IrDistance = 61.58148m;
            chartData.IrDistanceDisplayValue = 0.993m;
            chartData.RawIrDistance = 61.5814819f;
            chartData.RawTac = 0.03277f;
            chartData.RawTemperature = null;
            chartData.ReadingDateTime = DateTime.Parse("9/18/2018 6:49:28 AM");
            chartData.Tac = 0.03277m;
            chartData.Temperature = 0;
            chartReadings.ChartDatas.Add(chartData);

            chartData = new ChartData();
            chartData.DeviceID = 778;
            chartData.IrDistance = 61.58148m;
            chartData.IrDistanceDisplayValue = 0.993m;
            chartData.RawIrDistance = 61.5814819f;
            chartData.RawTac = 0.02977f;
            chartData.RawTemperature = null;
            chartData.ReadingDateTime = DateTime.Parse("9/18/2018 7:19:28 AM");
            chartData.Tac = 0.02977m;
            chartData.Temperature = 0;
            chartReadings.ChartDatas.Add(chartData);

            chartData = new ChartData();
            chartData.DeviceID = 778;
            chartData.IrDistance = 61.58148m;
            chartData.IrDistanceDisplayValue = 0.993m;
            chartData.RawIrDistance = 61.5814819f;
            chartData.RawTac = 0.02677f;
            chartData.RawTemperature = null;
            chartData.ReadingDateTime = DateTime.Parse("9/18/2018 7:49:28 AM");
            chartData.Tac = 0.02677m;
            chartData.Temperature = 0;
            chartReadings.ChartDatas.Add(chartData);

            chartData = new ChartData();
            chartData.DeviceID = 778;
            chartData.IrDistance = 61.58148m;
            chartData.IrDistanceDisplayValue = 0.993m;
            chartData.RawIrDistance = 61.5814819f;
            chartData.RawTac = 0.02377f;
            chartData.RawTemperature = null;
            chartData.ReadingDateTime = DateTime.Parse("9/18/2018 8:19:28 AM");
            chartData.Tac = 0.02377m;
            chartData.Temperature = 0;
            chartReadings.ChartDatas.Add(chartData);

            chartData = new ChartData();
            chartData.DeviceID = 778;
            chartData.IrDistance = 61.58148m;
            chartData.IrDistanceDisplayValue = 0.993m;
            chartData.RawIrDistance = 61.5814819f;
            chartData.RawTac = 0.01977f;
            chartData.RawTemperature = null;
            chartData.ReadingDateTime = DateTime.Parse("9/18/2018 8:49:28 AM");
            chartData.Tac = 0.01977m;
            chartData.Temperature = 0;
            chartReadings.ChartDatas.Add(chartData);

            chartData = new ChartData();
            chartData.DeviceID = 778;
            chartData.IrDistance = 61.58148m;
            chartData.IrDistanceDisplayValue = 0.993m;
            chartData.RawIrDistance = 61.5814819f;
            chartData.RawTac = 0;
            chartData.RawTemperature = null;
            chartData.ReadingDateTime = DateTime.Parse("9/18/2018 9:19:28 AM");
            chartData.Tac = 0;
            chartData.Temperature = 0;
            chartReadings.ChartDatas.Add(chartData);

            chartData = new ChartData();
            chartData.DeviceID = 778;
            chartData.IrDistance = 61.58148m;
            chartData.IrDistanceDisplayValue = 0.993m;
            chartData.RawIrDistance = 61.5814819f;
            chartData.RawTac = 0;
            chartData.RawTemperature = null;
            chartData.ReadingDateTime = DateTime.Parse("9/18/2018 9:49:28 AM");
            chartData.Tac = 0;
            chartData.Temperature = 0;
            chartReadings.ChartDatas.Add(chartData);


            #endregion


            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
