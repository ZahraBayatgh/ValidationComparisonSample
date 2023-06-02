using BenchmarkDotNet.Attributes;
using System.ComponentModel.DataAnnotations;
using ValidationComparisonSample.Data;

public class ValidationBenchmark
{
    private readonly Form _form1;
    private readonly Form2 _form2;

    public ValidationBenchmark()
    {
        _form1 = new Form
        {
            Email = "example@example.com"
        };

        _form2 = new Form2
        {
            Email = "example@example.com"
        };
    }


    [Benchmark]
    public void DataAnnotationsValidation()
    {
        for (int i = 0; i < 10; i++)
        {
            Validator.ValidateObject(_form1, new ValidationContext(_form1), true);

        }

    }

    [Benchmark]
    public void FluentValidationValidation()
    {
        for (int i = 0; i < 10; i++)
        {
            var validator = new FormValidator();

            validator.Validate(_form2);
        }
    }
}