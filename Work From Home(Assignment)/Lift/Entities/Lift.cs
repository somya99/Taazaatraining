using Lift.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lift.Entities
{
    public class Lift
    {
        #region "Events"

        public event LiftArrivedAtAFloor LiftArriverAtAFloor;

        #endregion

        #region "Data"
        public int Capacity { get; set; }
        public List<Person> People { get; set; }
        public int CurrentFloor { get; set; }
        public Direction LiftDirection { get; set; }

        #endregion
        public Lift(int capacity)
        {
            this.CurrentFloor = 0;
            this.Capacity = capacity;
            this.LiftDirection = Direction.Stationary;
        }
        public void Start()
        {
            this.LiftDirection = Direction.GoingUp;
            this.LiftArriverAtAFloor(this.CurrentFloor);
        }

        public void OnboardPeople(List<Person> people)
        {
            this.People.AddRange(people);
        }

        public List<Person> OffboardPeople(int floorNumber)
        {
            var peopleToOffboard = this.People.Where(p => p.DestinationFloor == floorNumber).ToList();
            this.People = this.People.Where(p => p.DestinationFloor != floorNumber).ToList();
            return peopleToOffboard;
        }

        public int GetAvailableCapacity()
        {
            return this.Capacity - this.People.Count;
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
