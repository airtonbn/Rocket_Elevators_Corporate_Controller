using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Rocket_Elevators_Corporate_Controller
{
    public partial class Form1 : Form
    {
        IList<Floors.FloorsColumn1> FloorsColumn1List = new List<Floors.FloorsColumn1>();
        IList<Floors.FloorsColumn1> FloorsColumn1List_Elev2 = new List<Floors.FloorsColumn1>();
        IList<Floors.FloorsColumn1> FloorsColumn1List_Elev3 = new List<Floors.FloorsColumn1>();
        IList<Floors.FloorsColumn1> FloorsColumn1List_Elev4 = new List<Floors.FloorsColumn1>();
        IList<Floors.FloorsColumn1> FloorsColumn1List_Elev5 = new List<Floors.FloorsColumn1>();

        IList<Floors.FloorsColumn2> FloorsColumn2List = new List<Floors.FloorsColumn2>();
        IList<Floors.FloorsColumn2> FloorsColumn2List_Elev2 = new List<Floors.FloorsColumn2>();
        IList<Floors.FloorsColumn2> FloorsColumn2List_Elev3 = new List<Floors.FloorsColumn2>();
        IList<Floors.FloorsColumn2> FloorsColumn2List_Elev4 = new List<Floors.FloorsColumn2>();
        IList<Floors.FloorsColumn2> FloorsColumn2List_Elev5 = new List<Floors.FloorsColumn2>();

        IList<Floors.FloorsColumn3> FloorsColumn3List = new List<Floors.FloorsColumn3>();
        IList<Floors.FloorsColumn3> FloorsColumn3List_Elev2 = new List<Floors.FloorsColumn3>();
        IList<Floors.FloorsColumn3> FloorsColumn3List_Elev3 = new List<Floors.FloorsColumn3>();
        IList<Floors.FloorsColumn3> FloorsColumn3List_Elev4 = new List<Floors.FloorsColumn3>();
        IList<Floors.FloorsColumn3> FloorsColumn3List_Elev5 = new List<Floors.FloorsColumn3>();

        IList<Floors.FloorsColumn4> FloorsColumn4List = new List<Floors.FloorsColumn4>();
        IList<Floors.FloorsColumn4> FloorsColumn4List_Elev2 = new List<Floors.FloorsColumn4>();
        IList<Floors.FloorsColumn4> FloorsColumn4List_Elev3 = new List<Floors.FloorsColumn4>();
        IList<Floors.FloorsColumn4> FloorsColumn4List_Elev4 = new List<Floors.FloorsColumn4>();
        IList<Floors.FloorsColumn4> FloorsColumn4List_Elev5 = new List<Floors.FloorsColumn4>();

        IList<Elevators.Elevator1Column1> Elevator1Column1List = new List<Elevators.Elevator1Column1>();
        IList<Elevators.Elevator2Column1> Elevator2Column1List = new List<Elevators.Elevator2Column1>();
        IList<Elevators.Elevator3Column1> Elevator3Column1List = new List<Elevators.Elevator3Column1>();
        IList<Elevators.Elevator4Column1> Elevator4Column1List = new List<Elevators.Elevator4Column1>();
        IList<Elevators.Elevator5Column1> Elevator5Column1List = new List<Elevators.Elevator5Column1>();

        public Form1()
        {
            InitializeComponent();
            //Columns column1 = new Columns("Column 1", 85, 4);
            //Columns column2 = new Columns("Column 2", 85, 4);
            //Columns column3 = new Columns("Column 3", 85, 4);
            //Columns column4 = new Columns("Column 4", 85, 4);
        }

        class Battery
        {/*
            public string Name { get; }
            public List<Elevator> Elevators { get; }
            public List<Column> Columns { get; }
            public List<GroundfloorButton> GroundfloorButtons { get; }
            public List<floorButton> floorButtons { get; }
            public int maxWeight { get; private set; }
            public string inputnumberFloor { get; private set; }
            public string inputnumberColumns { get; private set; }
            public string inputnumberElevators { get; private set; }
            public string inputnumberElevatorsByColumns { get; private set; }
            public int numberFloor { get; private set; }
            public int numberColumns { get; private set; }
            public int numberElevators { get; private set; }
            public int numberElevatorsByColumns { get; private set; }*/

            public int numberFloor;
            public int numberElevator;
            public List<Columns> column;
            public Battery(int _numberFloor, int _numberElevator)
            {
                numberFloor = _numberFloor;
                numberElevator = _numberElevator;
                column = new List<Columns>();
            }
        }

        public class Columns
        {
            public class Column1
            {
                public int numberFloorColumn1;
                public string columnNumberColumn1;
                public int numberElevatorColumn1;
                public List<int> callElevatorList;
                public List<int> outsideCallButtonsList;
                public Column1(string columnNumber, int numberFloor, int numberElevator)
                {
                    numberFloorColumn1 = numberFloor;
                    columnNumberColumn1 = columnNumber;
                    numberElevatorColumn1 = numberElevator;
                    callElevatorList = new List<int>();
                    outsideCallButtonsList = new List<int>();
                }
            }
            public class Column2
            {
                public int numberFloorColumn2;
                public string columnNumberColumn2;
                public int numberElevatorColumn2;
                public List<int> callElevatorList;
                public List<int> outsideCallButtonsList;
                public Column2(string columnNumber, int numberFloor, int numberElevator)
                {
                    numberFloorColumn2 = numberFloor;
                    columnNumberColumn2 = columnNumber;
                    numberElevatorColumn2 = numberElevator;
                    callElevatorList = new List<int>();
                    outsideCallButtonsList = new List<int>();
                }
            }
            public class Column3
            {
                public int numberFloorColumn3;
                public string columnNumberColumn3;
                public int numberElevatorColumn3;
                public List<int> callElevatorList;
                public List<int> outsideCallButtonsList;
                public Column3(string columnNumber, int numberFloor, int numberElevator)
                {
                    numberFloorColumn3 = numberFloor;
                    columnNumberColumn3 = columnNumber;
                    numberElevatorColumn3 = numberElevator;
                    callElevatorList = new List<int>();
                    outsideCallButtonsList = new List<int>();
                }
            }
            public class Column4
            {
                public int numberFloorColumn4;
                public string columnNumberColumn4;
                public int numberElevatorColumn4;
                public List<int> callElevatorList;
                public List<int> outsideCallButtonsList;
                public Column4(string columnNumber, int numberFloor, int numberElevator)
                {
                    numberFloorColumn4 = numberFloor;
                    columnNumberColumn4 = columnNumber;
                    numberElevatorColumn4 = numberElevator;
                    callElevatorList = new List<int>();
                    outsideCallButtonsList = new List<int>();
                }
            }
        }

        public class Elevators
        {
            public class Elevator1Column1
            {
                public string numberElevator1Column1;
                public int numberFloorColumn1;
                public string directionElevator1Column1;
                public string statusElevator1Column1;
                public List<int> requestFloorListColumn1;
                public List<int> insideRequestButtonListElevator1Column1;
                public int currentfloorElevator1Column1;
                public Elevator1Column1(string _elevatorName, int _numberFloor)
                {
                    this.numberElevator1Column1 = numberElevator1Column1;
                    this.numberFloorColumn1 = numberFloorColumn1;
                    this.directionElevator1Column1 = directionElevator1Column1;
                    this.statusElevator1Column1 = statusElevator1Column1;
                    this.requestFloorListColumn1 = new List<int>();
                    this.insideRequestButtonListElevator1Column1 = new List<int>();
                    this.currentfloorElevator1Column1 = currentfloorElevator1Column1;
                }
            }

            public class Elevator2Column1
            {
                public string numberElevator2Column1;
                public int numberFloorColumn1;
                public string directionElevator2Column1;
                public string statusElevator2Column1;
                public List<int> requestFloorListColumn1;
                public List<int> insideRequestButtonListElevator2Column1;
                public int currentfloorElevator2Column1;
                public Elevator2Column1(string elevatorName, int numberFloor)
                {
                    this.numberElevator2Column1 = numberElevator2Column1;
                    this.numberFloorColumn1 = numberFloorColumn1;
                    this.directionElevator2Column1 = directionElevator2Column1;
                    this.statusElevator2Column1 = statusElevator2Column1;
                    this.requestFloorListColumn1 = new List<int>();
                    this.insideRequestButtonListElevator2Column1 = new List<int>();
                    this.currentfloorElevator2Column1 = currentfloorElevator2Column1;
                }
            }

            public class Elevator3Column1
            {
                public string numberElevator3Column1;
                public int numberFloorColumn1;
                public string directionElevator3Column1;
                public string statusElevator3Column1;
                public List<int> requestFloorListColumn1;
                public List<int> insideRequestButtonListElevator3Column1;
                public int currentfloorElevator3Column1;
                public Elevator3Column1(string elevatorName, int numberFloor)
                {
                    this.numberElevator3Column1 = numberElevator3Column1;
                    this.numberFloorColumn1 = numberFloorColumn1;
                    this.directionElevator3Column1 = directionElevator3Column1;
                    this.statusElevator3Column1 = statusElevator3Column1;
                    this.requestFloorListColumn1 = new List<int>();
                    this.insideRequestButtonListElevator3Column1 = new List<int>();
                    this.currentfloorElevator3Column1 = currentfloorElevator3Column1;
                }
            }

            public class Elevator4Column1
            {
                public string numberElevator4Column1;
                public int numberFloorColumn1;
                public string directionElevator4Column1;
                public string statusElevator4Column1;
                public List<int> requestFloorListColumn1;
                public List<int> insideRequestButtonListElevator4Column1;
                public int currentfloorElevator4Column1;
                public Elevator4Column1(string elevatorName, int numberFloor)
                {
                    this.numberElevator4Column1 = numberElevator4Column1;
                    this.numberFloorColumn1 = numberFloorColumn1;
                    this.directionElevator4Column1 = directionElevator4Column1;
                    this.statusElevator4Column1 = statusElevator4Column1;
                    this.requestFloorListColumn1 = new List<int>();
                    this.insideRequestButtonListElevator4Column1 = new List<int>();
                    this.currentfloorElevator4Column1 = currentfloorElevator4Column1;
                }
            }

            public class Elevator5Column1
            {
                public string numberElevator5Column1;
                public int numberFloorColumn1;
                public string directionElevator5Column1;
                public string statusElevator5Column1;
                public List<int> requestFloorListColumn1;
                public List<int> insideRequestButtonListElevator5Column1;
                public int currentfloorElevator5Column1;
                public Elevator5Column1(string elevatorName, int numberFloor)
                {
                    this.numberElevator5Column1 = numberElevator5Column1;
                    this.numberFloorColumn1 = numberFloorColumn1;
                    this.directionElevator5Column1 = directionElevator5Column1;
                    this.statusElevator5Column1 = statusElevator5Column1;
                    this.requestFloorListColumn1 = new List<int>();
                    this.insideRequestButtonListElevator5Column1 = new List<int>();
                    this.currentfloorElevator5Column1 = currentfloorElevator5Column1;
                }
            }
        }

        public class CallButton
        {
            public class CallButtonColumn1
            {
                public int requestedFloorColumn1;
                public string directionColumn1;
                public bool activateButtonColumn1;
                public CallButtonColumn1(int requestedFloorColumn1, string directionColumn1)
                {
                    this.requestedFloorColumn1 = requestedFloorColumn1;
                    this.directionColumn1 = directionColumn1;
                    this.activateButtonColumn1 = false;
                }
            }

            public class CallButtonColumn2
            {
                public int requestedFloorColumn2;
                public string directionColumn2;
                public bool activateButtonColumn2;
                public CallButtonColumn2(int requestedFloorColumn2, string directionColumn2)
                {
                    this.requestedFloorColumn2 = requestedFloorColumn2;
                    this.directionColumn2 = directionColumn2;
                    this.activateButtonColumn2 = false;
                }
            }

            public class CallButtonColumn3
            {
                public int requestedFloorColumn3;
                public string directionColumn3;
                public bool activateButtonColumn3;
                public CallButtonColumn3(int requestedFloorColumn3, string directionColumn3)
                {
                    this.requestedFloorColumn3 = requestedFloorColumn3;
                    this.directionColumn3 = directionColumn3;
                    this.activateButtonColumn3 = false;
                }
            }

            public class CallButtonColumn4
            {
                public int requestedFloorColumn4;
                public string directionColumn4;
                public bool activateButtonColumn4;
                public CallButtonColumn4(int requestedFloorColumn4, string directionColumn4)
                {
                    this.requestedFloorColumn4 = requestedFloorColumn4;
                    this.directionColumn4 = directionColumn4;
                    this.activateButtonColumn4 = false;
                }
            }
        }

        public class Floors
        {
            public class FloorsColumn1
            {
                public int floorColumn1 { get; set; }
                public bool elevatorIsAtThisFloorSoc { get; set; }
            }
            public class FloorsColumn2
            {
                public int floorColumn2 { get; set; }
                public bool elevatorIsAtThisFloor { get; set; }
            }
            public class FloorsColumn3
            {
                
            }
            public class FloorsColumn4
            {

            }
        }

        private void btnCallElevator_Click(object sender, EventArgs e)
        {
            int whereIam = int.Parse(txtFloorIam.Text);
            int whereIgo = int.Parse(txtFloorIgo.Text);

            //Call column B
            if (whereIgo >= 23 && whereIgo <= 43)
            {
                textBox1.Text += "Start COLUMN B \r\n";


                //Looking Elevator 1 at column B
                for (int i = 1; i <= 85; i++)
                {
                    Floors.FloorsColumn2 reg = new Floors.FloorsColumn2();
                    reg.floorColumn2 = i;
                    reg.elevatorIsAtThisFloor = false;

                    int startElevator = int.Parse(txtElev1Col2Start.Text);
                    //Floor where elevator start work
                    if (i == startElevator)
                    {
                        reg.elevatorIsAtThisFloor = true;
                    }
                    FloorsColumn2List.Add(reg);
                }

                //Looking Elevator 2 at column B
                for (int i = 1; i <= 85; i++)
                {
                    Floors.FloorsColumn2 reg = new Floors.FloorsColumn2();
                    reg.floorColumn2 = i;
                    reg.elevatorIsAtThisFloor = false;

                    int startElevator = int.Parse(txtElev2Col2Start.Text);
                    //Floor where elevator start work
                    if (i == startElevator)
                    {
                        reg.elevatorIsAtThisFloor = true;
                    }
                    FloorsColumn2List_Elev2.Add(reg);
                }

                //Looking Elevator 3 at column B
                for (int i = 1; i <= 85; i++)
                {
                    Floors.FloorsColumn2 reg = new Floors.FloorsColumn2();
                    reg.floorColumn2 = i;
                    reg.elevatorIsAtThisFloor = false;

                    int startElevator = int.Parse(txtElev3Col2Start.Text);
                    //Floor where elevator start work
                    if (i == startElevator)
                    {
                        reg.elevatorIsAtThisFloor = true;
                    }
                    FloorsColumn2List_Elev3.Add(reg);
                }

                //Looking Elevator 4 at column B
                for (int i = 1; i <= 85; i++)
                {
                    Floors.FloorsColumn2 reg = new Floors.FloorsColumn2();
                    reg.floorColumn2 = i;
                    reg.elevatorIsAtThisFloor = false;

                    int startElevator = int.Parse(txtElev4Col2Start.Text);
                    //Floor where elevator start work
                    if (i == startElevator)
                    {
                        reg.elevatorIsAtThisFloor = true;
                    }
                    FloorsColumn2List_Elev4.Add(reg);
                }


                //Looking Elevator 5 at column B
                for (int i = 1; i <= 85; i++)
                {
                    Floors.FloorsColumn2 reg = new Floors.FloorsColumn2();
                    reg.floorColumn2 = i;
                    reg.elevatorIsAtThisFloor = false;

                    int startElevator = int.Parse(txtElev5Col2Start.Text);
                    //Floor where elevator start work
                    if (i == startElevator)
                    {
                        reg.elevatorIsAtThisFloor = true;
                    }
                    FloorsColumn2List_Elev5.Add(reg);
                }


                textBox1.Text += "Elevator started \r\n";
                Thread.Sleep(1000);
                Application.DoEvents();
                textBox1.Text += "I am at floor " + whereIam + "\r\n";
                Thread.Sleep(1000);
                Application.DoEvents();
                textBox1.Text += "I called the elevator\r\n";
                Thread.Sleep(1000);
                Application.DoEvents();
                MovingElevUpOrDown_ColumnB(whereIam);
                textBox1.Text += "I in and press the floor " + whereIgo + "\r\n";
                Thread.Sleep(1000);
                Application.DoEvents();
                MovingElevUpOrDown_ColumnB(whereIgo);
                Thread.Sleep(1000);
                Application.DoEvents();
                textBox1.Text += "I out of the elevator \r\n";
            }

            //Call column 1
            if (whereIgo >= 1 && whereIgo <= 22)
            {
                for (int i = 1; i <= 85; i++)
                {
                    Floors.FloorsColumn1 reg = new Floors.FloorsColumn1();
                    reg.floorColumn1 = i;
                    reg.elevatorIsAtThisFloorSoc = false;

                    int startElevator = int.Parse(txtElev1Col1Start.Text);
                    //Floor where elevator start work
                    if (i == startElevator)
                    {
                        reg.elevatorIsAtThisFloorSoc = true;
                    }
                    FloorsColumn1List.Add(reg);
                }

                for (int i = 1; i <= 85; i++)
                {
                    Floors.FloorsColumn1 reg = new Floors.FloorsColumn1();
                    reg.floorColumn1 = i;
                    reg.elevatorIsAtThisFloorSoc = false;

                    int startElevator = int.Parse(txtElev1Col1Start.Text);
                    //Floor where elevator start work
                    if (i == startElevator)
                    {
                        reg.elevatorIsAtThisFloorSoc = true;
                    }
                    FloorsColumn1List.Add(reg);
                }

                textBox1.Text += "Elevator started \r\n";
                Thread.Sleep(1000);
                Application.DoEvents();
                textBox1.Text += "I am at floor " + whereIam + "\r\n";
                Thread.Sleep(1000);
                Application.DoEvents();
                textBox1.Text += "I called the elevator\r\n";
                Thread.Sleep(1000);
                Application.DoEvents();
                MovingElevUpOrDown(whereIam);
                textBox1.Text += "I in and press the floor " + whereIgo + "\r\n";
                Thread.Sleep(1000);
                Application.DoEvents();
                MovingElevUpOrDown(whereIgo);
                Thread.Sleep(1000);
                Application.DoEvents();
                textBox1.Text += "I out of the elevator \r\n";
            }

            //Start COLUMN C
            if (whereIgo >= 44 && whereIgo <= 68)
            {

            }

            //Start COLUMN D
            if (whereIgo >= 69 && whereIgo <= 83)
            {

            }


        }

        public class ElevatorFloor
        {
            public int numberElevator { get; set; }
            public int distance { get; set; }
        }



        private int MovingElevUpOrDown_ColumnB(int whereIgo)
        {
            //Discover where elevator is
            int FloorsWhereElevatorAreX = 0;
            
            int floorIam = int.Parse(this.txtFloorIam.Text);

            int elev1Col2Start = int.Parse(this.txtElev1Col2Start.Text);
            int elev2Col2Start = int.Parse(this.txtElev2Col2Start.Text);
            int elev3Col2Start = int.Parse(this.txtElev3Col2Start.Text);
            int elev4Col2Start = int.Parse(this.txtElev4Col2Start.Text);
            int elev5Col2Start = int.Parse(this.txtElev5Col2Start.Text);

            int elev1Col2GoTo = int.Parse(this.txtElev1Col2GoTo.Text);
            int elev2Col2GoTo = int.Parse(this.txtElev2Col2GoTo.Text);
            int elev3Col2GoTo = int.Parse(this.txtElev3Col2GoTo.Text);
            int elev4Col2GoTo = int.Parse(this.txtElev4Col2GoTo.Text);
            int elev5Col2GoTo = int.Parse(this.txtElev5Col2GoTo.Text);
            
            int elev1 = elev1Col2GoTo - elev1Col2Start;
            int elev2 = elev2Col2GoTo - elev2Col2Start;
            int elev3 = elev3Col2GoTo - elev3Col2Start;
            int elev4 = elev4Col2GoTo - elev4Col2Start;
            int elev5 = elev5Col2GoTo - elev5Col2Start;

            int distanceBetweenEndAndI1 = elev1Col2GoTo - floorIam;
            int distanceBetweenEndAndI2 = elev2Col2GoTo - floorIam;
            int distanceBetweenEndAndI3 = elev3Col2GoTo - floorIam;
            int distanceBetweenEndAndI4 = elev4Col2GoTo - floorIam;
            int distanceBetweenEndAndI5 = elev5Col2GoTo - floorIam;
            
            if (distanceBetweenEndAndI1 < 0) { distanceBetweenEndAndI1 = distanceBetweenEndAndI1 * (-1); }
            if (distanceBetweenEndAndI2 < 0) { distanceBetweenEndAndI2 = distanceBetweenEndAndI2 * (-1); }
            if (distanceBetweenEndAndI3 < 0) { distanceBetweenEndAndI3 = distanceBetweenEndAndI3 * (-1); }
            if (distanceBetweenEndAndI4 < 0) { distanceBetweenEndAndI4 = distanceBetweenEndAndI4 * (-1); }
            if (distanceBetweenEndAndI5 < 0) { distanceBetweenEndAndI5 = distanceBetweenEndAndI5 * (-1); }
            
            if (elev1 < 0) { elev1 = elev1 * (-1); }
            if (elev2 < 0) { elev2 = elev2 * (-1); }
            if (elev3 < 0) { elev3 = elev3 * (-1); }
            if (elev4 < 0) { elev4 = elev4 * (-1); }
            if (elev5 < 0) { elev5 = elev5 * (-1); }

            IList<ElevatorFloor> listDistanceBetweenEndAndI = new List<ElevatorFloor>();
            IList<ElevatorFloor> listDistanceBetweenStartToEnd = new List<ElevatorFloor>();

            ElevatorFloor ea1 = new ElevatorFloor();
            ea1.numberElevator = 1;
            ea1.distance = distanceBetweenEndAndI1;
            listDistanceBetweenEndAndI.Add(ea1);

            ElevatorFloor ea2 = new ElevatorFloor();
            ea2.numberElevator = 2;
            ea2.distance = distanceBetweenEndAndI2;
            listDistanceBetweenEndAndI.Add(ea2);

            ElevatorFloor ea3 = new ElevatorFloor();
            ea3.numberElevator = 3;
            ea3.distance = distanceBetweenEndAndI3;
            listDistanceBetweenEndAndI.Add(ea3);

            ElevatorFloor ea4 = new ElevatorFloor();
            ea4.numberElevator = 4;
            ea4.distance = distanceBetweenEndAndI4;
            listDistanceBetweenEndAndI.Add(ea4);

            ElevatorFloor ea5 = new ElevatorFloor();
            ea5.numberElevator = 5;
            ea5.distance = distanceBetweenEndAndI5;
            listDistanceBetweenEndAndI.Add(ea5);

            ElevatorFloor ea1a = new ElevatorFloor();
            ea1a.numberElevator = 1;
            ea1a.distance = elev1;
            listDistanceBetweenStartToEnd.Add(ea1a);

            ElevatorFloor ea2a = new ElevatorFloor();
            ea2a.numberElevator = 2;
            ea2a.distance = elev2;
            listDistanceBetweenStartToEnd.Add(ea2a);

            ElevatorFloor ea3a = new ElevatorFloor();
            ea3a.numberElevator = 3;
            ea3a.distance = elev3;
            listDistanceBetweenStartToEnd.Add(ea3a);

            ElevatorFloor ea4a = new ElevatorFloor();
            ea4a.numberElevator = 4;
            ea4a.distance = elev4;
            listDistanceBetweenStartToEnd.Add(ea4a);

            ElevatorFloor ea5a = new ElevatorFloor();
            ea5a.numberElevator = 5;
            ea5a.distance = elev5;
            listDistanceBetweenStartToEnd.Add(ea5a);

            listDistanceBetweenEndAndI = listDistanceBetweenEndAndI.OrderBy(x => x.distance).ToList();
            listDistanceBetweenStartToEnd = listDistanceBetweenStartToEnd.OrderBy(x => x.distance).ToList();

            int nearstElevator = listDistanceBetweenEndAndI[0].numberElevator;

            listDistanceBetweenEndAndI = listDistanceBetweenEndAndI.Where(x => x.distance == listDistanceBetweenEndAndI[0].distance).ToList();
            
            if (listDistanceBetweenEndAndI.Count > 1)
            {
                listDistanceBetweenStartToEnd = listDistanceBetweenStartToEnd.Where(x => x.numberElevator == listDistanceBetweenEndAndI[0].numberElevator || x.numberElevator == listDistanceBetweenEndAndI[1].numberElevator).ToList();

                listDistanceBetweenStartToEnd = listDistanceBetweenStartToEnd.OrderBy(x => x.distance).ToList();

                nearstElevator = listDistanceBetweenStartToEnd[0].numberElevator;

            }

            MessageBox.Show("Nearst Elevator: " + nearstElevator);

            if (nearstElevator == 1)
            {
                for (int i = 1; i < 85; i++)
                {
                    if (FloorsColumn2List[i].elevatorIsAtThisFloor == true)
                    {
                        FloorsWhereElevatorAreX = FloorsColumn2List[i].floorColumn2;
                    }
                }
                int FloorsWhereElevatorAreY = 0;
                for (int i = 0; i < 85; i++)
                {

                }

                int distanceBetweenFloorAndX = whereIgo - FloorsWhereElevatorAreX;
                int distanceBetweenFloorAndY = whereIgo - FloorsWhereElevatorAreY;
                
                if (distanceBetweenFloorAndX < 0)
                {
                    distanceBetweenFloorAndX = distanceBetweenFloorAndX * (-1);
                }
                if (distanceBetweenFloorAndY < 0)
                {
                    distanceBetweenFloorAndY = distanceBetweenFloorAndY * (-1);
                }

                if (distanceBetweenFloorAndX < distanceBetweenFloorAndY)
                { 
                    if (whereIgo < FloorsWhereElevatorAreX)
                    {
                        for (int i = 85; i >= 1; i--)
                        {
                            textBox1.Text += "Looking elevator at floor: " + (i + 1) + "\r\n";
                            Thread.Sleep(1000);
                            Application.DoEvents();

                            if ((i + 1) == whereIgo)
                            {
                                textBox1.Text += "It arrived at the floor: " + (i + 1) + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                textBox1.Text += "Opening the door\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();

                                textBox1.Text += "Closing the door" + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                return i;
                            }

                            if (FloorsColumn2List[i].elevatorIsAtThisFloor == true)
                            {
                                textBox1.Text += "Moving elevator: " + (i + 1) + " to floor >>> " + i + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                FloorsColumn2List[i].elevatorIsAtThisFloor = false;
                                FloorsColumn2List[i - 1].elevatorIsAtThisFloor = true;
                            }
                        }
                    }

                    if (whereIgo > FloorsWhereElevatorAreX)
                    {
                        for (int i = 1; i < 85; i++)
                        {
                            textBox1.Text += "Looking elevator at floor: " + (i + 1) + "\r\n";
                            Thread.Sleep(1000);
                            Application.DoEvents();


                            if ((i + 1) == whereIgo)
                            {
                                textBox1.Text += "It arrived at the floor: " + (i + 1) + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                textBox1.Text += "Opening the door\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                textBox1.Text += "Closing the door\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                return i;
                            }

                            if (FloorsColumn2List[i].elevatorIsAtThisFloor == true)
                            {
                                textBox1.Text += "Moving elevator: " + (i + 1) + " to floor >>> " + (i + 2) + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                FloorsColumn2List[i].elevatorIsAtThisFloor = false;
                                FloorsColumn2List[i + 1].elevatorIsAtThisFloor = true;
                            }                            
                        }
                    }                    
                }
                else
                {
                    if (whereIgo < FloorsWhereElevatorAreY)
                    {
                        for (int i = 85; i >= 1; i--)
                        {
                            textBox1.Text += "Looking elevator at floor: " + (i + 1) + "\r\n";
                            Thread.Sleep(1000);
                            Application.DoEvents();

                            if ((i + 1) == whereIgo)
                            {
                                textBox1.Text += "It arrived at the floor: " + (i + 1) + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                textBox1.Text += "Opening the door" + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                textBox1.Text += "Closing the door" + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                return i;
                            }
                        }

                    }


                    if (whereIgo > FloorsWhereElevatorAreY)
                    {
                        for (int i = 1; i < 10; i++)
                        {
                            textBox1.Text += "Looking elevator at floor: " + (i + 1) + "\r\n";
                            Thread.Sleep(1000);
                            Application.DoEvents();


                            if ((i + 1) == whereIgo)
                            {
                                textBox1.Text += "It arrived at the floor: " + (i + 1) + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                textBox1.Text += "Opening the door" + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                textBox1.Text += "Closing the door" + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                return i;
                            }
                        }
                    }
                }
                return 0;
            }
            
            if (nearstElevator == 2)
            {
                for (int i = 1; i < 85; i++)
                {
                    if (FloorsColumn2List_Elev2[i].elevatorIsAtThisFloor == true)
                    {
                        FloorsWhereElevatorAreX = FloorsColumn2List_Elev2[i].floorColumn2;
                    }
                }
                int FloorsWhereElevatorAreY = 0;
                for (int i = 0; i < 85; i++)
                {

                }
                int distanceBetweenFloorAndX = whereIgo - FloorsWhereElevatorAreX;
                int distanceBetweenFloorAndY = whereIgo - FloorsWhereElevatorAreY;
                if (distanceBetweenFloorAndX < 0)
                {
                    distanceBetweenFloorAndX = distanceBetweenFloorAndX * (-1);
                }
                if (distanceBetweenFloorAndY < 0)
                {
                    distanceBetweenFloorAndY = distanceBetweenFloorAndY * (-1);
                }
                
                if (distanceBetweenFloorAndX < distanceBetweenFloorAndY)
                {
                    if (whereIgo < FloorsWhereElevatorAreX)
                    {
                        for (int i = 85; i >= 1; i--)
                        {
                            textBox1.Text += "Looking elevator at floor: " + (i + 1) + "\r\n";
                            Thread.Sleep(1000);
                            Application.DoEvents();

                            if ((i + 1) == whereIgo)
                            {
                                textBox1.Text += "It arrived at the floor: " + (i + 1) + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                textBox1.Text += "Opening the door\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                textBox1.Text += "Closing the door" + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                return i;
                            }

                            if (FloorsColumn2List_Elev2[i].elevatorIsAtThisFloor == true)
                            {
                                textBox1.Text += "Moving elevator: " + (i + 1) + " to floor >>> " + i + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                FloorsColumn2List_Elev2[i].elevatorIsAtThisFloor = false;
                                FloorsColumn2List_Elev2[i - 1].elevatorIsAtThisFloor = true;
                            }
                        }
                    }

                    if (whereIgo > FloorsWhereElevatorAreX)
                    {
                        for (int i = 1; i < 85; i++)
                        {
                            textBox1.Text += "Looking elevator at floor: " + (i + 1) + "\r\n";
                            Thread.Sleep(1000);
                            Application.DoEvents();

                            if ((i + 1) == whereIgo)
                            {
                                textBox1.Text += "It arrived at the floor: " + (i + 1) + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                textBox1.Text += "Opening the door\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                textBox1.Text += "Closing the door\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                return i;
                            }

                            if (FloorsColumn2List_Elev2[i].elevatorIsAtThisFloor == true)
                            {
                                textBox1.Text += "Moving elevator: " + (i + 1) + " to floor >>> " + (i + 2) + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                FloorsColumn2List_Elev2[i].elevatorIsAtThisFloor = false;
                                FloorsColumn2List_Elev2[i + 1].elevatorIsAtThisFloor = true;
                            }
                        }
                    }
                }
                else
                {
                    if (whereIgo < FloorsWhereElevatorAreY)
                    {
                        for (int i = 85; i >= 1; i--)
                        {
                            textBox1.Text += "Looking elevator at floor: " + (i + 1) + "\r\n";
                            Thread.Sleep(1000);
                            Application.DoEvents();

                            if ((i + 1) == whereIgo)
                            {
                                textBox1.Text += "It arrived at the floor: " + (i + 1) + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                textBox1.Text += "Opening the door" + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                textBox1.Text += "Closing the door" + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                return i;
                            }
                        }
                    }

                    if (whereIgo > FloorsWhereElevatorAreY)
                    {
                        for (int i = 1; i < 10; i++)
                        {
                            textBox1.Text += "Looking elevator at floor: " + (i + 1) + "\r\n";
                            Thread.Sleep(1000);
                            Application.DoEvents();


                            if ((i + 1) == whereIgo)
                            {
                                textBox1.Text += "It arrived at the floor: " + (i + 1) + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                textBox1.Text += "Opening the door" + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                textBox1.Text += "Closing the door" + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                return i;
                            }
                        }
                    }
                }
                return 0;
            }

            if (nearstElevator == 3)
            {
                for (int i = 1; i < 85; i++)
                {
                    if (FloorsColumn2List_Elev3[i].elevatorIsAtThisFloor == true)
                    {
                        FloorsWhereElevatorAreX = FloorsColumn2List_Elev3[i].floorColumn2;
                    }
                }
                int FloorsWhereElevatorAreY = 0;
                for (int i = 0; i < 85; i++)
                {

                }

                int distanceBetweenFloorAndX = whereIgo - FloorsWhereElevatorAreX;
                int distanceBetweenFloorAndY = whereIgo - FloorsWhereElevatorAreY;
                if (distanceBetweenFloorAndX < 0)
                {
                    distanceBetweenFloorAndX = distanceBetweenFloorAndX * (-1);
                }
                if (distanceBetweenFloorAndY < 0)
                {
                    distanceBetweenFloorAndY = distanceBetweenFloorAndY * (-1);
                }
                
                if (distanceBetweenFloorAndX < distanceBetweenFloorAndY)
                {
                    if (whereIgo < FloorsWhereElevatorAreX)
                    {
                        for (int i = 85; i >= 1; i--)
                        {
                            textBox1.Text += "Looking elevator at floor: " + (i + 1) + "\r\n";
                            Thread.Sleep(1000);
                            Application.DoEvents();

                            if ((i + 1) == whereIgo)
                            {
                                textBox1.Text += "It arrived at the floor: " + (i + 1) + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                textBox1.Text += "Opening the door\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                textBox1.Text += "Closing the door" + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                return i;
                            }

                            if (FloorsColumn2List_Elev3[i].elevatorIsAtThisFloor == true)
                            {
                                textBox1.Text += "Moving elevator: " + (i + 1) + " to floor >>> " + i + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                FloorsColumn2List_Elev3[i].elevatorIsAtThisFloor = false;
                                FloorsColumn2List_Elev3[i - 1].elevatorIsAtThisFloor = true;
                            }
                        }
                    }

                    if (whereIgo > FloorsWhereElevatorAreX)
                    {
                        for (int i = 1; i < 85; i++)
                        {
                            textBox1.Text += "Looking elevator at floor: " + (i + 1) + "\r\n";
                            Thread.Sleep(1000);
                            Application.DoEvents();


                            if ((i + 1) == whereIgo)
                            {
                                textBox1.Text += "It arrived at the floor: " + (i + 1) + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                textBox1.Text += "Opening the door\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                textBox1.Text += "Closing the door\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                return i;
                            }

                            if (FloorsColumn2List_Elev3[i].elevatorIsAtThisFloor == true)
                            {
                                textBox1.Text += "Moving elevator: " + (i + 1) + " to floor >>> " + (i + 2) + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                FloorsColumn2List_Elev3[i].elevatorIsAtThisFloor = false;
                                FloorsColumn2List_Elev3[i + 1].elevatorIsAtThisFloor = true;
                            }
                        }
                    }
                }
                else
                {
                    if (whereIgo < FloorsWhereElevatorAreY)
                    {
                        for (int i = 85; i >= 1; i--)
                        {
                            textBox1.Text += "Looking elevator at floor: " + (i + 1) + "\r\n";
                            Thread.Sleep(1000);
                            Application.DoEvents();

                            if ((i + 1) == whereIgo)
                            {
                                textBox1.Text += "It arrived at the floor: " + (i + 1) + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                textBox1.Text += "Opening the door" + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                textBox1.Text += "Closing the door" + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                return i;
                            }
                        }
                    }

                    if (whereIgo > FloorsWhereElevatorAreY)
                    {
                        for (int i = 1; i < 10; i++)
                        {
                            textBox1.Text += "Looking elevator at floor: " + (i + 1) + "\r\n";
                            Thread.Sleep(1000);
                            Application.DoEvents();


                            if ((i + 1) == whereIgo)
                            {
                                textBox1.Text += "It arrived at the floor: " + (i + 1) + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                textBox1.Text += "Opening the door" + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                textBox1.Text += "Closing the door" + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                return i;
                            }
                        }
                    }
                }
                return 0;
            }

            if (nearstElevator == 3)
            {
                for (int i = 1; i < 85; i++)
                {
                    if (FloorsColumn2List_Elev3[i].elevatorIsAtThisFloor == true)
                    {
                        FloorsWhereElevatorAreX = FloorsColumn2List_Elev3[i].floorColumn2;
                    }
                }

                int FloorsWhereElevatorAreY = 0;
                for (int i = 0; i < 85; i++)
                {

                }
                
                int distanceBetweenFloorAndX = whereIgo - FloorsWhereElevatorAreX;
                int distanceBetweenFloorAndY = whereIgo - FloorsWhereElevatorAreY;
                
                if (distanceBetweenFloorAndX < 0)
                {
                    distanceBetweenFloorAndX = distanceBetweenFloorAndX * (-1);
                }
                if (distanceBetweenFloorAndY < 0)
                {
                    distanceBetweenFloorAndY = distanceBetweenFloorAndY * (-1);
                }
                
                if (distanceBetweenFloorAndX < distanceBetweenFloorAndY)
                {
                    if (whereIgo < FloorsWhereElevatorAreX)
                    {                        
                        for (int i = 85; i >= 1; i--)
                        {
                            textBox1.Text += "Looking elevator at floor: " + (i + 1) + "\r\n";
                            Thread.Sleep(1000);
                            Application.DoEvents();

                            if ((i + 1) == whereIgo)
                            {
                                textBox1.Text += "It arrived at the floor: " + (i + 1) + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                textBox1.Text += "Opening the door\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                textBox1.Text += "Closing the door" + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                return i;
                            }

                            if (FloorsColumn2List_Elev3[i].elevatorIsAtThisFloor == true)
                            {
                                textBox1.Text += "Moving elevator: " + (i + 1) + " to floor >>> " + i + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                FloorsColumn2List_Elev3[i].elevatorIsAtThisFloor = false;
                                FloorsColumn2List_Elev3[i - 1].elevatorIsAtThisFloor = true;
                            }


                        }

                    }


                    if (whereIgo > FloorsWhereElevatorAreX)
                    {
                        for (int i = 1; i < 85; i++)
                        {
                            textBox1.Text += "Looking elevator at floor: " + (i + 1) + "\r\n";
                            Thread.Sleep(1000);
                            Application.DoEvents();

                            if ((i + 1) == whereIgo)
                            {
                                textBox1.Text += "It arrived at the floor: " + (i + 1) + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                textBox1.Text += "Opening the door\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                textBox1.Text += "Closing the door\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                return i;
                            }

                            if (FloorsColumn2List_Elev3[i].elevatorIsAtThisFloor == true)
                            {
                                textBox1.Text += "Moving elevator: " + (i + 1) + " to floor >>> " + (i + 2) + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                FloorsColumn2List_Elev3[i].elevatorIsAtThisFloor = false;
                                FloorsColumn2List_Elev3[i + 1].elevatorIsAtThisFloor = true;
                            }
                        }
                    }
                }
                else
                {
                    if (whereIgo < FloorsWhereElevatorAreY)
                    {
                        for (int i = 85; i >= 1; i--)
                        {
                            textBox1.Text += "Looking elevator at floor: " + (i + 1) + "\r\n";
                            Thread.Sleep(1000);
                            Application.DoEvents();

                            if ((i + 1) == whereIgo)
                            {
                                textBox1.Text += "It arrived at the floor: " + (i + 1) + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                textBox1.Text += "Opening the door" + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                textBox1.Text += "Closing the door" + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                return i;
                            }                            
                        }
                    }

                    if (whereIgo > FloorsWhereElevatorAreY)
                    {
                        for (int i = 1; i < 10; i++)
                        {
                            textBox1.Text += "Looking elevator at floor: " + (i + 1) + "\r\n";
                            Thread.Sleep(1000);
                            Application.DoEvents();


                            if ((i + 1) == whereIgo)
                            {
                                textBox1.Text += "It arrived at the floor: " + (i + 1) + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                textBox1.Text += "Opening the door" + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                textBox1.Text += "Closing the door" + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                return i;
                            }
                        }
                    }
                }
                return 0;
            }

            if (nearstElevator == 5)
            {
                for (int i = 1; i < 85; i++)
                {
                    if (FloorsColumn2List_Elev5[i].elevatorIsAtThisFloor == true)
                    {
                        FloorsWhereElevatorAreX = FloorsColumn2List_Elev5[i].floorColumn2;
                    }
                }

                int FloorsWhereElevatorAreY = 0;
                for (int i = 0; i < 85; i++)
                {

                }
                
                int distanceBetweenFloorAndX = whereIgo - FloorsWhereElevatorAreX;
                int distanceBetweenFloorAndY = whereIgo - FloorsWhereElevatorAreY;
                
                if (distanceBetweenFloorAndX < 0)
                {
                    distanceBetweenFloorAndX = distanceBetweenFloorAndX * (-1);
                }
                if (distanceBetweenFloorAndY < 0)
                {
                    distanceBetweenFloorAndY = distanceBetweenFloorAndY * (-1);
                }

                if (distanceBetweenFloorAndX < distanceBetweenFloorAndY)
                {
                    if (whereIgo < FloorsWhereElevatorAreX)
                    {
                        for (int i = 85; i >= 1; i--)
                        {
                            textBox1.Text += "Looking elevator at floor: " + (i + 1) + "\r\n";
                            Thread.Sleep(1000);
                            Application.DoEvents();

                            if ((i + 1) == whereIgo)
                            {
                                textBox1.Text += "It arrived at the floor: " + (i + 1) + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                textBox1.Text += "Opening the door\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                textBox1.Text += "Closing the door" + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                return i;
                            }

                            if (FloorsColumn2List_Elev5[i].elevatorIsAtThisFloor == true)
                            {
                                textBox1.Text += "Moving elevator: " + (i + 1) + " to floor >>> " + i + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                FloorsColumn2List_Elev5[i].elevatorIsAtThisFloor = false;
                                FloorsColumn2List_Elev5[i - 1].elevatorIsAtThisFloor = true;
                            }
                        }
                    }

                    if (whereIgo > FloorsWhereElevatorAreX)
                    {
                        for (int i = 1; i < 85; i++)
                        {
                            textBox1.Text += "Looking elevator at floor: " + (i + 1) + "\r\n";
                            Thread.Sleep(1000);
                            Application.DoEvents();

                            if ((i + 1) == whereIgo)
                            {
                                textBox1.Text += "It arrived at the floor: " + (i + 1) + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                textBox1.Text += "Opening the door\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                textBox1.Text += "Closing the door\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                return i;
                            }

                            if (FloorsColumn2List_Elev5[i].elevatorIsAtThisFloor == true)
                            {
                                textBox1.Text += "Moving elevator: " + (i + 1) + " to floor >>> " + (i + 2) + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                FloorsColumn2List_Elev5[i].elevatorIsAtThisFloor = false;
                                FloorsColumn2List_Elev5[i + 1].elevatorIsAtThisFloor = true;
                            }
                        }
                    }
                }
                else
                {
                    if (whereIgo < FloorsWhereElevatorAreY)
                    {
                        for (int i = 85; i >= 1; i--)
                        {
                            textBox1.Text += "Looking elevator at floor: " + (i + 1) + "\r\n";
                            Thread.Sleep(1000);
                            Application.DoEvents();

                            if ((i + 1) == whereIgo)
                            {
                                textBox1.Text += "It arrived at the floor: " + (i + 1) + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                textBox1.Text += "Opening the door" + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                textBox1.Text += "Closing the door" + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                return i;
                            }
                        }
                    }

                    if (whereIgo > FloorsWhereElevatorAreY)
                    {
                        for (int i = 1; i < 10; i++)
                        {
                            textBox1.Text += "Looking elevator at floor: " + (i + 1) + "\r\n";
                            Thread.Sleep(1000);
                            Application.DoEvents();
                            if ((i + 1) == whereIgo)
                            {
                                textBox1.Text += "It arrived at the floor: " + (i + 1) + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                textBox1.Text += "Opening the door" + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                textBox1.Text += "Closing the door" + "\r\n";
                                Thread.Sleep(1000);
                                Application.DoEvents();
                                return i;
                            }
                        }
                    }
                }
                return 0;
            }
            return 0;
        }

        private int MovingElevUpOrDown(int whereIgo)
        {
            int FloorsWhereElevatorAreX = 0;

            for (int i = 1; i < 85; i++)
            {
                if (FloorsColumn1List[i].elevatorIsAtThisFloorSoc == true)
                {
                    FloorsWhereElevatorAreX = FloorsColumn1List[i].floorColumn1;
                }
            }
            int FloorsWhereElevatorAreY = 0;
            for (int i = 0; i < 85; i++)
            {

            }
            
            int distanceBetweenFloorAndX = whereIgo - FloorsWhereElevatorAreX;
            int distanceBetweenFloorAndY = whereIgo - FloorsWhereElevatorAreY;
            
            if (distanceBetweenFloorAndX < 0)
            {
                distanceBetweenFloorAndX = distanceBetweenFloorAndX * (-1);
            }
            if (distanceBetweenFloorAndY < 0)
            {
                distanceBetweenFloorAndY = distanceBetweenFloorAndY * (-1);
            }

            if (distanceBetweenFloorAndX < distanceBetweenFloorAndY)
            {
                if (whereIgo < FloorsWhereElevatorAreX)
                {
                    for (int i = 85; i >= 1; i--)
                    {
                        textBox1.Text += "Looking elevator at floor: " + (i + 1) + "\r\n";
                        Thread.Sleep(1000);
                        Application.DoEvents();

                        if ((i + 1) == whereIgo)
                        {
                            textBox1.Text += "It arrived at the floor: " + (i + 1) + "\r\n";
                            Thread.Sleep(1000);
                            Application.DoEvents();
                            textBox1.Text += "Opening the door\r\n";
                            Thread.Sleep(1000);
                            Application.DoEvents();
                            textBox1.Text += "Closing the door" + "\r\n";
                            Thread.Sleep(1000);
                            Application.DoEvents();
                            return i;
                        }

                        if (FloorsColumn1List[i].elevatorIsAtThisFloorSoc == true)
                        {
                            textBox1.Text += "Moving elevator: " + (i + 1) + " to floor >>> " + i + "\r\n";
                            Thread.Sleep(1000);
                            Application.DoEvents();
                            FloorsColumn1List[i].elevatorIsAtThisFloorSoc = false;
                            FloorsColumn1List[i - 1].elevatorIsAtThisFloorSoc = true;
                        }
                    }
                }

                if (whereIgo > FloorsWhereElevatorAreX)
                {
                    for (int i = 1; i < 85; i++)
                    {
                        textBox1.Text += "Looking elevator at floor: " + (i + 1) + "\r\n";
                        Thread.Sleep(1000);
                        Application.DoEvents();


                        if ((i + 1) == whereIgo)
                        {
                            textBox1.Text += "It arrived at the floor: " + (i + 1) + "\r\n";
                            Thread.Sleep(1000);
                            Application.DoEvents();
                            textBox1.Text += "Opening the door\r\n";
                            Thread.Sleep(1000);
                            Application.DoEvents();
                            textBox1.Text += "Closing the door\r\n";
                            Thread.Sleep(1000);
                            Application.DoEvents();
                            return i;
                        }

                        if (FloorsColumn1List[i].elevatorIsAtThisFloorSoc == true)
                        {
                            textBox1.Text += "Moving elevator: " + (i + 1) + " at floor >>> " + (i + 2) + "\r\n";
                            Thread.Sleep(1000);            
                            Application.DoEvents();
                            FloorsColumn1List[i].elevatorIsAtThisFloorSoc = false;
                            FloorsColumn1List[i + 1].elevatorIsAtThisFloorSoc = true;
                        }                        
                    }
                }                
            }
            else
            {
                if (whereIgo < FloorsWhereElevatorAreY)
                {
                    for (int i = 85; i >= 1; i--)
                    {
                        textBox1.Text += "Looking elevator at floor: " + (i + 1) + "\r\n";
                        Thread.Sleep(1000);
                        Application.DoEvents();

                        if ((i + 1) == whereIgo)
                        {
                            textBox1.Text += "It arrived at the floor: " + (i + 1) + "\r\n";
                            Thread.Sleep(1000);
                            Application.DoEvents();
                            textBox1.Text += "Opening the door" + "\r\n";
                            Thread.Sleep(1000);
                            Application.DoEvents();
                            textBox1.Text += "Closing the door" + "\r\n";
                            Thread.Sleep(1000);
                            Application.DoEvents();
                            return i;
                        }         
                    }
                }

                if (whereIgo > FloorsWhereElevatorAreY)
                {
                    for (int i = 1; i < 10; i++)
                    {
                        textBox1.Text += "Looking elevator at floor: " + (i + 1) + "\r\n"; 
                        Thread.Sleep(1000);
                        Application.DoEvents();


                        if ((i + 1) == whereIgo)
                        {
                            textBox1.Text += "It arrived at the floor: " + (i + 1) + "\r\n";
                            Thread.Sleep(1000);
                            Application.DoEvents();
                            textBox1.Text += "Opening the door" + "\r\n";
                            Thread.Sleep(1000);
                            Application.DoEvents();
                            textBox1.Text += "Closing the door" + "\r\n";
                            Thread.Sleep(1000);
                            Application.DoEvents();
                            return i;
                        }
                    }
                }
            }
            return 0;
        }
    }
}
