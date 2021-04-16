using System;
using System.Collections.Generic;
using System.Text;

namespace Lift.Entities
{
    public class Lift
    {
        public int Capacity { get; set; }
        public List<Person> People { get; set; }
        public int CurrentFloor { get; set; }

        public Lift(int capacity)
        {
            this.CurrentFloor = 0;
            this.Capacity = capacity;
        }

        private void MoveUp()
        {
            //direction = GoingUp
            //if number of people in lift is less than capacity then
            //open the door let people enter the lift till the capacity and for them set WaitingStatus = BoardedLift
            //else open door check 
            //if anyone came out of lift set WaitingStatus = Reached then let people enter the lift till capacity and for them set WaitingStatus = BoardedLift
            //else no one enters and MoveUp request is again made and keep the WaitingStatus = Waiting
            //CurrentFloor++
        }

        private void MoveDown()
        {
            //direction = GoingDown
            //if number of people in lift is less than capacity then
            //open the door let people enter the lift till the capacity and for them set WaitingStatus = BoardedLift
            //else open door check 
            //if anyone came out of lift set WaitingStatus = Reached then let people enter the lift till capacity and for them set WaitingStatus = BoardedLift
            //else no one enters and MoveUp request is again made and keep the WaitingStatus = Waiting
            //CurrentFloor--
        }
    }
}
