using System;
using System.Collections.Generic;
using System.Text.Json;

public class ComputerApplication
{
    public string Name { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }
    public string PAN { get; set; }
}
public class ValidationError
{
    public int RecordIdx { get; set; }
    public List<string> Messages { get; set; } =new List<string>();
}
public class ValidationReport
{
    public int TotalRecords { get; set; }
    public int ValidRecords { get; set; }
    public int InvalidRecords { get; set; }
    public List<ValidationError> Errors { get; set; } = new List<ValidationError>();
}
public class BatchValidator
{
    public static ValidationReport ValidateBatch(List<string> jsonPayloads)
    {
        ValidationReport report = new ValidationReport();
        report.TotalRecords = jsonPayloads.Count;
        for(int i=0;i<jsonPayloads.Count;i++)
        {
            ValidationError error = new ValidationError ();
            error.RecordIdx = i;
            try
            {
                ComputerApplication app = JsonSerializer.Deserialize<ComputerApplication>(jsonPayloads[i]);
                if (string.IsNullOrEmpty(app.Name))
                    error.Messages.Add("Name is required.");
                if (string.IsNullOrEmpty(app.Email) || !app.Email.Contains("@"))
                    error.Messages.Add("Valid Email is required.");
                if (app.Age < 18 || app.Age > 60)
                    error.Messages.Add("Age must be between 18 and 60.");
                if (string.IsNullOrEmpty(app.PAN) || app.PAN.Length != 10)
                    error.Messages.Add("Valid PAN is required.");
            }
            catch (Exception ex)
            {
                error.Messages.Add("Invalid JSON format: " + ex.Message);
            }
            if (error.Messages.Count > 0)
                report.Errors.Add(error);
        }
        report.InvalidRecords = report.Errors.Count;
        report.ValidRecords = report.TotalRecords - report.InvalidRecords;
        return report;
    }
}
class Program
{
    static void Main()
    {
        List<string> jsonBatch = new List<string>
        {
            "{\"Name\":\"John Doe\",\"Email\":\"johndoe@gmail.com\",\"Age\":30,\"PAN\":\"ABCDE1234F\"}",
            "{\"Name\":\"Jane Smith\",\"Email\":\"janesmith@gmail\",\"Age\":25,\"PAN\":\"123\"}",
            "{\"Name\":\"\",\"Email\":\"invalidemail\",\"Age\":17,\"PAN\":\"ABCDE1234F\"}",
            "{\"Name\":\"Suryansh shukla\",\"Email\":\"ssuryansh678@gmail.com\",\"Age\":24,\"PAN\":\"OEFPS5690R\"}"
        };
        ValidationReport report = BatchValidator.ValidateBatch(jsonBatch);
        Console.WriteLine($"Total Records: {report.TotalRecords}");
        Console.WriteLine($"Valid Records: {report.ValidRecords}");
        Console.WriteLine($"Invalid Records: {report.InvalidRecords}");
        foreach (var error in report.Errors)
        {
            Console.WriteLine($"Record {error.RecordIdx}: {string.Join(", ", error.Messages)}");
        }
    }
}