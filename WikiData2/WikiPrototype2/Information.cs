using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WikiPrototype2
{
    internal class Information : IComparable<Information>
    {
        // 6.1 Create a separate class file to hold the four data items of the Data Structure (use the Data Structure Matrix as a guide).
        // Use private properties for the fields which must be of type “string”. The class file must have separate setters and getters,
        // add an appropriate IComparable for the Name attribute. Save the class as “Information.cs”.

        public string Name;
        public string Definition;
        public string Category;
        public string Structure;

        public Information(string name, string category, string structure, string definition)
        {
            Name = name;
            Category = category;
            Structure = structure;
            Definition = definition;
        }

        public string getName()
        {
            return Name;

        }

        public void setName(string newName)
        {
            Name = newName;
        }

        public string getDefinition()
        {
            return Definition;

        }

        public void setDefinition(string newDefinition)
        {
            Definition = newDefinition;
        }

        public string getCategory()
        {
            return Category;

        }

        public void setCategory(string newCategory)
        {
            Category = newCategory;
        }

        public string getStructure()
        {
            return Structure;
        }

        public void setStructure(string newStructure)
        {
            Structure = newStructure;
        }

        public int CompareTo(Information other)
        {
            return string.Compare(this.Name, other.Name, StringComparison.Ordinal);
        }
    }
}


    

