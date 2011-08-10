using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;

namespace FinanceAI.AI
{
    // Classes for the tables used by the database
    [Table( Name = "Companies" )]
    public class Company : ISample
    {
        // identifier of the company
        private int id;

        [Column( IsPrimaryKey = true, Name = "Company_ID" )]
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                this.id = value;
            }
        }

        // Official name of the company
        private string name;

        [Column( Name = "Name" )]
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }

        // Ticker of the company stock
        private string ticker;

        [Column( Name = "Ticker" )]
        public string Ticker
        {
            get
            {
                return ticker;
            }
            set
            {
                this.ticker = value;
            }
        }

        // Number of employees of the company
        private int employees;

        [Column( Name = "Number_Of_Employees" )]
        public int Employees
        {
            get
            {
                return employees;
            }
            set
            {
                this.employees = value;
                featureVector.Insert( employeesFeatureIndex, value );
            }
        }

        // Implementation of the ISample interface
        
        // TODO: Decide the correct indexing scheme
        // Index of the features
        private int employeesFeatureIndex = 0;

        // private feature vector, for caching
        private List<Double> featureVector = new List<Double>( );

        // Description is TICKER (Name)
        public String Description
        {
            get
            {
                return Ticker + " (" + Name + ")";
            }
        }

        // Return the feature vector
        public List<Double> FeatureVector
        {
            get
            {
                return featureVector;
            }
        }

        // TODO: No categories for now
        public String Category
        {
            get
            {
                return "";
            }
        }

        // TODO: No confidences for now
        public Double Confidence
        {
            get
            {
                return 1;
            }
        }

        // TODO: No categories, consequently no labels
        public Boolean IsLabeled( )
        {
            return false;
        }
    }

    class DataBaseCompanyExtractor : IExtractor
    {
        // Connection with the database
        DataContext dataSource;
        
        // Data extracted from the database
        private ClassificationData data = new ClassificationData( );

        public ClassificationData Data
        {
            get
            {
                return data;
            }
        }

        // Initialize the connection with the database
        public void Initialize( string source )
        {
            // TODO: Add checks in the source string

            dataSource = new DataContext( source );
        }

        // Extract the features from the database
        public void Extract( string criteria )
        {
            // Get the table of companies
            Table<Company> companies = dataSource.GetTable<Company>( );
            
            // TODO: Apply selection criteria
            // all the data instances
            IQueryable<Company> allCompaniesQuery = 
                from company in companies select company;

            // copy the data to the list of training cases
            foreach (Company company in allCompaniesQuery)
            {
                data.Samples.Add( company );
            }

            // Close the connection
            dataSource.Dispose( );
        }
    }
}
