using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace vMixMonitor.Helpers
{
    public class vMixSchema
    {
        public XmlSchema schema
        {
            get; set;
        }


        public vMixSchema()
        {
            BuildSchema();
        }

        private void BuildSchema()
        {
            //XmlSchema schema = new XmlSchema();

            //// <xs:element name="cat" type="xs:string"/>
            //XmlSchemaElement e1 = new XmlSchemaElement();
            //schema.Items.Add(e1);
            //e1.Name = "version";
            //e1.SchemaTypeName = new XmlQualifiedName("string", "http://www.w3.org/2001/XMLSchema");

            //// <xs:element name="dog" type="xs:string"/>
            //XmlSchemaElement e2 = new XmlSchemaElement();
            //schema.Items.Add(e2);
            //e2.Name = "edition";
            //e2.SchemaTypeName = new XmlQualifiedName("string", "http://www.w3.org/2001/XMLSchema");

            //// <xs:element name="redDog" substitutionGroup="dog" />
            //XmlSchemaElement e3 = new XmlSchemaElement();
            //schema.Items.Add(e3);
            //e3.Name = "preset";
            //e3.SchemaTypeName = new XmlQualifiedName("string", "http://www.w3.org/2001/XMLSchema");
                       

            //// <xs:element name="pets">
            //XmlSchemaElement eInputs = new XmlSchemaElement();
            //schema.Items.Add(eInputs);
            //eInputs.Name = "inputs";

            //// <xs:complexType>
            //XmlSchemaComplexType complexType = new XmlSchemaComplexType();
            //eInputs.SchemaType = complexType;

            //// <xs:choice minOccurs="0" maxOccurs="unbounded">
            //XmlSchemaChoice choice = new XmlSchemaChoice();
            //complexType.Particle = choice;
            //choice.MinOccurs = 0;
            //choice.MaxOccursString = "unbounded";

            //// <xs:element ref="cat"/>
            //XmlSchemaElement catRef = new XmlSchemaElement();
            //choice.Items.Add(catRef);
            //catRef.RefName = new XmlQualifiedName("cat");

            //// <xs:element ref="dog"/>
            //XmlSchemaElement dogRef = new XmlSchemaElement();
            //choice.Items.Add(dogRef);
            //dogRef.RefName = new XmlQualifiedName("dog");

            //XmlSchemaSet schemaSet = new XmlSchemaSet();
            //schemaSet.ValidationEventHandler += new ValidationEventHandler(ValidationCallbackOne);
            //schemaSet.Add(schema);
            //schemaSet.Compile();
            //// <xs:element name="brownDog" substitutionGroup ="dog" />
            //XmlSchemaElement elementBrownDog = new XmlSchemaElement();
            //schema.Items.Add(elementBrownDog);
            //elementBrownDog.Name = "brownDog";
            //elementBrownDog.SubstitutionGroup = new XmlQualifiedName("dog");
            //XmlSchema compiledSchema = null;

            //// <xs:element name="brownDog" substitutionGroup ="dog" />
            //XmlSchemaElement elementBrownDog = new XmlSchemaElement();
            //schema.Items.Add(elementBrownDog);
            //elementBrownDog.Name = "brownDog";
            //elementBrownDog.SubstitutionGroup = new XmlQualifiedName("dog");

            //// <xs:element name="brownDog" substitutionGroup ="dog" />
            //XmlSchemaElement elementBrownDog = new XmlSchemaElement();
            //schema.Items.Add(elementBrownDog);
            //elementBrownDog.Name = "brownDog";
            //elementBrownDog.SubstitutionGroup = new XmlQualifiedName("dog");
            //foreach (XmlSchema schema1 in schemaSet.Schemas()) {
            //    compiledSchema = schema1;
            //}

            //XmlNamespaceManager nsmgr = new XmlNamespaceManager(new NameTable());
            //nsmgr.AddNamespace("xs", "http://www.w3.org/2001/XMLSchema");
            //compiledSchema.Write(Console.Out, nsmgr);
        //}
        }
    }
}
