using CostDashboard.Models;

namespace CostDashboard.Services
{
    public class CostDataService
    {
        // In a real application, this would fetch data from an API or database
        // For demo purposes, we'll generate sample data
        
        public Task<Dictionary<string, decimal>> GetCostDistributionData(Filters filters, DateRange dateRange)
        {
            // Sample data for cost distribution by service
            var data = new Dictionary<string, decimal>
            {
                { "EC2", 4250.75m },
                { "S3", 1825.30m },
                { "RDS", 3150.25m },
                { "Lambda", 950.80m },
                { "CloudFront", 725.50m }
            };
            
            return Task.FromResult(data);
        }
        
        public Task<List<CostData>> GetCostTrendsData(Filters filters, DateRange dateRange)
        {
            // Sample data for cost trends over time
            var startDate = new DateTime(2023, 1, 1);
            var data = new List<CostData>();
            
            for (int i = 0; i < 12; i++)
            {
                var date = startDate.AddMonths(i);
                // Generate some random-ish variation in the data
                var baseAmount = 10000m;
                var randomFactor = 0.8m + (decimal)(new Random(i).NextDouble() * 0.4);
                var seasonalFactor = 1m + (decimal)Math.Sin(i * Math.PI / 6) * 0.2m;
                
                data.Add(new CostData
                {
                    Date = date,
                    Amount = baseAmount * randomFactor * seasonalFactor,
                });
            }
            
            return Task.FromResult(data);
        }
        
        public Task<Dictionary<string, (decimal ThisMonth, decimal LastMonth)>> GetServiceComparisonData(Filters filters, DateRange dateRange)
        {
            // Sample data for service comparison (this month vs last month)
            var data = new Dictionary<string, (decimal ThisMonth, decimal LastMonth)>
            {
                { "EC2", (4250.75m, 4100.50m) },
                { "S3", (1825.30m, 1750.25m) },
                { "RDS", (3150.25m, 3350.75m) },
                { "Lambda", (950.80m, 850.30m) },
                { "CloudFront", (725.50m, 780.20m) }
            };
            
            return Task.FromResult(data);
        }
        
        public Task<List<CostBreakdownItem>> GetCostBreakdownData(Filters filters, DateRange dateRange)
        {
            // Sample data for cost breakdown table
            var data = new List<CostBreakdownItem>
            {
                new CostBreakdownItem 
                { 
                    Service = "EC2", 
                    Region = "us-east-1", 
                    Account = "Production", 
                    Cost = 2150.25m, 
                    Change = 3.5m 
                },
                new CostBreakdownItem 
                { 
                    Service = "EC2", 
                    Region = "us-west-2", 
                    Account = "Development", 
                    Cost = 1250.50m, 
                    Change = 5.2m 
                },
                new CostBreakdownItem 
                { 
                    Service = "S3", 
                    Region = "us-east-1", 
                    Account = "Production", 
                    Cost = 950.75m, 
                    Change = -2.3m 
                },
                new CostBreakdownItem 
                { 
                    Service = "RDS", 
                    Region = "eu-west-1", 
                    Account = "Production", 
                    Cost = 1850.30m, 
                    Change = -5.7m 
                },
                new CostBreakdownItem 
                { 
                    Service = "Lambda", 
                    Region = "us-east-1", 
                    Account = "Development", 
                    Cost = 450.20m, 
                    Change = 12.5m 
                },
                new CostBreakdownItem 
                { 
                    Service = "CloudFront", 
                    Region = "Global", 
                    Account = "Production", 
                    Cost = 725.50m, 
                    Change = -7.0m 
                },
                new CostBreakdownItem 
                { 
                    Service = "S3", 
                    Region = "ap-southeast-1", 
                    Account = "Testing", 
                    Cost = 350.80m, 
                    Change = 1.8m 
                },
                new CostBreakdownItem 
                { 
                    Service = "EC2", 
                    Region = "eu-west-1", 
                    Account = "Staging", 
                    Cost = 850.00m, 
                    Change = -3.2m 
                },
                new CostBreakdownItem 
                { 
                    Service = "RDS", 
                    Region = "us-west-2", 
                    Account = "Development", 
                    Cost = 1300.45m, 
                    Change = 4.3m 
                },
                new CostBreakdownItem 
                { 
                    Service = "Lambda", 
                    Region = "eu-west-1", 
                    Account = "Testing", 
                    Cost = 500.60m, 
                    Change = -1.5m 
                }
            };
            
            return Task.FromResult(data);
        }
    }
}