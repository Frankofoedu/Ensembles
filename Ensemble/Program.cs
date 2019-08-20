using Microsoft.ML;
using Microsoft.ML.Transforms;
using ML.Models;
using System;
using System.Linq;

namespace Ensemble
{
    class Program
    {

        //Create MLContext
        static readonly MLContext mlContext = new MLContext();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LoadData(mlContext);

            Console.Read();
        }

        private static void LoadData(MLContext mLContext)
        {

            //Load Data
            IDataView data = mLContext.Data.LoadFromTextFile<CreditCardData>("Data/creditcard.csv", separatorChar: ',', hasHeader: true);

            //drop the id column 

           var pipeline = mLContext.Transforms.DropColumns("Id");

            
            
        }

        NormalizingTransformer StandardizeData(IDataView data)
        {
            // Define min-max estimator
            var minMaxEstimator = mlContext.Transforms.norma("Price");

            // Fit data to estimator
            // Fitting generates a transformer that applies the operations of defined by estimator
            return minMaxEstimator.Fit(data);
        }
    }
}
