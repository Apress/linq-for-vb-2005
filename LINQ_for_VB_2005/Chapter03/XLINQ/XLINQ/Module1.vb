Imports System.Xml

Module Module1

    Sub Main()
        ' Listing3_2()

        ' Listing3_3()

        ' Listing3_4()

        ' Listing3_5()

        ' Listing3_6()

        ' Listing3_7()

        ' Listing3_9()

        ' Listing3_10()

        ' Listing3_11()

        ' Listing3_12()

        ' Listing3_13()

        ' Listing3_14()

        ' Listing3_15()

        ' Listing3_16()

        ' Listing3_17()

        ' Listing3_18()

        ' Listing3_19()

        ' Listing3_20()

        ' Listing3_21()

        ' Listing3_22()

        ' Listing3_23()

        ' Listing3_24()

        ' Listing3_25()

        ' Listing3_26()

        ' Listing3_27()

    End Sub

#Region "Listing 3-2"
    Sub Listing3_2()
        Dim xml As XDocument = XDocument.Load("..\..\People.xml")

        Dim query = From p In xml.Elements("people").Elements("person") _
            Where p.Element("id").Value = 1 _
            Select p

        For Each Dim record In query
            Console.WriteLine("Person: {0} {1}", _
               record.Element("firstname").Value, _
               record.Element("lastname").Value)
        Next


    End Sub
#End Region

#Region "Listing 3-3"
    Sub Listing3_3()
        Dim xml As XElement = XElement.Load("..\..\People.xml")

        Dim query = From p In xml.Elements("person") _
            Where p.Element("id").value = 1 _
            Select p

        For Each Dim record In query
            Console.WriteLine("Person: {0} {1}", _
                                record.Element("firstname"), _
                                record.Element("lastname"))
        Next
    End Sub
#End Region

#Region "Listing 3-4"
    Sub Listing3_4()
        Dim xml As XElement = XElement.Load("..\..\People.xml")

        Dim query = From s In xml.Elements("salary").Elements("idperson") _
            Where s.Attribute("year").Value = 2004 _
            Select s

        For Each Dim record In query
            Console.WriteLine("Amount: {0}", record.Attribute("salaryyear"))
        Next
    End Sub
#End Region

#Region "Listing 3-5"
    Sub Listing3_5()
        Dim xml As XElement = XElement.Load("..\..\People.xml")

        Dim query = From p In xml.Descendants("person"), s In xml.Descendants("idperson") _
            Where p.Element("id").Value = s.Attribute("id").Value _
            Select New {FirstName := p.Element("firstname").Value, _
                                LastName := p.Element("lastname").Value, _
                                Amount := s.Attribute("salaryyear").Value}

        For Each Dim record In query
            Console.WriteLine("Person: {0} {1}, Salary {2}", record.FirstName, _
                                                            record.LastName, _
                                                            record.Amount)
        Next
    End Sub
#End Region

#Region "Listing 3-6"
    Sub Listing3_6()
        Dim xml As XElement = XElement.Load("..\..\People.xml")

        Dim record = xml.Descendants("firstname").First()
        For Each Dim tag In record.Ancestors()
            Console.WriteLine(tag.Name)
        Next
    End Sub
#End Region

#Region "Listing 3-7"
    Sub Listing3_7()
        Dim xml As XElement = XElement.Load("..\..\People.xml")

        Dim record As IEnumerable(Of XComment) = xml.Nodes().OfType(Of XComment)()
        For Each comment As XComment In record
            Console.WriteLine(comment)
        Next
    End Sub
#End Region

#Region "Listing 3-9"
    Sub Listing3_9()
        Dim xml As XElement = XElement.Load("..\..\Hello_XLINQ.xml")
        Dim o As XNamespace = "urn:schemas-microsoft-com:office:office"

        Dim query = From w In xml.Descendants(o + "Author") _
            Select w

        For Each Dim record In query
            Console.WriteLine("Author: {0}", record.Value)
        Next
    End Sub
#End Region

#Region "Listing 3-10"
    Sub Listing3_10()
        Dim xml As XElement = XElement.Load("..\..\Hello_XLINQ.xml")
        Dim w As XNamespace = "http://schemas.microsoft.com/office/word/2003/wordml"

        Dim defaultFonts As XElement = xml.Descendants(w + "defaultFonts").First()
        Console.WriteLine("Default Fonts: {0}", _
            defaultFonts.Attribute(w + "ascii").Value)

    End Sub
#End Region

#Region "Listing 3-11"
    Sub Listing3_11()
        Dim xml As XElement = XElement.Load("..\..\People.xml")

        Dim firstName As XElement = xml.Descendants("firstname").First()

        Console.WriteLine("Before <firstname>")
        For Each Dim tag In firstName.ElementsBeforeThis()
            Console.WriteLine(tag.Name)
        Next

        Console.WriteLine("")
        Console.WriteLine("After <firstname>")
        For Each Dim tag In firstName.ElementsAfterThis()
            Console.WriteLine(tag.Name)
        Next
    End Sub
#End Region

#Region "Listing 3-12"
    Sub Listing3_12()
        Dim xml As XElement = XElement.Load("..\..\People.xml")

        Dim firstName As XElement = xml.Descendants("firstname").First()

        Console.WriteLine(firstName.Parent)
    End Sub
#End Region

#Region "Listing 3-13"
    Sub Listing3_13()
        Dim xml As XElement = XElement.Load("..\..\People.xml")

        Dim firstName As XElement = xml.Descendants("firstname").First()

        Console.WriteLine("FirstName tag has attributes: {0}", _
            firstName.HasAttributes)
        Console.WriteLine("FirstName tag has child elements: {0}", _
            firstName.HasElements)
        Console.WriteLine("FirstName tag's parent has attributes: {0}", _
            firstName.Parent.HasAttributes)
        Console.WriteLine("FirstName tag's parent has child elements: {0}", _
            firstName.Parent.HasElements)
    End Sub
#End Region

#Region "Listing 3-14"
    Sub Listing3_14()
        Dim xml As XElement = XElement.Load("..\..\People.xml")

        Dim firstName As XElement = xml.Descendants("firstname").First()

        Console.WriteLine("Is FirstName tag empty? {0}", IIf(firstName.IsEmpty, "Yes", "No"))

        Dim idPerson As XElement = xml.Descendants("idperson").First()

        Console.WriteLine("Is idperson tag empty? {0}", IIf(idPerson.IsEmpty, "Yes", "No"))

    End Sub
#End Region

#Region "Listing 3-15"
    Sub Listing3_15()
        Dim xml As XDocument = XDocument.Load("..\..\Hello_XLINQ.xml")

        Console.WriteLine("Encoding: {0}", xml.Declaration.Encoding)
        Console.WriteLine("Version: {0}", xml.Declaration.Version)
        Console.WriteLine("Standalone: {0}", xml.Declaration.Standalone)

    End Sub
#End Region

#Region "Listing 3-16"
    Sub Listing3_16()
        Dim xml As New XDocument(New XDeclaration("1.0", "UTF-8", "yes"), _
                    New XElement("people", _
                    New XElement("idperson", _
                    New XAttribute("id", 1), _
                    New XAttribute("year", 2004), _
                    New XAttribute("salaryyear", "10000,0000"))))

        Dim sw As New System.IO.StringWriter()
        xml.Save(sw)
        Console.WriteLine(sw)

    End Sub
#End Region

#Region "Listing 3-17"
    Sub Listing3_17()
        Dim w As XNamespace = "http://schemas.microsoft.com/office/word/2003/wordml"

        Dim word As New XDocument(New XDeclaration("1.0", "utf-8", "yes"), _
                             New XProcessingInstruction("mso-application", _
                                 "progid=""Word.Document"""), _
                             New XElement(w + "wordDocument", _
                                 New XAttribute(XNamespace.Xmlns + "w", _
                                   w.Uri)))

        Dim sw As New System.IO.StringWriter()
        word.Save(sw)

        Console.WriteLine(sw)

    End Sub
#End Region

#Region "Listing 3-18"
    Sub Listing3_18()
        Dim xml As XElement = XElement.Load("..\..\People.xml")

        Dim html As New XElement("HTML", _
                                New XElement("BODY", _
                                    New XElement("TABLE", _
                                        New XElement("TH", "ID"), _
                                        New XElement("TH", "Full Name"), _
                                        New XElement("TH", "Role"), _
            From p In xml.Descendants("person"), r In xml.Descendants("role") _
            Where p.Element("idrole").Value = r.Element("id").Value _
            Select New XElement("TR", _
                                        New XElement("TD", p.Element("id").Value), _
                                        New XElement("TD", p.Element("firstname").Value _
                                        & " " & p.Element("lastname").Value), _
                                        New XElement("TD", r.Element("roledescription").Value)))))

        html.Save("C:\People.html")

    End Sub
#End Region

#Region "Listing 3-19"
    Sub Listing3_19()
        Dim doc As String = "<people>" & _
                     "<!-- Person section -->" & _
                         "<person>" & _
                          "<id>1</id>" & _
                          "<firstname>Carl</firstname>" & _
                          "<lastname>Lewis</lastname>" & _
                          "<idrole>1</idrole>" & _
                         "</person>" & _
                           "</people>"
        Dim xml As XElement = XElement.Parse(doc)
        Console.WriteLine(xml)

    End Sub
#End Region

#Region "Listing 3-20"
    Sub Listing3_20()
        Dim reader As XmlReader = XmlReader.Create("..\..\People.xml")
        Dim xml As XDocument = XDocument.Load(reader)
        Console.WriteLine(xml)

        Dim idperson As XElement = xml.Descendants("idperson").Last()
        idperson.Add(New XElement("idperson", _
                        New XAttribute("id", 1), _
                        New XAttribute("year", 2006), _
                        New XAttribute("salaryyear", "160000,0000")))

        Dim sw As New IO.StringWriter()
        Dim w As XmlWriter = XmlWriter.Create(sw)
        xml.Save(w)
        w.Close()
        Console.WriteLine(sw.ToString())

    End Sub
#End Region

#Region "Listing 3-21"
    Sub Listing3_21()
        Dim xml As XElement = XElement.Load("..\..\People.xml")

        xml.AddFirst(New XElement("person", _
                        New XElement("id", 5), _
                        New XElement("firstname", "Tom"), _
                        New XElement("lastname", "Cruise"), _
                        New XElement("idrole", 1)))

        Console.WriteLine(xml)

    End Sub
#End Region

#Region "Listing 3-22"
    Sub Listing3_22()
        Dim xml As XElement = XElement.Load("..\..\People.xml")

        Dim role As XElement = xml.Descendants("role").First()
        Console.WriteLine("-=-=ORIGINAL-=-=")
        Console.WriteLine(role)

        role.SetElement("roledescription", "Actor")
        Console.WriteLine(String.Empty)
        Console.WriteLine("-=-=UPDATED-=-=")
        Console.WriteLine(role)

    End Sub
#End Region

#Region "Listing 3-23"
    Sub Listing3_23()
        Dim xml As XElement = XElement.Load("..\..\People.xml")

        Dim role As XElement = xml.Descendants("idperson").First()
        Console.WriteLine("-=-=ORIGINAL-=-=")
        Console.WriteLine(role)

        role.SetAttribute("year", "2006")
        Console.WriteLine(String.Empty)
        Console.WriteLine("-=-=UPDATED-=-=")
        Console.WriteLine(role)

    End Sub
#End Region

#Region "Listing 3-24"
    Sub Listing3_24()
        Dim xml As XElement = XElement.Load("..\..\People.xml")

        xml.Element("person").ReplaceContent(New XElement("id", 5), _
                                             New XElement("firstname", "Tom"), _
                                             New XElement("lastname", "Cruise"), _
                                             New XElement("idrole", 1))
        Console.WriteLine(xml)

    End Sub
#End Region

#Region "Listing 3-25"
    Sub Listing3_25()
        Dim xml As XElement = XElement.Load("..\..\People.xml")

        xml.Descendants("idperson").First().Remove()

        xml.Elements("role").Remove()

        Console.WriteLine(xml)
    End Sub
#End Region

#Region "Listing 3-26"
    Sub Listing3_26()
        Dim xml As XElement = XElement.Load("..\..\People.xml")

        xml.Element("role").RemoveContent()

        Console.WriteLine(xml)
    End Sub
#End Region

#Region "Listing 3-27"
    Sub Listing3_27()
        Dim people As New PeopleDataContext()

        Dim xml As New XElement("people", _
                           From p In people.People _
            Select New XElement("person", _
                           New XElement("id", p.ID), _
                           New XElement("firstname", p.FirstName), _
                           New XElement("lastname", p.LastName), _
                           New XElement("idrole", p.IDRole)))
        Console.WriteLine(xml)

        Listing3_28(xml, people)
    End Sub
#End Region

#Region "Listing 3-28"
    Sub Listing3_28(ByVal xml As XElement, ByVal people As PeopleDataContext)
        xml.Add(New XElement("person", _
                    New XElement("id", 5), _
                    New XElement("firstname", "Tom"), _
                    New XElement("lastname", "Cruise"), _
                    New XElement("idrole", 1)))

        Console.WriteLine(xml)

        AddPerson(xml, people)

    End Sub
#End Region

#Region "Listing 3-29"
    Private Sub AddPerson(ByVal xml As XElement, ByVal peopledb As PeopleDataContext)
        Dim people = xml.Descendants("person")
        Dim id As Integer

        For Each Dim person In people
            id = Convert.ToInt32(person.Element("id").Value)

            Dim query = From p In peopledb.People _
                Where p.ID = id _
                Select p

            If query.ToList().Count = 0 Then
                Dim per As New Person()
                per.FirstName = person.Element("firstname").Value
                per.LastName = person.Element("lastname").Value
                per.IDRole = person.Element("idrole").Value
                peopledb.People.Add(per)
            End If
        Next

        peopledb.SubmitChanges()
    End Sub
#End Region
End Module


