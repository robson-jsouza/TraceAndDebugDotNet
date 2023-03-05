// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

string sProdName = "Widget";
int iUnitQty = 100;
double dUnitCost = 1.03;

// Debug messages only appear when running on Debug mode and not on Release mode

Debug.WriteLine("Debug Information-Product Starting");
Debug.Indent(); // this indents the lines, in other words, puts a tab or some blank spaces
Debug.WriteLine("The product name is " + sProdName);
Debug.WriteLine("The available units on hand are " + iUnitQty.ToString());
Debug.WriteLine("The per unit cost is " + dUnitCost.ToString());

System.Xml.XmlDocument oxml = new System.Xml.XmlDocument();
Debug.WriteLine(oxml);  // writes the object namespace

Debug.WriteLine("The product name is " + sProdName, "Field");
Debug.WriteLine("The units on hand are " + iUnitQty, "Field");
Debug.WriteLine("The per unit cost is " + dUnitCost.ToString(), "Field");
Debug.WriteLine("Total Cost is " + (iUnitQty * dUnitCost), "Calc");

Debug.WriteLineIf(iUnitQty > 50, "This message WILL appear");
Debug.WriteLineIf(iUnitQty < 50, "This message will NOT appear");   // iUnitQty is greater than 50, it is 100

Debug.Assert(dUnitCost > 1, "Message will NOT appear"); // this will break and not appear because it is true and an Assert should be false to appear

Debug.Assert(dUnitCost < 1, "Message will appear since dUnitcost < 1 is false");    // this will appear because dUnitCost is not smaller than 1, it is 1.03

Debug.Unindent();  // this unindents the lines, in other words, removes the tab or the blank spaces, to distinguish processing messages from messages to highlight
                   // steps starting
Debug.WriteLine("Debug Information-Product Ending");
Debug.Flush();  // it is like a dispose of the file

TextWriterTraceListener tr1 = new TextWriterTraceListener(System.Console.Out);
Trace.Listeners.Add(tr1);   // starts showing messages on the CMD screen

TextWriterTraceListener tr2 = new TextWriterTraceListener(System.IO.File.CreateText("Output.txt"));
Trace.Listeners.Add(tr2);   // starts writing messages to a text file called Outuput.txt in the bin folder

Trace.WriteLine("Trace Information-Product Starting");
Trace.Indent(); // this indents the lines, in other words, puts a tab or some blank spaces

Trace.WriteLine("The product name is " + sProdName);
Trace.WriteLine("The available units on hand are " + iUnitQty);
Trace.WriteLine("The per unit cost is " + dUnitCost);

Trace.WriteLine("The product name is" + sProdName, "Field");
Trace.WriteLineIf(iUnitQty > 50, "This message WILL appear");
Trace.Assert(dUnitCost > 1, "Message will NOT appear"); // this won't break but not appear because it is true and an Assert should be false to appear

Trace.Unindent();  // this unindents the lines, in other words, removes the tab or the blank spaces, to distinguish processing messages from messages to highlight
                   // steps starting
Trace.WriteLine("Trace Information-Product Ending");

Trace.Flush();  // it is like a dispose of the file

Console.ReadLine();
