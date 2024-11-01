using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiftDemo_A
{
	public partial class Form1 : Form
	{
		bool isClosing = false;
		bool isOpening = false;

		int doorMaxOpenWidth;
		int doorSpeed = 5;
		int liftSpeed = 5;

		private Lift lift;
		DataTable dt = new DataTable();
		DBContext dbContext = new DBContext();

		public Form1()
		{
			InitializeComponent();

			lift = new Lift(mainElevator, buttton1, btn_G, this.ClientSize.Height, liftSpeed, liftTimerUp, liftTimerDown);


			doorMaxOpenWidth = mainElevator.Width / 2 - 30;

			dataGridViewLogs.ColumnCount = 2;
			dataGridViewLogs.Columns[0].Name = "Time";
			dataGridViewLogs.Columns[1].Name = "Events";

			dt.Columns.Add("LogTime");
			dt.Columns.Add("EventDescription");

		}

		private void logEvents(string message)
		{
			string currentTime = DateTime.Now.ToString("hh:mm:ss");

			dt.Rows.Add(currentTime, message);
			dataGridViewLogs.Rows.Add(currentTime, message);

			dbContext.InsertLogsIntoDB(dt);
		}


		private void Form1_Load(object sender, EventArgs e)
		{
			dbContext.loadLogsFromDB(dt, dataGridViewLogs);
		}


        private void btn_1_click(object sender, EventArgs e)
        {
            // Your logic for handling Button 1 click
            if (isOpening || doorTimer.Enabled)  // If doors are open or currently opening
            {
                CloseDoors();  // Start door-closing process
                lift.SetState(new MovingUpState());  // Set the elevator's next state

				lift.LiftTimerUp.Tag = "Start"; // Flag to start moving after doors close
            }
            else
            {
                // Start moving the elevator directly
                lift.SetState(new MovingUpState());
                lift.LiftTimerUp.Start();
                logEvents("Lift is coming up.");
            }
			//lift.LiftTimerDown.Start();

			btn_G.Enabled = false; // Disable the ground button
        }


        public void btn_G_click(object sender, EventArgs e)
		{
            if (isOpening)  // If doors are open or currently opening // || doorTimer.Enabled
            {
                CloseDoors();  // Start door-closing process
                
                lift.SetState(new MovingDownState());  // Set the elevator's next state

                lift.LiftTimerDown.Tag = "Start"; // Flag to start moving after doors close
            }
            else
            {
                // Start moving the elevator directly
                lift.SetState(new MovingDownState());
                lift.LiftTimerDown.Start();
                logEvents("Lift is coming down.");
            }

            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);


        }

        public void liftTimerUp_Tick(object sender, EventArgs e)
		{
			lift.MovingUp();
		}

		public void liftTimerDown_Tick(object sender, EventArgs e)
		{
			lift.MovingDown();
		}

		private void btn_Open_Click(object sender, EventArgs e)
		{
            if (lift._CurrentState is IdleState)
            {
                isOpening = true;
                isClosing = false;
                doorTimer.Start();
                btn_Close.Enabled = false;

                logEvents("Door is Opening!");
            }
        }

		private void btn_Close_Click(object sender, EventArgs e)
		{
			isOpening =false;
			isClosing=true;
			doorTimer.Start();
			logEvents("Door Is Closing!");
		}

        private void door_Timer_Tick(object sender, EventArgs e)
        {
            if (isOpening)
            {
                // Open the doors
                if (mainElevator.Top == 0) // Assuming the ground floor is Top = 0
                {
                    if (doorLeft_1.Left > doorMaxOpenWidth / 2)
                    {
                        doorLeft_1.Left -= doorSpeed;
                        doorRight_1.Left += doorSpeed;
                    }
                    else
                    {
                        doorTimer.Stop();
                        btn_Close.Enabled = true; // Enable close button

					}
				}
                else // When at floor 1
                {
                    if (doorLeft_G.Left > doorMaxOpenWidth / 2)
                    {
                        doorLeft_G.Left -= doorSpeed;
                        doorRight_G.Left += doorSpeed;
                    }
                    else
                    {
                        doorTimer.Stop();
                        btn_Close.Enabled = true; // Enable close button

					}
				}
            }
            else if (isClosing)
            {
                // Close the doors
                if (mainElevator.Top == 0) // Assuming the ground floor is Top = 0
                {
                    if (doorLeft_1.Right < mainElevator.Width + doorMaxOpenWidth / 2 - 5)
                    {
                        doorLeft_1.Left += doorSpeed;
                        doorRight_1.Left -= doorSpeed;
                    }
                    else
                    {
                        doorTimer.Stop();
                        liftTimerDown.Start();
                    }
                }
                else // When at floor 1
                {
                    if (doorLeft_G.Right < mainElevator.Width + doorMaxOpenWidth / 2 - 5)
                    {
                        doorLeft_G.Left += doorSpeed;
                        doorRight_G.Left -= doorSpeed;
                    }
                    else
                    {
                        doorTimer.Stop();
						liftTimerUp.Start();

					}
				}
            }
        }



        private void doorLeft_1_Click(object sender, EventArgs e)
        {

        }

        public void OpenDoors()
        {
            if (lift.MainElevator.Top == 0) // Top floor
            {
                isOpening = true;
                isClosing = false;
                doorTimer.Start();  // Start door timer to open doors on the top floor
                btn_Close.Enabled = false;
                logEvents("Doors are opening at the top floor!");
            }
            else if (lift.MainElevator.Top >= this.ClientSize.Height - lift.MainElevator.Height) // Ground floor
            {
                isOpening = true;
                isClosing = false;
                doorTimer.Start();  // Start door timer to open doors on the ground floor
                btn_Close.Enabled = false;
                logEvents("Doors are opening at the ground floor!");
            }
        }

        private void CloseDoors()
        {
            isOpening = false;
            isClosing = true;
            doorTimer.Start();
            logEvents("Doors are closing!");
        }


    }
}
