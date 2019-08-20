using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ML.Models
{

    public class CreditCardData
    {
        [LoadColumn(1)]
        public float LIMIT_BAL;
        [LoadColumn(2)]
        public float SEX;
        [LoadColumn(3)]
        public float EDUCATION;
        [LoadColumn(4)]
        public float MARRIAGE;

        [LoadColumn(5)]
        public float AGE;

        [LoadColumn(6, 12)]
        [VectorType(7)]
        public float[] Payments;

        [LoadColumn(12,17)]
        [VectorType(6)]
        public float[] BILL_AMT1;

        [LoadColumn(18,23)]
        public float[] PAY_AMT1;

        [LoadColumn(24), ColumnName("Label")]
        public bool isDefault;
    }

    public class CreditCardPrediction : CreditCardData
    {

        [ColumnName("PredictedLabel")]
        public bool Prediction { get; set; }

        //public float Probability { get; set; }

        //public float Score { get; set; }
    }
}
