using CodeFirstData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstData.DAL
{
    public class DatamodelInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var datamodels = new List<Datamodel>
            {
                new Datamodel{ExampleFirstName="Example", ExampleLastName="Student"},
                new Datamodel{ExampleFirstName="Test", ExampleLastName="Material"},
                new Datamodel{ExampleFirstName="Last", ExampleLastName="One"}
            };
            datamodels.ForEach(d => context.Datamodels.Add(d));
            context.SaveChanges();
        }
    }
}