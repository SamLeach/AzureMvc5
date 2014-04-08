using Azure.Data.Entities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azure.Data.Tests
{
    [TestFixture, Description("Manipulating the database via tests")]
    public class DataTests
    {
        private string connectionString = @"";

        [Test, Description("Inserts a new consultant into the database")]
        public void Can_Insert_Consultant()
        {
            using (var context = new TokiotaModel(connectionString))
            {
                context.Consultants.Add(new Consultant 
                { 
                    Created = DateTime.Now,
                    Name = "Pepe", 
                    Skills = new List<Skill> 
                    { 
                        new Skill{ Name = "C#", Created = DateTime.Now }
                    }, 
                    Projects = new List<Project> 
                    { 
                        new Project
                        { 
                            Name = "SharePoint 2013 Super Project 3000+ Ultra 10,0000",
                            Created = DateTime.Now
                        } 
                    } 
                });

                context.SaveChanges();
            }
        }

        [Test, Description("Reads a new consultant from the database")]
        public void Can_Read_Consultant()
        {
            Consultant expected = new Consultant
            {
                 Name = "Pepe"
            };

            Consultant actual = null;

            using (var context = new TokiotaModel(connectionString))
            {
                var consultants = context.Consultants.SingleOrDefault(x => x.Name == "Pepe");
                actual = consultants;
            }

            Assert.AreEqual(expected.Name, actual.Name);
        }
    }
}
