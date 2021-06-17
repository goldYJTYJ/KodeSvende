using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelLibrary;
using ModelLibrary.DTO;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EcoController : Controller
    {

        private readonly RangeMateContext _RangeMatecontext;
        public EcoController(RangeMateContext rangeMateContext)
        {
            _RangeMatecontext = rangeMateContext;
        }

        ////////////////////////////////// ICE SECTION //////////////////////////////////

        // Get Summary for ICE Engine
        [HttpGet("{EngineID}", Name = "GetEcoSummaryICE")]
        public IActionResult GetEcoSummaryICE([FromQuery] int EngineID)
        {
            try
            {
                var GetSummary = _RangeMatecontext.EconomySummaryICEs
                    .FirstOrDefault(x => x.EngineId == EngineID);
                return Ok(GetSummary);
            }
            catch (Exception)
            {
                return Ok("Could Not Connect To Database");
            }
        }

        // Get list of all ICE Engines given engine ID
        [HttpGet("GetEcoListICE/{EngineID}", Name = "GetEcoListICE")]
        public IActionResult GetEcoICEList([FromRoute] int EngineID)
        {
            try
            {
                var AllEcoReports = _RangeMatecontext.EconomyReportICE.Where(x => x.EngineId == EngineID).ToList();
                return Ok(AllEcoReports.OrderBy(x => x.UserID));
            }
            catch (Exception)
            {
                // if database connection fails return error
                return Ok("Could Not Connect To Database");
            }
        }

        // Create report for ICE
        [HttpPost("CreateReport/ICE", Name = "CreateICEReport")]
        public IActionResult CreateICEReport([FromBody] EconomyReportICE EcoReport)
        {
            double EconomyNumbers = 0; // To Save Economy numbers for later use

            // Check if the recived model is valid
            if (!ModelState.IsValid)
            {
                return Ok("Model State Invalid");
            }

            if (!_RangeMatecontext.Engine.Any(EngineID => EngineID.Id == EcoReport.EngineId))
            {
                return Ok("Engine ID does not exist.");
            }

            try
            {
                // Get Engine information
                var EngineInformation = _RangeMatecontext.Engine.FirstOrDefault(x => x.Id == EcoReport.EngineId);

                // Use WLTP numbers if available
                if (EngineInformation.WLTP != 0)
                {
                    EconomyNumbers = EngineInformation.WLTP;
                }
                else
                {
                    EconomyNumbers = EngineInformation.NEDC;
                }

                /*
                This checks if the report is unrealistic.
                e.g if the number sways too much from the official number,
                the report is considered unrealistical.
                */
                // Check if numbers are considered realistic
                if (EcoReport.Average > EconomyNumbers * 1.50 ||
                    EcoReport.Average < EconomyNumbers * 0.50)
                {
                    return Ok("The Average is considered unrealistic");
                }

                if ((EcoReport.Motorway > EconomyNumbers * 1.50 ||
                    EcoReport.Motorway < EconomyNumbers * 0.50) && EcoReport.Motorway != 0)
                {
                    return Ok("The Motorway considered unrealistic");
                }

                if ((EcoReport.City > EconomyNumbers * 1.50 ||
                    EcoReport.City < EconomyNumbers * 0.50) && EcoReport.City != 0)
                {
                    return Ok("The City considered unrealistic");
                }

                // Save new report
                _RangeMatecontext.EconomyReportICE.Add(EcoReport);
                _RangeMatecontext.SaveChanges();

                // Update summary table
                var getSummary = _RangeMatecontext.EconomySummaryICEs.FirstOrDefault(x => x.EngineId == EcoReport.EngineId);
                // Check if first summary
                if (getSummary == null)
                {

                    // Create report
                    EconomySummaryICE CreateSummary = new EconomySummaryICE
                    {
                        EngineId = EcoReport.EngineId,
                        Reported_Motorway = EcoReport.Motorway,
                        Reported_City = EcoReport.City,
                        Reported_Average = EcoReport.Average,
                        Amount_Of_Reports = 1,
                        Manufacturer_Average = EconomyNumbers
                    };

                    // save report
                    _RangeMatecontext.EconomySummaryICEs.Add(CreateSummary);
                    _RangeMatecontext.SaveChanges();
                    return Ok("First Report");
                }
                else
                {
                    // update report
                    List<EconomyReportICE> GetAllReports = _RangeMatecontext.EconomyReportICE.Where(x => x.EngineId == EcoReport.EngineId && x.Is_Active).ToList();
                    double AverageOfAverage = 0;
                    double AverageOfMotorway = 0;
                    double AverageOfCity = 0;

                    int averageCounterMotorway = 0;
                    int averageCounterCity = 0;

                    var NumberOfReports = 0;

                    // Go through all reports
                    foreach (var item in GetAllReports)
                    {
                        AverageOfAverage += item.Average;
                        AverageOfMotorway += item.Motorway;
                        AverageOfCity += item.City;

                        // Make sure the average number is correct, if the user has not entered a City or motorway number
                        if (item.Motorway != 0)
                        {
                            averageCounterMotorway++;
                        }
                        if (item.City != 0)
                        {
                            averageCounterCity++;
                        }
                        NumberOfReports++;
                    }

                    // Calculate the average
                    AverageOfAverage /= NumberOfReports;

                    //Dont divide by 0
                    if (AverageOfMotorway != 0)
                    {
                        AverageOfMotorway /= averageCounterMotorway;
                    }
                    if (AverageOfCity != 0)
                    {
                        AverageOfCity /= averageCounterCity;
                    }

                    //Modify object and save to database
                    getSummary.Reported_Average = Math.Round(AverageOfAverage, 2);
                    getSummary.Reported_City = Math.Round(AverageOfCity, 2);
                    getSummary.Reported_Motorway = Math.Round(AverageOfMotorway, 2);
                    getSummary.Amount_Of_Reports = NumberOfReports;
                    _RangeMatecontext.SaveChanges();

                    return Ok("Report added");
                }
            }
            catch (Exception)
            {
                return Ok("Could Not Connect To Database");
            }

        }

        // Update report for ICE
        [HttpPost("UpdateReport/ICE", Name = "UpdateICEReport")]
        public IActionResult UpdateICEReport([FromBody] EconomyReportICE EcoReport)
        {
            double EconomyNumbers = 0; // To Save Economy numbers for later use

            // Check if the recived model is valid
            if (!ModelState.IsValid)
            {
                return Ok("Model State Invalid");
            }

            try
            {
                // Get Engine information
                var EngineInformation = _RangeMatecontext.Engine.FirstOrDefault(x => x.Id == EcoReport.EngineId);

                /*
                This checks if the report is unrealistic.
                e.g if the number sways too much from the official number,
                the report is considered unrealistical.
                */
                // Use WLTP numbers if available
                if (EngineInformation.WLTP != 0)
                {
                    EconomyNumbers = EngineInformation.WLTP;
                }
                else
                {
                    EconomyNumbers = EngineInformation.NEDC;
                }

                // Check if numbers are considered realistic
                if (EcoReport.Average > EconomyNumbers * 1.50 ||
                    EcoReport.Average < EconomyNumbers * 0.50)
                {
                    return Ok("The Average km/l is considered unrealistic");
                }

                if (EcoReport.Motorway > EconomyNumbers * 1.50 ||
                    EcoReport.Motorway < EconomyNumbers * 0.50)
                {
                    return Ok("The Motorway km/l considered unrealistic");
                }

                if (EcoReport.City > EconomyNumbers * 1.50 ||
                    EcoReport.City < EconomyNumbers * 0.50)
                {
                    return Ok("The City km/l considered unrealistic");
                }

                // Update old report
                _RangeMatecontext.EconomyReportICE.Update(EcoReport);
                _RangeMatecontext.SaveChanges();

                // Update summary table
                var getSummary = _RangeMatecontext.EconomySummaryICEs.FirstOrDefault(x => x.EngineId == EcoReport.EngineId);
                // Check if first summary
                if (getSummary == null)
                {

                    // Create report
                    EconomySummaryICE CreateSummary = new EconomySummaryICE
                    {
                        EngineId = EcoReport.EngineId,
                        Reported_Motorway = EcoReport.Motorway,
                        Reported_City = EcoReport.City,
                        Reported_Average = EcoReport.Average,
                        Amount_Of_Reports = 1,
                        Manufacturer_Average = EconomyNumbers
                    };

                    _RangeMatecontext.EconomySummaryICEs.Add(CreateSummary);
                    _RangeMatecontext.SaveChanges();
                    return Ok("First Report");
                }
                else
                {
                    // update report
                    List<EconomyReportICE> GetAllReports = _RangeMatecontext.EconomyReportICE.Where(x => x.EngineId == EcoReport.EngineId).ToList();
                    double AverageOfAverage = 0;
                    double AverageOfMotorway = 0;
                    double AverageOfCity = 0;

                    int averageCounterMotorway = 0;
                    int averageCounterCity = 0;

                    var NumberOfReports = 0;

                    // Go through all reports
                    foreach (var item in GetAllReports)
                    {
                        AverageOfAverage += item.Average;
                        AverageOfMotorway += item.Motorway;
                        AverageOfCity += item.City;

                        // Make sure the average number is correct, if the user has not entered a City or motorway number
                        if (item.Motorway != 0)
                        {
                            averageCounterMotorway++;
                        }
                        if (item.City != 0)
                        {
                            averageCounterCity++;
                        }
                        NumberOfReports++;
                    }

                    // Calculate the average
                    AverageOfAverage /= NumberOfReports;

                    //Dont divide by 0
                    if (AverageOfMotorway != 0)
                    {
                        AverageOfMotorway /= averageCounterMotorway;
                    }
                    if (AverageOfCity != 0)
                    {
                        AverageOfCity /= averageCounterCity;
                    }

                    //Modify object and save to database
                    getSummary.Reported_Average = Math.Round(AverageOfAverage, 2);
                    getSummary.Reported_City = Math.Round(AverageOfCity, 2);
                    getSummary.Reported_Motorway = Math.Round(AverageOfMotorway, 2);
                    getSummary.Amount_Of_Reports = NumberOfReports;
                    _RangeMatecontext.SaveChanges();

                    return Ok("ICE Report Updated");
                }
            }
            catch (Exception)
            {
                return Ok("Could Not Connect To Database");
            }
        }

        /////////////////////////// END OF ICE SECTION //////////////////////////////////


        /////////////////////////// ELECTRIC SECTION //////////////////////////////////
        // Get summary for Electric
        [HttpGet("GetEcoSummaryElectric/{EngineID}", Name = "GetEcoSummaryElectric")]
        public IActionResult GetEcoSummaryElectric([FromRoute] int EngineID)
        {
            try
            {
                var GetSummary = _RangeMatecontext.EconomySummaryElectrics.FirstOrDefault(x => x.EngineId == EngineID);
                return Ok(GetSummary);
            }
            catch (Exception)
            {
                return Ok("Could Not Connect To Database");
            }
        }

        // Get list of all electric reports, given engine ID
        [HttpGet("GetEcoListElectric/{EngineID}", Name = "GetEcoListElectric")]
        public IActionResult GetEcoListElectric([FromRoute] int EngineID)
        {
            try
            {
                var AllElectric = _RangeMatecontext.EconomyReportElectric.Where(x => x.EngineId == EngineID);
                return Ok(AllElectric.OrderBy(x => x.UserID));
            }
            catch (Exception)
            {
                // if database connection fails return error
                return Ok("Could Not Connect To Database");
            }
        }

        //Create report for eletric
        [HttpPost("CreateReport/Electric", Name = "CreateElectricReport")]
        public IActionResult CreateElectricReport([FromBody] EconomyReportElectric EcoReport)
        {
            // Check if the recived model is valid
            if (!ModelState.IsValid)
            {
                return Ok("Model State Invalid");
            }

            if (!_RangeMatecontext.Engine.Any(EngineID => EngineID.Id == EcoReport.EngineId))
            {
                return Ok("Engine ID does not exists.");
            }

            try
            {
                // Get Engine information
                var EngineInformation = _RangeMatecontext.Engine.FirstOrDefault(x => x.Id == EcoReport.EngineId);

                /*
                    This checks if the report is unrealistic.
                e.g if the number sways too much from the official number,
                the report is considered unrealistical.
                    */
                if (EcoReport.Full_Range > EngineInformation.WLTP * 2 ||
                    EcoReport.Full_Range < EngineInformation.WLTP * 0.50)
                {
                    return Ok("Number is considered unrealistic");
                }

                // Save new report
                _RangeMatecontext.EconomyReportElectric.Add(EcoReport);
                _RangeMatecontext.SaveChanges();

                // Update summary table
                var getSummary = _RangeMatecontext.EconomySummaryElectrics.FirstOrDefault(x => x.EngineId == EcoReport.EngineId);
                // First check if first summary
                if (getSummary == null)
                {

                    // Create report
                    EconomySummaryElectric CreateSummary = new EconomySummaryElectric
                    {
                        EngineId = EcoReport.EngineId,
                        Manufacturer_Full_Range = EngineInformation.WLTP,
                        Reported_Full_Range = EcoReport.Full_Range,
                        Manufacturer_Watt_Hours_Per_100Km = Math.Round(((Convert.ToDouble(EngineInformation.Size) / Convert.ToDouble(EngineInformation.WLTP)) * 100), 2),
                        Reported_Watt_Hours_Per_100Km = Math.Round(((Convert.ToDouble(EngineInformation.Size) / Convert.ToDouble(EcoReport.Full_Range)) * 100), 2),
                        Amount_Of_Reports = 1
                    };

                    _RangeMatecontext.EconomySummaryElectrics.Add(CreateSummary);
                    _RangeMatecontext.SaveChanges();
                    return Ok("First Report");
                }
                else
                {
                    // update report
                    List<EconomyReportElectric> GetAllReports = _RangeMatecontext.EconomyReportElectric.Where(x => x.EngineId == EcoReport.EngineId && x.Is_Active).ToList();

                    double AverageOfFullRange = 0;
                    var NumberOfReports = 0;

                    // Go through all reports
                    foreach (var item in GetAllReports)
                    {
                        AverageOfFullRange += item.Full_Range;
                        NumberOfReports++;
                    }

                    // Calculate the average
                    AverageOfFullRange /= NumberOfReports;

                    //Modify object and save to database
                    getSummary.Reported_Full_Range = Math.Round(AverageOfFullRange, 2);
                    getSummary.Reported_Watt_Hours_Per_100Km = Math.Round(((Convert.ToDouble(EngineInformation.Size) / Convert.ToDouble(AverageOfFullRange)) * 100), 2);
                    getSummary.Amount_Of_Reports = NumberOfReports;
                    _RangeMatecontext.SaveChanges();
                    return Ok("Report added");
                }
            }
            catch (Exception)
            {
                return Ok("Could Not Connect To Database");
            }
        }

        //Update report for eletric
        [HttpPost("UpdateReport/Electric", Name = "UpdateElectricReport")]
        public IActionResult UpdateElectricReport([FromBody] EconomyReportElectric EcoReport)
        {
            // Check if the recived model is valid
            if (!ModelState.IsValid)
            {
                return Ok("Model State Invalid");
            }

            try
            {
                // Get Engine information
                var EngineInformation = _RangeMatecontext.Engine.FirstOrDefault(x => x.Id == EcoReport.EngineId);

                /*
                    This checks if the report is unrealistic.
                e.g if the number sways too much from the official number,
                the report is considered unrealistical.
                    */
                if (EcoReport.Full_Range > EngineInformation.WLTP * 2 ||
                    EcoReport.Full_Range < EngineInformation.WLTP * 0.50)
                {
                    return Ok("Number is considered unrealistic");
                }

                // Save new report
                _RangeMatecontext.EconomyReportElectric.Update(EcoReport);
                _RangeMatecontext.SaveChanges();

                // Update summary table
                var getSummary = _RangeMatecontext.EconomySummaryElectrics.FirstOrDefault(x => x.EngineId == EcoReport.EngineId);
                // First check if first summary
                if (getSummary == null)
                {

                    // Create report
                    EconomySummaryElectric CreateSummary = new EconomySummaryElectric
                    {
                        EngineId = EcoReport.EngineId,
                        Manufacturer_Full_Range = EngineInformation.WLTP,
                        Reported_Full_Range = EcoReport.Full_Range,
                        Manufacturer_Watt_Hours_Per_100Km = Math.Round(((Convert.ToDouble(EngineInformation.Size) / Convert.ToDouble(EngineInformation.WLTP)) * 100), 2),
                        Reported_Watt_Hours_Per_100Km = Math.Round(((Convert.ToDouble(EngineInformation.Size) / Convert.ToDouble(EcoReport.Full_Range)) * 100), 2),
                        Amount_Of_Reports = 1
                    };

                    _RangeMatecontext.EconomySummaryElectrics.Add(CreateSummary);
                    _RangeMatecontext.SaveChanges();
                    return Ok("First Report");
                }
                else
                {
                    // update report
                    List<EconomyReportElectric> GetAllReports = _RangeMatecontext.EconomyReportElectric.Where(x => x.EngineId == EcoReport.EngineId && x.Is_Active).ToList();

                    double AverageOfFullRange = 0;
                    var NumberOfReports = 0;

                    // Go through all reports
                    foreach (var item in GetAllReports)
                    {
                        AverageOfFullRange += item.Full_Range;
                        NumberOfReports++;
                    }

                    // Calculate the average
                    AverageOfFullRange /= NumberOfReports;

                    //Modify object and save to database
                    getSummary.Reported_Full_Range = Math.Round(AverageOfFullRange, 2);
                    getSummary.Reported_Watt_Hours_Per_100Km = Math.Round(((Convert.ToDouble(EngineInformation.Size) / Convert.ToDouble(AverageOfFullRange)) * 100), 2);
                    getSummary.Amount_Of_Reports = NumberOfReports;
                    _RangeMatecontext.SaveChanges();
                    return Ok("Electric Report Updated");
                }
            }
            catch (Exception)
            {
                return Ok("Could Not Connect To Database");
            }
        }
        /////////////////////////// END OF ELECTRIC SECTION //////////////////////////////////

        // Get Car Information
        [HttpGet("GetCarInformation/{EngineID}", Name = "GetCarInformation")]
        public IActionResult GetCarInformation([FromRoute] int EngineID)
        {
            try
            {
                CarInfoObject CarInfo = (CarInfoObject)
                    (from x in _RangeMatecontext.Engine
                     join y in _RangeMatecontext.Models on x.ModelId equals y.Id
                     where x.ModelId == y.Id
                     join z in _RangeMatecontext.Manufacturer on y.ManufacturerId equals z.Id
                     where EngineID == x.Id
                     where x.ModelId == y.Id
                     where y.ManufacturerId == z.Id
                     select new CarInfoObject
                     {
                         ManufacturerName = z.Name,
                         ModelName = y.ModelName,
                         EngineName = x.Type + " " + x.Size,
                         ManufacturerID = y.ManufacturerId,
                         ModelID = y.Id
                     }).FirstOrDefault();

                return Ok(CarInfo);
            }
            catch (Exception)
            {
                return Ok("Could Not Connect To Database");
            }
        }
    }
}
